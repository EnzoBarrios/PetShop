using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Datos;
using PetShop.Entidades;

namespace PetShop.Negocio
{
    public class CN_Producto
    {
        private readonly CD_Producto _cdProducto = new CD_Producto();

        public List<Producto> ListarProductos(string textoBusqueda = "")
        {
            List<Producto> lista = _cdProducto.Listar();

            if (!string.IsNullOrWhiteSpace(textoBusqueda))
            {
                string filtro = textoBusqueda.Trim().ToLower();
                lista = lista.Where(c =>
                    c.Nombre.ToLower().Contains(filtro) ||
                    (!string.IsNullOrWhiteSpace(c.Descripcion) && c.Descripcion.ToLower().Contains(filtro))
                    ).ToList();
            }

            return lista;
        }

        // Método para obtener un usuario por su ID, devolviendo null si el ID es inválido
        public Producto ObtenerPorId(int idProducto)
        {
            if (idProducto <= 0)
            {
                return null;
            }

            try
            {
                return _cdProducto.ObtenerPorId(idProducto);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool RegistrarProducto(Producto producto, out string mensaje)
        {
            mensaje = string.Empty;

            if (!ValidarCampos(producto, out mensaje))
            {
                return false;
            }

            producto.Codigo = producto.Codigo.Trim();

            if (_cdProducto.ExisteCodigoBarra(producto.Codigo))
            {
                mensaje = "El código de barra ingresado ya existe en el sistema.";
                return false;
            }

            try
            {
                int idGenerado = _cdProducto.Registrar(producto);

                if (idGenerado > 0)
                {
                    producto.IdProducto = idGenerado;
                    mensaje = "Producto registrado con éxito.";
                    return true;
                }

                mensaje = "No se pudo registrar el producto.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = $"Error al registrar el producto: " + ex.Message;
                return false;
            }
        }

        public bool Modificar(Producto producto, out string mensaje)
        {
            mensaje = string.Empty;

            if (producto == null || producto.IdProducto <= 0)
            {
                mensaje = "Producto inválido para modificar.";
                return false;
            }

            if (!ValidarCampos(producto, out mensaje))
            {
                return false;
            }

            producto.Codigo = producto.Codigo.Trim();

            if (_cdProducto.ExisteCodigoBarra(producto.Codigo, producto.IdProducto))
            {
                mensaje = "El código de barra pertenece a otro producto.";
                return false;
            }

            try
            {
                bool modificado = _cdProducto.Modificar(producto);

                if (modificado)
                {
                    mensaje = "Producto modificado con éxito.";
                    return true;
                }

                mensaje = "No se pudo modificar el producto.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = $"Error al modificar el producto: " + ex.Message;
                return false;
            }
        }

        public bool CambiarEstado(int idProducto, bool nuevoEstado, out string mensaje)
        {
            mensaje = string.Empty;

            if (idProducto <= 0)
            {
                mensaje = "Producto inválido.";
                return false;
            }

            try
            {
                bool resultado = _cdProducto.CambiarEstado(idProducto, nuevoEstado);

                if (resultado)
                {
                    mensaje = nuevoEstado ? "Producto activado con éxito." : "Producto desactivado con éxito.";
                    return true;
                }

                mensaje = "No se pudo cambiar el estado del producto.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = $"Error al cambiar el estado del producto: " + ex.Message;
                return false;
            }
        }

        private bool ValidarCampos(Producto producto, out string mensaje)
        {
            mensaje = string.Empty;

            if (producto == null)
            {
                mensaje = "Los datos del producto no pueden ser nulos.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(producto.Codigo))
            {
                mensaje = "El código de barra es obligatorio.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                mensaje = "El nombre del producto es obligatorio.";
                return false;
            }
            if (producto.PrecioCompra < 0)
            {
                mensaje = "El precio de compra no puede ser menor a cero.";
                return false;
            }
            if (producto.PrecioVenta <= 0)
            {
                mensaje = "El precio de venta debe ser mayor a cero.";
                return false;
            }
            if (producto.PrecioVenta < producto.PrecioCompra)
            {
                mensaje = "El precio de venta no puede ser inferior al precio de compra.";
                return false;
            }
            if (producto.StockActual < 0 || producto.StockMinimo < 0)
            {
                mensaje = "El stock no puede contener valores negativos.";
                return false;
            }
            if (producto.Categoria == null || producto.Categoria.IdCategoria <= 0)
            {
                mensaje = "Debe asignar una categoría válida.";
                return false;
            }
            return true;
        }
    }
}
