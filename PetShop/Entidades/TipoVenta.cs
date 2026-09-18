using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class TipoVenta
    {
        // Atributos directos de la tabla TipoVenta
        public int IdTipoVenta { get; set; } // Clave primaria de la tabla TipoVenta
        public string Descripcion { get; set; }

        // Constructor vacío
        public TipoVenta()
        {
        }

        // Constructor con parámetros
        public TipoVenta(int idTipoVenta, string descripcion)
        {
            IdTipoVenta = idTipoVenta;
            Descripcion = descripcion;
        }
    }
}
