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

            // Inicializar campos de descuento y monto abonado
            txtDescuento.Text = "0";
            txtMontoAbonado.Text = "0,00";
        }

        private void ConfigurarGrillaCarrito()
        {
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.Columns.Clear();

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Producto", HeaderText = "Producto", Width = 200 });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Codigo", HeaderText = "Código", Width = 100 });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PrecioUnitario", HeaderText = "Precio U.", Width = 100 });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cantidad", HeaderText = "Cantidad", Width = 80 });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal", HeaderText = "Subtotal", Width = 110 });

            // Columna de imagen para eliminar
            DataGridViewImageColumn btnEliminar = new DataGridViewImageColumn
            {
                HeaderText = "Acción",
                Name = "btnQuitar",
                Image = Properties.Resources.eliminar_producto, // Asegúrate de que el nombre coincida exactamente en Resources
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 60
            };

            // Evita que aparezca el ícono por defecto de la 'X' cuando la fila se inicializa
            btnEliminar.DefaultCellStyle.NullValue = null;

            dgvCarrito.Columns.Add(btnEliminar);
        }

        // --- 1. BÚSQUEDA Y SELECCIÓN DE PRODUCTO ---

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoPorNombre();
        }

        private void TxtNombreProducto_KeyDown(object sender, KeyEventArgs e)
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

            // 1. Obtener todos los productos activos que contengan el texto ingresado
            List<Producto> productosEncontrados = _cnProducto.ListarProductos(busquedaNombre)
                .Where(p => p.Estado && p.Nombre.ToLower().Contains(busquedaNombre.ToLower()))
                .ToList();

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

        // --- EVENTO PARA QUITAR FILAS DEL CARRITO ---
        private void DgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Verifica que el clic sea en una fila válida (no en el encabezado)
            // 2. Verifica que se haya hecho clic sobre la columna de la imagen "btnQuitar"
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvCarrito.Columns[e.ColumnIndex].Name == "btnQuitar")
            {
                _listaDetalle.RemoveAt(e.RowIndex);
                RefrescarCarrito();
            }
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

        // --- 4. CONFIRMAR REGISTRO ---

        private void BtnConfirmarVenta_Click(object sender, EventArgs e)
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

            // Después de confirmar la venta con éxito
            foreach (var detalle in _listaDetalle)
            {
                // Consultar el stock actualizado del producto
                Producto prod = _cnProducto.ObtenerPorId(detalle.IdProducto);

                if (prod.StockActual <= prod.StockMinimo)
                {
                    MessageBox.Show(
                        $"¡Atención! El producto '{prod.Nombre}' ha alcanzado o superado su stock mínimo.\n" +
                        $"Stock actual: {prod.StockActual} (Mínimo: {prod.StockMinimo})",
                        "Alerta de Stock Mínimo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
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
            txtNroFactura.Text = _cnVenta.ObtenerProximoNroFactura();
            txtNombreProducto.Focus();
        }

        
    }
}