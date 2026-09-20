using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class Rol
    {
        // Atributos directos de la tabla Rol
        public int IdRol { get; set; } // Clave primaria de la tabla Rol
        public string NombreRol { get; set; } 

        // Constructor vacío 
        public Rol()
        {
        }

        // Constructor con parámetros para instanciarlo completo
        public Rol(int idRol, string nombreRol)
        {
            IdRol = idRol; // Asigna el ID del rol
            NombreRol = nombreRol; 
        }
    }
}
