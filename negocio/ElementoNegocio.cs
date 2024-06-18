using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {
			List<Elemento> lista = new List<Elemento>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setQuery("SELECT Id, Descripcion, UrlImagen FROM ELEMENTOS ORDER BY Id ASC;");
				datos.executeReader();

				while(datos.Reader.Read())
				{
					Elemento elementoAux = new Elemento();
					elementoAux.Id = (int)datos.Reader["Id"];
					elementoAux.Descripcion = (string)datos.Reader["Descripcion"];
					elementoAux.Imagen = (string)datos.Reader["UrlImagen"];

					lista.Add(elementoAux);
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

		public void agregar(Elemento elemento)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setQuery("INSERT INTO ELEMENTOS (Descripcion, UrlImagen) VALUES (@descripcion, @imagen);");
				datos.setParameters("@descripcion", elemento.Descripcion);
				datos.setParameters("@imagen", elemento.Imagen);

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


        
		public void eliminar(Elemento elemento)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setQuery("DELETE FROM ELEMENTOS WHERE Id = @id");
				datos.setParameters("@id", elemento.Id);
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
		

    }
}
