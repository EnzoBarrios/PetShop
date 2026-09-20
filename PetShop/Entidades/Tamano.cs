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
        public string NombreTamano { get; set; }

        // Constructor vacío
        public Tamano()
        {
        }

        // Constructor con parámetros para instanciarlo completo
        public Tamano(int idTamano, string nombreTamano)
        {
            IdTamano = idTamano;
            NombreTamano = nombreTamano;
        }

    }
}
