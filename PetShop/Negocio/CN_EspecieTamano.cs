using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Datos;
using PetShop.Entidades;

namespace PetShop.Negocio
{
    public class CN_EspecieTamano
    {
        private readonly CD_EspecieTamano _cdEspecieTamano = new CD_EspecieTamano();

        public List<EspecieTamano> ListarRelaciones(string filtroBusqueda = "")
        {
            List<EspecieTamano> lista = _cdEspecieTamano.Listar();

            if (!string.IsNullOrWhiteSpace(filtroBusqueda))
            {
                string filtro = filtroBusqueda.Trim().ToLower();
                lista = lista.Where(r =>
                    (!string.IsNullOrEmpty(r.NombreEspecie) && r.NombreEspecie.ToLower().Contains(filtro)) ||
                    (!string.IsNullOrEmpty(r.NombreTamano) && r.NombreTamano.ToLower().Contains(filtro))
                ).ToList();
            }

            return lista;
        }

        public bool AsignarRelacion(int idEspecie, int idTamano, out string mensaje)
        {
            mensaje = string.Empty;

            if (idEspecie <= 0 || idTamano <= 0)
            {
                mensaje = "Debe seleccionar una especie y un tamaño válidos.";
                return false;
            }

            try
            {
                bool existe = _cdEspecieTamano.ExisteRelacion(idEspecie, idTamano, out bool estaActivo);
                if (existe)
                {
                    if (estaActivo)
                    {
                        mensaje = "La combinación seleccionada ya se encuentra registrada en el sistema.";
                        return false;
                    }
                    else
                    {
                        bool reactivado = _cdEspecieTamano.CambiarEstado(idEspecie, idTamano, true);
                        if (reactivado)
                        {
                            mensaje = "La combinación existía previamente inactiva y ha sido reactivada con éxito.";
                            return true;
                        }

                        mensaje = "No se pudo reactivar la combinación existente.";
                        return false;
                    }
                }

                EspecieTamano nuevaRelacion = new EspecieTamano(idEspecie, idTamano, estado: true);
                bool resultado = _cdEspecieTamano.Registrar(nuevaRelacion);

                if (resultado)
                {
                    mensaje = "Combinación asignada y registrada con exito.";
                    return true;
                }

                mensaje = "No se pudo registrar la combinación en la base de datos.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al guardar la relación: " + ex.Message;
                return false;
            }
        }

        public bool CambiarEstado(int idEspecie, int idTamano, bool nuevoEstado, out string mensaje)
        {
            mensaje = string.Empty;

            if (idEspecie <= 0 || idTamano <= 0)
            {
                mensaje = "Identificadores de relación no válidos.";
                return false;
            }

            try
            {
                bool resultado = _cdEspecieTamano.CambiarEstado(idEspecie, idTamano, nuevoEstado);
                if (resultado)
                {
                    mensaje = nuevoEstado ? "Combinación activada correctamente." : "Combinación desactivada correctamente.";
                    return true;
                }

                mensaje = "No se pudo actualizar el estado de la combinación.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al actualizar estado: " + ex.Message;
                return false;
            }
        }

        public List<Tamano> ObtenerTamanosPorEspecie(int idEspecie)
        {
            if (idEspecie <= 0)
            {
                return new List<Tamano>();
            }

            return _cdEspecieTamano.Listar()
                .Where(r => r.IdEspecie == idEspecie && r.Estado && r.Tamano != null && r.Tamano.Estado)
                .Select(r => r.Tamano)
                .ToList();
        }
    }
}
