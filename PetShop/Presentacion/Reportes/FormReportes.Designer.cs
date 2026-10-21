namespace PetShop.Presentacion
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTituloReportesStock = new System.Windows.Forms.Label();
            this.gbSeleccionReporte = new System.Windows.Forms.GroupBox();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.gbFiltroStock = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.dgvIdTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTotalRecaudado = new System.Windows.Forms.Label();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.lblProductoEstrella = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSeleccionReporte.SuspendLayout();
            this.gbFiltroStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ingresar.png");
            this.imageList1.Images.SetKeyName(1, "Cancelar.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTituloReportesStock
            // 
            this.lblTituloReportesStock.AutoSize = true;
            this.lblTituloReportesStock.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloReportesStock.ForeColor = System.Drawing.Color.Black;
            this.lblTituloReportesStock.Location = new System.Drawing.Point(531, 20);
            this.lblTituloReportesStock.Name = "lblTituloReportesStock";
            this.lblTituloReportesStock.Size = new System.Drawing.Size(219, 32);
            this.lblTituloReportesStock.TabIndex = 5;
            this.lblTituloReportesStock.Text = "Reportes de Stock";
            // 
            // gbSeleccionReporte
            // 
            this.gbSeleccionReporte.Controls.Add(this.cboTipoReporte);
            this.gbSeleccionReporte.Controls.Add(this.lblTipoReporte);
            this.gbSeleccionReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionReporte.Location = new System.Drawing.Point(40, 70);
            this.gbSeleccionReporte.Name = "gbSeleccionReporte";
            this.gbSeleccionReporte.Size = new System.Drawing.Size(300, 200);
            this.gbSeleccionReporte.TabIndex = 6;
            this.gbSeleccionReporte.TabStop = false;
            this.gbSeleccionReporte.Text = "Filtros y Reportes";
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoReporte.FormattingEnabled = true;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "Stock Bajo Minimo",
            "Stock por Categoria",
            "Stock por Especie",
            "Stock Mensual"});
            this.cboTipoReporte.Location = new System.Drawing.Point(24, 62);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(250, 25);
            this.cboTipoReporte.TabIndex = 9;
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.Location = new System.Drawing.Point(20, 40);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(109, 19);
            this.lblTipoReporte.TabIndex = 8;
            this.lblTipoReporte.Text = "Tipo de Reporte:";
            // 
            // gbFiltroStock
            // 
            this.gbFiltroStock.Controls.Add(this.dtpHasta);
            this.gbFiltroStock.Controls.Add(this.dtpDesde);
            this.gbFiltroStock.Controls.Add(this.lblHasta);
            this.gbFiltroStock.Controls.Add(this.lblDesde);
            this.gbFiltroStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroStock.Location = new System.Drawing.Point(40, 300);
            this.gbFiltroStock.Name = "gbFiltroStock";
            this.gbFiltroStock.Size = new System.Drawing.Size(300, 200);
            this.gbFiltroStock.TabIndex = 7;
            this.gbFiltroStock.TabStop = false;
            this.gbFiltroStock.Text = "Filtros de Stock";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(159, 65);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(115, 25);
            this.dtpHasta.TabIndex = 7;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(24, 65);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(115, 25);
            this.dtpDesde.TabIndex = 6;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(155, 40);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(47, 19);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(20, 40);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(50, 19);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarReporte.Location = new System.Drawing.Point(90, 532);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(200, 50);
            this.btnGenerarReporte.TabIndex = 4;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // dgvReportes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdTicket,
            this.dgvNroTicket,
            this.dgvFechaTicket,
            this.producto,
            this.categoria,
            this.especie,
            this.stockActual,
            this.stockMinimo,
            this.diferencia,
            this.estado});
            this.dgvReportes.Location = new System.Drawing.Point(380, 300);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 24;
            this.dgvReportes.Size = new System.Drawing.Size(860, 310);
            this.dgvReportes.TabIndex = 0;
            // 
            // dgvIdTicket
            // 
            this.dgvIdTicket.HeaderText = "IdTicket";
            this.dgvIdTicket.MinimumWidth = 6;
            this.dgvIdTicket.Name = "dgvIdTicket";
            this.dgvIdTicket.Visible = false;
            this.dgvIdTicket.Width = 125;
            // 
            // dgvNroTicket
            // 
            this.dgvNroTicket.HeaderText = "N° Ticket";
            this.dgvNroTicket.MinimumWidth = 6;
            this.dgvNroTicket.Name = "dgvNroTicket";
            this.dgvNroTicket.Width = 125;
            // 
            // dgvFechaTicket
            // 
            this.dgvFechaTicket.HeaderText = "Fecha";
            this.dgvFechaTicket.MinimumWidth = 6;
            this.dgvFechaTicket.Name = "dgvFechaTicket";
            this.dgvFechaTicket.Width = 125;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.Width = 125;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.Width = 125;
            // 
            // especie
            // 
            this.especie.HeaderText = "Especie";
            this.especie.MinimumWidth = 6;
            this.especie.Name = "especie";
            this.especie.Width = 125;
            // 
            // stockActual
            // 
            this.stockActual.HeaderText = "Stock Actual";
            this.stockActual.MinimumWidth = 6;
            this.stockActual.Name = "stockActual";
            this.stockActual.Width = 125;
            // 
            // stockMinimo
            // 
            this.stockMinimo.HeaderText = "Stock Minimo";
            this.stockMinimo.MinimumWidth = 6;
            this.stockMinimo.Name = "stockMinimo";
            this.stockMinimo.Width = 125;
            // 
            // diferencia
            // 
            this.diferencia.HeaderText = "Diferencia";
            this.diferencia.MinimumWidth = 6;
            this.diferencia.Name = "diferencia";
            this.diferencia.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(40, 20);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 32);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblTotalRecaudado
            // 
            this.lblTotalRecaudado.AutoSize = true;
            this.lblTotalRecaudado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalRecaudado.Location = new System.Drawing.Point(15, 5);
            this.lblTotalRecaudado.Name = "lblTotalRecaudado";
            this.lblTotalRecaudado.Size = new System.Drawing.Size(124, 20);
            this.lblTotalRecaudado.TabIndex = 11;
            this.lblTotalRecaudado.Text = "Total Recaudado:\r\n";
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCantidadVentas.Location = new System.Drawing.Point(10, 5);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(140, 20);
            this.lblCantidadVentas.TabIndex = 12;
            this.lblCantidadVentas.Text = "Cantidad de Ventas:\r\n";
            this.lblCantidadVentas.Click += new System.EventHandler(this.lblCantidadVentas_Click);
            // 
            // lblProductoEstrella
            // 
            this.lblProductoEstrella.AutoSize = true;
            this.lblProductoEstrella.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProductoEstrella.Location = new System.Drawing.Point(19, 5);
            this.lblProductoEstrella.Name = "lblProductoEstrella";
            this.lblProductoEstrella.Size = new System.Drawing.Size(124, 20);
            this.lblProductoEstrella.TabIndex = 13;
            this.lblProductoEstrella.Text = "Producto Estrella:\r\n";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(380, 70);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(660, 200);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotalRecaudado);
            this.panel1.Location = new System.Drawing.Point(1080, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 60);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(1, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "100000,00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblProductoEstrella);
            this.panel2.Location = new System.Drawing.Point(1080, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 60);
            this.panel2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(1, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Alimento de Perros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblCantidadVentas);
            this.panel3.Location = new System.Drawing.Point(1080, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 60);
            this.panel3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(1, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "153";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.gbFiltroStock);
            this.Controls.Add(this.gbSeleccionReporte);
            this.Controls.Add(this.lblTituloReportesStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesión";
            this.gbSeleccionReporte.ResumeLayout(false);
            this.gbSeleccionReporte.PerformLayout();
            this.gbFiltroStock.ResumeLayout(false);
            this.gbFiltroStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTituloReportesStock;
        private System.Windows.Forms.GroupBox gbSeleccionReporte;
        private System.Windows.Forms.GroupBox gbFiltroStock;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTotalRecaudado;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.Label lblProductoEstrella;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}