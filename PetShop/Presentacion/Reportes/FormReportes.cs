using PetShop.Datos;
using PetShop.Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PetShop.Presentacion
{
    public partial class FormReportes : Form
    {
        private readonly CN_Reporte _cnReporte = new CN_Reporte();
        private const string REPORTE_STOCK = "Stock Crítico y Reposición";
        private const string REPORTE_VENTAS = "Ventas por Vendedor";
        private const string REPORTE_TOP_PRODUCTOS = "Productos Más Vendidos";
        private string _ultimoTipoReporteGenerado = string.Empty;
        private DateTime _ultimaFechaDesde;
        private DateTime _ultimaFechaHasta;

        public FormReportes()
        {
            this.SuspendLayout();
            InitializeComponent();

            typeof(DataGridView).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgvReportes, true, null);

            this.ResumeLayout(true);
        }

        private async void FormReportes_Shown(object sender, EventArgs e)
        {
            CargarCombosFiltro();
            InicializarComboTipoReporte();
        }

        private void CargarCombosFiltro()
        {
            dtpDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpHasta.Value = DateTime.Now;
        }

        private void InicializarComboTipoReporte()
        {
            cbxTipoReporte.Items.Clear();
            cbxTipoReporte.Items.Add(REPORTE_STOCK);
            cbxTipoReporte.Items.Add(REPORTE_VENTAS);
            cbxTipoReporte.Items.Add(REPORTE_TOP_PRODUCTOS);

            cbxTipoReporte.SelectedIndex = 0;
        }

        private void CbxTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxTipoReporte.SelectedItem?.ToString();

            // Limpiamos la grilla previa
            dgvReportes.DataSource = null;

            // Limpiamos las series y puntos del gráfico anterior
            chartReportes.Series.Clear();

            // Limpiamos las etiquetas personalizadas del eje X y reiniciamos los intervalos de los ejes
            if (chartReportes.ChartAreas.Count > 0)
            {
                chartReportes.ChartAreas[0].AxisX.CustomLabels.Clear();
                chartReportes.ChartAreas[0].AxisX.Interval = double.NaN;
                chartReportes.ChartAreas[0].AxisY.Interval = double.NaN;
                chartReportes.ChartAreas[0].RecalculateAxesScale();
            }

            switch (opcion)
            {
                case REPORTE_STOCK:
                    ConfigurarModoStock();
                    break;
                case REPORTE_VENTAS:
                    ConfigurarModoVentas();
                    break;
                case REPORTE_TOP_PRODUCTOS:
                    ConfigurarModoTopProductos();
                    break;
            }
        }

        private void ConfigurarModoStock()
        {
            // 1. Visibilidad y habilitación de filtros
            gbFiltroReporte.Enabled = true; // Habilitamos el grupo de filtros para stock crítico
            gbFiltroFechas.Enabled = false; // Deshabilitamos el grupo de filtros para fechas, ya que no aplica para stock crítico

            // 2. Títulos de KPIs (Tarjetas)
            lblTitulo1.Text = "Stock Crítico";            
            lblValor1.Text = "0";

            lblTitulo2.Text = "Productos Agotados";
            lblValor2.Text = "0";

            lblTitulo3.Text = "Total Registros";
            lblValor3.Text = "0";
        }

        private void ConfigurarModoVentas()
        {
            // 1. Visibilidad y habilitación de filtros
            gbFiltroReporte.Enabled = true;  // Desde y Hasta
            gbFiltroFechas.Enabled = true;  // No aplica para el reporte general de ventas

            // 2. Títulos de KPIs (Tarjetas)
            lblTitulo1.Text = "Total Recaudado ($)";
            lblValor1.Text = "$ 0,00";

            lblTitulo2.Text = "Cantidad de Ventas";
            lblValor2.Text = "0";

            lblTitulo3.Text = "Promedio por Ticket";
            lblValor3.Text = "$ 0,00";
        }

        private void ConfigurarModoTopProductos()
        {
            // 1. Visibilidad y habilitación de filtros
            gbFiltroReporte.Enabled = true;  // Desde y Hasta
            gbFiltroFechas.Enabled = true;  // No aplica para el reporte general de ventas

            // 2. Títulos de KPIs (Tarjetas)
            lblTitulo1.Text = "Producto Líder";
            lblValor1.Text = "-";

            lblTitulo2.Text = "Unidades del Líder";
            lblValor2.Text = "0";

            lblTitulo3.Text = "Total Recaudado Top 10";
            lblValor3.Text = "$ 0,00";
        }

        private void CargarGraficoStock(DataTable dt)
        {
            chartReportes.Series.Clear();

            if (dt == null || dt.Rows.Count == 0) return;

            var area = chartReportes.ChartAreas[0];
            area.AxisX.Interval = 1;
            area.AxisX.IsReversed = true;

            // 1. Crear nueva serie
            Series serie = new Series("Stock Actual")
            {
                ChartType = SeriesChartType.Bar // Gráfico de barras
            };

            // 2. Cargar los 10 productos con menor stock
            var top10Criticos = dt.AsEnumerable()
                    .OrderBy(r => Convert.ToInt32(r["Stock Actual"]))
                    .Take(10);
            int limite = Math.Min(top10Criticos.Count(), 10);

            foreach (var row in top10Criticos)
            {
                string producto = row["Producto"].ToString();
                int stock = Convert.ToInt32(row["Stock Actual"]);

                // Agregar punto: (X = Nombre Producto, Y = Cantidad Stock)
                serie.Points.AddXY(producto, stock);
            }

            // 3. Personalización del gráfico
            lblTituloReportesStock.Text = "Top 10 Productos con Menor Stock";
            chartReportes.Series.Add(serie);

            area.RecalculateAxesScale();
        }

        private void CargarGraficoVentas(DataTable dt)
        {
            chartReportes.Series.Clear();

            if (dt == null || dt.Rows.Count == 0) return;

            var area = chartReportes.ChartAreas[0];
            area.AxisX.Minimum = double.NaN;
            area.AxisX.Maximum = double.NaN;
            area.AxisX.Interval = double.NaN;
            area.AxisX.LabelStyle.Format = "$#,##0";

            Series serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.Bar // Gráfico de barras
            };

            // Agrupar ventas por vendedor o por fecha
            var ventasPorVendedor = dt.AsEnumerable()
                .GroupBy(r => r.Field<string>("Vendedor"))
                .Select(g => new {
                    Vendedor = g.Key,
                    Total = g.Sum(r => Convert.ToDecimal(r["Total"]))
                });

            foreach (var item in ventasPorVendedor)
            {
                serie.Points.AddXY(item.Vendedor, item.Total);
            }

            lblTituloReportesStock.Text = "Distribución de Ventas por Vendedor";
            chartReportes.Series.Add(serie);
            area.RecalculateAxesScale();
        }

        private void CargarGraficoTopProductos(DataTable dt)
        {
            chartReportes.Series.Clear();

            if (dt == null || dt.Rows.Count == 0) return;

            var area = chartReportes.ChartAreas[0];
            area.AxisX.Interval = 1;
            area.AxisX.IsReversed = true;

            // Gráfico de Barras Horizontales para leer cómodamente los nombres largos de productos
            Series serie = new Series("Unidades")
            {
                ChartType = SeriesChartType.Bar
            };

            foreach (DataRow row in dt.Rows)
            {
                string producto = row["Producto"].ToString();
                int unidades = Convert.ToInt32(row["Unidades Vendidas"]);
                serie.Points.AddXY(producto, unidades);
            }

            lblTituloReportesStock.Text = "Top Productos Más Vendidos (Unidades)";
            chartReportes.Series.Add(serie);

            area.RecalculateAxesScale();
        }

        private void ConfigurarGrilla(DataTable dt)
        {
            dgvReportes.DataSource = dt;

            for (int i = 0; i < dgvReportes.Columns.Count; i++)
            {
                if (i < dt.Columns.Count)
                {
                    dgvReportes.Columns[i].HeaderText = dt.Columns[i].ColumnName;
                    dgvReportes.Columns[i].DataPropertyName = dt.Columns[i].ColumnName;

                    if (dt.Columns[i].ColumnName.ToLower().Contains("id"))
                    {
                        dgvReportes.Columns[i].Visible = false; // Ocultamos la primera columna (ID) para que no se muestre al usuario
                    }
                    else
                    {
                        dgvReportes.Columns[i].Visible = true;
                    }
                }
                else
                {
                    dgvReportes.Columns[i].Visible = false;
                }
            }
        }

        private async void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (cbxTipoReporte.SelectedItem == null) return;

            string opcionActual = cbxTipoReporte.SelectedItem.ToString();
            DateTime desdeActual = dtpDesde.Value.Date;
            DateTime hastaActual = dtpHasta.Value.Date;

            switch (opcionActual)
            {
                case REPORTE_STOCK:
                    break; // No requiere validación de fechas
                case REPORTE_VENTAS:
                    if (!ValidarFechas(desdeActual, hastaActual)) return;
                    break;
                case REPORTE_TOP_PRODUCTOS:
                    if (!ValidarFechas(desdeActual, hastaActual)) return;
                    break;
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                dgvReportes.SuspendLayout();

                switch (opcionActual)
                {
                    case REPORTE_STOCK:
                        DataTable dtStock = await Task.Run(() => _cnReporte.ObtenerStockCritico());
                        CalcularStock(dtStock);
                        CargarGraficoStock(dtStock);
                        ConfigurarGrilla(dtStock);
                        _ultimoTipoReporteGenerado = REPORTE_STOCK;
                        break;
                    case REPORTE_VENTAS:
                        DateTime desdeVentas = dtpDesde.Value.Date;
                        DateTime hastaVentas = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);
                        DataTable dtVentas = await Task.Run(() => _cnReporte.ObtenerVentasPorVendedor(desdeVentas, hastaVentas));
                        CalcularVentas(dtVentas);
                        CargarGraficoVentas(dtVentas);
                        ConfigurarGrilla(dtVentas);
                        _ultimoTipoReporteGenerado = REPORTE_VENTAS;
                        _ultimaFechaDesde = desdeVentas;
                        _ultimaFechaHasta = hastaVentas;
                        break;
                    case REPORTE_TOP_PRODUCTOS:
                        DateTime desdeTop = dtpDesde.Value.Date;
                        DateTime hastaTop = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);
                        DataTable dtTopProductos = await Task.Run(() => _cnReporte.ObtenerProductosVendidos(desdeTop, hastaTop));
                        CalcularTopProductos(dtTopProductos);
                        CargarGraficoTopProductos(dtTopProductos);
                        ConfigurarGrilla(dtTopProductos);
                        _ultimoTipoReporteGenerado = REPORTE_TOP_PRODUCTOS;
                        _ultimaFechaDesde = desdeTop;
                        _ultimaFechaHasta = hastaTop;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}",
                                "Error de Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvReportes.ResumeLayout(true);
                this.Cursor = Cursors.Default;
            }
        }

        private void CalcularStock(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                lblValor1.Text = "0";
                lblValor2.Text = "0";
                lblValor3.Text = "0";
                return;
            }

            int totalCriticos = dt.Rows.Count;
            int agotados = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row[dt.Columns["Stock Actual"]]) == 0)
                {
                    agotados++;
                }
            }

            lblValor3.Text = totalCriticos.ToString();
            lblValor2.Text = agotados.ToString();
            lblValor1.Text = dt.Rows.Count.ToString();
        }

        private void CalcularVentas(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                lblValor1.Text = "$ 0,00";
                lblValor2.Text = "0";
                lblValor3.Text = "$ 0,00";
                return;
            }

            decimal totalRecaudado = dt.AsEnumerable().Sum(r => Convert.ToDecimal(r["Total"]));
            int totalVentas = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["Cantidad Ventas"]));
            decimal promedioTicket = totalVentas > 0 ? (totalRecaudado / totalVentas) : 0;

            lblValor1.Text = totalRecaudado.ToString("C2");
            lblValor2.Text = totalVentas.ToString();
            lblValor3.Text = promedioTicket.ToString("C2");
        }

        private void CalcularTopProductos(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                lblValor1.Text = "-";
                lblValor2.Text = "0";
                lblValor3.Text = "$ 0,00";
                return;
            }

            // La primera fila corresponde al producto #1 (ordenado en SQL)
            DataRow productoLider = dt.Rows[0];
            string nombreLider = productoLider["Producto"].ToString();
            int unidadesLider = Convert.ToInt32(productoLider["Unidades Vendidas"]);

            decimal totalTop10 = 0;
            foreach (DataRow row in dt.Rows)
            {
                totalTop10 += Convert.ToDecimal(row["Total Generado"]);
            }

            lblValor1.Text = nombreLider;
            lblValor2.Text = unidadesLider.ToString();
            lblValor3.Text = totalTop10.ToString("C2");
        }

        private bool ValidarFechas(DateTime desde, DateTime hasta)
        {
            if (desde.Year < 2026)
            {
                MessageBox.Show("La fecha de inicio no puede ser menor que el año 2026.",
                                "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (desde > hasta)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.",
                                "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (hasta > DateTime.Now)
            {
                MessageBox.Show("La fecha de fin no puede ser mayor que la fecha actual.",
                                "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}