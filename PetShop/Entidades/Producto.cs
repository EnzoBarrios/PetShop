using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class Producto
    {
        // Propiedades de la clase Producto
        public int IdProducto { get; set; } // Clave primaria de la tabla Producto
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        // Relacion con Categoria
        public Categoria Categoria { get; set; }    // Objeto completo para tener acceso al nombre de la categoría

        // Relacion compuesta con Especie_Tamano
        public EspecieTamano EspecieTamano { get; set; }    // Objeto completo para tener acceso a la especie y tamaño

        // Constructor vacío
        public Producto()
        {
            Categoria = new Categoria();            // Inicializa el objeto Categoria para evitar referencias nulas
            EspecieTamano = new EspecieTamano();   
            Estado = true;                          // Por defecto activo
            FechaCreacion = DateTime.Now;          // Asigna la fecha de creación
        }

        // Constructor con parámetros
        public Producto(int idProducto, string codigo, string nombreProducto, string descripcion, 
            decimal precioCompra, decimal precioVenta, int stockActual, int stockMinimo, bool estado, 
            int idCategoria, int idEspecie, int idTamano)
        {
            IdProducto = idProducto;
            Codigo = codigo;
            Nombre = nombreProducto;
            Descripcion = descripcion;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            StockActual = stockActual;
            StockMinimo = stockMinimo;
            Estado = estado;
            FechaCreacion = DateTime.Now;

            Categoria = new Categoria { IdCategoria = idCategoria }; 
            EspecieTamano = new EspecieTamano { IdEspecie = idEspecie, IdTamano = idTamano};
        }
    }
}
