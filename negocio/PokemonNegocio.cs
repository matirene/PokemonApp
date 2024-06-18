using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Incluimos la libreria para trabajar con la DB.
using dominio;
using System.IO; // Incluimos el Proyecto "dominio".


namespace negocio
{
    public class PokemonNegocio
    {
        // Metodo que lea los registros de la DB.
        // El metodo retorna una lista de <Pokemon>.
        public List<Pokemon> listar()
        {
            // Creamos la variable lista y le asignamos un List. Este List esta vacio actualmente.
            List<Pokemon> lista = new List<Pokemon>();

            // Declaramos los Objetos para conectarnos a la DB.
            //1. Objeto que establece la conexion con la DB.
            SqlConnection conexion = new SqlConnection();
            //2. Objeto donde definimos las acciones ante la DB.
            SqlCommand comando = new SqlCommand();
            //3. Albergamos la data en el Objeto lector.
            SqlDataReader lector;
            // No se puede instanciar acá.


            // Manejo de Excepciones. 

            try // Toda la funcionalidad que puede fallar.
            {

                // Seteamos el string con la direccion de nuestra DB, para abrir la conexion.
                // Vamos al SSMS y clickeamos Connect. Copiamos el server name.

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true;";

                // Inyectamos la sentencia SQL que queremos ejecutar.
                comando.CommandType = System.Data.CommandType.Text; //Formato del comando.
                comando.CommandText = "SELECT P.Id, P.Numero, P.Nombre, P.Descripcion, E.Descripcion as Tipo, D.Descripcion as Debilidad, P.UrlImagen, P.IdTipo, P.IdDebilidad FROM POKEMONS as P LEFT JOIN ELEMENTOS as E ON P.IdTipo = E.Id LEFT JOIN ELEMENTOS as D ON P.IdDebilidad = D.Id WHERE Activo = 1 ORDER BY Numero ASC;";
                comando.Connection = conexion; // Le decimos al comando que se ejecute en nuestra conexion.

                // Abrimos la conexion.
                conexion.Open();

                // Realizo la lectura de la DB. 
                lector = comando.ExecuteReader(); // Retorna un Objeto SqlDataReader.


                while (lector.Read()) // Si hay registro = true. Y ademas el .Read() apunta a la primera fila del registro.
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"]; //Le indicamos al lector entre [] el nombre de la columna. Mediante casteo explicito le indicamos que tipo de dato va a recibir.
                    aux.Descripcion = (string)lector["Descripcion"];

                    if (!(lector["UrlImagen"] is DBNull)) // Si la imagen de ese Poke es NULL, ignoramos la lectura de esa columna.
                        aux.Imagen = (string)lector["UrlImagen"];

                    aux.Tipo = new Elemento(); // Hay que instanciar el Objeto Elemento.
                    aux.Tipo.Id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];

                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux); //Agrego cada pokemon a la lista.

                    // El lector.Read() va recorrer cada fila del registro por vuelta. Cuando no haya mas por leer, retorna FALSE.
                    // Reutiliza la variable aux. Pero va a crear una nueva instancia de ese Objeto por cada vuelta. Por lo tanto no va a tener la referencia del anterior y no lo va a modificar. 
                }

                //Cerramos la conexion a la DB.
                conexion.Close();

