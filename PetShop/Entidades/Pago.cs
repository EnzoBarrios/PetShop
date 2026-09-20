using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class Pago
    {
        // Atributos directos de la tabla Pago
        public decimal Monto { get; set; }

        // Relacion con MetodoPago
        public int IdMetodoPago { get; set; }         // Clave foránea para MetodoPago
        public MetodoPago MetodoPago { get; set; }  // Objeto completo para tener acceso al nombre del metodo de pago

        // Relacion con Venta
        public int IdVenta { get; set; } // Clave foránea para Venta

        // Constructor vacío 
        public Pago()
        {
            MetodoPago = new MetodoPago(); // Inicializa el objeto MetodoPago para evitar referencias nulas
        }

        // Constructor con parámetros para instanciarlo
        public Pago(decimal monto, int idVenta, int metodoPago)
        {
            Monto = monto;

            IdVenta = idVenta;

            IdMetodoPago = metodoPago;
            MetodoPago = new MetodoPago { IdMetodoPago = metodoPago };
        }

        // Constructor sobrecargado con el objeto MetodoPago completo
        public Pago(decimal monto, int idVenta, MetodoPago metodoPago)
        {
            Monto = monto;

            IdVenta = idVenta;

            IdMetodoPago = metodoPago.IdMetodoPago;
            MetodoPago = metodoPago;
        }
    }
}
