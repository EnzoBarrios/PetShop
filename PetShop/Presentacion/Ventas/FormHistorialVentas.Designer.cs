namespace PetShop.Presentacion
{
    partial class FormHistorialVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblTituloHistorialVentas = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.colIdDetalleVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEfectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.gbDetalleVenta = new System.Windows.Forms.GroupBox();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.colDetProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPaginacion = new System.Windows.Forms.Panel();
            this.pnlContenedorBotones = new System.Windows.Forms.Panel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblPaginaInfo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
            this.gbDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.pnlPaginacion.SuspendLayout();
            this.pnlContenedorBotones.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.gbInformacionVenta.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Buscar.png");
            // 
            // lblTituloHistorialVentas
            // 
            this.lblTituloHistorialVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloHistorialVentas.AutoSize = true;
            this.lblTituloHistorialVentas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloHistorialVentas.ForeColor = System.Drawing.Color.Black;
            this.lblTituloHistorialVentas.Location = new System.Drawing.Point(592, 19);
            this.lblTituloHistorialVentas.Name = "lblTituloHistorialVentas";
            this.lblTituloHistorialVentas.Size = new System.Drawing.Size(263, 38);
            this.lblTituloHistorialVentas.TabIndex = 4;
            this.lblTituloHistorialVentas.Text = "Historial de Ventas";
            this.lblTituloHistorialVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdDetalleVenta,
            this.colNroTicket,
            this.colFecha,
            this.colHora,
            this.colMontoTotal,
            this.colEfectivo,
            this.colTransferencia,
            this.colQR});
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVentas.Location = new System.Drawing.Point(51, 8);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(1338, 262);
            this.dgvVentas.TabIndex = 6;
            this.dgvVentas.SelectionChanged += new System.EventHandler(this.DgvVentas_SelectionChanged);
            // 
            // colIdDetalleVenta
            // 
            this.colIdDetalleVenta.DataPropertyName = "IdVenta";
            this.colIdDetalleVenta.HeaderText = "ID";
            this.colIdDetalleVenta.MinimumWidth = 6;
            this.colIdDetalleVenta.Name = "colIdDetalleVenta";
            this.colIdDetalleVenta.ReadOnly = true;
            this.colIdDetalleVenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIdDetalleVenta.Visible = false;
            // 
            // colNroTicket
            // 
            this.colNroTicket.DataPropertyName = "NroTicket";
            this.colNroTicket.HeaderText = "N° Ticket";
            this.colNroTicket.MinimumWidth = 120;
            this.colNroTicket.Name = "colNroTicket";
            this.colNroTicket.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "Fecha";
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 120;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colHora
            // 
            this.colHora.DataPropertyName = "Hora";
            this.colHora.HeaderText = "Hora";
            this.colHora.MinimumWidth = 120;
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            // 
            // colMontoTotal
            // 
            this.colMontoTotal.DataPropertyName = "MontoTotal";
            this.colMontoTotal.HeaderText = "Monto Total";
            this.colMontoTotal.MinimumWidth = 150;
            this.colMontoTotal.Name = "colMontoTotal";
            this.colMontoTotal.ReadOnly = true;
            // 
            // colEfectivo
            // 
            this.colEfectivo.DataPropertyName = "Efectivo";
            this.colEfectivo.HeaderText = "Abonado en Efectivo";
            this.colEfectivo.MinimumWidth = 150;
            this.colEfectivo.Name = "colEfectivo";
            this.colEfectivo.ReadOnly = true;
            // 
            // colTransferencia
            // 
            this.colTransferencia.DataPropertyName = "Transferencia";
            this.colTransferencia.HeaderText = "Abonado en Transferencia";
            this.colTransferencia.MinimumWidth = 150;
            this.colTransferencia.Name = "colTransferencia";
            this.colTransferencia.ReadOnly = true;
            // 
            // colQR
            // 
            this.colQR.DataPropertyName = "QR";
            this.colQR.HeaderText = "Abonado en QR";
            this.colQR.MinimumWidth = 150;
            this.colQR.Name = "colQR";
            this.colQR.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(51, 15);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 62);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTituloHistorialVentas);
            this.pnlTitulo.Controls.Add(this.btnVolver);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Padding = new System.Windows.Forms.Padding(51, 8, 51, 8);
            this.pnlTitulo.Size = new System.Drawing.Size(1440, 94);
            this.pnlTitulo.TabIndex = 11;
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.gbDetalleVenta);
            this.pnlGrilla.Controls.Add(this.pnlPaginacion);
            this.pnlGrilla.Controls.Add(this.dgvVentas);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 250);
            this.pnlGrilla.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Padding = new System.Windows.Forms.Padding(51, 8, 51, 12);
            this.pnlGrilla.Size = new System.Drawing.Size(1440, 525);
            this.pnlGrilla.TabIndex = 12;
            // 
            // gbDetalleVenta
            // 
            this.gbDetalleVenta.Controls.Add(this.dgvDetalleVenta);
            this.gbDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetalleVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbDetalleVenta.Location = new System.Drawing.Point(51, 320);
            this.gbDetalleVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalleVenta.Name = "gbDetalleVenta";
            this.gbDetalleVenta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalleVenta.Size = new System.Drawing.Size(1338, 193);
            this.gbDetalleVenta.TabIndex = 8;
            this.gbDetalleVenta.TabStop = false;
            this.gbDetalleVenta.Text = "Productos Vendidos";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetProducto,
            this.colDetCantidad,
            this.colDetPrecio,
            this.colDetSubtotal});
            this.dgvDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(3, 28);
            this.dgvDetalleVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersWidth = 51;
            this.dgvDetalleVenta.RowTemplate.Height = 24;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(1332, 161);
            this.dgvDetalleVenta.TabIndex = 0;
            // 
            // colDetProducto
            // 
            this.colDetProducto.DataPropertyName = "NombreProducto";
            this.colDetProducto.HeaderText = "Producto";
            this.colDetProducto.MinimumWidth = 200;
            this.colDetProducto.Name = "colDetProducto";
            this.colDetProducto.ReadOnly = true;
            // 
            // colDetCantidad
            // 
            this.colDetCantidad.DataPropertyName = "Cantidad";
            this.colDetCantidad.HeaderText = "Cantidad";
            this.colDetCantidad.MinimumWidth = 100;
            this.colDetCantidad.Name = "colDetCantidad";
            this.colDetCantidad.ReadOnly = true;
            // 
            // colDetPrecio
            // 
            this.colDetPrecio.DataPropertyName = "PrecioUnitario";
            this.colDetPrecio.HeaderText = "Precio Unitario";
            this.colDetPrecio.MinimumWidth = 120;
            this.colDetPrecio.Name = "colDetPrecio";
            this.colDetPrecio.ReadOnly = true;
            // 
            // colDetSubtotal
            // 
            this.colDetSubtotal.DataPropertyName = "Subtotal";
            this.colDetSubtotal.HeaderText = "Subtotal";
            this.colDetSubtotal.MinimumWidth = 120;
            this.colDetSubtotal.Name = "colDetSubtotal";
            this.colDetSubtotal.ReadOnly = true;
            // 
            // pnlPaginacion
            // 
            this.pnlPaginacion.Controls.Add(this.pnlContenedorBotones);
            this.pnlPaginacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPaginacion.Location = new System.Drawing.Point(51, 270);
            this.pnlPaginacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPaginacion.Name = "pnlPaginacion";
            this.pnlPaginacion.Size = new System.Drawing.Size(1338, 50);
            this.pnlPaginacion.TabIndex = 7;
            // 
            // pnlContenedorBotones
            // 
            this.pnlContenedorBotones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContenedorBotones.Controls.Add(this.btnAnterior);
            this.pnlContenedorBotones.Controls.Add(this.lblPaginaInfo);
            this.pnlContenedorBotones.Controls.Add(this.btnSiguiente);
            this.pnlContenedorBotones.Location = new System.Drawing.Point(472, 2);
            this.pnlContenedorBotones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlContenedorBotones.Name = "pnlContenedorBotones";
            this.pnlContenedorBotones.Size = new System.Drawing.Size(394, 45);
            this.pnlContenedorBotones.TabIndex = 0;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.SlateGray;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(6, 4);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(107, 38);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // lblPaginaInfo
            // 
            this.lblPaginaInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaInfo.Location = new System.Drawing.Point(118, 4);
            this.lblPaginaInfo.Name = "lblPaginaInfo";
            this.lblPaginaInfo.Size = new System.Drawing.Size(158, 38);
            this.lblPaginaInfo.TabIndex = 1;
            this.lblPaginaInfo.Text = "Página 1 de 1";
            this.lblPaginaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.SlateGray;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(281, 4);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(107, 38);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.gbInformacionVenta);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 94);
            this.pnlFiltro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Padding = new System.Windows.Forms.Padding(51, 8, 51, 8);
            this.pnlFiltro.Size = new System.Drawing.Size(1440, 156);
            this.pnlFiltro.TabIndex = 12;
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.flowLayoutPanel1);
            this.gbInformacionVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInformacionVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVenta.Location = new System.Drawing.Point(51, 8);
            this.gbInformacionVenta.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Padding = new System.Windows.Forms.Padding(51, 8, 51, 8);
            this.gbInformacionVenta.Size = new System.Drawing.Size(1338, 140);
            this.gbInformacionVenta.TabIndex = 5;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "Filtros de Busqueda";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblMetodoPago);
            this.flowLayoutPanel1.Controls.Add(this.cbxMetodoPago);
            this.flowLayoutPanel1.Controls.Add(this.lblFechaDesde);
            this.flowLayoutPanel1.Controls.Add(this.dtpDesde);
            this.flowLayoutPanel1.Controls.Add(this.lblFechaHasta);
            this.flowLayoutPanel1.Controls.Add(this.dtpHasta);
            this.flowLayoutPanel1.Controls.Add(this.btnBuscar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(120, 60);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 6, 17, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1099, 65);
            this.flowLayoutPanel1.TabIndex = 19;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(3, 22);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(127, 21);
            this.lblMetodoPago.TabIndex = 18;
            this.lblMetodoPago.Text = "Método de pago:";
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxMetodoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Location = new System.Drawing.Point(136, 16);
            this.cbxMetodoPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(259, 33);
            this.cbxMetodoPago.TabIndex = 17;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(401, 22);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(56, 21);
            this.lblFechaDesde.TabIndex = 5;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(463, 18);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(150, 29);
            this.dtpDesde.TabIndex = 7;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(619, 22);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(52, 21);
            this.lblFechaHasta.TabIndex = 7;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(677, 18);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(150, 29);
            this.dtpHasta.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.SlateGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.ImageIndex = 0;
            this.btnBuscar.Location = new System.Drawing.Point(833, 5);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 55);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Aplicar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // FormHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1440, 775);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHistorialVentas";
            this.Text = "FormHistorialVentas";
            this.Load += new System.EventHandler(this.FormHistorialVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlGrilla.ResumeLayout(false);
            this.gbDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.pnlPaginacion.ResumeLayout(false);
            this.pnlContenedorBotones.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTituloHistorialVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEfectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQR;
        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Panel pnlPaginacion;
        private System.Windows.Forms.Panel pnlContenedorBotones;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblPaginaInfo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox gbDetalleVenta;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetSubtotal;
    }
}