namespace PetShop.Presentacion.Ventas
{
    partial class FormRegistrarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloVenta = new System.Windows.Forms.Label();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.lblTipoVenta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInformacionProducto = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtStockDisponible = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.btnAgregrarProducto = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCobro = new System.Windows.Forms.GroupBox();
            this.pVuelto = new System.Windows.Forms.Panel();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.lblDescuentoFinal = new System.Windows.Forms.Label();
            this.lblMontoAbonado = new System.Windows.Forms.Label();
            this.txtMontoAbonado = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.cbxTipoVenta = new System.Windows.Forms.ComboBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.gbInformacionVenta.SuspendLayout();
            this.gbInformacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.gbCobro.SuspendLayout();
            this.pVuelto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloVenta
            // 
            this.lblTituloVenta.AutoSize = true;
            this.lblTituloVenta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloVenta.ForeColor = System.Drawing.Color.Black;
            this.lblTituloVenta.Location = new System.Drawing.Point(614, 25);
            this.lblTituloVenta.Name = "lblTituloVenta";
            this.lblTituloVenta.Size = new System.Drawing.Size(217, 38);
            this.lblTituloVenta.TabIndex = 0;
            this.lblTituloVenta.Text = "Registrar Venta";
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.cbxTipoVenta);
            this.gbInformacionVenta.Controls.Add(this.txtFecha);
            this.gbInformacionVenta.Controls.Add(this.txtNroFactura);
            this.gbInformacionVenta.Controls.Add(this.lblTipoVenta);
            this.gbInformacionVenta.Controls.Add(this.lblFecha);
            this.gbInformacionVenta.Controls.Add(this.lblNroFactura);
            this.gbInformacionVenta.Controls.Add(this.label1);
            this.gbInformacionVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVenta.Location = new System.Drawing.Point(847, 88);
            this.gbInformacionVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInformacionVenta.Size = new System.Drawing.Size(551, 184);
            this.gbInformacionVenta.TabIndex = 2;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "Información de la Venta";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(324, 60);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(203, 31);
            this.txtFecha.TabIndex = 9;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(28, 60);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(203, 31);
            this.txtNroFactura.TabIndex = 8;
            // 
            // lblTipoVenta
            // 
            this.lblTipoVenta.AutoSize = true;
            this.lblTipoVenta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVenta.Location = new System.Drawing.Point(24, 117);
            this.lblTipoVenta.Name = "lblTipoVenta";
            this.lblTipoVenta.Size = new System.Drawing.Size(123, 21);
            this.lblTipoVenta.TabIndex = 7;
            this.lblTipoVenta.Text = "Tipo de Venta: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(320, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 21);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.Location = new System.Drawing.Point(24, 38);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(114, 21);
            this.lblNroFactura.TabIndex = 5;
            this.lblNroFactura.Text = "N° de factura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // gbInformacionProducto
            // 
            this.gbInformacionProducto.Controls.Add(this.numCantidad);
            this.gbInformacionProducto.Controls.Add(this.btnBuscarProducto);
            this.gbInformacionProducto.Controls.Add(this.txtStockDisponible);
            this.gbInformacionProducto.Controls.Add(this.txtPrecioUnitario);
            this.gbInformacionProducto.Controls.Add(this.btnAgregrarProducto);
            this.gbInformacionProducto.Controls.Add(this.txtNombreProducto);
            this.gbInformacionProducto.Controls.Add(this.lblCantidad);
            this.gbInformacionProducto.Controls.Add(this.lblStockDisponible);
            this.gbInformacionProducto.Controls.Add(this.lblPrecioUnitario);
            this.gbInformacionProducto.Controls.Add(this.lblNombreProducto);
            this.gbInformacionProducto.Controls.Add(this.txtCodProducto);
            this.gbInformacionProducto.Controls.Add(this.lblCodProducto);
            this.gbInformacionProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionProducto.Location = new System.Drawing.Point(45, 88);
            this.gbInformacionProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInformacionProducto.Name = "gbInformacionProducto";
            this.gbInformacionProducto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInformacionProducto.Size = new System.Drawing.Size(766, 184);
            this.gbInformacionProducto.TabIndex = 3;
            this.gbInformacionProducto.TabStop = false;
            this.gbInformacionProducto.Text = "Información del Producto";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscarProducto.ImageIndex = 1;
            this.btnBuscarProducto.ImageList = this.imageList1;
            this.btnBuscarProducto.Location = new System.Drawing.Point(250, 56);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(36, 40);
            this.btnBuscarProducto.TabIndex = 5;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Buscar.png");
            this.imageList1.Images.SetKeyName(1, "buscar (1).png");
            // 
            // txtStockDisponible
            // 
            this.txtStockDisponible.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockDisponible.Location = new System.Drawing.Point(277, 140);
            this.txtStockDisponible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStockDisponible.Name = "txtStockDisponible";
            this.txtStockDisponible.Size = new System.Drawing.Size(112, 29);
            this.txtStockDisponible.TabIndex = 14;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(20, 142);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(180, 29);
            this.txtPrecioUnitario.TabIndex = 13;
            // 
            // btnAgregrarProducto
            // 
            this.btnAgregrarProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregrarProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregrarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregrarProducto.ImageIndex = 3;
            this.btnAgregrarProducto.ImageList = this.imageList2;
            this.btnAgregrarProducto.Location = new System.Drawing.Point(634, 56);
            this.btnAgregrarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregrarProducto.Name = "btnAgregrarProducto";
            this.btnAgregrarProducto.Size = new System.Drawing.Size(112, 117);
            this.btnAgregrarProducto.TabIndex = 5;
            this.btnAgregrarProducto.Text = "Agregar Producto";
            this.btnAgregrarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregrarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregrarProducto.UseVisualStyleBackColor = false;
            this.btnAgregrarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Agregar_Venta.png");
            this.imageList2.Images.SetKeyName(1, "Cancelar_Venta.png");
            this.imageList2.Images.SetKeyName(2, "Crear_Venta.png");
            this.imageList2.Images.SetKeyName(3, "icono-mas.png");
            this.imageList2.Images.SetKeyName(4, "cruz.png");
            this.imageList2.Images.SetKeyName(5, "marca-de-verificacion.png");
            this.imageList2.Images.SetKeyName(6, "marca-de-verificacion.png");
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(20, 67);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(224, 29);
            this.txtNombreProducto.TabIndex = 12;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(472, 117);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 21);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockDisponible.Location = new System.Drawing.Point(263, 115);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(141, 21);
            this.lblStockDisponible.TabIndex = 9;
            this.lblStockDisponible.Text = "Stock disponible:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(20, 117);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(131, 21);
            this.lblPrecioUnitario.TabIndex = 8;
            this.lblPrecioUnitario.Text = "Precio unitario: ";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(20, 43);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(80, 21);
            this.lblNombreProducto.TabIndex = 7;
            this.lblNombreProducto.Text = "Producto";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(329, 63);
            this.txtCodProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(267, 29);
            this.txtCodProducto.TabIndex = 6;
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(325, 38);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(118, 21);
            this.lblCodProducto.TabIndex = 5;
            this.lblCodProducto.Text = "Cod. Producto";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(45, 25);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 40);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCódigo,
            this.colPrecio,
            this.colCantidad,
            this.colSubtotal,
            this.colAcción});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCarrito.Location = new System.Drawing.Point(45, 306);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidth = 62;
            this.dgvCarrito.RowTemplate.Height = 40;
            this.dgvCarrito.Size = new System.Drawing.Size(1353, 211);
            this.dgvCarrito.TabIndex = 11;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 8;
            this.colProducto.Name = "colProducto";
            // 
            // colCódigo
            // 
            this.colCódigo.HeaderText = "Código";
            this.colCódigo.MinimumWidth = 8;
            this.colCódigo.Name = "colCódigo";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio U.";
            this.colPrecio.MinimumWidth = 8;
            this.colPrecio.Name = "colPrecio";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 8;
            this.colCantidad.Name = "colCantidad";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 8;
            this.colSubtotal.Name = "colSubtotal";
            // 
            // colAcción
            // 
            this.colAcción.HeaderText = "Acción";
            this.colAcción.MinimumWidth = 8;
            this.colAcción.Name = "colAcción";
            // 
            // gbCobro
            // 
            this.gbCobro.Controls.Add(this.pVuelto);
            this.gbCobro.Controls.Add(this.txtDescuento);
            this.gbCobro.Controls.Add(this.lblDescuento);
            this.gbCobro.Controls.Add(this.btnEliminarVenta);
            this.gbCobro.Controls.Add(this.btnConfirmarVenta);
            this.gbCobro.Controls.Add(this.lblDescuentoFinal);
            this.gbCobro.Controls.Add(this.lblMontoAbonado);
            this.gbCobro.Controls.Add(this.txtMontoAbonado);
            this.gbCobro.Controls.Add(this.lblSubtotal);
            this.gbCobro.Controls.Add(this.lblTotalFinal);
            this.gbCobro.Controls.Add(this.lblMetodoPago);
            this.gbCobro.Controls.Add(this.cbxMetodoPago);
            this.gbCobro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCobro.Location = new System.Drawing.Point(45, 535);
            this.gbCobro.Name = "gbCobro";
            this.gbCobro.Size = new System.Drawing.Size(1353, 264);
            this.gbCobro.TabIndex = 12;
            this.gbCobro.TabStop = false;
            this.gbCobro.Text = "RESUMEN Y COBRO";
            // 
            // pVuelto
            // 
            this.pVuelto.BackColor = System.Drawing.Color.PaleGreen;
            this.pVuelto.Controls.Add(this.lblVuelto);
            this.pVuelto.Location = new System.Drawing.Point(303, 171);
            this.pVuelto.Name = "pVuelto";
            this.pVuelto.Size = new System.Drawing.Size(224, 44);
            this.pVuelto.TabIndex = 24;
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVuelto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblVuelto.Location = new System.Drawing.Point(3, 10);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(215, 25);
            this.lblVuelto.TabIndex = 18;
            this.lblVuelto.Text = "Vuelto/Cambio: $500,00";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(303, 81);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(224, 29);
            this.txtDescuento.TabIndex = 23;
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarVenta.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminarVenta.FlatAppearance.BorderSize = 0;
            this.btnEliminarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVenta.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEliminarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarVenta.ImageIndex = 4;
            this.btnEliminarVenta.ImageList = this.imageList2;
            this.btnEliminarVenta.Location = new System.Drawing.Point(1169, 158);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(158, 79);
            this.btnEliminarVenta.TabIndex = 21;
            this.btnEliminarVenta.Text = "ELIMINAR";
            this.btnEliminarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarVenta.UseVisualStyleBackColor = false;
            this.btnEliminarVenta.Click += new System.EventHandler(this.BtnEliminarVenta_Click);
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmarVenta.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmarVenta.FlatAppearance.BorderSize = 0;
            this.btnConfirmarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVenta.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnConfirmarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarVenta.ImageIndex = 6;
            this.btnConfirmarVenta.ImageList = this.imageList2;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(742, 158);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(387, 79);
            this.btnConfirmarVenta.TabIndex = 20;
            this.btnConfirmarVenta.Text = "CONFIRMAR Y REGISTRAR VENTA";
            this.btnConfirmarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarVenta.UseVisualStyleBackColor = false;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.BtnConfirmarVenta_Click);
            // 
            // lblDescuentoFinal
            // 
            this.lblDescuentoFinal.AutoSize = true;
            this.lblDescuentoFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoFinal.Location = new System.Drawing.Point(737, 76);
            this.lblDescuentoFinal.Name = "lblDescuentoFinal";
            this.lblDescuentoFinal.Size = new System.Drawing.Size(148, 25);
            this.lblDescuentoFinal.TabIndex = 17;
            this.lblDescuentoFinal.Text = "Descuento: 15%";
            // 
            // lblMontoAbonado
            // 
            this.lblMontoAbonado.AutoSize = true;
            this.lblMontoAbonado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAbonado.Location = new System.Drawing.Point(27, 157);
            this.lblMontoAbonado.Name = "lblMontoAbonado";
            this.lblMontoAbonado.Size = new System.Drawing.Size(157, 25);
            this.lblMontoAbonado.TabIndex = 13;
            this.lblMontoAbonado.Text = "Monto Abonado:";
            // 
            // txtMontoAbonado
            // 
            this.txtMontoAbonado.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAbonado.Location = new System.Drawing.Point(32, 186);
            this.txtMontoAbonado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMontoAbonado.Name = "txtMontoAbonado";
            this.txtMontoAbonado.Size = new System.Drawing.Size(224, 29);
            this.txtMontoAbonado.TabIndex = 14;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(737, 44);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(179, 25);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "Subtotal: $70000,00";
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTotalFinal.Location = new System.Drawing.Point(733, 101);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(483, 54);
            this.lblTotalFinal.TabIndex = 15;
            this.lblTotalFinal.Text = "TOTAL FINAL: $59500,00";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(27, 52);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(153, 25);
            this.lblMetodoPago.TabIndex = 1;
            this.lblMetodoPago.Text = "Método de Pago";
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Location = new System.Drawing.Point(32, 81);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(224, 29);
            this.cbxMetodoPago.TabIndex = 0;
            // 
            // cbxTipoVenta
            // 
            this.cbxTipoVenta.FormattingEnabled = true;
            this.cbxTipoVenta.Location = new System.Drawing.Point(28, 142);
            this.cbxTipoVenta.Name = "cbxTipoVenta";
            this.cbxTipoVenta.Size = new System.Drawing.Size(203, 33);
            this.cbxTipoVenta.TabIndex = 10;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(298, 56);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(170, 25);
            this.lblDescuento.TabIndex = 22;
            this.lblDescuento.Text = "Descuento (% / $):";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(476, 140);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 31);
            this.numCantidad.TabIndex = 15;
            // 
            // FormRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 846);
            this.Controls.Add(this.gbCobro);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbInformacionProducto);
            this.Controls.Add(this.gbInformacionVenta);
            this.Controls.Add(this.lblTituloVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            this.gbInformacionProducto.ResumeLayout(false);
            this.gbInformacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.gbCobro.ResumeLayout(false);
            this.gbCobro.PerformLayout();
            this.pVuelto.ResumeLayout(false);
            this.pVuelto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVenta;
        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.GroupBox gbInformacionProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtStockDisponible;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.Button btnAgregrarProducto;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label lblTipoVenta;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcción;
        private System.Windows.Forms.GroupBox gbCobro;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.TextBox txtMontoAbonado;
        private System.Windows.Forms.Label lblMontoAbonado;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label lblDescuentoFinal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Panel pVuelto;
        private System.Windows.Forms.ComboBox cbxTipoVenta;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.NumericUpDown numCantidad;
    }
}