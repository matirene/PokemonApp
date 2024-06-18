using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon
    {
        public int Id { get; set; }

        [DisplayName("Número")]
        public int Numero { get; set; }

        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        public Elemento Tipo { get; set; } // El Tipo de Pokemon es un Objeto Elemento.

        public Elemento Debilidad { get; set; } // La Debilidad del Pokemon es un Objeto Elemento.
    }
}
