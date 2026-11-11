using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using PetShop.Entidades;
using PetShop.Negocio;

namespace PetShop.Presentacion.Ventas
{
    public partial class FormRegistrarVenta : Form
    {
        // --- ATRIBUTOS PRIVADOS ---
        private readonly CN_Venta _cnVenta = new CN_Venta();
        private readonly CN_Producto _cnProducto = new CN_Producto();
        private readonly List<DetalleVenta> _listaDetalle = new List<DetalleVenta>();

        private Producto _productoSeleccionado = null;
        private readonly Usuario _usuarioLogueado;

        // --- CONSTRUCTOR Y CARGA INICIAL ---
        public FormRegistrarVenta(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogueado = usuario;

            typeof(DataGridView).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgvCarrito, true, null);
        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            ConfigurarGrillaCarrito();
        }

        private void FormResitrarVenta_Shown(object sender, EventArgs e)
        {
            CargarInformacionInicial();
        }

        private void CargarInformacionInicial()
        {
            txtCodProducto.ReadOnly = true;
            txtPrecioUnitario.ReadOnly = true;
            txtStockDisponible.ReadOnly = true;
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            txtFecha.ReadOnly = true;
            txtNroFactura.ReadOnly = true;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                txtNroFactura.Text = _cnVenta.ObtenerProximoNroFactura();

                // Cargar Tipos de Venta
                cbxTipoVenta.DataSource = _cnVenta.ListarTiposVenta();
                cbxTipoVenta.DisplayMember = nameof(TipoVenta.Descripcion);
                cbxTipoVenta.ValueMember = nameof(TipoVenta.IdTipoVenta);
                if (cbxTipoVenta.Items.Count > 0) cbxTipoVenta.SelectedIndex = 0;

                // Cargar Primer Método de Pago
                cbxMetodoPago.DataSource = _cnVenta.ListarMetodosPago();
                cbxMetodoPago.DisplayMember = nameof(MetodoPago.NombreMetodo);
                cbxMetodoPago.ValueMember = nameof(MetodoPago.IdMetodoPago);
                if (cbxMetodoPago.Items.Count > 0) cbxMetodoPago.SelectedIndex = 0;

                // Actualizar las opciones del segundo combo según la selección del primero
                ActualizarOpcionesSegundoMetodoPago();

                // Estado inicial del segundo método de pago (deshabilitado por defecto)
                chbxMetodoPago.Checked = false;
                HabilitarSegundoMetodoPago(false);

                txtDescuento.Text = "0%";
                txtMontoAbonado.Text = "0,00";
                txtMontoAbonado2.Text = "0,00";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar configuración inicial: {ex.Message}",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ConfigurarGrillaCarrito()
        {
            if (dgvCarrito.Columns.Count > 0) return;

            dgvCarrito.AutoGenerateColumns = false;

            dgvCarrito.Columns["colProducto"].DataPropertyName = "Producto";
            dgvCarrito.Columns["colCodigo"].DataPropertyName = "Codigo";
            dgvCarrito.Columns["colPrecio"].DataPropertyName = "PrecioUnitario";
            dgvCarrito.Columns["colCantidad"].DataPropertyName = "Cantidad";
            dgvCarrito.Columns["colSubtotal"].DataPropertyName = "Subtotal";

            if (dgvCarrito.Columns["colAccion"] is DataGridViewButtonColumn colBtn)
            {
                colBtn.Text = "Quitar";
                colBtn.UseColumnTextForButtonValue = true;
                colBtn.FlatStyle = FlatStyle.Flat;
                colBtn.DefaultCellStyle.ForeColor = Color.Red;
                colBtn.DefaultCellStyle.SelectionForeColor = Color.Red;
                colBtn.DefaultCellStyle.BackColor = Color.FromArgb(253, 237, 236);
            }
        }

        // --- BÚSQUEDA Y SELECCIÓN DE PRODUCTOS ---
        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoPorNombre();
        }

        private void TxtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BuscarProductoPorNombre();
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

            this.Cursor = Cursors.WaitCursor;

