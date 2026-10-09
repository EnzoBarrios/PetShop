using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            try
            {
                return _cdUsuario.Listar();
            }
            catch (Exception)
            {
                return new List<Usuario>();
            }
        }

        // Método para cargar usuarios en la grilla según el rol del usuario logueado y un texto de búsqueda
        public List<Usuario> CargarUsuariosParaGrilla(string rolLogueado, string textoBusqueda)
        {
            try
            {
                string rol = (rolLogueado ?? string.Empty).Trim();
                string texto = (textoBusqueda ?? string.Empty).Trim();

                List<Usuario> listaUsuarios = _cdUsuario.Listar(0, textoBusqueda);

                if (rol.Equals(CN_Rol.ROL_ADMINISTRADOR, StringComparison.OrdinalIgnoreCase))
                {
                    return listaUsuarios;
                }

                if (rol.Equals(CN_Rol.ROL_GERENTE, StringComparison.OrdinalIgnoreCase))
                {
                    return listaUsuarios
                    .Where(u => u.Rol != null &&
                                u.Rol.NombreRol.Trim().Equals(CN_Rol.ROL_VENDEDOR, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                }

                return new List<Usuario>();
            }
            catch (Exception)
            {
                return new List<Usuario>();
            }
        }

        // Método para obtener un usuario por su ID, devolviendo null si el ID es inválido
        public Usuario ObtenerPorId(int idUsuario)
        {
            if (idUsuario <= 0)
            {
                return null;
            }

            try
            {
                return _cdUsuario.ObtenerPorId(idUsuario);
            }
            catch (Exception)
            {
                return null;
            }


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

            try
            {
                Usuario usuario = _cdUsuario.ObtenerPorNombreUsuario(nombreUsuario.Trim());

                if (usuario == null)
                {
                    mensaje = "Usuario o contraseña incorrectos";
                    return null;
                }

                if (!usuario.Estado)
                {
                    mensaje = "La cuenta del usuario está inactiva. Contacte al administrador";
                    return null;
                }

                string claveIngresada = clave.Trim();
                bool claveValida = false;

                // Caso 1: La base de datos ya contiene el hash SHA-256
                if (SeguridadHelper.EsHashSha256(usuario.Clave))
                {
                    string claveHashIngresada = SeguridadHelper.GenerarHashSha256(claveIngresada);
                    claveValida = usuario.Clave.Equals(claveHashIngresada, StringComparison.OrdinalIgnoreCase);
                }
                // Caso 2: El registro fue insertado a mano con texto plano (Migración Automática)
                else
                {
                    if (usuario.Clave.Equals(claveIngresada, StringComparison.Ordinal))
                    {
                        claveValida = true;

                        // Genera el hash y actualiza la base de datos de inmediato
                        string nuevoHash = SeguridadHelper.GenerarHashSha256(claveIngresada);
                        _cdUsuario.ActualizarHashClave(usuario.IdUsuario, nuevoHash);
                        usuario.Clave = nuevoHash;
                    }
                }

                if (!claveValida)
                {
                    mensaje = "Usuario o contraseña incorrectos";
                    return null;
                }

                return usuario;
            }
            catch (Exception ex)
            {
                mensaje = "Error al intentar conectar el servidor" + ex.Message;
                return null;
            }
        }

        // Método para registrar un nuevo usuario con validación de duplicidad de nombre de usuario, DNI y correo electrónico
        public bool RegistrarUsuario(Usuario usuario,string clave, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación de duplicidad delegada a datos
            if (!ValidarCamposObligatorios(usuario, out mensaje))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(clave) || clave.Trim().Length < 6) 
            { 
                mensaje = "La contraseña debe tener al menos 6 caracteres.";
                return false;
            }

            if (!ValidarUnicidad(usuario, out mensaje))
            {
                return false;
            }

            

            try
            {
                usuario.Clave = SeguridadHelper.GenerarHashSha256(clave.Trim());

                int nuevoId = _cdUsuario.Registrar(usuario);
                if (nuevoId > 0)
                {
                    usuario.IdUsuario = nuevoId;
                    mensaje = "Usuario registrado con éxito.";
                    return true;
                }

                mensaje = "No se puede registrar el usuario en la base de datos.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar al usuario: " + ex.Message;
                return false;
            }
        }

        // Método para modificar un usuario existente con validación de duplicidad de nombre de usuario
        public bool ModificarUsuario(Usuario usuario, bool actualizarClave, string claveNueva, out string mensaje)
        {
            mensaje = string.Empty;

            if (usuario == null || usuario.IdUsuario <= 0)
            {
                mensaje = "El usuario no es válido.";
                return false;
            }

            if (!ValidarCamposObligatorios(usuario, out mensaje))
            {
                return false;
            }

            if (!ValidarUnicidad(usuario, out mensaje))
            {
                return false;
            }

            if (actualizarClave)
            {
                if (string.IsNullOrWhiteSpace(claveNueva) || claveNueva.Trim().Length < 6)
                {
                    mensaje = "La nueva contraseña debe tener al menos 6 caracteres.";
                    return false;
                }

                usuario.Clave = SeguridadHelper.GenerarHashSha256(claveNueva.Trim());
            }

            try
            {
                bool resultado = _cdUsuario.Modificar(usuario, actualizarClave);

                if (resultado)
                {
                    mensaje = "Usuario actualizado con éxito.";
                    return true;
                }

                mensaje = "No se pudo actualizar el registro en la base de datos.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al actualizar el usuario: " + ex.Message;
                return false;
            }


        }

        // Método para cambiar el estado de un usuario (activar/desactivar) con validación para evitar que un usuario se desactive a sí mismo
        public bool CambiarEstadoUsuario(int idUsuarioObjetivo, int idUsuarioLogueado, bool nuevoEstado, out string mensaje)
        {
            mensaje = string.Empty;

            if (idUsuarioObjetivo == idUsuarioLogueado && !nuevoEstado)
            {
                mensaje = "No puedes desactivar tu propia cuenta mientras tiene la sesion activa.";
                return false;
            }

            try
            {
                bool resultado = _cdUsuario.CambiarEstado(idUsuarioObjetivo, nuevoEstado);
                if (resultado)
                {
                    mensaje = $"Usuario {(nuevoEstado ? "activado" : "desactivado")} con éxito.";
                    return resultado;
                }

                mensaje = "No se pudo actualizar el estado del usuario.";
                return resultado;
            }
            catch (Exception ex)
            {
                mensaje = "Error al cambiar el estado del usuario: " + ex.Message;
                return false;
            }
        }

        private static bool ValidarCamposObligatorios(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;

            if (usuario == null)
            {
                mensaje = "Los datos del usuario son requeridos.";
                return false;
                }

            if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Apellido))
            {
                mensaje = "El nombre y el apellido son obligatorios.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario) || usuario.NombreUsuario.Trim().Length < 4)
            {
                mensaje = "El nombre de usuario debe tener al menos 4 caracteres.";
                return false;
            }

            if (usuario.Rol == null || usuario.Rol.IdRol <= 0)
            {
                mensaje = "Debes asignar un rol valido al usuario.";
                return false;
            }

            return true;
        }

        private bool ValidarUnicidad(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;

            // Validar que el nombre de usuario no esté tomado por otro
            if (_cdUsuario.ExisteUsuario(usuario.NombreUsuario.Trim(), usuario.IdUsuario))
            {
                mensaje = $"El nombre de usuario '{usuario.NombreUsuario.Trim()}' ya está registrado.";
                return false;
            }

            // Validar DNI único para otro usuario
            if (!string.IsNullOrWhiteSpace(usuario.Dni) && _cdUsuario.ExisteDni(usuario.Dni.Trim(), usuario.IdUsuario))
            {
                mensaje = "El DNI ingresado ya pertenece a otro usuario.";
                return false;
            }

            // Validar Correo único para otro usuario
            if (!string.IsNullOrWhiteSpace(usuario.Correo) && _cdUsuario.ExisteCorreo(usuario.Correo.Trim(), usuario.IdUsuario))
            {
                mensaje = "El correo electrónico ya pertenece a otro usuario.";
                return false;
            }

            return true;
        }
    }
}
