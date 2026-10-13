using PetShop.Datos;
using PetShop.Entidades;
using PetShop.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace PetShop.Presentacion.Productos
{
    public partial class FormCargaProducto : Form
    {
        // Instancias de servicios de negocio y ErrorProvider
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Producto _cnProducto = new CN_Producto();
        private readonly CN_Categoria _cnCategoria = new CN_Categoria();
        private readonly CN_Especie _cnEspecie = new CN_Especie();
        private readonly CN_EspecieTamano _cnEspecieTamano = new CN_EspecieTamano();

        public FormCargaProducto()
        {
            InitializeComponent();
        }

        private void FormCargaProducto_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            CargarCombosIniciales();
        }

        private void ConfigurarControles()
        {
            // Configuración visual del ErrorProvider (estático, ícono de advertencia)
            _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _ep.Icon = SystemIcons.Warning;

            // Bloquear edición manual en los ComboBoxes
            CBCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTamano.DropDownStyle = ComboBoxStyle.DropDownList;

            // Estado inicial del combo de tamaño
            CBTamano.Enabled = false;

            // Restricción de entrada por teclado en vivo (KeyPress)
            TBCantidad.KeyPress += SoloNumeros_KeyPress;
            TBStockMin.KeyPress += SoloNumeros_KeyPress;
            TBPrecioCompra.KeyPress += SoloDecimales_KeyPress;
            TBPrecioVenta.KeyPress += SoloDecimales_KeyPress;

            // Evento para filtrado dinámico de Tamaños según Especie
            CBEspecie.SelectedIndexChanged += CBEspecie_SelectedIndexChanged;
        }

        private void CargarCombosIniciales()
        {
            try
            {
                // Cargar Categorías activas
                List<Categoria> categorias = _cnCategoria.ListarCategorias();
                CBCategoria.DataSource = null;
                CBCategoria.DisplayMember = "NombreCategoria";
                CBCategoria.ValueMember = "IdCategoria";
                CBCategoria.DataSource = categorias;
                CBCategoria.SelectedIndex = -1;

                // Cargar Especies activas
                List<Especie> especies = _cnEspecie.ListarEspecies();
                CBEspecie.DataSource = null;
                CBEspecie.DisplayMember = "Nombre";
                CBEspecie.ValueMember = "IdEspecie";
                CBEspecie.DataSource = especies;
                CBEspecie.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las listas desplegables: " + ex.Message,
                                "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EVENTO: Filtrado Dinámico de Tamaños por Especie
        private void CBEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBTamano.DataSource = null;

            if (CBEspecie.SelectedIndex != -1 && CBEspecie.SelectedValue != null)
            {
                if (int.TryParse(CBEspecie.SelectedValue.ToString(), out int idEspecie))
                {
                    // Obtener únicamente los tamaños vinculados e activos en Especie_Tamano
                    List<Tamano> tamanosValidos = _cnEspecieTamano.ObtenerTamanosPorEspecie(idEspecie);

                    if (tamanosValidos != null && tamanosValidos.Count > 0)
                    {
                        CBTamano.DisplayMember = "Nombre";
                        CBTamano.ValueMember = "IdTamano";
                        CBTamano.DataSource = tamanosValidos;
                        CBTamano.SelectedIndex = -1;
                        CBTamano.Enabled = true;
                        return;
                    }
                }
            }

            // Si no se seleccionó especie o la especie elegida no requiere/tiene tamaños cargados
            CBTamano.Enabled = false;
        }

        // Restricción para ingresar solo números enteros (Cantidad / Stock Mínimo)
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Restricción para ingresar números decimales (Precios)
        private void SoloDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            char separadorDecimal = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != separadorDecimal)
            {
                e.Handled = true;
            }

            // Evitar ingresar más de un separador decimal
            if (e.KeyChar == separadorDecimal && ((TextBox)sender).Text.IndexOf(separadorDecimal) > -1)
            {
                e.Handled = true;
            }
        }

        // Validaciones locales del formulario de presentación
        private bool ValidarFormulario()
        {
            _ep.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(TBCodigo.Text))
            {
                _ep.SetError(TBCodigo, "El código de barra es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(TBNombre.Text))
            {
                _ep.SetError(TBNombre, "El nombre del producto es obligatorio.");
                esValido = false;
            }

            if (CBCategoria.SelectedIndex == -1 || CBCategoria.SelectedValue == null)
            {
                _ep.SetError(CBCategoria, "Debe seleccionar una categoría para el producto.");
                esValido = false;
            }

            if (!decimal.TryParse(TBPrecioCompra.Text.Trim(), out decimal precioCompra) || precioCompra < 0)
            {
                _ep.SetError(TBPrecioCompra, "Ingrese un precio de compra válido mayor o igual a 0.");
                esValido = false;
            }

            if (!decimal.TryParse(TBPrecioVenta.Text.Trim(), out decimal precioVenta) || precioVenta <= 0)
            {
                _ep.SetError(TBPrecioVenta, "El precio de venta debe ser mayor a cero.");
                esValido = false;
            }
            else if (precioVenta < precioCompra)
            {
                _ep.SetError(TBPrecioVenta, "El precio de venta no puede ser inferior al precio de compra.");
                esValido = false;
            }

            if (!int.TryParse(TBCantidad.Text.Trim(), out int cantidad) || cantidad < 0)
            {
                _ep.SetError(TBCantidad, "Ingrese una cantidad inicial de stock válida (mayor o igual a 0).");
                esValido = false;
            }

            if (!int.TryParse(TBStockMin.Text.Trim(), out int stockMinimo) || stockMinimo < 0)
            {
                _ep.SetError(TBStockMin, "Ingrese un stock mínimo válido (mayor o igual a 0).");
                esValido = false;
            }

            // Si el combo de Tamaño está HABILITADO, exige seleccionar un tamaño para la especie
            if (CBTamano.Enabled && (CBTamano.SelectedIndex == -1 || CBTamano.SelectedValue == null))
            {
                _ep.SetError(CBTamano, "Debe seleccionar un tamaño para la especie indicada.");
                esValido = false;
            }

            return esValido;
        }

        // BOTÓN GUARDAR
        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Por favor, verifique los campos marcados con advertencias.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construcción del objeto Entidad Producto
            Producto nuevoProducto = new Producto
            {
                Codigo = TBCodigo.Text.Trim(),
                Nombre = TBNombre.Text.Trim(),
                Descripcion = string.IsNullOrWhiteSpace(TBDescripcion.Text) ? null : TBDescripcion.Text.Trim(),
                PrecioCompra = Convert.ToDecimal(TBPrecioCompra.Text.Trim()),
                PrecioVenta = Convert.ToDecimal(TBPrecioVenta.Text.Trim()),
                StockActual = Convert.ToInt32(TBCantidad.Text.Trim()),
                StockMinimo = Convert.ToInt32(TBStockMin.Text.Trim()), // Toma el valor cargado
                Estado = true,
                Categoria = new Categoria { IdCategoria = Convert.ToInt32(CBCategoria.SelectedValue) }
            };

            // Evaluar asignación de EspecieTamano
            if (CBTamano.Enabled && CBTamano.SelectedValue != null && CBEspecie.SelectedValue != null)
            {
                nuevoProducto.EspecieTamano = new EspecieTamano
                {
                    IdEspecie = Convert.ToInt32(CBEspecie.SelectedValue),
                    IdTamano = Convert.ToInt32(CBTamano.SelectedValue)
                };
            }
            else
            {
                // Si la especie no requiere tamaño o no se seleccionó especie, pasa NULL a SQL
                nuevoProducto.EspecieTamano = null;
            }

            // Registrar en Capa de Negocio
            bool registrado = _cnProducto.RegistrarProducto(nuevoProducto, out string mensaje);

            if (registrado)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Mapear error de código de barras existente al ErrorProvider
                if (mensaje.IndexOf("código", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    _ep.SetError(TBCodigo, mensaje);
                    TBCodigo.Focus();
                }
                else
                {
                    MessageBox.Show(mensaje, "Validación de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // BOTÓN ELIMINAR TODO / LIMPIAR
        private void BEliminar_Click(object sender, EventArgs e)
        {
            bool hayDatosCargados = !string.IsNullOrWhiteSpace(TBCodigo.Text) ||
                                    !string.IsNullOrWhiteSpace(TBNombre.Text) ||
                                    !string.IsNullOrWhiteSpace(TBDescripcion.Text) ||
                                    !string.IsNullOrWhiteSpace(TBPrecioCompra.Text) ||
                                    !string.IsNullOrWhiteSpace(TBPrecioVenta.Text) ||
                                    !string.IsNullOrWhiteSpace(TBCantidad.Text) ||
                                    !string.IsNullOrWhiteSpace(TBStockMin.Text) ||
                                    CBCategoria.SelectedIndex != -1 ||
                                    CBEspecie.SelectedIndex != -1;

            if (!hayDatosCargados)
            {
                MessageBox.Show("No hay datos ingresados para borrar.", "Formulario Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea limpiar todos los campos cargados?",
                "Confirmar Limpieza",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                TBCodigo.Clear();
                TBNombre.Clear();
                TBDescripcion.Clear();
                TBPrecioCompra.Clear();
                TBPrecioVenta.Clear();
                TBCantidad.Clear();
                TBStockMin.Clear();
                CBCategoria.SelectedIndex = -1;
                CBEspecie.SelectedIndex = -1;
                CBTamano.DataSource = null;
                CBTamano.Enabled = false;
                _ep.Clear();
                TBCodigo.Focus();
            }
        }

        // BOTÓN VOLVER
        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}