                return lista;
                
            }
            catch (Exception ex)
            {
                // Captura del error si lo hay.
                throw ex;
            }
        }

        public List<Pokemon> listarInactivos()
        {
            List<Pokemon> inactivos = new List<Pokemon>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("SELECT P.Id, P.Numero, P.Nombre, P.Descripcion, E.Descripcion as Tipo, D.Descripcion as Debilidad, P.UrlImagen, P.IdTipo, P.IdDebilidad FROM POKEMONS as P LEFT JOIN ELEMENTOS as E ON P.IdTipo = E.Id LEFT JOIN ELEMENTOS as D ON P.IdDebilidad = D.Id WHERE Activo = 0 ORDER BY Numero ASC;");
                datos.executeReader();

                while (datos.Reader.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Reader["Id"];
                    aux.Numero = (int)datos.Reader["Numero"];
                    aux.Nombre = (string)datos.Reader["Nombre"];
                    aux.Descripcion = (string)datos.Reader["Descripcion"];

                    if (!(datos.Reader["UrlImagen"] is DBNull)) // Si la imagen de ese Poke es NULL, ignoramos la lectura de esa columna.
                        aux.Imagen = (string)datos.Reader["UrlImagen"];

                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Reader["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Reader["Tipo"];

                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Reader["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Reader["Debilidad"];

                    inactivos.Add(aux);
                }

                return inactivos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.closeConexion();
            }
        }

        public void activar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("UPDATE POKEMONS SET Activo = 1 WHERE Id = @id;");
                datos.setParameters("@id", id);
                datos.executeAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            { 
                datos.closeConexion();
            }
        }

        public void agregar(Pokemon pokemon)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("INSERT INTO POKEMONS (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, Activo) VALUES (" + pokemon.Numero + ", '" + pokemon.Nombre + "', '" + pokemon.Descripcion + "', '" + pokemon.Imagen + "', @IdTipo, @IdDebilidad, 1)");
                datos.setParameters("@IdTipo", pokemon.Tipo.Id);
                datos.setParameters("@IdDebilidad", pokemon.Debilidad.Id);
                datos.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.closeConexion();
            }
        }

        public void modificar(Pokemon pokemon)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("UPDATE POKEMONS SET Numero = @numero, Nombre = @nombre, Descripcion = @descripcion, UrlImagen = @imagen, IdTipo = @idtipo, IdDebilidad = @iddebilidad WHERE Id = @id;");
                datos.setParameters("@numero", pokemon.Numero);
                datos.setParameters("@nombre", pokemon.Nombre);
                datos.setParameters("@descripcion", pokemon.Descripcion);
                datos.setParameters("@imagen", pokemon.Imagen);
                datos.setParameters("@idtipo", pokemon.Tipo.Id);
                datos.setParameters("@iddebilidad", pokemon.Debilidad.Id);
                datos.setParameters("@id", pokemon.Id);

                datos.executeAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.closeConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("DELETE FROM POKEMONS WHERE Id = @id;");
                datos.setParameters("@id", id);
                datos.executeAction();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.closeConexion();
            }
        }

        public void eliminarLogica(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("UPDATE POKEMONS SET Activo = 0 WHERE Id = @id;");
                datos.setParameters("@id", id);
                datos.executeAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            { 
                datos.closeConexion();
            }
        }

        public List<Pokemon> filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string query = "SELECT P.Id, P.Numero, P.Nombre, P.Descripcion, E.Descripcion as Tipo, D.Descripcion as Debilidad, P.UrlImagen, P.IdTipo, P.IdDebilidad FROM POKEMONS as P LEFT JOIN ELEMENTOS as E ON P.IdTipo = E.Id LEFT JOIN ELEMENTOS as D ON P.IdDebilidad = D.Id WHERE Activo = 1 AND ";

                switch (campo)
                {
                    case "Numero":

                        switch (criterio)
                        {
                            case "Mayor a":
                                query += "P.Numero > " + filtro;
                                break;
                            case "Menor a":
                                query += "Numero < " + filtro;
                                break;
                            default:
                                query += "Numero = " + filtro;
                                break;
                        }
                        break;

                    case "Nombre":

                        switch (criterio)
                        {
                            case "Contiene":
                                query += "Nombre LIKE '%" + filtro + "%'";
                                break;
                            case "Empieza con":
                                query += "Nombre LIKE '" + filtro + "%'";
                                break;
                            default:
                                query += "Nombre LIKE '%" + filtro + "'";
                                break;
                        }
                        break;

                    case "Descripcion":
                        switch (criterio)
                        {
                            case "Contiene":
                                query += "P.Descripcion LIKE '%" + filtro + "%'";
                                break;
                            case "Empieza con":
                                query += "P.Descripcion LIKE '" + filtro + "%'";
                                break;
                            default:
                                query += "P.Descripcion LIKE '%" + filtro + "'";
                                break;
                        }
                        break;
                }

                datos.setQuery(query);
                datos.executeReader();

                while (datos.Reader.Read())
                {
                    Pokemon aux = new Pokemon();

                    aux.Id = (int)datos.Reader["Id"];
                    aux.Numero = (int)datos.Reader["Numero"];
                    aux.Nombre = (string)datos.Reader["Nombre"];
                    aux.Descripcion = (string)datos.Reader["Descripcion"];

                    if (!(datos.Reader["UrlImagen"] is DBNull)) // Si la imagen de ese Poke es NULL, ignoramos la lectura de esa columna.
                        aux.Imagen = (string)datos.Reader["UrlImagen"];

                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Reader["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Reader["Tipo"];

                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Reader["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Reader["Debilidad"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.closeConexion();
            }
        }
    }
}
