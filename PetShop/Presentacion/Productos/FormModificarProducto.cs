using PetShop.Entidades;
using PetShop.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FormModificarProducto : Form
    {
        private readonly int _idProducto;
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Producto _cnProducto = new CN_Producto();
        private readonly CN_Categoria _cnCategoria = new CN_Categoria();
        private readonly CN_EspecieTamano _cnEspecieTamano = new CN_EspecieTamano();

        public FormModificarProducto(int idProducto)
        {
            InitializeComponent();
            _idProducto = idProducto;
        }

        private void FormModificarProducto_Load(object sender, EventArgs e)
        {
            if (_idProducto <= 0)
            {
                MessageBox.Show("No se selecciono un producto valido para modificar.", 
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            ActualizarContadorCaracteres();
            CargarCategorias();
            CargarEspeciesTamanos();
            CargarProductos();
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ActualizarContadorCaracteres();
        }

        private void ActualizarContadorCaracteres()
        {
            lblContador.Text = $"{txtDescripcion.Text.Length} / 255";
            lblContador.ForeColor = txtDescripcion.Text.Length > 250 ? Color.Red : Color.DimGray;
        }

        private void CargarCategorias()
        {
            try
            {
                List<Categoria> categorias = _cnCategoria.ListarCategorias();

                cbxCategoria.DataSource = null;
                cbxCategoria.DisplayMember = nameof(Categoria.NombreCategoria);
                cbxCategoria.ValueMember = nameof(Categoria.IdCategoria);
                cbxCategoria.DataSource = categorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEspeciesTamanos()
        {
            try
            {
                List<EspecieTamano> relacionesActivas = _cnEspecieTamano.ListarRelaciones();

                relacionesActivas.Insert(0, new EspecieTamano
                {
                    IdEspecie = 0,
                    IdTamano = 0,
                    Especie = new Especie { Nombre = "-- Seleccione" },
                    Tamano = new Tamano { Nombre = "Especie / Tamaño --" }
                });

                cbxEspecieTamano.DataSource = null;
                cbxEspecieTamano.DisplayMember = nameof(EspecieTamano.NombreRelacion);
                cbxEspecieTamano.SelectedIndex = 0;
                cbxEspecieTamano.DataSource = relacionesActivas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las relaciones entre especies y tamaños: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                Producto producto = _cnProducto.ObtenerPorId(_idProducto);

                if (producto == null)
                {
                    MessageBox.Show($"No se encontro el producto en la base de datos", 
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                txtCodigo.Text = producto.Codigo;
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion ?? string.Empty;

                if (producto.Categoria != null)
                {
                    cbxCategoria.SelectedValue = producto.Categoria.IdCategoria;
                }
                
                if (producto.EspecieTamano != null && cbxEspecieTamano.Items.Count > 0)
                {
                    foreach (EspecieTamano item in cbxEspecieTamano.Items)
                    {
                        if (item.IdEspecie == producto.EspecieTamano.IdEspecie &&
                            item.IdTamano == producto.EspecieTamano.IdTamano)
                        {
                            cbxEspecieTamano.SelectedItem = producto.EspecieTamano;
                            break;
                        }
                    }
                }

                txtPrecioCompra.Text = producto.PrecioCompra.ToString();
                txtPrecioVenta.Text = producto.PrecioVenta.ToString();
                txtStock.Text = producto.StockActual.ToString();
                txtStockMinimo.Text = producto.StockMinimo.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del producto: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }

            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == ',') && (textBox != null) && (textBox.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, verifique los campos marcados con advertencias.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro que desea guardar los cambios del producto?",
                "Confirmar Modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)cbxCategoria.SelectedItem;
            EspecieTamano especieTamanoSeleccionado = (EspecieTamano)cbxEspecieTamano.SelectedItem;

            Producto productoModificado = new Producto
            {
                IdProducto = _idProducto,
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Categoria = new Categoria 
                { 
                    IdCategoria =  categoriaSeleccionada.IdCategoria
                },
                EspecieTamano = new EspecieTamano 
                { 
                    IdEspecie = especieTamanoSeleccionado.IdEspecie,
                    IdTamano = especieTamanoSeleccionado.IdTamano
                },
                PrecioCompra = decimal.Parse(txtPrecioCompra.Text.Trim()),
                PrecioVenta = decimal.Parse(txtPrecioVenta.Text.Trim()),
                StockActual = int.Parse(txtStock.Text.Trim()),
                StockMinimo = int.Parse(txtStockMinimo.Text.Trim())
            };

            bool exito = _cnProducto.ModificarProducto(productoModificado, out string mensaje);

            if (exito)
            {
                MessageBox.Show(mensaje, 
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _ep.SetError(txtCodigo, mensaje);
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarCampos()
        {
            _ep.Clear();
            bool esValido = true;

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _ep.SetError(txtNombre, "El nombre del producto es obligatorio.");
                esValido = false;
            }

            // Validar Categoría
            if (cbxCategoria.SelectedIndex == -1 || cbxCategoria.SelectedValue == null)
            {
                _ep.SetError(cbxCategoria, "Debe seleccionar una categoría.");
                esValido = false;
            }

            // Validar Precio Compra
            if (!decimal.TryParse(txtPrecioCompra.Text.Trim(), out decimal precioCompra) || precioCompra < 0)
            {
                _ep.SetError(txtPrecioCompra, "El precio de compra no puede ser menor a 0");
                esValido = false;
            }

            // Validar Precio Venta
            if (!decimal.TryParse(txtPrecioVenta.Text.Trim(), out decimal precioVenta) || precioVenta < 0)
            {
                _ep.SetError(txtPrecioVenta, "El precio de la venta no puede ser menor a 0");
                esValido = false;
            }

            // Validar Relación Precios
            if (precioVenta < precioCompra)
            {
                _ep.SetError(txtPrecioVenta, "El precio de venta debe ser mayor al precio de la compra");
                esValido = false;
            }

            // Validar Stock / Cantidad
            if (!int.TryParse(txtStock.Text.Trim(), out int cantidad) || cantidad < 0)
            {
                _ep.SetError(txtStock, "La cantidad de productos no puede ser menor a 0");
                esValido = false;
            }

            // Validar Stock Minimo
            if (!int.TryParse(txtStockMinimo.Text.Trim(), out int stockMinimo) || stockMinimo < 0)
            {
                _ep.SetError(txtStockMinimo, "El stock minimo de productos no puede ser menor a 0");
                txtStockMinimo.Focus();
                return false;
            }

            // Validar Relación Stock
            if (cantidad < stockMinimo)
            {
                _ep.SetError(txtStockMinimo, "El stock minimo debe ser menor al stock del producto");
                txtStockMinimo.Focus();
                return false;
            }

            return esValido;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
