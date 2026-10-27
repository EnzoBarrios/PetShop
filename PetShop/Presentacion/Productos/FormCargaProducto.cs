using PetShop.Datos;
using PetShop.Entidades;
using PetShop.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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
                // Carga únicamente las categorías que están activas
                List<Categoria> categoriasActivas = _cnCategoria.ListarCategorias()
                    .Where(c => c.Estado)
                    .ToList();

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
                // Carga únicamente las combinaciones activas
                List<EspecieTamano> relacionesActivas = _cnEspecieTamano.ListarRelaciones()
                    .Where(r => r.Estado)
                    .ToList();

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

        // Permitir solo números enteros (para Código, Cantidad y Stock Mínimo)
        private void SoloNumerosEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Permitir números y el separador decimal (para Precios)
        private void SoloNumerosDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            char separadorDecimal = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != separadorDecimal)
            {
                e.Handled = true;
            }

            // Evitar ingresar más de un separador decimal
            if (e.KeyChar == separadorDecimal && (sender as TextBox).Text.Contains(separadorDecimal))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecio_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox txt && !string.IsNullOrWhiteSpace(txt.Text))
            {
                if (decimal.TryParse(txt.Text.Trim(), out decimal precio))
                {
                    // El formato "N2" formatea el número con separador de miles y 2 decimales
                    txt.Text = precio.ToString("N2");
                }
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

            int categoriaSeleccionada = (int)cbxCategoria.SelectedValue;
            EspecieTamano especieTamanoSeleccionado = (EspecieTamano)cbxEspecieTamano.SelectedItem;

            Producto producto = new Producto
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? string.Empty : txtDescripcion.Text.Trim(),
                Categoria = new Categoria { IdCategoria = categoriaSeleccionada },
                EspecieTamano = (especieTamanoSeleccionado != null && especieTamanoSeleccionado.IdEspecie > 0)
                    ? new EspecieTamano
                    {
                        IdEspecie = especieTamanoSeleccionado.IdEspecie,
                        IdTamano = especieTamanoSeleccionado.IdTamano
                    }
                    : null,
                PrecioCompra = decimal.Parse(txtPrecioCompra.Text.Trim()),
                PrecioVenta = decimal.Parse(txtPrecioVenta.Text.Trim()),
                StockActual = int.Parse(txtStock.Text.Trim()),
                StockMinimo = int.Parse(txtStockMinimo.Text.Trim()),
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
        }

        private bool ValidarCampos()
        {
            _ep.Clear();

            // 1. Validar Código
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                _ep.SetError(txtCodigo, "El código del producto es obligatorio.");
                txtCodigo.Focus();
                return false;
            }

            // 2. Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _ep.SetError(txtNombre, "El nombre del producto es obligatorio.");
                txtNombre.Focus();
                return false;
            }

            // 3. Validar Categoría
            if (cbxCategoria.SelectedValue == null || (int)cbxCategoria.SelectedValue == 0)
            {
                _ep.SetError(cbxCategoria, "Debes seleccionar una categoría.");
                cbxCategoria.Focus();
                return false;
            }

            // 4. Validar Precio Compra
            if (!decimal.TryParse(txtPrecioCompra.Text.Trim(), out decimal precioCompra) || precioCompra < 0)
            {
                _ep.SetError(txtPrecioCompra, "El precio de compra debe ser un valor numérico válido mayor o igual a 0.");
                txtPrecioCompra.Focus();
                return false;
            }

            // 5. Validar Precio Venta
            if (!decimal.TryParse(txtPrecioVenta.Text.Trim(), out decimal precioVenta) || precioVenta < 0)
            {
                _ep.SetError(txtPrecioVenta, "El precio de venta debe ser un valor numérico válido mayor o igual a 0.");
                txtPrecioVenta.Focus();
                return false;
            }

            // 6. Validar Relación Precios (Venta >= Compra)
            if (precioVenta < precioCompra)
            {
                _ep.SetError(txtPrecioVenta, "El precio de venta no puede ser inferior al precio de compra.");
                txtPrecioVenta.Focus();
                return false;
            }

            // 7. Validar Cantidad / Stock Actual
            if (!int.TryParse(txtStock.Text.Trim(), out int cantidad) || cantidad < 0)
            {
                _ep.SetError(txtStock, "La cantidad de stock no puede ser un valor negativo.");
                txtStock.Focus();
                return false;
            }

            // 8. Validar Stock Mínimo
            if (!int.TryParse(txtStockMinimo.Text.Trim(), out int stockMinimo) || stockMinimo < 0)
            {
                _ep.SetError(txtStockMinimo, "El stock mínimo no puede ser un valor negativo.");
                txtStockMinimo.Focus();
                return false;
            }

            // 9. Validar Relación Stock (Stock Actual >= Stock Mínimo)
            if (cantidad < stockMinimo)
            {
                _ep.SetError(txtStock, "La cantidad de stock no puede ser menor que el stock mínimo.");
                txtStock.Focus();
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