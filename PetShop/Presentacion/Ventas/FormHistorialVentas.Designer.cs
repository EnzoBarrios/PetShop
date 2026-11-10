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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
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
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.Location = new System.Drawing.Point(45, 6);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(1350, 519);
            this.dgvVentas.TabIndex = 6;
            // 
            // colIdDetalleVenta
            // 
            this.colIdDetalleVenta.HeaderText = "";
            this.colIdDetalleVenta.MinimumWidth = 6;
            this.colIdDetalleVenta.Name = "colIdDetalleVenta";
            this.colIdDetalleVenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIdDetalleVenta.Visible = false;
            // 
            // colNroTicket
            // 
            this.colNroTicket.DataPropertyName = "NroTicket";
            this.colNroTicket.HeaderText = "N° Ticket";
            this.colNroTicket.MinimumWidth = 6;
            this.colNroTicket.Name = "colNroTicket";
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "Fecha";
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            // 
            // colHora
            // 
            this.colHora.DataPropertyName = "Hora";
            this.colHora.HeaderText = "Hora";
            this.colHora.MinimumWidth = 6;
            this.colHora.Name = "colHora";
            // 
            // colMontoTotal
            // 
            this.colMontoTotal.DataPropertyName = "MontoTotal";
            this.colMontoTotal.HeaderText = "Monto Total";
            this.colMontoTotal.MinimumWidth = 6;
            this.colMontoTotal.Name = "colMontoTotal";
            // 
            // colEfectivo
            // 
            this.colEfectivo.DataPropertyName = "Efectivo";
            this.colEfectivo.HeaderText = "Abonado en Efectivo";
            this.colEfectivo.MinimumWidth = 6;
            this.colEfectivo.Name = "colEfectivo";
            // 
            // colTransferencia
            // 
            this.colTransferencia.DataPropertyName = "Transferencia";
            this.colTransferencia.HeaderText = "Abonado en Transferencia";
            this.colTransferencia.MinimumWidth = 6;
            this.colTransferencia.Name = "colTransferencia";
            // 
            // colQR
            // 
            this.colQR.DataPropertyName = "QR";
            this.colQR.HeaderText = "Abonado en QR";
            this.colQR.MinimumWidth = 6;
            this.colQR.Name = "colQR";
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(45, 12);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 50);
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
            this.pnlTitulo.Padding = new System.Windows.Forms.Padding(45, 6, 45, 6);
            this.pnlTitulo.Size = new System.Drawing.Size(1440, 75);
            this.pnlTitulo.TabIndex = 11;
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.dgvVentas);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 200);
            this.pnlGrilla.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Padding = new System.Windows.Forms.Padding(45, 6, 45, 50);
            this.pnlGrilla.Size = new System.Drawing.Size(1440, 575);
            this.pnlGrilla.TabIndex = 12;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.gbInformacionVenta);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 75);
            this.pnlFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Padding = new System.Windows.Forms.Padding(45, 6, 45, 6);
            this.pnlFiltro.Size = new System.Drawing.Size(1440, 125);
            this.pnlFiltro.TabIndex = 12;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(373, 15);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(56, 21);
            this.lblFechaDesde.TabIndex = 5;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(575, 15);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(52, 21);
            this.lblFechaHasta.TabIndex = 7;
            this.lblFechaHasta.Text = "Hasta:";
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
            this.btnBuscar.Location = new System.Drawing.Point(773, 4);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 44);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Aplicar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(435, 11);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(134, 29);
            this.dtpDesde.TabIndex = 7;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(633, 11);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(134, 29);
            this.dtpHasta.TabIndex = 16;
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxMetodoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Location = new System.Drawing.Point(136, 9);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(231, 33);
            this.cbxMetodoPago.TabIndex = 17;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(3, 15);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(127, 21);
            this.lblMetodoPago.TabIndex = 18;
            this.lblMetodoPago.Text = "Método de pago:";
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.flowLayoutPanel1);
            this.gbInformacionVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInformacionVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVenta.Location = new System.Drawing.Point(45, 6);
            this.gbInformacionVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Padding = new System.Windows.Forms.Padding(45, 6, 45, 6);
            this.gbInformacionVenta.Size = new System.Drawing.Size(1350, 113);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(187, 48);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 5, 15, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(977, 52);
            this.flowLayoutPanel1.TabIndex = 19;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // FormHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 775);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHistorialVentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHistorialVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlGrilla.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
    }
}