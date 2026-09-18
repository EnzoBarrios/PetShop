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
        public string CodigoBarra { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public bool Estado { get; set; }

        // Relacion con Categoria
        public int IdCategoria { get; set; }        // Clave foránea para la categoría
        public Categoria Categoria { get; set; }    // Objeto completo para tener acceso al nombre de la categoría

        // Relacion compuesta con Especie_Tamano
        public int? IdEspecie { get; set; }                  // Clave foránea para la especie
        public int? IdTamano { get; set; }                   // Clave foránea para el tamaño
        public EspecieTamano EspecieTamano { get; set; }    // Objeto completo para tener acceso a la especie y tamaño

        // Constructor vacío
        public Producto()
        {
            Categoria = new Categoria();            // Inicializa el objeto Categoria para evitar referencias nulas
            EspecieTamano = new EspecieTamano();    // Inicializa el objeto EspecieTamano para evitar referencias nulas
            Estado = true;                          // Por defecto activo
        }

        // Constructor con parámetros
        public Producto(int idProducto, string codigo, string nombreProducto, string descripcion, decimal precioCompra, 
            decimal precioVenta, int stockActual, int stockMinimo, bool estado, int idCategoria, 
            int? idEspecie, int? idTamano)
        {
            IdProducto = idProducto;
            CodigoBarra = codigo;
            NombreProducto = nombreProducto;
            Descripcion = descripcion;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            StockActual = stockActual;
            StockMinimo = stockMinimo;
            Estado = estado;

            IdCategoria = idCategoria; 
            Categoria = new Categoria { IdCategoria = idCategoria }; 

            IdEspecie = idEspecie;
            IdTamano = idTamano;
            if (idEspecie.HasValue && idTamano.HasValue)
            {
                EspecieTamano = new EspecieTamano (IdEspecie.Value, IdTamano.Value);
            }
        }
    }
}