            List<Producto> productosEncontrados = _cnProducto.ListarProductos(busquedaNombre)
                .Where(p => p.Estado && p.Nombre.ToLower().Contains(busquedaNombre.ToLower()))
                .ToList();

            this.Cursor = Cursors.Default;

            if (productosEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontró ningún producto activo con ese nombre.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposProducto();
                return;
            }

            using (var modal = new FormBuscarProducto(productosEncontrados))
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK && modal.ProductoSeleccionado != null)
                {
                    CargarProductoEnInterfaz(modal.ProductoSeleccionado);
                }
            }
        }

        private void CargarProductoEnInterfaz(Producto producto)
        {
            if (!producto.Estado)
            {
                MessageBox.Show("El producto seleccionado se encuentra inactivo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCamposProducto();
                return;
            }

            _productoSeleccionado = producto;

            txtNombreProducto.Text = _productoSeleccionado.Nombre;
            txtCodProducto.Text = _productoSeleccionado.Codigo;
            txtPrecioUnitario.Text = _productoSeleccionado.PrecioVenta.ToString("F2");
            txtStockDisponible.Text = _productoSeleccionado.StockActual.ToString();

            numCantidad.Value = 1;
            numCantidad.Maximum = _productoSeleccionado.StockActual > 0 ? _productoSeleccionado.StockActual : 1;
        }

        // --- GESTIÓN DEL CARRITO DE COMPRAS ---
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un producto primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_productoSeleccionado.StockActual <= 0)
            {
                MessageBox.Show($"El producto '{_productoSeleccionado.Nombre}' no cuenta con stock disponible.", "Sin Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (_productoSeleccionado.StockActual <= _productoSeleccionado.StockMinimo)
            {
                MessageBox.Show(
                    $"¡Atención! El producto '{_productoSeleccionado.Nombre}' ha alcanzado o superado su stock mínimo.\n" +
                    $"Stock actual: {_productoSeleccionado.StockActual} (Mínimo: {_productoSeleccionado.StockMinimo})",
                    "Alerta de Stock Mínimo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            RefrescarCarrito();
            LimpiarCamposProducto();
        }

        private void RefrescarCarrito()
        {
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.DataSource = null;

            dgvCarrito.DataSource = _listaDetalle.Select(d => new
            {
                Producto = d.Producto.Nombre,
                d.Producto.Codigo,
                PrecioUnitario = d.PrecioUnitario.ToString("C2"),
                d.Cantidad,
                Subtotal = d.Subtotal.ToString("C2")
            }).ToList();

            CalcularTotales();
        }

        private void DgvCarrito_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvCarrito.Columns[e.ColumnIndex].Name == "colAccion")
            {
                dgvCarrito.Cursor = Cursors.Hand;
            }
        }

        private void DgvCarrito_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvCarrito.Columns[e.ColumnIndex].Name == "colAccion")
            {
                dgvCarrito.Cursor = Cursors.Default;
            }
        }

        private void DgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvCarrito.Columns[e.ColumnIndex].Name == "colAccion")
                {
                    _listaDetalle.RemoveAt(e.RowIndex);
                    RefrescarCarrito();
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"No hay productos en el carrito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- CÁLCULOS Y EVENTOS DE DESCUENTO / ABONADO ---

        private void ActualizarOpcionesSegundoMetodoPago()
        {
            if (cbxMetodoPago.SelectedValue == null) return;

            int idMetodo1 = Convert.ToInt32(cbxMetodoPago.SelectedValue);
            List<MetodoPago> todosLosMetodos = _cnVenta.ListarMetodosPago();

            // Excluir el método seleccionado en el primer combo
            List<MetodoPago> metodosFiltrados = todosLosMetodos
                .Where(m => m.IdMetodoPago != idMetodo1)
                .ToList();

            cbxMetodoPago2.DataSource = metodosFiltrados;
            cbxMetodoPago2.DisplayMember = nameof(MetodoPago.NombreMetodo);
            cbxMetodoPago2.ValueMember = nameof(MetodoPago.IdMetodoPago);

            if (cbxMetodoPago2.Items.Count > 0)
            {
                cbxMetodoPago2.SelectedIndex = 0;
            }
        }

        private void HabilitarSegundoMetodoPago(bool habilitar)
        {
            lblMetodoPago2.Enabled = habilitar;
            cbxMetodoPago2.Enabled = habilitar;
            lblMontoAbonado2.Enabled = habilitar;
            txtMontoAbonado2.Enabled = habilitar;

            if (!habilitar)
            {
                txtMontoAbonado2.Text = "0,00";
            }
        }

        private void ChbxMetodoPago_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarSegundoMetodoPago(chbxMetodoPago.Checked);
            CalcularTotales();
        }

        private void CbxMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarOpcionesSegundoMetodoPago();
        }

        private void CalcularTotales()
        {
            decimal subtotal = _listaDetalle.Sum(d => d.Subtotal);

            string textoDescuentoLimpio = txtDescuento.Text.Replace("%", "").Replace("$", "").Trim();
            decimal.TryParse(textoDescuentoLimpio, out decimal valorDescuento);

            var (montoDescuento, totalFinal, textoDescuento) = _cnVenta.CalcularTotalesVenta(subtotal, valorDescuento);

            // Sumar Monto Abonado 1
            string textoAbonado1 = txtMontoAbonado.Text.Replace("$", "").Trim();
            decimal.TryParse(textoAbonado1, out decimal abonado1);

            // Sumar Monto Abonado 2 (solo si está activo el checkbox)
            decimal abonado2 = 0;
            if (chbxMetodoPago.Checked)
            {
                string textoAbonado2 = txtMontoAbonado2.Text.Replace("$", "").Trim();
                decimal.TryParse(textoAbonado2, out abonado2);
            }

            decimal totalAbonado = abonado1 + abonado2;

            lblSubtotal.Text = $"Subtotal: ${subtotal:F2}";
            lblDescuentoFinal.Text = $"Descuento: {textoDescuento}";
            lblMontoFinal.Text = $"Abonado: ${totalAbonado:F2}";
            lblTotalFinal.Text = $"TOTAL FINAL: ${totalFinal:F2}";

            ActualizarInterfazVuelto(totalAbonado, totalFinal);
        }

        private void ActualizarInterfazVuelto(decimal abonado, decimal totalFinal)
        {
            var (vuelto, esSuficiente) = _cnVenta.CalcularVuelto(abonado, totalFinal);

            if (esSuficiente)
            {
                if (vuelto > 0)
                {
                    lblVuelto.Text = $"Vuelto/Cambio: ${vuelto:F2}";
                    lblVuelto.BackColor = Color.LightGreen;
                }
                else
                {
                    lblVuelto.Text = "Vuelto/Cambio: $0,00";
                }
            }
            else
            {
                lblVuelto.Text = $"Falta abonar: ${Math.Abs(vuelto):F2}";
                lblVuelto.BackColor = Color.LightPink;
            }
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void TxtMontoAbonado_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void TxtMontoAbonado2_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void TxtDescuento_Enter(object sender, EventArgs e)
        {
            string textoLimpio = txtDescuento.Text.Replace("%", "").Replace("$", "").Trim();
            if (textoLimpio == "0" || textoLimpio == "0,00")
            {
                txtDescuento.Text = "";
            }
            else
            {
                txtDescuento.Text = textoLimpio;
            }
        }

        private void TxtDescuento_Leave(object sender, EventArgs e)
        {
            string textoLimpio = txtDescuento.Text.Replace("%", "").Replace("$", "").Trim();

            if (string.IsNullOrWhiteSpace(textoLimpio))
            {
                txtDescuento.Text = "0%";
            }
            else if (decimal.TryParse(textoLimpio, out decimal valor))
            {
                if (valor <= 100)
                {
                    txtDescuento.Text = $"{valor:0}%";
                }
                else
                {
                    txtDescuento.Text = $"${valor:F2}";
                }
            }

            CalcularTotales();
        }

        private void TxtMontoAbonado_Enter(object sender, EventArgs e)
        {
            string textoActual = txtMontoAbonado.Text.Trim();
            if (textoActual == "0,00" || textoActual == "0")
            {
                txtMontoAbonado.Text = "";
            }
        }

        private void TxtMontoAbonado_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMontoAbonado.Text))
            {
                txtMontoAbonado.Text = "0,00";
            }
            else if (decimal.TryParse(txtMontoAbonado.Text.Trim(), out decimal valor))
            {
                txtMontoAbonado.Text = valor.ToString("F2");
            }
        }

        private void TxtMontoAbonado2_Enter(object sender, EventArgs e)
        {
            string textoActual = txtMontoAbonado2.Text.Trim();
            if (textoActual == "0,00" || textoActual == "0")
            {
                txtMontoAbonado2.Text = "";
            }
        }

        private void TxtMontoAbonado2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMontoAbonado2.Text))
            {
                txtMontoAbonado2.Text = "0,00";
            }
            else if (decimal.TryParse(txtMontoAbonado2.Text.Trim(), out decimal valor))
            {
                txtMontoAbonado2.Text = valor.ToString("F2");
            }
        }

        // Permitir números y el separador decimal (para Precios)
        private void SoloNumerosDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Teclas de control (Backspace) siempre se permiten
            if (char.IsControl(e.KeyChar)) return;

            char separadorDecimal = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            // Bloquear si no es dígito ni el separador decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != separadorDecimal)
            {
                e.Handled = true;
                return;
            }

            // Bloquear si intenta ingresar un segundo separador decimal
            if (e.KeyChar == separadorDecimal && txt.Text.Contains(separadorDecimal))
            {
                e.Handled = true;
                return;
            }

            // Limitar a máximo 2 decimales a la derecha del separador
            int posicionSeparador = txt.Text.IndexOf(separadorDecimal);
            if (posicionSeparador != -1 && txt.SelectionStart > posicionSeparador && txt.SelectionLength == 0)
            {
                // En lugar de Substring, medimos directamente los caracteres restantes desde la coma/punto
                if (txt.Text.Length - posicionSeparador - 1 >= 2)
                {
                    e.Handled = true;
                }
            }
        }

        // --- REGISTRO DE VENTA Y PROCESAMIENTO ---
        private void BtnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (_listaDetalle.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto al carrito.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = _listaDetalle.Sum(d => d.Subtotal);
            string textoDescuentoLimpio = txtDescuento.Text.Replace("%", "").Replace("$", "").Trim();
            decimal.TryParse(textoDescuentoLimpio, out decimal valorDescuento);
            var (montoDescuento, totalFinal, _) = _cnVenta.CalcularTotalesVenta(subtotal, valorDescuento);

            // Validar Pago 1
            if (!decimal.TryParse(txtMontoAbonado.Text.Replace("$", "").Trim(), out decimal abonado1) || abonado1 <= 0)
            {
                MessageBox.Show("Ingrese un monto abonado válido mayor a $0 para el primer método de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Pago> listaPagos = new List<Pago>
            {
                new Pago
                {
                    IdMetodoPago = Convert.ToInt32(cbxMetodoPago.SelectedValue),
                    Monto = abonado1
                }
            };

            // Validar Pago 2 si el checkbox está activo
            if (chbxMetodoPago.Checked)
            {
                if (!decimal.TryParse(txtMontoAbonado2.Text.Replace("$", "").Trim(), out decimal abonado2) || abonado2 <= 0)
                {
                    MessageBox.Show("Ingrese un monto abonado válido mayor a $0 para el segundo método de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                listaPagos.Add(new Pago
                {
                    IdMetodoPago = Convert.ToInt32(cbxMetodoPago2.SelectedValue),
                    Monto = abonado2
                });
            }

            int idTipoVenta = Convert.ToInt32(cbxTipoVenta.SelectedValue);

            Venta nuevaVenta = new Venta
            {
                NroFactura = txtNroFactura.Text,
                FechaHora = DateTime.Now,
                Descuento = montoDescuento,
                Total = totalFinal,
                IdTipoVenta = idTipoVenta,
                IdUsuario = _usuarioLogueado.IdUsuario,
                Detalles = _listaDetalle,
                Pagos = listaPagos // Pasa la lista con 1 o 2 pagos
            };

            this.Cursor = Cursors.WaitCursor;

            string mensaje = string.Empty;
            bool exito = _cnVenta.RegistrarVenta(nuevaVenta, out mensaje);

            this.Cursor = Cursors.Default;

            if (exito)
            {
                DialogResult respuestaImpresion = MessageBox.Show(
                    "Venta registrada con éxito.\n\n¿Desea imprimir el comprobante de pago?",
                    "Comprobante de Venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuestaImpresion == DialogResult.Yes)
                {
                    ImprimirComprobante();
                }

                foreach (var detalle in _listaDetalle)
                {
                    Producto prod = _cnProducto.ObtenerPorId(detalle.IdProducto);

                    if (prod != null && prod.StockActual <= prod.StockMinimo)
                    {
                        MessageBox.Show(
                            $"RECORDATORIO: El producto '{prod.Nombre}' alcanzó/superó su stock mínimo.\n" +
                            $"Stock actual: {prod.StockActual}\n" +
                            $"Mínimo: {prod.StockMinimo}",
                            "Alerta de Stock Mínimo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }

                LimpiarFormularioVenta();
            }
            else
            {
                MessageBox.Show(mensaje, "Error al Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- MÉTODOS DE IMPRESIÓN ---
        public void ImprimirComprobante()
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintController = new StandardPrintController();
                pd.PrintPage += new PrintPageEventHandler(ImprimirPage);
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar imprimir: {ex.Message}", "Error de Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontNormal = new Font("Courier New", 9, FontStyle.Regular);
            Font fontBold = new Font("Courier New", 9, FontStyle.Bold);
            Font fontTitulo = new Font("Courier New", 12, FontStyle.Bold);

            float y = 10;
            float posX = 10;

            g.DrawString("      PETCONTROL      ", fontTitulo, Brushes.Black, posX, y); y += 20;
            g.DrawString("------------------------------", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"N° Factura: {txtNroFactura.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}", fontNormal, Brushes.Black, posX, y); y += 15;

            // Imprimir el/los métodos de pago en el ticket
            if (chbxMetodoPago.Checked)
            {
                g.DrawString($"Pago 1: {cbxMetodoPago.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
                g.DrawString($"Pago 2: {cbxMetodoPago2.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            }
            else
            {
                g.DrawString($"Pago: {cbxMetodoPago.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            }

            g.DrawString("------------------------------", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString("Cant. Producto          Subtotal", fontBold, Brushes.Black, posX, y); y += 15;

            foreach (var detalle in _listaDetalle)
            {
                string cant = detalle.Cantidad.ToString();
                string prod = detalle.Producto?.Nombre ?? "Producto";
                string subtotal = detalle.Subtotal.ToString("C2");

                if (prod.Length > 15) prod = prod.Substring(0, 15);

                string linea = $"{cant.PadRight(4)} {prod.PadRight(15)} {subtotal.PadLeft(8)}";
                g.DrawString(linea, fontNormal, Brushes.Black, posX, y);
                y += 15;
            }

            g.DrawString("------------------------------", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"{lblSubtotal.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"{lblDescuentoFinal.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"{lblTotalFinal.Text}", fontBold, Brushes.Black, posX, y); y += 18;
            g.DrawString($"{lblMontoFinal.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"{lblVuelto.Text}", fontNormal, Brushes.Black, posX, y); y += 25;

            g.DrawString("  ¡Gracias por su compra!  ", fontBold, Brushes.Black, posX, y);
        }

        // --- LIMPIEZA Y NAVEGACIÓN ---
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
            txtMontoAbonado2.Clear();
            chbxMetodoPago.Checked = false;
            CargarInformacionInicial();
            txtNombreProducto.Focus();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}