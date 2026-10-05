using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Datos;
using PetShop.Entidades;

namespace PetShop.Negocio
{
    public class CN_Categoria
    {
        private readonly CD_Categoria _cdCategoria = new CD_Categoria();

        public List<Categoria> ListarCategorias(string textoBusqueda = "")
        {
            List<Categoria> lista = _cdCategoria.Listar();

            if (!string.IsNullOrWhiteSpace(textoBusqueda))
            {
                string filtro = textoBusqueda.Trim().ToLower();
                lista = lista.Where(c => 
                    c.NombreCategoria.ToLower().Contains(filtro) || 
                    (!string.IsNullOrWhiteSpace(c.Descripcion) && c.Descripcion.ToLower().Contains(filtro))
                    ).ToList();
            }

            return lista;
        }

        public Categoria ObtenerCategoriaPorId(int idCategoria)
        {
            if (idCategoria <= 0)
            {
                return null;
            }

            return _cdCategoria.ObtenerPorId(idCategoria);
        }

        public bool RegistrarCategoria(Categoria categoria, out string mensaje)
        {
            mensaje = string.Empty;

            if (!ValidarDatosCategoria(categoria,out mensaje))
            {
                return false;
            }

            categoria.NombreCategoria = categoria.NombreCategoria.Trim();
            categoria.Descripcion = string.IsNullOrWhiteSpace(categoria.Descripcion) ? null : categoria.Descripcion.Trim();

            if (_cdCategoria.ExisteNombre(categoria.NombreCategoria, 0))
            {
                mensaje = $"Ya existe una categoría con ese nombre '{categoria.NombreCategoria.Trim()}'";
                return false;
            }

            try
            {
                int idGenerado = _cdCategoria.Registrar(categoria);

                if (idGenerado > 0)
                {
                    categoria.IdCategoria = idGenerado;
                    mensaje = "Categoría registrada con éxito.";
                    return true;
                }

                mensaje = "No se pudo registrar la categoría."; 
                return false;
            }  
            catch (Exception ex)
            {
                mensaje = $"Error al registrar la categoría: " + ex.Message;
                return false;
            }
        } 

        public bool ModificarCategoria(Categoria categoria, out string mensaje)
        {
            mensaje = string.Empty;

            if(categoria == null || categoria.IdCategoria <= 0)
            {
                mensaje = "El objeto de categoría no es válido.";
                return false;
            }   

            if (!ValidarDatosCategoria(categoria, out mensaje))
            {
                return false;
            }

            categoria.NombreCategoria = categoria.NombreCategoria.Trim();
            categoria.Descripcion = string.IsNullOrWhiteSpace(categoria.Descripcion) ? null : categoria.Descripcion.Trim();

            if (_cdCategoria.ExisteNombre(categoria.NombreCategoria, 0))
            {
                mensaje = $"Ya existe otra categoría con el nombre '{categoria.NombreCategoria.Trim()}'";
                return false;
            }

            try
            {
                bool modificado = _cdCategoria.Modificar(categoria);
                
                if (modificado)
                {
                    mensaje = "Categoría modificada con éxito.";
                    return true;
                }

                mensaje = "No se pudo modificar la categoría.";
                return false;
            }
            catch(Exception ex)
            {
                mensaje = $"Error al modificar la categoría: " + ex.Message;
                return false;
            }
        }

        public bool CambiarEstadoCategoria(int idCategoria, bool nuevoEstado, out string mensaje)
        {
            mensaje = string.Empty;

            if (idCategoria <= 0)
            {
                mensaje = "El Id de la categoría no es válido.";
                return false;
            }
            try
            { 
                bool resultado = _cdCategoria.CambiarEstado(idCategoria, nuevoEstado);

                if (resultado)
                {
                    mensaje = nuevoEstado ? "Categoría activada con éxito." : "Categoría desactivada con éxito.";
                    return true;
                }

                mensaje = "No se pudo cambiar el estado de la categoría.";
                return false;
            }
            catch(Exception ex)
            {
                mensaje = $"Error al cambiar el estado de la categoría: " + ex.Message;
                return false;
            }
        }

        private static bool ValidarDatosCategoria(Categoria categoria, out string mensaje)
        {
            mensaje = string.Empty;

            if(categoria == null)
            {
                mensaje = "Los datos de la categoría no pueden ser nulos.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(categoria.NombreCategoria))
            {
                mensaje = "El nombre de la categoría no puede estar vacío.";
                return false;
            }

            if (categoria.NombreCategoria.Length > 50)
            {
                mensaje = "El nombre de la categoría no puede exceder los 50 caracteres.";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(categoria.Descripcion) && categoria.Descripcion.Length > 255)
            {
                mensaje = "La descripción de la categoría no puede exceder los 255 caracteres.";
                return false;
            }

            return true;
        }
    }
}
