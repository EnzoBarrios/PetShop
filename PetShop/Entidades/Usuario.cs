using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class Usuario
    {
        // Atributos directos de la tabla Usuario
        public int IdUsuario { get; set; } // Clave primaria de la tabla Usuario
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Dni { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; } // true = activo, false = inactivo

        // Relación con la tabla Rol
        public Rol Rol { get; set; }    // Objeto completo para tener acceso al nombre del rol

        // Constructor vacío 
        public Usuario()
        {
            Rol = new Rol();                // Inicializa el objeto Rol para evitar referencias nulas
            FechaCreacion = DateTime.Now;   // Por defecto la fecha y hora actual
            Estado = true;                  // Por defecto activo
        }

        // Propiedad calculada para obtener el nombre completo del usuario
        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}".Trim(); }
        }
    }
}
