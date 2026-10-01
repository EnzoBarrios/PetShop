using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Datos;
using PetShop.Entidades;

namespace PetShop.Negocio
{
    public class CN_Usuario
    {
        // Instancia de la capa de datos para interactuar con la base de datos
        private readonly CD_Usuario _cdUsuario = new CD_Usuario();

        // Método para listar todos los usuarios, delegando la llamada a la capa de datos
        public List<Usuario> ListarUsuarios()
        {
            return _cdUsuario.Listar();
        }

        // Método para cargar usuarios en la grilla según el rol del usuario logueado y un texto de búsqueda
        public List<Usuario> CargarUsuariosParaGrilla(string rolLogueado, string textoBusqueda)
        {
            string rol = rolLogueado?.Trim() ?? string.Empty;

            string condicionRol = rol.Equals("Gerente", StringComparison.OrdinalIgnoreCase)
                ? "r.nombre_rol = 'Vendedor'"
                : "r.nombre_rol IN ('Vendedor', 'Gerente')";

            return _cdUsuario.ListarFiltrado(condicionRol, textoBusqueda);
        }

        public Usuario IniciarSesion(string nombreUsuario, string clave, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                mensaje = "Debe ingresar el nombre de usuario.";
                return null;
            }

            if (string.IsNullOrWhiteSpace(clave))
            {
                mensaje = "Debe ingresar la contraseña.";
                return null;
            }

            Usuario usuario = _cdUsuario.ValidarLogin(nombreUsuario, clave);

            if (usuario == null)
            {
                mensaje = "Usuario o contraseña incorrectos, o la cuenta está inactiva.";
                return null;
            }

            return usuario;
        }

        // Método para obtener un usuario por su ID, devolviendo null si el ID es inválido
        public Usuario ObtenerPorId(int idUsuario)
        {
            if (idUsuario <= 0) return null;
            return _cdUsuario.ObtenerPorId(idUsuario);
        }

        // Metodo para registrar un nuevo usuario con validación de duplicidad de nombre de usuario, DNI y correo electrónico
        public bool RegistrarUsuario(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación de duplicidad delegada a datos
            if (_cdUsuario.ExisteUsuario(obj.NombreUsuario))
            {
                mensaje = "El nombre de usuario ingresado ya está en uso. Elija otro.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(obj.Dni) && _cdUsuario.ExisteDni(obj.Dni))
            {
                mensaje = "El DNI ingresado ya pertenece a otro usuario.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(obj.Correo) && _cdUsuario.ExisteCorreo(obj.Correo))
            {
                mensaje = "El correo electrónico ingresado ya pertenece a otro usuario.";
                return false;
            }

            bool respuesta = _cdUsuario.Registrar(obj);

            if (respuesta)
            {
                mensaje = "Usuario registrado con éxito.";
                return true;
            }

            mensaje = "No se pudo completar el registro en la base de datos.";
            return false;
        }

        // Método para modificar un usuario existente con validación de duplicidad de nombre de usuario
        public bool ModificarUsuario(Usuario obj, bool actualizarClave, out string mensaje)
        {
            mensaje = string.Empty;

            if (_cdUsuario.ExisteNombreUsuarioParaOtro(obj.NombreUsuario, obj.IdUsuario))
            {
                mensaje = "El nombre de usuario ingresado ya está asignado a otra cuenta.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(obj.Dni) && _cdUsuario.ExisteDniParaOtro(obj.Dni.Trim(), obj.IdUsuario))
            {
                mensaje = "El DNI ingresado ya pertenece a otro usuario";
                return false; 
            }

            if (!string.IsNullOrWhiteSpace(obj.Dni) & _cdUsuario.ExisteCorreoParaOtro(obj.Correo.Trim(), obj.IdUsuario)){
                mensaje = "El correo ingresado ya pertenece a otro usuario";
            }

            bool resultado = _cdUsuario.Editar(obj, actualizarClave);

            if (resultado)
            {
                mensaje = "Usuario modificado con éxito.";
                return true;
            }

            mensaje = "No se pudo actualizar el registro en la base de datos.";
            return false;
        }

        public bool ActualizarPerfilUsuario(Usuario obj, bool actualizarClave, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Nombre) || string.IsNullOrWhiteSpace(obj.Apellido))
            {
                mensaje = "El nombre y el apellido son obligatorios.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(obj.NombreUsuario) || obj.NombreUsuario.Trim().Length < 4)
            {
                mensaje = "El nombre de usuario debe tener al menos 4 caracteres.";
                return false;
            }

            // Validar que el nombre de usuario no esté tomado por otro
            if (_cdUsuario.ExisteNombreUsuarioParaOtro(obj.NombreUsuario.Trim(), obj.IdUsuario))
            {
                mensaje = "El nombre de usuario ya está en uso por otra cuenta.";
                return false;
            }

            // Validar DNI único para otro usuario
            if (!string.IsNullOrWhiteSpace(obj.Dni) && _cdUsuario.ExisteDniParaOtro(obj.Dni.Trim(), obj.IdUsuario))
            {
                mensaje = "El DNI ingresado ya pertenece a otro usuario.";
                return false;
            }

            // Validar Correo único para otro usuario
            if (!string.IsNullOrWhiteSpace(obj.Correo) && _cdUsuario.ExisteCorreoParaOtro(obj.Correo.Trim(), obj.IdUsuario))
            {
                mensaje = "El correo electrónico ya pertenece a otro usuario.";
                return false;
            }

            // 4. Persistir cambios
            bool exito = _cdUsuario.ActualizarPerfil(obj, actualizarClave);

            if (exito)
            {
                mensaje = "Perfil actualizado con éxito.";
                return true;
            }
            else
            {
                mensaje = "No se pudo actualizar el perfil en la base de datos.";
                return false;
            }            
        }

        // Método para cambiar el estado de un usuario (activar/desactivar) con validación para evitar que un usuario se desactive a sí mismo
        public bool CambiarEstadoUsuario(int idUsuarioObjetivo, int idUsuarioLogueado, bool nuevoEstado, out string mensaje)
        {
            if (idUsuarioObjetivo == idUsuarioLogueado && !nuevoEstado)
            {
                mensaje = "No puedes desactivar tu propia cuenta mientras tiene la sesion activa.";
                return false;
            }

            bool resultado = _cdUsuario.CambiarEstado(idUsuarioObjetivo, nuevoEstado);

            mensaje = resultado
                ? $"Usuario {(nuevoEstado ? "Activado" : "Desactivado")} con éxito."
                : "No se puedo actualizar el estado del usuario.";

            return resultado;
        }
    }
}
