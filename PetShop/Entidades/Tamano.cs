using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class Tamano
    {
        // Atributos directos de la tabla Tamano
        public int IdTamano { get; set; } // Clave primaria de la tabla Tamano
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        // Constructor vacío
        public Tamano()
        {
            Estado = true;
        }

        public override string ToString() => Nombre;
    }
}
