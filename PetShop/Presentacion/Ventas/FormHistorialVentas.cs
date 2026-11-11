using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PetShop.Entidades;
using PetShop.Negocio;

namespace PetShop.Presentacion
{
    public partial class FormHistorialVentas : Form
    {
        private readonly CN_Venta _cnVenta = new CN_Venta();

        // Variables para la paginación
        private DataTable _dtTotalVentas;
        private int _paginaActual = 1;
        private const int TAMANO_PAGINA = 10;
        private int _totalPaginas = 1;

        public FormHistorialVentas()
        {
            InitializeComponent();
        }

        private void FormHistorialVentas_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            dtpHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

            CargarFiltroMetodosPago();
            ConfigurarGrillas();
            CargarHistorial();
        }

        private void CargarFiltroMetodosPago()
        {
            try
            {
                List<MetodoPago> listaMetodos = _cnVenta.ListarMetodosPago();

                listaMetodos.Insert(0, new MetodoPago
                {
                    IdMetodoPago = 0,
                    NombreMetodo = "-- Todos los métodos --"
                });

                cbxMetodoPago.DataSource = listaMetodos;
                cbxMetodoPago.DisplayMember = nameof(MetodoPago.NombreMetodo);
                cbxMetodoPago.ValueMember = nameof(MetodoPago.IdMetodoPago);
                cbxMetodoPago.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el filtro de métodos de pago: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigurarGrillas()
        {
            // Mapeo grilla principal
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgvVentas.Columns.Contains("colNroTicket")) dgvVentas.Columns["colNroTicket"].DataPropertyName = "NroTicket";
            if (dgvVentas.Columns.Contains("colFecha")) dgvVentas.Columns["colFecha"].DataPropertyName = "Fecha";
            if (dgvVentas.Columns.Contains("colHora")) dgvVentas.Columns["colHora"].DataPropertyName = "Hora";
            if (dgvVentas.Columns.Contains("colDescuento")) dgvVentas.Columns["colDescuento"].DataPropertyName = "Descuento";
            if (dgvVentas.Columns.Contains("colMontoTotal")) dgvVentas.Columns["colMontoTotal"].DataPropertyName = "MontoTotal";
            if (dgvVentas.Columns.Contains("colEfectivo")) dgvVentas.Columns["colEfectivo"].DataPropertyName = "Efectivo";
            if (dgvVentas.Columns.Contains("colTransferencia")) dgvVentas.Columns["colTransferencia"].DataPropertyName = "Transferencia";
            if (dgvVentas.Columns.Contains("colQR")) dgvVentas.Columns["colQR"].DataPropertyName = "QR";

            // Mapeo grilla detalle
            dgvDetalleVenta.AutoGenerateColumns = false;

            if (dgvDetalleVenta.Columns.Contains("colDetProducto")) dgvDetalleVenta.Columns["colDetProducto"].DataPropertyName = "NombreProducto";
            if (dgvDetalleVenta.Columns.Contains("colDetCantidad")) dgvDetalleVenta.Columns["colDetCantidad"].DataPropertyName = "Cantidad";
            if (dgvDetalleVenta.Columns.Contains("colDetPrecio")) dgvDetalleVenta.Columns["colDetPrecio"].DataPropertyName = "PrecioUnitario";
            if (dgvDetalleVenta.Columns.Contains("colDetSubtotal")) dgvDetalleVenta.Columns["colDetSubtotal"].DataPropertyName = "Subtotal";
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            _paginaActual = 1;
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha de inicio ('Desde') no puede ser posterior a la fecha final ('Hasta').",
                    "Rango de Fechas Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;

                DateTime fechaDesde = dtpDesde.Value.Date;
                DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

                int idMetodoSeleccionado = Convert.ToInt32(cbxMetodoPago.SelectedValue ?? 0);

                // La consulta SQL en CD_Venta ya viene ordenada correctamente por v.fecha_hora DESC
                _dtTotalVentas = _cnVenta.ObtenerHistorialVentas(fechaDesde, fechaHasta, idMetodoSeleccionado);

                MostrarPaginaActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar el historial de ventas: {ex.Message}",
                    "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void MostrarPaginaActual()
        {
            if (_dtTotalVentas == null || _dtTotalVentas.Rows.Count == 0)
            {
                dgvVentas.DataSource = null;
                dgvDetalleVenta.DataSource = null;
                lblPaginaInfo.Text = "Página 0 de 0";
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                return;
            }

            int totalRegistros = _dtTotalVentas.Rows.Count;
            _totalPaginas = (int)Math.Ceiling((double)totalRegistros / TAMANO_PAGINA);

            if (_paginaActual > _totalPaginas) _paginaActual = _totalPaginas;
            if (_paginaActual < 1) _paginaActual = 1;

            DataTable dtPagina = _dtTotalVentas.Clone();
            int inicio = (_paginaActual - 1) * TAMANO_PAGINA;
            int fin = Math.Min(inicio + TAMANO_PAGINA, totalRegistros);

            for (int i = inicio; i < fin; i++)
            {
                dtPagina.ImportRow(_dtTotalVentas.Rows[i]);
            }

            // Desvincular temporalmente el evento para evitar disparos múltiples durante el binding
            dgvVentas.SelectionChanged -= DgvVentas_SelectionChanged;
            dgvVentas.DataSource = dtPagina;
            dgvVentas.SelectionChanged += DgvVentas_SelectionChanged;

            lblPaginaInfo.Text = $"Página {_paginaActual} de {_totalPaginas} ({totalRegistros} registros)";
            btnAnterior.Enabled = _paginaActual > 1;
            btnSiguiente.Enabled = _paginaActual < _totalPaginas;

            // Forzar el cambio de celda actual a la primera celda disponible
            if (dgvVentas.Rows.Count > 0)
            {
                dgvVentas.CurrentCell = dgvVentas.Rows[0].Cells["colNroTicket"];
                CargarDetalleVentaSeleccionada();
            }
        }

        private void DgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            CargarDetalleVentaSeleccionada();
        }

        private void CargarDetalleVentaSeleccionada()
        {
            if (dgvVentas.CurrentRow != null && dgvVentas.CurrentRow.Index >= 0)
            {
                string nroTicket = dgvVentas.CurrentRow.Cells["colNroTicket"].Value?.ToString();

                if (!string.IsNullOrEmpty(nroTicket))
                {
                    try
                    {
                        DataTable dtDetalle = _cnVenta.ObtenerDetalleVentaPorTicket(nroTicket);

                        // Forzar refresco del origen de datos
                        dgvDetalleVenta.DataSource = null;
                        dgvDetalleVenta.DataSource = dtDetalle;

                        gbDetalleVenta.Text = $"Productos Vendidos (Ticket: {nroTicket})";
                    }
                    catch (Exception ex)
                    {
                        dgvDetalleVenta.DataSource = null;
                        gbDetalleVenta.Text = "Productos Vendidos";
                        MessageBox.Show($"Error al cargar detalle: {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                dgvDetalleVenta.DataSource = null;
                gbDetalleVenta.Text = "Productos Vendidos";
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (_paginaActual > 1)
            {
                _paginaActual--;
                MostrarPaginaActual();
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (_paginaActual < _totalPaginas)
            {
                _paginaActual++;
                MostrarPaginaActual();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}