using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class Resumen
    {
        public decimal TotalRecaudado { get; set; }
        public int CantidadVentas { get; set; }
        public string ProductoEstrella { get; set; }

        public Resumen() { }
    }
}
