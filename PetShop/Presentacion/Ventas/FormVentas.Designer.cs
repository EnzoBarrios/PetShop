namespace PetShop.Presentacion
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloVenta = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.gbInformacionPago = new System.Windows.Forms.GroupBox();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.lblPagaCon = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.chkQR = new System.Windows.Forms.CheckBox();
            this.chkEfectivo = new System.Windows.Forms.CheckBox();
            this.chkTransferencia = new System.Windows.Forms.CheckBox();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInformacionProducto = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.ListBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregrarProducto = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.gbInformacionPago.SuspendLayout();
            this.gbInformacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloVenta
            // 
            this.lblTituloVenta.AutoSize = true;
            this.lblTituloVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVenta.Location = new System.Drawing.Point(20, 20);
            this.lblTituloVenta.Name = "lblTituloVenta";
            this.lblTituloVenta.Size = new System.Drawing.Size(158, 28);
            this.lblTituloVenta.TabIndex = 0;
            this.lblTituloVenta.Text = "Registrar Venta";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(5, 65);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(122, 19);
            this.lblMetodoPago.TabIndex = 1;
            this.lblMetodoPago.Text = "Método de Pago";
            // 
            // gbInformacionPago
            // 
            this.gbInformacionPago.Controls.Add(this.txtPagaCon);
            this.gbInformacionPago.Controls.Add(this.lblPagaCon);
            this.gbInformacionPago.Controls.Add(this.txtCambio);
            this.gbInformacionPago.Controls.Add(this.lblCambio);
            this.gbInformacionPago.Controls.Add(this.chkQR);
            this.gbInformacionPago.Controls.Add(this.chkEfectivo);
            this.gbInformacionPago.Controls.Add(this.chkTransferencia);
            this.gbInformacionPago.Controls.Add(this.txtTotalPago);
            this.gbInformacionPago.Controls.Add(this.textBox1);
            this.gbInformacionPago.Controls.Add(this.textBox2);
            this.gbInformacionPago.Controls.Add(this.textBox3);
            this.gbInformacionPago.Controls.Add(this.lblTotalPagar);
            this.gbInformacionPago.Controls.Add(this.label1);
            this.gbInformacionPago.Controls.Add(this.lblMetodoPago);
            this.gbInformacionPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionPago.Location = new System.Drawing.Point(980, 190);
            this.gbInformacionPago.Name = "gbInformacionPago";
            this.gbInformacionPago.Size = new System.Drawing.Size(260, 290);
            this.gbInformacionPago.TabIndex = 2;
            this.gbInformacionPago.TabStop = false;
            this.gbInformacionPago.Text = "Información del Pago";
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaCon.Location = new System.Drawing.Point(150, 215);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(100, 25);
            this.txtPagaCon.TabIndex = 16;
            // 
            // lblPagaCon
            // 
            this.lblPagaCon.AutoSize = true;
            this.lblPagaCon.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaCon.Location = new System.Drawing.Point(5, 215);
            this.lblPagaCon.Name = "lblPagaCon";
            this.lblPagaCon.Size = new System.Drawing.Size(65, 19);
            this.lblPagaCon.TabIndex = 15;
            this.lblPagaCon.Text = "Paga con";
            // 
            // txtCambio
            // 
            this.txtCambio.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(150, 255);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(100, 25);
            this.txtCambio.TabIndex = 14;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(5, 255);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(56, 19);
            this.lblCambio.TabIndex = 13;
            this.lblCambio.Text = "Cambio";
            // 
            // chkQR
            // 
            this.chkQR.AutoSize = true;
            this.chkQR.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQR.Location = new System.Drawing.Point(10, 170);
            this.chkQR.Name = "chkQR";
            this.chkQR.Size = new System.Drawing.Size(50, 23);
            this.chkQR.TabIndex = 12;
            this.chkQR.Text = "QR";
            this.chkQR.UseVisualStyleBackColor = true;
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEfectivo.Location = new System.Drawing.Point(10, 90);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(78, 23);
            this.chkEfectivo.TabIndex = 11;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // chkTransferencia
            // 
            this.chkTransferencia.AutoSize = true;
            this.chkTransferencia.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransferencia.Location = new System.Drawing.Point(10, 130);
            this.chkTransferencia.Name = "chkTransferencia";
            this.chkTransferencia.Size = new System.Drawing.Size(110, 23);
            this.chkTransferencia.TabIndex = 10;
            this.chkTransferencia.Text = "Transferencia";
            this.chkTransferencia.UseVisualStyleBackColor = true;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPago.Location = new System.Drawing.Point(150, 25);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(100, 25);
            this.txtTotalPago.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(150, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(150, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(150, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 6;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(5, 30);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(88, 19);
            this.lblTotalPagar.TabIndex = 6;
            this.lblTotalPagar.Text = "Total a pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // gbInformacionProducto
            // 
            this.gbInformacionProducto.Controls.Add(this.btnBuscarProducto);
            this.gbInformacionProducto.Controls.Add(this.txtStock);
            this.gbInformacionProducto.Controls.Add(this.txtPrecio);
            this.gbInformacionProducto.Controls.Add(this.txtProducto);
            this.gbInformacionProducto.Controls.Add(this.txtCantidad);
            this.gbInformacionProducto.Controls.Add(this.lblCantidad);
            this.gbInformacionProducto.Controls.Add(this.lblStock);
            this.gbInformacionProducto.Controls.Add(this.lblPrecio);
            this.gbInformacionProducto.Controls.Add(this.lblProducto);
            this.gbInformacionProducto.Controls.Add(this.txtCodProducto);
            this.gbInformacionProducto.Controls.Add(this.lblCodProducto);
            this.gbInformacionProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionProducto.Location = new System.Drawing.Point(40, 70);
            this.gbInformacionProducto.Name = "gbInformacionProducto";
            this.gbInformacionProducto.Size = new System.Drawing.Size(1060, 100);
            this.gbInformacionProducto.TabIndex = 3;
            this.gbInformacionProducto.TabStop = false;
            this.gbInformacionProducto.Text = "Información Producto";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ImageIndex = 0;
            this.btnBuscarProducto.ImageList = this.imageList1;
            this.btnBuscarProducto.Location = new System.Drawing.Point(220, 45);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(32, 32);
            this.btnBuscarProducto.TabIndex = 5;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Buscar.png");
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(780, 50);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 25);
            this.txtStock.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(580, 50);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(160, 25);
            this.txtPrecio.TabIndex = 13;
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(340, 50);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 25);
            this.txtProducto.TabIndex = 12;
            // 
            // txtCantidad
            // 
            this.txtCantidad.DisplayMember = "1";
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.FormattingEnabled = true;
            this.txtCantidad.ItemHeight = 20;
            this.txtCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtCantidad.Location = new System.Drawing.Point(920, 50);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 24);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.ValueMember = "1";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(920, 30);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 19);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(780, 30);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(42, 19);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(580, 30);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 19);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(340, 30);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(65, 19);
            this.lblProducto.TabIndex = 7;
            this.lblProducto.Text = "Producto";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(40, 50);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(160, 25);
            this.txtCodProducto.TabIndex = 6;
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(40, 30);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(97, 19);
            this.lblCodProducto.TabIndex = 5;
            this.lblCodProducto.Text = "Cod. Producto";
            // 
            // dgvVenta
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colProducto,
            this.colPrecio,
            this.colCantidad,
            this.colSubTotal,
            this.btnQuitarProducto});
            this.dgvVenta.Location = new System.Drawing.Point(40, 190);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersWidth = 51;
            this.dgvVenta.RowTemplate.Height = 28;
            this.dgvVenta.Size = new System.Drawing.Size(920, 400);
            this.dgvVenta.TabIndex = 4;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVenta_CellContentClick);
            this.dgvVenta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvVenta_CellPainting);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCodigo.Visible = false;
            this.colCodigo.Width = 50;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 6;
            this.colProducto.Name = "colProducto";
            this.colProducto.Width = 180;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 150;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 125;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.MinimumWidth = 6;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Width = 150;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.HeaderText = "";
            this.btnQuitarProducto.MinimumWidth = 6;
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.ReadOnly = true;
            this.btnQuitarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnQuitarProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnQuitarProducto.Width = 40;
            // 
            // btnAgregrarProducto
            // 
            this.btnAgregrarProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregrarProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregrarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregrarProducto.ImageIndex = 0;
            this.btnAgregrarProducto.ImageList = this.imageList2;
            this.btnAgregrarProducto.Location = new System.Drawing.Point(1140, 80);
            this.btnAgregrarProducto.Name = "btnAgregrarProducto";
            this.btnAgregrarProducto.Size = new System.Drawing.Size(100, 90);
            this.btnAgregrarProducto.TabIndex = 5;
            this.btnAgregrarProducto.Text = "Agregar Producto";
            this.btnAgregrarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregrarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregrarProducto.UseVisualStyleBackColor = false;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Agregar_Venta.png");
            this.imageList2.Images.SetKeyName(1, "Cancelar_Venta.png");
            this.imageList2.Images.SetKeyName(2, "Crear_Venta.png");
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmarVenta.ImageIndex = 2;
            this.btnConfirmarVenta.ImageList = this.imageList2;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(1143, 500);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(100, 90);
            this.btnConfirmarVenta.TabIndex = 6;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirmarVenta.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarVenta.ImageIndex = 1;
            this.btnCancelarVenta.ImageList = this.imageList2;
            this.btnCancelarVenta.Location = new System.Drawing.Point(983, 500);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(100, 90);
            this.btnCancelarVenta.TabIndex = 7;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.btnAgregrarProducto);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.gbInformacionProducto);
            this.Controls.Add(this.gbInformacionPago);
            this.Controls.Add(this.lblTituloVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbInformacionPago.ResumeLayout(false);
            this.gbInformacionPago.PerformLayout();
            this.gbInformacionProducto.ResumeLayout(false);
            this.gbInformacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVenta;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.GroupBox gbInformacionPago;
        private System.Windows.Forms.GroupBox gbInformacionProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ListBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.Button btnAgregrarProducto;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.CheckBox chkQR;
        private System.Windows.Forms.CheckBox chkEfectivo;
        private System.Windows.Forms.CheckBox chkTransferencia;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.Label lblPagaCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnQuitarProducto;
    }
}