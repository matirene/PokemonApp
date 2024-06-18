using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public  class Elemento
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        public override string ToString()
        {
            // El dataGridView detecta que la columna "Tipo" tiene un Objeto dentro, pero no puede "acceder" a el.
            // Por lo tanto, utiliza el metodo ToString() de este Objeto (Elemento) para mostrar su direccion.
            // Hacemos un override para que nos muestre la prop que deseamos, en vez de la direccion.
            return Descripcion;
        }
    }
}
