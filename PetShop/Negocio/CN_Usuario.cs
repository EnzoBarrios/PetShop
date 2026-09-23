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
            string condicionRol = rolLogueado.Equals("Gerente", StringComparison.OrdinalIgnoreCase)
                ? "r.nombre_rol = 'Vendedor'"
                : "r.nombre_rol IN ('Vendedor', 'Gerente')";
            return _cdUsuario.ListarFiltrado(condicionRol, textoBusqueda);
        }

        // Método para cambiar el estado de un usuario (activar/desactivar) con validación para evitar que un usuario se desactive a sí mismo
        public bool CambiarEstadoUsuario(int idUsuarioObjetivo, int idUsuarioLogueado, bool nuevoEstado, out string mensaje)
        {
            if (idUsuarioObjetivo == idUsuarioLogueado)
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
            else
            {
                mensaje = "No se pudo completar el registro en la base de datos.";
                return false;
            }
        }

        // Método para obtener un usuario por su ID, devolviendo null si el ID es inválido
        public Usuario ObtenerPorId(int idUsuario)
        {
            if (idUsuario <= 0) return null;
            return _cdUsuario.ObtenerPorId(idUsuario);
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

            bool resultado = _cdUsuario.EditarUsuario(obj, actualizarClave);

            if (resultado)
            {
                mensaje = "Usuario modificado con éxito.";
                return true;
            }

            mensaje = "No se pudo actualizar el registro en la base de datos.";
            return false;
        }
    }
}
