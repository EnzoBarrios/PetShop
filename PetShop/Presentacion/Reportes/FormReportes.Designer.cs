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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTotalRecaudado = new System.Windows.Forms.Panel();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.pnlProductoEstrella = new System.Windows.Forms.Panel();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.pnlCantidadVenta = new System.Windows.Forms.Panel();
            this.lblDescripcion3 = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.dgvIdTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSeleccionReporte.SuspendLayout();
            this.gbFiltroStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlTotalRecaudado.SuspendLayout();
            this.pnlProductoEstrella.SuspendLayout();
            this.pnlCantidadVenta.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
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
            this.lblTituloReportesStock.Location = new System.Drawing.Point(582, 15);
            this.lblTituloReportesStock.Name = "lblTituloReportesStock";
            this.lblTituloReportesStock.Size = new System.Drawing.Size(116, 32);
            this.lblTituloReportesStock.TabIndex = 5;
            this.lblTituloReportesStock.Text = "Reportes";
            // 
            // gbSeleccionReporte
            // 
            this.gbSeleccionReporte.Controls.Add(this.cboTipoReporte);
            this.gbSeleccionReporte.Controls.Add(this.lblTipoReporte);
            this.gbSeleccionReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionReporte.Location = new System.Drawing.Point(40, 10);
            this.gbSeleccionReporte.Name = "gbSeleccionReporte";
            this.gbSeleccionReporte.Size = new System.Drawing.Size(300, 200);
            this.gbSeleccionReporte.TabIndex = 6;
            this.gbSeleccionReporte.TabStop = false;
            this.gbSeleccionReporte.Text = "Filtros de Reportes";
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoReporte.FormattingEnabled = true;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "Stock Critico y Reposición",
            "Ventas y Metodos de Pago",
            "Productos Mas Vendidos",
            "Rendimientos por Vendedor"});
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
            this.gbFiltroStock.Location = new System.Drawing.Point(40, 250);
            this.gbFiltroStock.Name = "gbFiltroStock";
            this.gbFiltroStock.Size = new System.Drawing.Size(300, 200);
            this.gbFiltroStock.TabIndex = 7;
            this.gbFiltroStock.TabStop = false;
            this.gbFiltroStock.Text = "Filtros de Fecha";
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
            this.btnGenerarReporte.Location = new System.Drawing.Point(80, 495);
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
            this.stockMinimo});
            this.dgvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportes.Location = new System.Drawing.Point(20, 5);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 24;
            this.dgvReportes.Size = new System.Drawing.Size(860, 300);
            this.dgvReportes.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(40, 10);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 40);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitulo1.Location = new System.Drawing.Point(15, 5);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(124, 20);
            this.lblTitulo1.TabIndex = 11;
            this.lblTitulo1.Text = "Total Recaudado:\r\n";
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitulo3.Location = new System.Drawing.Point(10, 5);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(140, 20);
            this.lblTitulo3.TabIndex = 12;
            this.lblTitulo3.Text = "Cantidad de Ventas:\r\n";
            this.lblTitulo3.Click += new System.EventHandler(this.lblCantidadVentas_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitulo2.Location = new System.Drawing.Point(19, 5);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(124, 20);
            this.lblTitulo2.TabIndex = 13;
            this.lblTitulo2.Text = "Producto Estrella:\r\n";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(20, 10);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(640, 220);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // pnlTotalRecaudado
            // 
            this.pnlTotalRecaudado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlTotalRecaudado.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTotalRecaudado.Controls.Add(this.lblDescripcion1);
            this.pnlTotalRecaudado.Controls.Add(this.lblTitulo1);
            this.pnlTotalRecaudado.Location = new System.Drawing.Point(720, 10);
            this.pnlTotalRecaudado.Name = "pnlTotalRecaudado";
            this.pnlTotalRecaudado.Size = new System.Drawing.Size(160, 60);
            this.pnlTotalRecaudado.TabIndex = 15;
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion1.Location = new System.Drawing.Point(1, 30);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(158, 20);
            this.lblDescripcion1.TabIndex = 12;
            this.lblDescripcion1.Text = "100000,00";
            this.lblDescripcion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProductoEstrella
            // 
            this.pnlProductoEstrella.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlProductoEstrella.BackColor = System.Drawing.SystemColors.Control;
            this.pnlProductoEstrella.Controls.Add(this.lblDescripcion2);
            this.pnlProductoEstrella.Controls.Add(this.lblTitulo2);
            this.pnlProductoEstrella.Location = new System.Drawing.Point(720, 90);
            this.pnlProductoEstrella.Name = "pnlProductoEstrella";
            this.pnlProductoEstrella.Size = new System.Drawing.Size(160, 60);
            this.pnlProductoEstrella.TabIndex = 18;
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion2.Location = new System.Drawing.Point(1, 30);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(158, 20);
            this.lblDescripcion2.TabIndex = 14;
            this.lblDescripcion2.Text = "Alimento de Perros";
            this.lblDescripcion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCantidadVenta
            // 
            this.pnlCantidadVenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlCantidadVenta.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCantidadVenta.Controls.Add(this.lblDescripcion3);
            this.pnlCantidadVenta.Controls.Add(this.lblTitulo3);
            this.pnlCantidadVenta.Location = new System.Drawing.Point(720, 170);
            this.pnlCantidadVenta.Name = "pnlCantidadVenta";
            this.pnlCantidadVenta.Size = new System.Drawing.Size(160, 60);
            this.pnlCantidadVenta.TabIndex = 20;
            // 
            // lblDescripcion3
            // 
            this.lblDescripcion3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion3.Location = new System.Drawing.Point(1, 30);
            this.lblDescripcion3.Name = "lblDescripcion3";
            this.lblDescripcion3.Size = new System.Drawing.Size(158, 20);
            this.lblDescripcion3.TabIndex = 13;
            this.lblDescripcion3.Text = "153";
            this.lblDescripcion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTituloReportesStock);
            this.pnlTitulo.Controls.Add(this.btnVolver);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Padding = new System.Windows.Forms.Padding(40, 5, 40, 5);
            this.pnlTitulo.Size = new System.Drawing.Size(1280, 60);
            this.pnlTitulo.TabIndex = 22;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.btnGenerarReporte);
            this.pnlFiltros.Controls.Add(this.gbSeleccionReporte);
            this.pnlFiltros.Controls.Add(this.gbFiltroStock);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 60);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(40, 5, 20, 5);
            this.pnlFiltros.Size = new System.Drawing.Size(360, 560);
            this.pnlFiltros.TabIndex = 23;
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.Controls.Add(this.pnlTotalRecaudado);
            this.pnlInformacion.Controls.Add(this.pnlProductoEstrella);
            this.pnlInformacion.Controls.Add(this.pnlCantidadVenta);
            this.pnlInformacion.Controls.Add(this.chart1);
            this.pnlInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInformacion.Location = new System.Drawing.Point(360, 60);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Padding = new System.Windows.Forms.Padding(20, 5, 40, 5);
            this.pnlInformacion.Size = new System.Drawing.Size(920, 240);
            this.pnlInformacion.TabIndex = 24;
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.dgvReportes);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(360, 300);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Padding = new System.Windows.Forms.Padding(20, 5, 40, 15);
            this.pnlGrilla.Size = new System.Drawing.Size(920, 320);
            this.pnlGrilla.TabIndex = 25;
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
            this.dgvNroTicket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvNroTicket.HeaderText = "N° Ticket";
            this.dgvNroTicket.MinimumWidth = 6;
            this.dgvNroTicket.Name = "dgvNroTicket";
            // 
            // dgvFechaTicket
            // 
            this.dgvFechaTicket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFechaTicket.HeaderText = "Fecha";
            this.dgvFechaTicket.MinimumWidth = 6;
            this.dgvFechaTicket.Name = "dgvFechaTicket";
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            // 
            // categoria
            // 
            this.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.Width = 105;
            // 
            // especie
            // 
            this.especie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.especie.HeaderText = "Especie";
            this.especie.MinimumWidth = 6;
            this.especie.Name = "especie";
            // 
            // stockActual
            // 
            this.stockActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockActual.HeaderText = "Stock Actual";
            this.stockActual.MinimumWidth = 6;
            this.stockActual.Name = "stockActual";
            // 
            // stockMinimo
            // 
            this.stockMinimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockMinimo.HeaderText = "Stock Minimo";
            this.stockMinimo.MinimumWidth = 6;
            this.stockMinimo.Name = "stockMinimo";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.pnlInformacion);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlTitulo);
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
            this.pnlTotalRecaudado.ResumeLayout(false);
            this.pnlTotalRecaudado.PerformLayout();
            this.pnlProductoEstrella.ResumeLayout(false);
            this.pnlProductoEstrella.PerformLayout();
            this.pnlCantidadVenta.ResumeLayout(false);
            this.pnlCantidadVenta.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlInformacion.ResumeLayout(false);
            this.pnlGrilla.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel pnlTotalRecaudado;
        private System.Windows.Forms.Panel pnlProductoEstrella;
        private System.Windows.Forms.Panel pnlCantidadVenta;
        private System.Windows.Forms.Label lblDescripcion1;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.Label lblDescripcion3;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
    }
}