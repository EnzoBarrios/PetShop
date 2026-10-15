using PetShop.Datos;
using PetShop.Entidades;
using PetShop.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using PetShop.Entidades;
using PetShop.Negocio;

namespace PetShop.Presentacion.Productos
{
    public partial class FormCargaProducto : Form
    {
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Producto _cnProducto = new CN_Producto();
        private readonly CN_Categoria _cnCategoria = new CN_Categoria();
        private readonly CN_EspecieTamano _cnEspecieTamano = new CN_EspecieTamano();

        public FormCargaProducto()
        {
            InitializeComponent();
        }

        private void FormCargaProducto_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            ActualizarContadorCaracteres();
            CargarCategorias();
            CargarEspeciesTamanos();
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
                List<Categoria> categoriasActivas = _cnCategoria.ListarCategorias()
                    .Where(e => e.Estado).ToList();

                categoriasActivas.Insert(0, new Categoria 
                { 
                    IdCategoria = 0, 
                    NombreCategoria = "-- Seleccione Categoría --" 
                });

                cbxCategoria.DataSource = categoriasActivas;
                cbxCategoria.DisplayMember = nameof(Categoria.NombreCategoria);
                cbxCategoria.ValueMember = nameof(Categoria.IdCategoria);
                cbxCategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}",
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

                cbxEspecieTamano.DataSource = relacionesActivas;
                cbxEspecieTamano.DisplayMember = nameof(EspecieTamano.NombreRelacion);
                cbxEspecieTamano.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las relaciones entre especies y tamaños: {ex.Message}",
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, verifique los campos marcados advertencias.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoriaSeleccionada = (int)cbxCategoria.SelectedValue;
            EspecieTamano especieTamanoSeleccionado = (EspecieTamano)cbxEspecieTamano.SelectedItem;

            Producto producto = new Producto
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? string.Empty : txtDescripcion.Text.Trim(),
                Categoria = new Categoria { IdCategoria = categoriaSeleccionada },
                EspecieTamano = new EspecieTamano 
                { 
                    IdEspecie = especieTamanoSeleccionado.IdEspecie, 
                    IdTamano = especieTamanoSeleccionado.IdTamano 
                },
                PrecioCompra = decimal.Parse(txtPrecioCompra.Text.Trim()),
                PrecioVenta = decimal.Parse(txtPrecioVenta.Text.Trim()),
                StockActual = int.Parse(txtCantidad.Text.Trim()),
                Estado = true
            };

            bool exito = _cnProducto.RegistrarProducto(producto, out string mensaje);

            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, 
                    "Validación de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return;
        }

        private bool ValidarCampos()
        {
            _ep.Clear();

            // Validar Código
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                _ep.SetError(txtCodigo, "El codigo del producto es obligatorio");
                txtCodigo.Focus();
                return false;
            }

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _ep.SetError(txtNombre, "El nombre del producto es obligatorio.");
                txtNombre.Focus();
                return false;
            }

            // Validar Categoría
            if (cbxCategoria.SelectedValue == null || (int)cbxCategoria.SelectedValue == 0)
            {
                _ep.SetError(cbxCategoria, "Debes seleccionar una categoría.");
                cbxCategoria.Focus();
                return false;
            }

            // Validar Precio Compra
            if (!decimal.TryParse(txtPrecioCompra.Text.Trim(), out decimal precioCompra) || precioCompra < 0)
            {
                _ep.SetError(txtPrecioCompra, "El precio de compra no puede ser menor a 0");
                txtPrecioCompra.Focus();
                return false;
            }

            // Validar Precio Venta
            if (!decimal.TryParse(txtPrecioVenta.Text.Trim(), out decimal precioVenta) ||  precioVenta < 0)
            {
                _ep.SetError(txtPrecioVenta, "El precio de la venta no puede ser menor a 0");
                txtPrecioVenta.Focus();
                return false;
            }

            // Validar Relación Precios
            if (precioVenta < precioCompra)
            {
                _ep.SetError(txtPrecioVenta, "El precio de venta debe ser mayor al precio de la compra");
                txtPrecioVenta.Focus();
                return false;
            }

            // Validar Stock / Cantidad
            if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad < 0)
            {
                _ep.SetError(txtCantidad, "La cantidad de productos no puede ser menor a 0");
                txtCantidad.Focus();
                return false;
            }

            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}