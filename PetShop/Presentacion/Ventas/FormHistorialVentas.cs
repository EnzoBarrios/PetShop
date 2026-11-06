using System;
using System.Data;
using System.Windows.Forms;
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
            // Ajustar el rango de fechas por defecto (desde las 00:00:00 del primer día del mes hasta las 23:59:59 de hoy)
            dtpDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            dtpHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

            ConfigurarGrilla();
            CargarHistorial();
        }

        private void ConfigurarGrilla()
        {
            // Evitar duplicación automática de columnas
            dgvVentas.AutoGenerateColumns = false;

            dgvVentas.Columns["colNroTicket"].DataPropertyName = "NroTicket";
            dgvVentas.Columns["colFecha"].DataPropertyName = "Fecha";
            dgvVentas.Columns["colHora"].DataPropertyName = "Hora";
            dgvVentas.Columns["colMontoTotal"].DataPropertyName = "MontoTotal";
            dgvVentas.Columns["colEfectivo"].DataPropertyName = "Efectivo";
            dgvVentas.Columns["colTransferencia"].DataPropertyName = "Transferencia";
            dgvVentas.Columns["colQR"].DataPropertyName = "QR";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            // Validar que la fecha 'Desde' no sea mayor a la fecha 'Hasta'
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha de inicio ('Desde') no puede ser posterior a la fecha final ('Hasta').",
                    "Rango de Fechas Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;

                // Ajustar 'dtpHasta' al final del día seleccionado (23:59:59)
                DateTime fechaDesde = dtpDesde.Value.Date;
                DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

                DataTable dt = _cnVenta.ObtenerHistorialVentas(fechaDesde, fechaHasta);
                dgvVentas.DataSource = dt;

                // Mensaje informativo si no hay registros en la fecha elegida
                if (dt == null || dt.Rows.Count == 0)
                {
                    // Limpia la grilla si no hay resultados
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