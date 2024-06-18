using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstApp_pokemon
{
    public partial class frmAltaElemento : Form
    {
        public frmAltaElemento()
        {
            InitializeComponent();
        }

        private void btnAceptarElemento_Click(object sender, EventArgs e)
        {
            Elemento aux = new Elemento();
            ElementoNegocio negocio = new ElementoNegocio();

            Validation validation = new Validation();

            if (validation.isEmpty(txtDescripcionElemento.Text))
            {
                MessageBox.Show("El campo nombre esta incompleto.", "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (validation.onlyLetters(txtDescripcionElemento.Text))
            {
                MessageBox.Show("El campo no permite numeros.", "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            aux.Descripcion = txtDescripcionElemento.Text;
            aux.Imagen = txtImagenElemento.Text;

            negocio.agregar(aux);

            MessageBox.Show("Elemento agregado.");

            this.Close();
        }

        private void txtImagenElemento_Leave(object sender, EventArgs e)
        {
            pbxNuevoElemento.Load(txtImagenElemento.Text);
        }

        private void btnCancelarElemento_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
