using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Entidades;
using PetShop.Datos;

namespace PetShop.Negocio
{
    public class CN_Tamano
    {
        private readonly CD_Tamano _cdTamano = new CD_Tamano();

        public List<Tamano> ListarTamanos(string textoBusqueda = "")
        {
            List<Tamano> lista = _cdTamano.Listar(textoBusqueda);

            return lista;
        }

        public Tamano ObtenerTamanoPorId(int idTamano)
        {
            if (idTamano <= 0)
            {
                return null;
            }

            return _cdTamano.ObtenerPorId(idTamano);
        }

        public bool RegistrarTamano(Tamano tamano, out string mensaje)
        {
            if (!ValidarDatosTamano(tamano, out mensaje))
            {
                return false;
            }

            if (_cdTamano.ExisteNombre(tamano.Nombre))
            {
                mensaje = "El tamaño '{tamano.Nombre.Trim()}' ya se encuentra registrado.";
                return false;
            }

            try
            {
                int idGenerado = _cdTamano.Registrar(tamano);
                if (idGenerado > 0)
                {
                    tamano.IdTamano = idGenerado;
                    mensaje = "Tamaño registrado correctamente.";
                    return true;
                }

                mensaje = "No se pudo registrar el tamaño en la base de datos.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar el tamaño: " + ex.Message;
                return false;
            }
        }

        public bool ModificarTamano(Tamano tamano, out string mensaje)
        {
            mensaje = string.Empty;

            if (tamano == null || tamano.IdTamano <= 0)
            {
                mensaje = "Identificador del tamaño no válido.";
                return false;
            }

            if (!ValidarDatosTamano(tamano, out mensaje))
            {
                return false;
            }

            try
            {
                bool resultado = _cdTamano.Modificar(tamano);
                if (resultado)
                {
                    mensaje = "Tamaño actualizado correctamente.";
                    return true;
                }

                mensaje = "No se pudo actualizar el tamaño en la base de datos.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al actualizar el tamaño: " + ex.Message;
                return false;
            }
        }

        public bool CambiarEstadoTamano(int idTamano, bool nuevoEstado, out string mensaje)
        {
            mensaje = string.Empty;

            if (idTamano <= 0)
            {
                mensaje = "El Id de la categoría no es válido.";
                return false;
            }
            try
            {
                bool resultado = _cdTamano.CambiarEstado(idTamano, nuevoEstado);

                if (resultado)
                {
                    mensaje = nuevoEstado ? "Categoría activada con éxito." : "Categoría desactivada con éxito.";
                    return true;
                }

                mensaje = "No se pudo cambiar el estado de la categoría.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = $"Error al cambiar el estado de la categoría: " + ex.Message;
                return false;
            }
        }

        private static bool ValidarDatosTamano(Tamano tamano, out string mensaje)
        {
            mensaje = string.Empty;

            if (tamano == null)
            {
                mensaje = "Los datos del tamano no pueden ser nulos.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tamano.Nombre))
            {
                mensaje = "El nombre del tamano no puede estar vacío.";
                return false;
            }

            if (tamano.Nombre.Trim().Length < 3)
            {
                mensaje = "El nombre del etamanospecie debe tener al menos de 3 letras.";
                return false;
            }

            return true;
        }
    }
}
