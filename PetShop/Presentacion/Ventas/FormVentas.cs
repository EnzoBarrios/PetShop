using PetShop.Entidades;
using PetShop.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PetShop.Presentacion.Ventas
{
    public partial class FormRegistrarVenta : Form
    {
        private readonly CN_Venta _cnVenta = new CN_Venta();
        private readonly CN_Producto _cnProducto = new CN_Producto();
        private readonly List<DetalleVenta> _listaDetalle = new List<DetalleVenta>();

        private Producto _productoSeleccionado = null;
        private readonly Usuario _usuarioLogueado;

        public FormRegistrarVenta(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogueado = usuario;
        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            CargarInformacionInicial();
            ConfigurarGrillaCarrito();
        }

        private void CargarInformacionInicial()
        {
            txtNroFactura.Text = _cnVenta.ObtenerProximoNroFactura();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            txtFecha.ReadOnly = true;
            txtNroFactura.ReadOnly = true;

            // Cargar Tipos de Venta desde la BD
            cbxTipoVenta.DataSource = _cnVenta.ListarTiposVenta();
            cbxTipoVenta.DisplayMember = nameof(TipoVenta.Descripcion);
            cbxTipoVenta.ValueMember = nameof(TipoVenta.IdTipoVenta);
            cbxTipoVenta.SelectedIndex = 0;

            // Cargar Métodos de Pago desde la BD
            cbxMetodoPago.DataSource = _cnVenta.ListarMetodosPago();
            cbxMetodoPago.DisplayMember = nameof(MetodoPago.NombreMetodo);
            cbxMetodoPago.ValueMember = nameof(MetodoPago.IdMetodoPago);
            cbxMetodoPago.SelectedIndex = 0;
        }

        private void ConfigurarGrillaCarrito()
        {
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.Columns.Clear();

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NombreProducto", HeaderText = "Producto", Width = 200 });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Codigo", HeaderText = "Código", Width = 100 });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PrecioUnitario", HeaderText = "Precio U.", Width = 100 });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cantidad", HeaderText = "Cantidad", Width = 80 });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal", HeaderText = "Subtotal", Width = 110 });

            // Botón Eliminar Fila
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "Acción",
                Text = "Quitar",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dgvCarrito.Columns.Add(btnEliminar);
        }

        // --- 1. BÚSQUEDA Y SELECCIÓN DE PRODUCTO ---

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoPorNombre();
        }

        private void TxtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarProductoPorNombre();
                e.SuppressKeyPress = true;
            }
        }

        private void BuscarProductoPorNombre()
        {
            string busquedaNombre = txtNombreProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(busquedaNombre))
            {
                MessageBox.Show("Ingrese el nombre del producto a buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Producto> productos = _cnProducto.ListarProductos(busquedaNombre);

            _productoSeleccionado = productos.FirstOrDefault(p =>
                p.Nombre.ToLower().Contains(busquedaNombre.ToLower())
            );

            if (_productoSeleccionado != null)
            {
                if (!_productoSeleccionado.Estado)
                {
                    MessageBox.Show("El producto seleccionado se encuentra inactivo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCamposProducto();
                    return;
                }

                txtNombreProducto.Text = _productoSeleccionado.Nombre;
                txtCodProducto.Text = _productoSeleccionado.Codigo;
                txtPrecioUnitario.Text = _productoSeleccionado.PrecioVenta.ToString("F2");
                txtStockDisponible.Text = _productoSeleccionado.StockActual.ToString();

                numCantidad.Value = 1;
                numCantidad.Maximum = _productoSeleccionado.StockActual > 0 ? _productoSeleccionado.StockActual : 1;
            }
            else
            {
                MessageBox.Show("No se encontró ningún producto con ese nombre.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposProducto();
            }
        }

        // --- 2. AGREGAR PRODUCTO AL CARRITO ---

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un producto primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidadIngresada = (int)numCantidad.Value;

            if (cantidadIngresada <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleVenta detalleExistente = _listaDetalle.FirstOrDefault(d => d.IdProducto == _productoSeleccionado.IdProducto);

            if (detalleExistente != null)
            {
                int nuevaCantidad = detalleExistente.Cantidad + cantidadIngresada;
                if (nuevaCantidad > _productoSeleccionado.StockActual)
                {
                    MessageBox.Show($"Supera el stock disponible ({_productoSeleccionado.StockActual} unidades).", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                detalleExistente.Cantidad = nuevaCantidad;
                detalleExistente.RecalcularSubtotal();
            }
            else
            {
                _listaDetalle.Add(new DetalleVenta(cantidadIngresada, _productoSeleccionado.PrecioVenta, _productoSeleccionado));
            }

            RefrescarCarrito();
            LimpiarCamposProducto();
        }

        private void RefrescarCarrito()
        {
            dgvCarrito.DataSource = null;

            dgvCarrito.DataSource = _listaDetalle.Select(d => new
            {
                Producto = d.Producto.Nombre,
                Codigo = d.Producto.Codigo,
                PrecioUnitario = d.PrecioUnitario.ToString("C2"),
                Cantidad = d.Cantidad,
                Subtotal = d.Subtotal.ToString("C2")
            }).ToList();

            CalcularTotales();
        }

        // --- 3. CÁLCULO DE TOTALES, DESCUENTOS Y VUELTO ---

        private void CalcularTotales()
        {
            decimal subtotal = _listaDetalle.Sum(d => d.Subtotal);
            decimal porcentajeDescuento = 0;

            if (decimal.TryParse(txtDescuento.Text.Trim(), out decimal desc))
            {
                porcentajeDescuento = desc;
            }

            decimal montoDescuento = subtotal * (porcentajeDescuento / 100);
            decimal totalFinal = subtotal - montoDescuento;

            lblSubtotal.Text = $"Subtotal: ${subtotal:F2}";
            lblDescuento.Text = $"Descuento: {porcentajeDescuento}%";
            lblTotalFinal.Text = $"TOTAL FINAL: ${totalFinal:F2}";

            CalcularVuelto(totalFinal);
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void TxtMontoAbonado_TextChanged(object sender, EventArgs e)
        {
            decimal subtotal = _listaDetalle.Sum(d => d.Subtotal);
            decimal.TryParse(txtDescuento.Text.Trim(), out decimal desc);
            decimal totalFinal = subtotal - (subtotal * (desc / 100));

            CalcularVuelto(totalFinal);
        }

        private void CalcularVuelto(decimal totalFinal)
        {
            if (decimal.TryParse(txtMontoAbonado.Text.Trim(), out decimal abonado))
            {
                decimal vuelto = abonado - totalFinal;
                if (vuelto >= 0)
                {
                    lblVuelto.Text = $"Vuelto/Cambio: ${vuelto:F2}";
                    lblVuelto.BackColor = Color.LightGreen;
                }
                else
                {
                    lblVuelto.Text = $"Falta abonar: ${Math.Abs(vuelto):F2}";
                    lblVuelto.BackColor = Color.LightPink;
                }
            }
            else
            {
                lblVuelto.Text = "Vuelto/Cambio: $0,00";
                lblVuelto.BackColor = Color.WhiteSmoke;
            }
        }

        // --- 4. CONFIRMAR REGISTRO ---

        private void BtnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (_listaDetalle.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto al carrito.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = _listaDetalle.Sum(d => d.Subtotal);
            decimal.TryParse(txtDescuento.Text.Trim(), out decimal desc);
            decimal totalFinal = subtotal - (subtotal * (desc / 100));

            if (!decimal.TryParse(txtMontoAbonado.Text.Trim(), out decimal abonado) || abonado < totalFinal)
            {
                MessageBox.Show($"El monto abonado es insuficiente para cubrir el total (${totalFinal:F2}).", "Monto Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idTipoVenta = Convert.ToInt32(cbxTipoVenta.SelectedValue);
            int idMetodoPago = Convert.ToInt32(cbxMetodoPago.SelectedValue);

            Venta nuevaVenta = new Venta
            {
                NroFactura = txtNroFactura.Text,
                FechaHora = DateTime.Now,
                Total = totalFinal,
                Estado = "Completada",
                IdTipoVenta = idTipoVenta,
                IdUsuario = _usuarioLogueado.IdUsuario,
                Detalles = _listaDetalle,
                Pagos = new List<Pago>
                {
                    new Pago
                    {
                        IdMetodoPago = idMetodoPago,
                        Monto = abonado
                    }
                }
            };

            bool exito = _cnVenta.RegistrarVenta(nuevaVenta, out string mensaje);

            if (exito)
            {
                MessageBox.Show("Venta registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormularioVenta();
            }
            else
            {
                MessageBox.Show(mensaje, "Error al Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar y limpiar la venta actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarFormularioVenta();
            }
        }

        private void LimpiarCamposProducto()
        {
            _productoSeleccionado = null;
            txtCodProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioUnitario.Clear();
            txtStockDisponible.Clear();
            numCantidad.Value = 1;
            txtNombreProducto.Focus();
        }

        private void LimpiarFormularioVenta()
        {
            LimpiarCamposProducto();
            _listaDetalle.Clear();
            RefrescarCarrito();
            txtDescuento.Clear();
            txtMontoAbonado.Clear();
            CargarInformacionInicial();
        }
    }
}