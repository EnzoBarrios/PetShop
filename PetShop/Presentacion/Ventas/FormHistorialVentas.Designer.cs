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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
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
            this.gbInformacionVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.lblMetodoPago);
            this.gbInformacionVenta.Controls.Add(this.cbxMetodoPago);
            this.gbInformacionVenta.Controls.Add(this.dtpHasta);
            this.gbInformacionVenta.Controls.Add(this.dtpDesde);
            this.gbInformacionVenta.Controls.Add(this.btnBuscar);
            this.gbInformacionVenta.Controls.Add(this.lblFechaHasta);
            this.gbInformacionVenta.Controls.Add(this.lblFechaDesde);
            this.gbInformacionVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInformacionVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVenta.Location = new System.Drawing.Point(40, 5);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Padding = new System.Windows.Forms.Padding(40, 5, 40, 5);
            this.gbInformacionVenta.Size = new System.Drawing.Size(1200, 90);
            this.gbInformacionVenta.TabIndex = 5;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "Filtros de Busqueda";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(150, 43);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(115, 19);
            this.lblMetodoPago.TabIndex = 18;
            this.lblMetodoPago.Text = "Método de pago:";
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Location = new System.Drawing.Point(277, 38);
            this.cbxMetodoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(206, 28);
            this.cbxMetodoPago.TabIndex = 17;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(748, 38);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(120, 25);
            this.dtpHasta.TabIndex = 16;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(556, 38);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(120, 25);
            this.dtpDesde.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.SlateGray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.ImageIndex = 0;
            this.btnBuscar.Location = new System.Drawing.Point(900, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 35);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Aplicar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(694, 42);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(47, 19);
            this.lblFechaHasta.TabIndex = 7;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(501, 42);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(50, 19);
            this.lblFechaDesde.TabIndex = 5;
            this.lblFechaDesde.Text = "Desde:";
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
            this.lblTituloHistorialVentas.Location = new System.Drawing.Point(526, 15);
            this.lblTituloHistorialVentas.Name = "lblTituloHistorialVentas";
            this.lblTituloHistorialVentas.Size = new System.Drawing.Size(228, 32);
            this.lblTituloHistorialVentas.TabIndex = 4;
            this.lblTituloHistorialVentas.Text = "Historial de Ventas";
            this.lblTituloHistorialVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvVentas.Location = new System.Drawing.Point(40, 5);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(1200, 415);
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
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(40, 10);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 40);
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
            this.pnlTitulo.Padding = new System.Windows.Forms.Padding(40, 5, 40, 5);
            this.pnlTitulo.Size = new System.Drawing.Size(1280, 60);
            this.pnlTitulo.TabIndex = 11;
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.dgvVentas);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 160);
            this.pnlGrilla.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Padding = new System.Windows.Forms.Padding(40, 5, 40, 40);
            this.pnlGrilla.Size = new System.Drawing.Size(1280, 460);
            this.pnlGrilla.TabIndex = 12;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.gbInformacionVenta);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 60);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Padding = new System.Windows.Forms.Padding(40, 5, 40, 5);
            this.pnlFiltro.Size = new System.Drawing.Size(1280, 100);
            this.pnlFiltro.TabIndex = 12;
            // 
            // FormHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorialVentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHistorialVentas_Load);
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlGrilla.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblTituloHistorialVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
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
    }
}