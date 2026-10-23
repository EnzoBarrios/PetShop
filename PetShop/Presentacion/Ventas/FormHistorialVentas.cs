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
            // Opcional: Ajustar fechas iniciales (ejemplo: inicio de mes actual hasta hoy)
            dtpDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpHasta.Value = DateTime.Now;

            CargarHistorial();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            try
            {
                dgvVentas.AutoGenerateColumns = false;

                // Mapear los DataPropertyName según los alias creados en el SQL
                dgvVentas.Columns[0].DataPropertyName = "NroTicket"; // o por el índice dgvVentas.Columns[0].DataPropertyName = "NroTicket";
                dgvVentas.Columns[1].DataPropertyName = "Fecha";
                dgvVentas.Columns[2].DataPropertyName = "Hora";
                dgvVentas.Columns[3].DataPropertyName = "MontoTotal";
                dgvVentas.Columns[4].DataPropertyName = "Efectivo";
                dgvVentas.Columns[5].DataPropertyName = "Transferencia";
                dgvVentas.Columns[6].DataPropertyName = "QR";

                DataTable dt = _cnVenta.ObtenerHistorialVentas(dtpDesde.Value, dtpHasta.Value);
                dgvVentas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}