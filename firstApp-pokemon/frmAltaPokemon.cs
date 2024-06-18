using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace firstApp_pokemon
{
    public partial class frmAltaPokemon : Form
    {
        // Atributos

        private Pokemon pokemon = null;
        // Click Agregar -> pokemon = null;
        // Click Modificar -> pokemon = Pokemon;

        private OpenFileDialog archivo = null;



        //Constructores
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.Text = "Modificar Pokemon"; // Cambiamos temporalmente el titulo de la ventana.
            this.pokemon = pokemon; // Asignamos el Pokemon que seleccionamos para modificar.
        }





        //Metodos
        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio negocio = new ElementoNegocio();

            try
            {
                // Asignamos una lista de Elementos para cada ComboBox.
                cbTipo.DataSource = negocio.listar();
                cbTipo.ValueMember = "Id";
                cbTipo.DisplayMember = "Descripcion";

                cbDebilidad.DataSource = negocio.listar();
                cbDebilidad.ValueMember = "Id";
                cbDebilidad.DisplayMember = "Descripcion";

                pbAgregarImagen.Load("https://cdn-icons-png.flaticon.com/512/1160/1160358.png");

                if (pokemon != null)
                {
                    // Si pokemon != null, se hizo click en Modificar.
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtImagen.Text = pokemon.Imagen;
                    cargarImagen(pokemon.Imagen);

                    cbTipo.SelectedValue = pokemon.Tipo.Id;
                    cbDebilidad.SelectedValue = pokemon.Debilidad.Id;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateFields() 
        { 
            Validation validation = new Validation();

            if(validation.isEmpty(txtNumero.Text) || validation.isEmpty(txtNombre.Text) || validation.isEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (validation.onlyNumbers(txtNumero.Text))
            {
                MessageBox.Show("Ingresá solo numeros.", "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {

                if (validateFields())
                    return;

                DialogResult respuestaAgregar = MessageBox.Show("¿Estas seguro de agregar el Pokemon?", "Agregar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuestaAgregar == DialogResult.No)
                    return;

                if(pokemon == null)
                    pokemon = new Pokemon();

                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.Tipo = (Elemento)cbTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cbDebilidad.SelectedItem;

                if(archivo != null && !txtImagen.Text.ToUpper().Contains("HTTP"))
                {
                    // Si cargamos una imagen localmente y NO hay una URL, guardo la imagen.


                    string carpetaImagenes = ConfigurationManager.AppSettings["carpeta-imagenes"];

                    // Obtener la extensión del archivo original
                    string extension = Path.GetExtension(archivo.SafeFileName);

                    // Crear un nuevo nombre para el archivo usando la fecha y hora actuales
                    string nuevoNombreArchivo = Path.GetFileNameWithoutExtension(archivo.SafeFileName) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + extension;

                    // Combinar la carpeta y el nuevo nombre del archivo
                    string totalPath = Path.Combine(carpetaImagenes, nuevoNombreArchivo);

                    // Copiar el archivo a la ruta especificada
                    File.Copy(archivo.FileName, totalPath);

                    // Asignar la ruta de la imagen al objeto pokemon
                    pokemon.Imagen = totalPath;


                } else
                {
                    // Carga la url si no es local.
                    pokemon.Imagen = txtImagen.Text;
                }

                if(pokemon.Id != 0)
                {
                    //Si el Id es distinto de 0, quiere decir que hay un Pokemon de la DB. QUEREMOS MODIFICAR. 
                    negocio.modificar(pokemon);
                    MessageBox.Show("Pokemon moficado.", "Modificar Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Pokemon agregado.", "Agregar Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }




                this.Close(); // Cerramos la ventana.
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
                pbxAltaPokemon.Load(imagen);
            }
            catch (Exception)
            {
                // Establecemos una imagen default.
                pbxAltaPokemon.Load("https://pngimg.com/uploads/pokeball/small/pokeball_PNG34.png");
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void pbAgregarImagen_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbAgregarImagen_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pbAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "(*.jpg; *.png)|*.jpg; *.png;";
            archivo.Title = "Agregar Imagen";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                // En el metodo btnAceptar_Click guardamos la imagen en la carpeta.
            }
        }
    }
}
