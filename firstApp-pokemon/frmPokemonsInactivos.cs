using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace firstApp_pokemon
{
    public partial class frmPokemonsInactivos : Form
    {
        public frmPokemonsInactivos()
        {
            InitializeComponent();
        }

        private void cargarData()
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                List<Pokemon> listaInactivos = negocio.listarInactivos();

                if (listaInactivos.Any())
                {
                    dgvPokemonsInactivos.DataSource = listaInactivos;
                    cargarImagen(listaInactivos[0].Imagen);

                    dgvPokemonsInactivos.Columns["Imagen"].Visible = false;
                    dgvPokemonsInactivos.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmPokemonsInactivos_Load(object sender, EventArgs e)
        {
           cargarData();
        }

        private void dgvPokemonsInactivos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPokemonsInactivos.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemonsInactivos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                Pokemon seleccionado = (Pokemon)dgvPokemonsInactivos.CurrentRow.DataBoundItem;
                string nombrePokemon = seleccionado.Nombre.ToUpper();

                if (dgvPokemonsInactivos.CurrentRow !=  null )
                {

                    DialogResult respuestaActivar = MessageBox.Show("¿Estas seguro de activar el Pokemon " + nombrePokemon + " ?", "Activar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuestaActivar == DialogResult.Yes)
                    {
                        negocio.activar(seleccionado.Id);
                        MessageBox.Show("Pokemon activado.", "Activar Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarData();
                    }


                } else
                {
                    MessageBox.Show("No hay pokemones para activar.", "Activar Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


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
                pbxPokemonInactivos.Load(imagen);
            }
            catch (Exception)
            {
                // Establecemos una imagen default.
                pbxPokemonInactivos.Load("https://pngimg.com/uploads/pokeball/small/pokeball_PNG34.png");
            }
        }

    }
}
