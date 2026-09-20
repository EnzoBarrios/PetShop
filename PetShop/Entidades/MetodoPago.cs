using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class MetodoPago
    {
        // Atributos directos de la tabla MetodoPago
        public int IdMetodoPago { get; set; } // Clave primaria de la tabla MetodoPago
        public string NombreMetodo { get; set; }

        // Constructor vacío
        public MetodoPago()
        {
        }

        // Constructor con parámetros
        public MetodoPago(int idMetodoPago, string nombreMetodo)
        {
            IdMetodoPago = idMetodoPago;
            NombreMetodo = nombreMetodo;
        }
    }
}
