using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Entidades;
using PetShop.Negocio;

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

            // Doble Búfer en el DataGridView del Carrito para eliminar parpadeos y lag
            typeof(DataGridView).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgvCarrito, true, null);
        }

        private async void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            ConfigurarGrillaCarrito();
        }

        private async void FormResitrarVenta_Shown(object sender, EventArgs e)
        {
            await CargarInformacionInicialAsync();
        }

        private async Task CargarInformacionInicialAsync()
        {
            txtCodProducto.ReadOnly = true;
            txtPrecioUnitario.ReadOnly = true;
            txtStockDisponible.ReadOnly = true;
            txtNroFactura.Text = _cnVenta.ObtenerProximoNroFactura();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            txtFecha.ReadOnly = true;
            txtNroFactura.ReadOnly = true;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                txtFecha.ReadOnly = true;
                txtNroFactura.ReadOnly = true;

                // Carga en segundo plano de todos los datos de inicio sin congelar la ventana
                var nroFacturaTask = Task.Run(() => _cnVenta.ObtenerProximoNroFactura());
                var tiposVentaTask = Task.Run(() => _cnVenta.ListarTiposVenta());
                var metodosPagoTask = Task.Run(() => _cnVenta.ListarMetodosPago());

                await Task.WhenAll(nroFacturaTask, tiposVentaTask, metodosPagoTask);

                txtNroFactura.Text = await nroFacturaTask;

                // Cargar Tipos de Venta desde la BD
                cbxTipoVenta.DataSource = await tiposVentaTask;
                cbxTipoVenta.DisplayMember = nameof(TipoVenta.Descripcion);
                cbxTipoVenta.ValueMember = nameof(TipoVenta.IdTipoVenta);
                if (cbxTipoVenta.Items.Count > 0)
                {
                    cbxTipoVenta.SelectedIndex = 0;
                }

                // Cargar Métodos de Pago desde la BD
                cbxMetodoPago.DataSource = await metodosPagoTask;
                cbxMetodoPago.DisplayMember = nameof(MetodoPago.NombreMetodo);
                cbxMetodoPago.ValueMember = nameof(MetodoPago.IdMetodoPago);
                if (cbxMetodoPago.Items.Count > 0)
                {
                    cbxMetodoPago.SelectedIndex = 0;
                }

                // Inicializar campos de descuento y monto abonado
                txtDescuento.Text = "0";
                txtMontoAbonado.Text = "0,00";
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
            // Solo configuramos la grilla si no tiene columnas creadas previamente
            if (dgvCarrito.Columns.Count > 0)
            {
                return;
            }

            dgvCarrito.AutoGenerateColumns = false;

            dgvCarrito.Columns["colProducto"].DataPropertyName = "Producto";
            dgvCarrito.Columns["colCodigo"].DataPropertyName = "Codigo";
            dgvCarrito.Columns["colPrecio"].DataPropertyName = "PrecioUnitario";
            dgvCarrito.Columns["colCantidad"].DataPropertyName = "Cantidad";
            dgvCarrito.Columns["colSubtotal"].DataPropertyName = "Subtotal";

            // Estilo personalizado para el botón Quitar (colAccion)
            if (dgvCarrito.Columns["colAccion"] is DataGridViewButtonColumn colBtn)
            {
                colBtn.Text = "Quitar";
                colBtn.UseColumnTextForButtonValue = true;
                colBtn.FlatStyle = FlatStyle.Flat;
                colBtn.DefaultCellStyle.ForeColor = Color.Red;
                colBtn.DefaultCellStyle.SelectionForeColor = Color.Red;
                colBtn.DefaultCellStyle.BackColor = Color.FromArgb(253, 237, 236); // Fondo rojo clarito opcional
            }
        }

        private void DgvCarrito_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Si el puntero entra a una celda válida de la columna de acción
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvCarrito.Columns[e.ColumnIndex].Name == "colAccion")
            {
                dgvCarrito.Cursor = Cursors.Hand;
            }
        }

        private void DgvCarrito_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Vuelve al cursor normal cuando el puntero sale de la celda
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvCarrito.Columns[e.ColumnIndex].Name == "colAccion")
            {
                dgvCarrito.Cursor = Cursors.Default;
            }
        }
        
        private void DgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Verifica que el clic sea en una fila válida (no en el encabezado)
            // 2. Verifica que se haya hecho clic sobre la columna de acción (colAccion)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvCarrito.Columns[e.ColumnIndex].Name == "colAccion")
            {
                _listaDetalle.RemoveAt(e.RowIndex);
                RefrescarCarrito();
            }
        }


        // --- 1. BÚSQUEDA Y SELECCIÓN DE PRODUCTO ---
        private async void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            await BuscarProductoPorNombreAsync();
        }

        private async void TxtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await BuscarProductoPorNombreAsync();
            }
        }

        private async Task BuscarProductoPorNombreAsync()
        {
            string busquedaNombre = txtNombreProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(busquedaNombre))
            {
                MessageBox.Show("Ingrese el nombre del producto a buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            // 1. Obtener todos los productos activos que contengan el texto ingresado
            List<Producto> productosEncontrados = await Task.Run(() =>
                _cnProducto.ListarProductos(busquedaNombre)
                           .Where(p => p.Estado && p.Nombre.ToLower().Contains(busquedaNombre.ToLower()))
                           .ToList()
            );

            this.Cursor = Cursors.Default;

            if (productosEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontró ningún producto activo con ese nombre.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposProducto();
                return;
            }

            // 2. MUESTRA SIEMPRE LA GRILLA EMERGENTE (incluso si hay 1 sola coincidencia)
            using (var modal = new FormBuscarProducto(productosEncontrados))
            {
                var result = modal.ShowDialog();

                // Si el usuario seleccionó un producto haciendo doble clic en la grilla y apretó OK
                if (result == DialogResult.OK && modal.ProductoSeleccionado != null)
                {
                    CargarProductoEnInterfaz(modal.ProductoSeleccionado);
                }
            }
        }

        // Método auxiliar para autocompletar la UI
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

        // --- 2. AGREGAR PRODUCTO AL CARRITO ---
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

       
        // --- 3. CÁLCULO DE TOTALES, DESCUENTOS Y VUELTO ---
        private void CalcularTotales()
        {
            decimal subtotal = _listaDetalle.Sum(d => d.Subtotal);
            decimal montoDescuento = 0;
            string textoDescuentoMostrado = "0%";

            if (decimal.TryParse(txtDescuento.Text.Trim(), out decimal valorIngresado) && valorIngresado > 0)
            {
                // CASO 1: Si es <= 100, se aplica como PORCENTAJE (%)
                if (valorIngresado <= 100)
                {
                    montoDescuento = subtotal * (valorIngresado / 100);
                    textoDescuentoMostrado = $"{valorIngresado}% (${montoDescuento:F2})";
                }
                // CASO 2: Si es > 100, se aplica como MONTO FIJO EN PESOS ($)
                else
                {
                    // Validar que el descuento fijo no supere el subtotal de la venta
                    if (valorIngresado > subtotal)
                    {
                        montoDescuento = subtotal;
                    }
                    else
                    {
                        montoDescuento = valorIngresado;
                    }

                    textoDescuentoMostrado = $"${montoDescuento:F2}";
                }
            }

            // Calcular el Total Final restando el descuento obtenido
            decimal totalFinal = subtotal - montoDescuento;
            if (totalFinal < 0) totalFinal = 0;

            // Convertir el monto abonado desde el TextBox (si está vacío toma 0)
            decimal.TryParse(txtMontoAbonado.Text.Trim(), out decimal abonado);

            // Actualizar las etiquetas en la interfaz
            lblSubtotal.Text = $"Subtotal: ${subtotal:F2}";
            lblDescuentoFinal.Text = $"Descuento: {textoDescuentoMostrado}";
            lblMontoFinal.Text = $"Abonado: ${abonado:F2}";
            lblTotalFinal.Text = $"TOTAL FINAL: ${totalFinal:F2}";

            CalcularVuelto(totalFinal);
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void TxtMontoAbonado_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void CalcularVuelto(decimal totalFinal)
        {
            if (decimal.TryParse(txtMontoAbonado.Text.Trim(), out decimal abonado))
            {
                decimal vuelto = abonado - totalFinal;
                // CASO 1: Le sobra dinero (Vuelto a favor)
                if (vuelto > 0)
                {
                    lblVuelto.Text = $"Vuelto/Cambio: ${vuelto:F2}";
                    lblVuelto.BackColor = Color.LightGreen;
                }
                // CASO 2: Pago exacto (No hay vuelto que dar)
                else if (vuelto == 0)
                {
                    lblVuelto.Text = "Vuelto/Cambio: $0,00";
                    lblVuelto.BackColor = Color.White;
                }
                // CASO 3: Falta dinero
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

        // --- 4. CONFIRMAR REGISTRO Y GESTIÓN DE IMPRESIÓN ---

        private async void BtnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (_listaDetalle.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto al carrito.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Recalcular Total Final respetando la regla (Porcentaje o Monto Fijo)
            decimal subtotal = _listaDetalle.Sum(d => d.Subtotal);
            decimal montoDescuento = 0;

            if (decimal.TryParse(txtDescuento.Text.Trim(), out decimal valorIngresado) && valorIngresado > 0)
            {
                if (valorIngresado <= 100)
                {
                    montoDescuento = subtotal * (valorIngresado / 100);
                }
                else
                {
                    montoDescuento = valorIngresado > subtotal ? subtotal : valorIngresado;
                }
            }

            decimal totalFinal = subtotal - montoDescuento;
            if (totalFinal < 0) totalFinal = 0;

            // Validar monto abonado
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
                Descuento = montoDescuento,
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

            this.Cursor = Cursors.WaitCursor;

            // Transacción de registro procesada en segundo plano
            string mensaje = string.Empty;
            bool exito = await Task.Run(() => _cnVenta.RegistrarVenta(nuevaVenta, out mensaje));

            this.Cursor = Cursors.Default;

            if (exito)
            {
                // Preguntar si se desea imprimir el comprobante antes de limpiar la pantalla
                DialogResult respuestaImpresion = MessageBox.Show(
                    "Venta registrada con éxito.\n\n¿Desea generar e imprimir el comprobante de pago?",
                    "Comprobante de Venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuestaImpresion == DialogResult.Yes)
                {
                    ImprimirComprobante();
                }

                // Verificar stock mínimo
                foreach (var detalle in _listaDetalle)
                {
                    // Consultar el stock actualizado del producto
                    Producto prod = await Task.Run(() => _cnProducto.ObtenerPorId(detalle.IdProducto));

                    if (prod.StockActual <= prod.StockMinimo)
                    {
                        MessageBox.Show(
                            $"RECORDATORIO: El producto '{prod.Nombre}' alcanzó/superó su stock mínimo.\n" +
                            $"Stock actual: {prod.StockActual} (Mínimo: {prod.StockMinimo})",
                            "Alerta de Stock Mínimo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }

                await LimpiarFormularioVentaAsync();
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
                // pd.PrinterSettings.PrinterName = "NombreDeTuImpresoraTermica"; // Configurar si tenés una específica
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

            // Encabezado
            g.DrawString("      PETCONTROL      ", fontTitulo, Brushes.Black, posX, y); y += 20;
            g.DrawString("------------------------------", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"N° Factura: {txtNroFactura.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"Pago: {cbxMetodoPago.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString("------------------------------", fontNormal, Brushes.Black, posX, y); y += 15;

            // Detalle de Ítems
            g.DrawString("Cant. Producto          Subtotal", fontBold, Brushes.Black, posX, y); y += 15;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Producto"].Value != null)
                {
                    string cant = row.Cells["Cantidad"].Value.ToString();
                    string prod = row.Cells["Producto"].Value.ToString();
                    string subtotal = row.Cells["Subtotal"].Value.ToString();

                    // Acortar nombre si es muy largo
                    if (prod.Length > 15) prod = prod.Substring(0, 15);

                    string linea = $"{cant.PadRight(4)} {prod.PadRight(15)} {subtotal.PadLeft(8)}";
                    g.DrawString(linea, fontNormal, Brushes.Black, posX, y);
                    y += 15;
                }
            }

            // Totales
            g.DrawString("------------------------------", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"{lblSubtotal.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"{lblDescuentoFinal.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"{lblTotalFinal.Text}", fontBold, Brushes.Black, posX, y); y += 18;
            g.DrawString($"{lblMontoFinal.Text}", fontNormal, Brushes.Black, posX, y); y += 15;
            g.DrawString($"{lblVuelto.Text}", fontNormal, Brushes.Black, posX, y); y += 25;

            // Pie de página
            g.DrawString("  ¡Gracias por su compra!  ", fontBold, Brushes.Black, posX, y);
        }

        private async void BtnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar y limpiar la venta actual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await LimpiarFormularioVentaAsync();
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

        private async Task LimpiarFormularioVentaAsync()
        {
            LimpiarCamposProducto();
            _listaDetalle.Clear();
            RefrescarCarrito();
            txtDescuento.Clear();
            txtMontoAbonado.Clear();
            await CargarInformacionInicialAsync();
            txtNombreProducto.Focus();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}