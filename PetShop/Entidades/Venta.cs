using System;
using System.Collections.Generic;

namespace PetShop.Entidades
{
    public class Venta
    {
        // Atributos directos de la tabla Venta
        public int IdVenta { get; set; }
        public string NroFactura { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } // 'Completada' o 'Anulada'

        // Relación con TipoVenta y Usuario
        public int IdTipoVenta { get; set; }
        public TipoVenta TipoVenta { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        // Listas asociadas
        public List<DetalleVenta> Detalles { get; set; }
        public List<Pago> Pagos { get; set; }

        // Constructor vacío
        public Venta()
        {
            NroFactura = string.Empty;
            FechaHora = DateTime.Now;
            Estado = "Completada";
            TipoVenta = new TipoVenta();
            Usuario = new Usuario();
            Detalles = new List<DetalleVenta>();
            Pagos = new List<Pago>();
        }

        // Constructor con parámetros
        public Venta(int idVenta, string nroFactura, DateTime fechaHora, decimal total, string estado, int idTipoVenta, int idUsuario)
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

        // Recalcular total
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