using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class Venta
    {
        // Atributos directos de la tabla Venta
        public int IdVenta { get; set; } // Clave primaria de la tabla Venta
        public int NroFactura { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; }

        // Relacion con TipoVenta
        public int IdTipoVenta { get; set; }        // Clave foránea para TipoVenta
        public TipoVenta TipoVenta { get; set; }    // Objeto completo para tener acceso al nombre del tipo de venta    

        // Relacion con Usuario
        public int IdUsuario { get; set; }      // Clave foránea para Usuario
        public Usuario Usuario { get; set; }    // Objeto completo para tener acceso al nombre del usuario

        // Renglones de productos y pagos asociados
        public List<DetalleVenta> Detalles { get; set; }    // Lista de detalles de la venta (productos)
        public List<Pago> Pagos { get; set; }               // Lista de pagos asociados a la venta

        // Constructor vacío
        public Venta()
        {
            FechaHora = DateTime.Now;               // Por defecto la fecha y hora actual
            Estado = true;                          // Por defecto activo
            TipoVenta = new TipoVenta();            // Inicializa el objeto TipoVenta para evitar referencias nulas
            Usuario = new Usuario();                // Inicializa el objeto Usuario para evitar referencias nulas
            Detalles = new List<DetalleVenta>();    // Inicializa la lista de detalles para evitar referencias nulas
            Pagos = new List<Pago>();               // Inicializa la lista de pagos para evitar referencias nulas
        }

        // Constructor con parámetros
        public Venta(int idVenta, int nroFactura, DateTime fechaHora, decimal total, bool estado, int idTipoVenta, 
            int idUsuario)
        {
            IdVenta = idVenta;
            NroFactura = nroFactura;
            FechaHora = fechaHora;
            Total = total;
            Estado = estado;

            IdTipoVenta = idTipoVenta;
            TipoVenta = new TipoVenta { IdTipoVenta = idTipoVenta };

            IdUsuario = idUsuario;
            Usuario = new Usuario { IdUsuario = idUsuario };

            Detalles = new List<DetalleVenta>();
            Pagos = new List<Pago>();
        }

        // Método auxiliar para recalcular el total sumando subtotales
        public void CalcularTotal()
        {
            decimal suma = 0;
            if (Detalles != null)
            {
                foreach (var item in Detalles)
                {
                    suma += item.Subtotal;
                }
            }
            Total = suma;
        }
    }
}
