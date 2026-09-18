using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class DetalleVenta
    {
        // Atributos directos de la tabla DetalleVenta
        public int Cantidad { get; set; } 
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        // Relacion con Venta
        public int IdVenta { get; set; } // Clave foránea para Venta

        // Relacion con Producto
        public int IdProducto { get; set; }     // Clave foránea para Producto
        public Producto Producto { get; set; } // Objeto completo para tener acceso al nombre del producto

        // Constructor vacío
        public DetalleVenta()
        {
            Producto = new Producto();  // Inicializa el objeto Producto para evitar referencias nulas
        }

        // Constructor con parámetros
        public DetalleVenta(int cantidad, decimal precioUnitario, int idVenta, int idProducto)
        {
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = cantidad * precioUnitario;

            IdVenta = idVenta;

            IdProducto = idProducto;
            Producto = new Producto { IdProducto = idProducto };
        }

        // Constructor sobrecargado pasando el objeto Producto completo
        public DetalleVenta(int cantidad, decimal precioUnitario, Producto producto)
        {
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = cantidad * precioUnitario; ;

            Producto = producto;
            IdProducto = producto.IdProducto;
        }

        // Método auxiliar para recalcular el subtotal si se modifica la cantidad o el precio
        public void RecalcularSubtotal()
        {
            Subtotal = Cantidad * PrecioUnitario;
        }
    }
}
