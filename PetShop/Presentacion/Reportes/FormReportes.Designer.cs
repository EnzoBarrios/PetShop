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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTituloReportesStock = new System.Windows.Forms.Label();
            this.gbFiltroReporte = new System.Windows.Forms.GroupBox();
            this.cbxTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.gbFiltroFechas = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.chartReportes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTotalRecaudado = new System.Windows.Forms.Panel();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.pnlProductoEstrella = new System.Windows.Forms.Panel();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.pnlCantidadVenta = new System.Windows.Forms.Panel();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.gbFiltroReporte.SuspendLayout();
            this.gbFiltroFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReportes)).BeginInit();
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
            this.lblTituloReportesStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloReportesStock.AutoSize = true;
            this.lblTituloReportesStock.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloReportesStock.ForeColor = System.Drawing.Color.Black;
            this.lblTituloReportesStock.Location = new System.Drawing.Point(582, 15);
            this.lblTituloReportesStock.Name = "lblTituloReportesStock";
            this.lblTituloReportesStock.Size = new System.Drawing.Size(116, 32);
            this.lblTituloReportesStock.TabIndex = 5;
            this.lblTituloReportesStock.Text = "Reportes";
            this.lblTituloReportesStock.UseWaitCursor = true;
            // 
            // gbFiltroReporte
            // 
            this.gbFiltroReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltroReporte.Controls.Add(this.cbxTipoReporte);
            this.gbFiltroReporte.Controls.Add(this.lblTipoReporte);
            this.gbFiltroReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroReporte.Location = new System.Drawing.Point(40, 10);
            this.gbFiltroReporte.Name = "gbFiltroReporte";
            this.gbFiltroReporte.Size = new System.Drawing.Size(300, 200);
            this.gbFiltroReporte.TabIndex = 6;
            this.gbFiltroReporte.TabStop = false;
            this.gbFiltroReporte.Text = "Filtros de Reportes";
            // 
            // cbxTipoReporte
            // 
            this.cbxTipoReporte.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoReporte.FormattingEnabled = true;
            this.cbxTipoReporte.Items.AddRange(new object[] {
            "Stock Critico y Reposición",
            "Ventas y Metodos de Pago",
            "Productos Mas Vendidos",
            "Rendimientos por Vendedor"});
            this.cbxTipoReporte.Location = new System.Drawing.Point(24, 62);
            this.cbxTipoReporte.Name = "cbxTipoReporte";
            this.cbxTipoReporte.Size = new System.Drawing.Size(250, 25);
            this.cbxTipoReporte.TabIndex = 9;
            this.cbxTipoReporte.SelectedIndexChanged += new System.EventHandler(this.CbxTipoReporte_SelectedIndexChanged);
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
            // gbFiltroFechas
            // 
            this.gbFiltroFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltroFechas.Controls.Add(this.dtpHasta);
            this.gbFiltroFechas.Controls.Add(this.dtpDesde);
            this.gbFiltroFechas.Controls.Add(this.lblHasta);
            this.gbFiltroFechas.Controls.Add(this.lblDesde);
            this.gbFiltroFechas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroFechas.Location = new System.Drawing.Point(40, 230);
            this.gbFiltroFechas.Name = "gbFiltroFechas";
            this.gbFiltroFechas.Size = new System.Drawing.Size(300, 240);
            this.gbFiltroFechas.TabIndex = 7;
            this.gbFiltroFechas.TabStop = false;
            this.gbFiltroFechas.Text = "Filtros de Fecha";
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
            this.btnGenerarReporte.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerarReporte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarReporte.Location = new System.Drawing.Point(80, 495);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(200, 50);
            this.btnGenerarReporte.TabIndex = 4;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // dgvReportes
            // 
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6,
            this.col7});
            this.dgvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportes.Location = new System.Drawing.Point(20, 5);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 24;
            this.dgvReportes.Size = new System.Drawing.Size(860, 270);
            this.dgvReportes.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "ColId";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // col1
            // 
            this.col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1.HeaderText = "Columna 1";
            this.col1.MinimumWidth = 6;
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col2.HeaderText = "Columna 2";
            this.col2.MinimumWidth = 6;
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col3.HeaderText = "Columna 3";
            this.col3.MinimumWidth = 6;
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col4
            // 
            this.col4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col4.HeaderText = "Columna 4";
            this.col4.MinimumWidth = 6;
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            // 
            // col5
            // 
            this.col5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col5.HeaderText = "Columna 5";
            this.col5.MinimumWidth = 6;
            this.col5.Name = "col5";
            this.col5.ReadOnly = true;
            // 
            // col6
            // 
            this.col6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col6.HeaderText = "Columna 6";
            this.col6.MinimumWidth = 6;
            this.col6.Name = "col6";
            this.col6.ReadOnly = true;
            // 
            // col7
            // 
            this.col7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col7.HeaderText = "Columna 7";
            this.col7.MinimumWidth = 6;
            this.col7.Name = "col7";
            this.col7.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(40, 15);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 40);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo1.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(200, 20);
            this.lblTitulo1.TabIndex = 11;
            this.lblTitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo3.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(200, 20);
            this.lblTitulo3.TabIndex = 12;
            this.lblTitulo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartReportes
            // 
            this.chartReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartReportes.BorderlineColor = System.Drawing.Color.Silver;
            this.chartReportes.BorderlineWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.chartReportes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartReportes.Legends.Add(legend2);
            this.chartReportes.Location = new System.Drawing.Point(20, 10);
            this.chartReportes.Name = "chartReportes";
            this.chartReportes.Size = new System.Drawing.Size(640, 250);
            this.chartReportes.TabIndex = 14;
            this.chartReportes.Text = "chart1";
            title2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "titulo";
            this.chartReportes.Titles.Add(title2);
            // 
            // pnlTotalRecaudado
            // 
            this.pnlTotalRecaudado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlTotalRecaudado.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTotalRecaudado.Controls.Add(this.lblValor1);
            this.pnlTotalRecaudado.Controls.Add(this.lblTitulo1);
            this.pnlTotalRecaudado.Location = new System.Drawing.Point(680, 25);
            this.pnlTotalRecaudado.Name = "pnlTotalRecaudado";
            this.pnlTotalRecaudado.Size = new System.Drawing.Size(200, 60);
            this.pnlTotalRecaudado.TabIndex = 15;
            // 
            // lblValor1
            // 
            this.lblValor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblValor1.Location = new System.Drawing.Point(0, 20);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(200, 40);
            this.lblValor1.TabIndex = 12;
            this.lblValor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProductoEstrella
            // 
            this.pnlProductoEstrella.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlProductoEstrella.BackColor = System.Drawing.SystemColors.Control;
            this.pnlProductoEstrella.Controls.Add(this.lblValor2);
            this.pnlProductoEstrella.Controls.Add(this.lblTitulo2);
            this.pnlProductoEstrella.Location = new System.Drawing.Point(680, 105);
            this.pnlProductoEstrella.Name = "pnlProductoEstrella";
            this.pnlProductoEstrella.Size = new System.Drawing.Size(200, 60);
            this.pnlProductoEstrella.TabIndex = 18;
            // 
            // lblValor2
            // 
            this.lblValor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblValor2.Location = new System.Drawing.Point(0, 20);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(200, 40);
            this.lblValor2.TabIndex = 14;
            this.lblValor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo2.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(200, 20);
            this.lblTitulo2.TabIndex = 13;
            this.lblTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCantidadVenta
            // 
            this.pnlCantidadVenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlCantidadVenta.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCantidadVenta.Controls.Add(this.lblValor3);
            this.pnlCantidadVenta.Controls.Add(this.lblTitulo3);
            this.pnlCantidadVenta.Location = new System.Drawing.Point(680, 185);
            this.pnlCantidadVenta.Name = "pnlCantidadVenta";
            this.pnlCantidadVenta.Size = new System.Drawing.Size(200, 60);
            this.pnlCantidadVenta.TabIndex = 20;
            // 
            // lblValor3
            // 
            this.lblValor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblValor3.Location = new System.Drawing.Point(0, 20);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(200, 40);
            this.lblValor3.TabIndex = 13;
            this.lblValor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlFiltros.Controls.Add(this.gbFiltroReporte);
            this.pnlFiltros.Controls.Add(this.gbFiltroFechas);
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
            this.pnlInformacion.Controls.Add(this.chartReportes);
            this.pnlInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInformacion.Location = new System.Drawing.Point(360, 60);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Padding = new System.Windows.Forms.Padding(20, 5, 40, 5);
            this.pnlInformacion.Size = new System.Drawing.Size(920, 270);
            this.pnlInformacion.TabIndex = 24;
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.dgvReportes);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(360, 330);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Padding = new System.Windows.Forms.Padding(20, 5, 40, 15);
            this.pnlGrilla.Size = new System.Drawing.Size(920, 290);
            this.pnlGrilla.TabIndex = 25;
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
            this.Shown += new System.EventHandler(this.FormReportes_Shown);
            this.gbFiltroReporte.ResumeLayout(false);
            this.gbFiltroReporte.PerformLayout();
            this.gbFiltroFechas.ResumeLayout(false);
            this.gbFiltroFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReportes)).EndInit();
            this.pnlTotalRecaudado.ResumeLayout(false);
            this.pnlProductoEstrella.ResumeLayout(false);
            this.pnlCantidadVenta.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbFiltroReporte;
        private System.Windows.Forms.GroupBox gbFiltroFechas;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.ComboBox cbxTipoReporte;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReportes;
        private System.Windows.Forms.Panel pnlTotalRecaudado;
        private System.Windows.Forms.Panel pnlProductoEstrella;
        private System.Windows.Forms.Panel pnlCantidadVenta;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col7;
    }
}