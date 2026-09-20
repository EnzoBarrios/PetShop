using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public int IdRol { get; set; }  // Clave foránea para Rol
        public Rol Rol { get; set; }    // Objeto completo para tener acceso al nombre del rol

        // Constructor vacío 
        public Usuario()
        {
            Rol = new Rol();                // Inicializa el objeto Rol para evitar referencias nulas
            FechaCreacion = DateTime.Now;   // Por defecto la fecha y hora actual
            Estado = true;                  // Por defecto activo
        }

        // Constructor con parámetros para instanciarlo completo
        public Usuario(int idUsuario, string nombre, string apellido, string nombreUsuario, string clave, string dni,
                       string correo, string telefono, DateTime fechaCreacion, bool estado,
                       int idRol)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Clave = clave;
            Dni = dni;
            Correo = correo;
            Telefono = telefono;
            FechaCreacion = fechaCreacion;
            Estado = estado;
            IdRol = idRol;
            Rol = new Rol { IdRol = idRol };
        }
    }
}
