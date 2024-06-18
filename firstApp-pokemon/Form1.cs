using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace firstApp_pokemon
{
    public partial class Pokemons : Form
    {

        // Atributo
        private List<Pokemon> listaPokemons;
        private List<Elemento> listaElementos;


        //Constructor
        public Pokemons()
        {
            InitializeComponent();
        }


        // Metodos


        //Cuando carga el formulario.. (Abrimos la App)
        private void Pokemons_Load(object sender, EventArgs e)
        {
            cargarData();

            cargarElementos();

            cargarCampo();
        }

        private void cargarData()
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                listaPokemons = negocio.listar(); //Le asignamos a listaPokemons la data.

                if (listaPokemons.Any())
                {
                    dgvPokemons.DataSource = listaPokemons; // Le asignamos a la grilla de datos el listado y lo modela en la tabla.
                    ocultarColumnas();
                    cargarImagen(listaPokemons[0].Imagen);
                } else
                {
                    List<Pokemon> listaVacia = new List<Pokemon>();
                    dgvPokemons.DataSource = listaVacia;
                    cargarImagen("");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvPokemons.Columns["Imagen"].Visible = false; // Ocultamos la columna que contiene el url de la img.
            dgvPokemons.Columns["Id"].Visible = false;
        }

        private void cargarElementos()
        {
            ElementoNegocio negocioE = new ElementoNegocio();
            try
            {
                listaElementos = negocioE.listar();
                dgvElementos.DataSource = listaElementos;
                dgvElementos.Columns["Imagen"].Visible = false;
                dgvElementos.Columns["Id"].Visible = false;
                cargarImagenElementos(listaElementos[0].Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception)
            {
                // Establecemos una imagen default.
                pbxPokemon.Load("https://pngimg.com/uploads/pokeball/small/pokeball_PNG34.png");
            }
        }

        private void cargarImagenElementos(string imagen)
        {
            try
            {
                pbxElementos.Load(imagen);
            }
            catch (Exception)
            {
                // Establecemos una imagen default.
                pbxElementos.Load("https://pngimg.com/uploads/pokeball/small/pokeball_PNG34.png");
            }
        }

        private void cargarCampo()
        {
            cbCampo.Items.Add("Numero");
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Descripcion");
            cbCampo.SelectedIndex = 0;
        }

        //Cada vez que se selecciona una fila distinta, se dispara este evento.
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
           
            if(dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem; // Le pedimos al DGV que nos devuelva el objeto de la fila seleccionada.
                cargarImagen(seleccionado.Imagen);

                
                string tipoPokemonSeleccionado = seleccionado.Tipo.Descripcion;

                foreach (DataGridViewRow filaElemento in dgvElementos.Rows)
                {
                    string tipoElemento = ((Elemento)filaElemento.DataBoundItem).Descripcion.ToString();
                    string imagenElemento = ((Elemento)filaElemento.DataBoundItem).Imagen;

                    if (tipoPokemonSeleccionado == tipoElemento)
                    {
                        dgvElementos.Rows[filaElemento.Index].Selected = true; // Marca la fila.
                        dgvElementos.CurrentCell = dgvElementos.Rows[filaElemento.Index].Cells[1]; // Aseguramos que seleccione el Objeto Elemento.

                        pbxElementos.Load(imagenElemento);

                        dgvElementos.FirstDisplayedScrollingRowIndex = filaElemento.Index;
                        // Hace que la fila seleccionada se muestre dentro del marco.

                    }
                }
                
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon altaPokemon = new frmAltaPokemon();
            altaPokemon.ShowDialog();
            // Cuando se cierra el form de Alta Pokemon, actualizamos la data.
            cargarData(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                frmAltaPokemon altaPokemon = new frmAltaPokemon(seleccionado);
                altaPokemon.ShowDialog();
                cargarData();
            }
            else
            {
                MessageBox.Show("No hay pokemon para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminacion Fisica (Permanente).
            if (dgvPokemons.CurrentRow != null)
                eliminar();
            else
                MessageBox.Show("No hay pokemon para eliminar");
        }

        private void btnEliminarLogica_Click(object sender, EventArgs e)
        {
            if (dgvPokemons.CurrentRow != null)
                eliminar(true);
            else
                MessageBox.Show("No hay pokemon para desactivar", "Desactivar Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void eliminar(bool logica = false)
        {

                PokemonNegocio negocio = new PokemonNegocio();
                Pokemon seleccionado;
                DialogResult respuesta;

                try
                {
                    seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                    string nombrePokemon = seleccionado.Nombre.ToUpper();

                    if (logica)
                    {
                        respuesta = MessageBox.Show("¿Estas seguro de desactivar el Pokemon " + nombrePokemon + " ?", "Desactivar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (respuesta == DialogResult.Yes)
                        {
                            negocio.eliminarLogica(seleccionado.Id);
                            MessageBox.Show("Pokemon Desactivado.", "Desactivar Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarData();
                        }

                    }
                    else
                    {
                        respuesta = MessageBox.Show("¿Estas seguro de eliminar el Pokemon " + nombrePokemon + " ?", "Eliminar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (respuesta == DialogResult.Yes)
                        {
                            negocio.eliminar(seleccionado.Id);
                            MessageBox.Show("Pokemon Eliminado.", "Eliminar Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cargarData();

                            if (File.Exists(seleccionado.Imagen))
                                File.Delete(seleccionado.Imagen);
                     
                        }

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length > 2)
                listaFiltrada = listaPokemons.FindAll(pokemon => pokemon.Nombre.ToUpper().Trim().Contains(filtro.ToUpper().Trim()) || pokemon.Tipo.Descripcion.ToUpper().Trim().Contains(filtro.ToUpper().Trim()));
            else
                listaFiltrada = listaPokemons;


            dgvPokemons.DataSource = null; // Limpiamos el dgv. 
            dgvPokemons.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            frmPokemonsInactivos pokemonsInactivos = new frmPokemonsInactivos();
            pokemonsInactivos.ShowDialog();
            cargarData();
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();

            if(opcion == "Numero")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Mayor a");
                cbCriterio.Items.Add("Menor a");
                cbCriterio.Items.Add("Igual a");
                cbCriterio.SelectedIndex = 0;

            } else
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Contiene");
                cbCriterio.Items.Add("Empieza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.SelectedIndex = 0;

            }
        }

        private bool validateFields()
        {
            Validation validation = new Validation();

            if (validation.isEmpty(txtFiltroAvanzado.Text))
            {
                MessageBox.Show("El filtro no puede estar vacio!");
                return true;
            }

            if (cbCampo.SelectedItem.ToString() == "Numero")
            {
                if (validation.onlyNumbers(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Ingresá solo numeros.");
                    return true;
                }
            }

            return false;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

                try
                {
                    if(validateFields())
                    {
                        // Si falló una validacion, entra y corta todo el evento.
                        return;
                    }

                    string campo = cbCampo.SelectedItem.ToString();
                    string criterio = cbCriterio.SelectedItem.ToString();
                    string filtro = txtFiltroAvanzado.Text;


                    dgvPokemons.DataSource = null;
                    dgvPokemons.DataSource = negocio.filtrar(campo, criterio, filtro);
                    ocultarColumnas();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

        }

        private void btnAgregarElem_Click(object sender, EventArgs e)
        {
            frmAltaElemento altaElemento = new frmAltaElemento();
            altaElemento.ShowDialog();
            cargarElementos();
        }

        private void btnEliminarElemento_Click(object sender, EventArgs e)
        {
            ElementoNegocio negocio = new ElementoNegocio();

            if(dgvElementos.CurrentRow == null) 
            {
                MessageBox.Show("Elemento no seleccionado.", "Eliminar Elemento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Elemento seleccionado = (Elemento)dgvElementos.CurrentRow.DataBoundItem;
            string nombreElemento = seleccionado.Descripcion.ToUpper();

            DialogResult resultado = MessageBox.Show("Estas seguro de eliminar el Elemento " + nombreElemento + " ?", "Eliminar Elemento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(resultado == DialogResult.Yes)
            {
                try
                {
                    negocio.eliminar(seleccionado);
                    MessageBox.Show("Elemento eliminado.", "Eliminar Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarElementos();

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Hay Pokemons que utilizan este Elemento. Debes borrarlos primero, para borrar el Elemento.", "Eliminar Elemento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void dgvElementos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvElementos.CurrentRow != null)
                {
                    Elemento seleccionado = (Elemento)dgvElementos.CurrentRow.DataBoundItem;
                    pbxElementos.Load(seleccionado.Imagen);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


    }
}
