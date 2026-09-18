using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class Categoria
    {
        public int IdCategoria { get; set; } // Clave primaria de la tabla Categoria
        public string NombreCategoria { get; set; }

        // Constructor vacío
        public Categoria ()
        {
        }

        // Constructor con parámetros
        public Categoria(int idCategoria, string nombreCategoria)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
        }
    }
}
