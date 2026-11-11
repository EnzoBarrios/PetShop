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

        public FormHistorialVentas()
        {
            InitializeComponent();
        }

        private void FormHistorialVentas_Load(object sender, EventArgs e)
        {
            // Ajustar el rango de fechas por defecto (inicio de mes hasta final del día de hoy)
            dtpDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            dtpHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

            CargarFiltroMetodosPago();
            ConfigurarGrilla();
            CargarHistorial();
        }

        private void CargarFiltroMetodosPago()
        {
            try
            {
                List<MetodoPago> listaMetodos = _cnVenta.ListarMetodosPago();

                // Insertar opción por defecto para consultar todas las ventas
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

        private void ConfigurarGrilla()
        {
            dgvVentas.AutoGenerateColumns = false;

            if (dgvVentas.Columns.Contains("colNroTicket")) dgvVentas.Columns["colNroTicket"].DataPropertyName = "NroTicket";
            if (dgvVentas.Columns.Contains("colFecha")) dgvVentas.Columns["colFecha"].DataPropertyName = "Fecha";
            if (dgvVentas.Columns.Contains("colHora")) dgvVentas.Columns["colHora"].DataPropertyName = "Hora";
            if (dgvVentas.Columns.Contains("colMontoTotal")) dgvVentas.Columns["colMontoTotal"].DataPropertyName = "MontoTotal";
            if (dgvVentas.Columns.Contains("colEfectivo")) dgvVentas.Columns["colEfectivo"].DataPropertyName = "Efectivo";
            if (dgvVentas.Columns.Contains("colTransferencia")) dgvVentas.Columns["colTransferencia"].DataPropertyName = "Transferencia";
            if (dgvVentas.Columns.Contains("colQR")) dgvVentas.Columns["colQR"].DataPropertyName = "QR";
        }

        // Asignar este evento tanto a BtnBuscar como al botón Aplicar en el diseñador
        private void BtnAplicar_Click(object sender, EventArgs e)
        {
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

                // Tomar el ID seleccionado del ComboBox cbxMetodoPago (0 = Todos)
                int idMetodoSeleccionado = Convert.ToInt32(cbxMetodoPago.SelectedValue ?? 0);

                DataTable dt = _cnVenta.ObtenerHistorialVentas(fechaDesde, fechaHasta, idMetodoSeleccionado);
                dgvVentas.DataSource = dt;

                if (dt == null || dt.Rows.Count == 0)
                {
                    dgvVentas.DataSource = null;
                }
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}