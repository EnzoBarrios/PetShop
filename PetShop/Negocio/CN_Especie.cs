using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Datos;
using PetShop.Entidades;

namespace PetShop.Negocio
{
    public class CN_Especie
    {
        private readonly CD_Especie _cdEspecie = new CD_Especie();

        public List<Especie> ListarEspecies(string textoBusqueda = "")
        {
            List<Especie> lista = _cdEspecie.Listar(textoBusqueda);

            return lista;
        }

        public Especie ObtenerEspeciePorId(int idEspecie)
        {
            if (idEspecie <= 0)
            {
                return null;
            }

            return _cdEspecie.ObtenerPorId(idEspecie);
        }

        public bool RegistrarEspecie(Especie especie, out string mensaje)
        {
            if (!ValidarDatosEspecie(especie, out mensaje))
            {
                return false;
            }

            if (_cdEspecie.ExisteNombre(especie.Nombre))
            {
                mensaje = "La especie '{especie.Nombre.Trim()}' ya se encuentra registrada.";
                return false;
            }

            try
            {
                int idGenerado = _cdEspecie.Registrar(especie);
                if (idGenerado > 0)
                {
                    especie.IdEspecie = idGenerado;
                    mensaje = "Especie registrada correctamente.";
                    return true;
                }

                mensaje = "No se pudo registrar la especie en la base de datos.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar la especie: " + ex.Message;
                return false;
            }
        }

        public bool ModificarEspecie(Especie especie, out string mensaje)
        {
            if (especie == null || especie.IdEspecie <= 0)
            {
                mensaje = "Identificador de especie no válido.";
                return false;
            }

            if (!ValidarDatosEspecie(especie, out mensaje))
            {
                return false;
            }

            try
            {
                bool resultado = _cdEspecie.Modificar(especie);
                if (resultado)
                {
                    mensaje = "Especie actualizada correctamente.";
                    return true;
                }

                mensaje = "No se pudo actualizar la especie en la base de datos.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al actualizar la especie: " + ex.Message;
                return false;
            }
        }

        public bool CambiarEstadoEspecie(int idEspecie, bool nuevoEstado, out string mensaje)
        {
            mensaje = string.Empty;

            if (idEspecie <= 0)
            {
                mensaje = "El Id de la especie no es válido.";
                return false;
            }
            try
            {
                bool resultado = _cdEspecie.CambiarEstado(idEspecie, nuevoEstado);

                if (resultado)
                {
                    mensaje = nuevoEstado ? "Especie activada con éxito." : "Especie desactivada con éxito.";
                    return true;
                }

                mensaje = "No se pudo cambiar el estado de la especie.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = $"Error al cambiar el estado de la especie: " + ex.Message;
                return false;
            }
        }

        private static bool ValidarDatosEspecie(Especie especie, out string mensaje)
        {
            mensaje = string.Empty;

            if (especie == null)
            {
                mensaje = "Los datos de la especie no pueden ser nulos.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(especie.Nombre))
            {
                mensaje = "El nombre de la especie no puede estar vacío.";
                return false;
            }

            if (especie.Nombre.Trim().Length < 3)
            {
                mensaje = "El nombre de la especie debe tener al menos de 3 letras.";
                return false;
            }

            return true;
        }
    }
}
