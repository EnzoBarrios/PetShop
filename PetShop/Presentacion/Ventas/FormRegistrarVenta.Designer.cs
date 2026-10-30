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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloVenta = new System.Windows.Forms.Label();
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.cbxTipoVenta = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.lblTipoVenta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.gbInformacionProducto = new System.Windows.Forms.GroupBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
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
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtMontoAbonado = new System.Windows.Forms.TextBox();
            this.lblMontoAbonado = new System.Windows.Forms.Label();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.gbCobro = new System.Windows.Forms.GroupBox();
            this.lblMontoFinal = new System.Windows.Forms.Label();
            this.lblDescuentoFinal = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.pnlCobro = new System.Windows.Forms.Panel();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.gbInformacionVenta.SuspendLayout();
            this.gbInformacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.gbCobro.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.pnlCobro.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloVenta
            // 
            this.lblTituloVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloVenta.AutoSize = true;
            this.lblTituloVenta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloVenta.ForeColor = System.Drawing.Color.Black;
            this.lblTituloVenta.Location = new System.Drawing.Point(614, 15);
            this.lblTituloVenta.Name = "lblTituloVenta";
            this.lblTituloVenta.Size = new System.Drawing.Size(217, 38);
            this.lblTituloVenta.TabIndex = 0;
            this.lblTituloVenta.Text = "Registrar Venta";
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformacionVenta.Controls.Add(this.cbxTipoVenta);
            this.gbInformacionVenta.Controls.Add(this.txtFecha);
            this.gbInformacionVenta.Controls.Add(this.txtNroFactura);
            this.gbInformacionVenta.Controls.Add(this.lblTipoVenta);
            this.gbInformacionVenta.Controls.Add(this.lblFecha);
            this.gbInformacionVenta.Controls.Add(this.lblNroFactura);
            this.gbInformacionVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVenta.Location = new System.Drawing.Point(830, 6);
            this.gbInformacionVenta.Margin = new System.Windows.Forms.Padding(0);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Padding = new System.Windows.Forms.Padding(0);
            this.gbInformacionVenta.Size = new System.Drawing.Size(565, 180);
            this.gbInformacionVenta.TabIndex = 2;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "Información de la Venta";
            // 
            // cbxTipoVenta
            // 
            this.cbxTipoVenta.FormattingEnabled = true;
            this.cbxTipoVenta.Location = new System.Drawing.Point(28, 130);
            this.cbxTipoVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipoVenta.Name = "cbxTipoVenta";
            this.cbxTipoVenta.Size = new System.Drawing.Size(203, 33);
            this.cbxTipoVenta.TabIndex = 10;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(324, 55);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(203, 31);
            this.txtFecha.TabIndex = 9;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(28, 55);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(203, 31);
            this.txtNroFactura.TabIndex = 8;
            // 
            // lblTipoVenta
            // 
            this.lblTipoVenta.AutoSize = true;
            this.lblTipoVenta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVenta.Location = new System.Drawing.Point(20, 102);
            this.lblTipoVenta.Name = "lblTipoVenta";
            this.lblTipoVenta.Size = new System.Drawing.Size(123, 21);
            this.lblTipoVenta.TabIndex = 7;
            this.lblTipoVenta.Text = "Tipo de Venta: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(316, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 21);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.Location = new System.Drawing.Point(20, 30);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(114, 21);
            this.lblNroFactura.TabIndex = 5;
            this.lblNroFactura.Text = "N° de factura:";
            // 
            // gbInformacionProducto
            // 
            this.gbInformacionProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
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
            this.gbInformacionProducto.Location = new System.Drawing.Point(45, 6);
            this.gbInformacionProducto.Margin = new System.Windows.Forms.Padding(0);
            this.gbInformacionProducto.Name = "gbInformacionProducto";
            this.gbInformacionProducto.Padding = new System.Windows.Forms.Padding(0);
            this.gbInformacionProducto.Size = new System.Drawing.Size(765, 180);
            this.gbInformacionProducto.TabIndex = 3;
            this.gbInformacionProducto.TabStop = false;
            this.gbInformacionProducto.Text = "Información del Producto";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(476, 130);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 31);
            this.numCantidad.TabIndex = 15;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 2;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuscarProducto.ImageIndex = 2;
            this.btnBuscarProducto.ImageList = this.imageList1;
            this.btnBuscarProducto.Location = new System.Drawing.Point(250, 48);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 45);
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
            this.imageList1.Images.SetKeyName(2, "lupa.png");
            // 
            // txtStockDisponible
            // 
            this.txtStockDisponible.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockDisponible.Location = new System.Drawing.Point(277, 130);
            this.txtStockDisponible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStockDisponible.Name = "txtStockDisponible";
            this.txtStockDisponible.Size = new System.Drawing.Size(112, 29);
            this.txtStockDisponible.TabIndex = 14;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(20, 130);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(180, 29);
            this.txtPrecioUnitario.TabIndex = 13;
            // 
            // btnAgregrarProducto
            // 
            this.btnAgregrarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregrarProducto.BackColor = System.Drawing.Color.MintCream;
            this.btnAgregrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregrarProducto.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregrarProducto.FlatAppearance.BorderSize = 2;
            this.btnAgregrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregrarProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregrarProducto.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAgregrarProducto.ImageIndex = 5;
            this.btnAgregrarProducto.ImageList = this.imageList2;
            this.btnAgregrarProducto.Location = new System.Drawing.Point(634, 48);
            this.btnAgregrarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregrarProducto.Name = "btnAgregrarProducto";
            this.btnAgregrarProducto.Size = new System.Drawing.Size(112, 112);
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
            this.imageList2.Images.SetKeyName(0, "boton-x.png");
            this.imageList2.Images.SetKeyName(1, "borrar (1).png");
            this.imageList2.Images.SetKeyName(2, "bolsa-de-la-compra.png");
            this.imageList2.Images.SetKeyName(3, "eliminar-producto.png");
            this.imageList2.Images.SetKeyName(4, "comercio-electronico.png");
            this.imageList2.Images.SetKeyName(5, "agregar-producto.png");
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(20, 56);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(224, 29);
            this.txtNombreProducto.TabIndex = 12;
            this.txtNombreProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNombreProducto_KeyDown);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(469, 106);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 21);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockDisponible.Location = new System.Drawing.Point(260, 106);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(141, 21);
            this.lblStockDisponible.TabIndex = 9;
            this.lblStockDisponible.Text = "Stock disponible:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(17, 106);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(131, 21);
            this.lblPrecioUnitario.TabIndex = 8;
            this.lblPrecioUnitario.Text = "Precio unitario: ";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(17, 32);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(80, 21);
            this.lblNombreProducto.TabIndex = 7;
            this.lblNombreProducto.Text = "Producto";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(328, 56);
            this.txtCodProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(267, 29);
            this.txtCodProducto.TabIndex = 6;
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(322, 32);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(118, 21);
            this.lblCodProducto.TabIndex = 5;
            this.lblCodProducto.Text = "Cod. Producto";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(45, 10);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 40);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCódigo,
            this.colPrecio,
            this.colCantidad,
            this.colSubtotal,
            this.colAccion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.Location = new System.Drawing.Point(45, 6);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidth = 62;
            this.dgvCarrito.RowTemplate.Height = 40;
            this.dgvCarrito.Size = new System.Drawing.Size(1350, 318);
            this.dgvCarrito.TabIndex = 11;
            this.dgvCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarrito_CellClick);
            this.dgvCarrito.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarrito_CellMouseEnter);
            this.dgvCarrito.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarrito_CellMouseLeave);
            // 
            // colProducto
            // 
            this.colProducto.DataPropertyName = "Producto";
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 8;
            this.colProducto.Name = "colProducto";
            // 
            // colCódigo
            // 
            this.colCódigo.DataPropertyName = "Codigo";
            this.colCódigo.HeaderText = "Código";
            this.colCódigo.MinimumWidth = 8;
            this.colCódigo.Name = "colCódigo";
            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "PrecioUnitario";
            this.colPrecio.HeaderText = "Precio U.";
            this.colPrecio.MinimumWidth = 8;
            this.colPrecio.Name = "colPrecio";
            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "Cantidad";
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 8;
            this.colCantidad.Name = "colCantidad";
            // 
            // colSubtotal
            // 
            this.colSubtotal.DataPropertyName = "Subtotal";
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 8;
            this.colSubtotal.Name = "colSubtotal";
            // 
            // colAccion
            // 
            this.colAccion.DataPropertyName = "Accion";
            this.colAccion.HeaderText = "Acción";
            this.colAccion.MinimumWidth = 8;
            this.colAccion.Name = "colAccion";
            this.colAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAccion.Text = "Quitar";
            this.colAccion.UseColumnTextForButtonValue = true;
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Location = new System.Drawing.Point(32, 70);
            this.cbxMetodoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(224, 29);
            this.cbxMetodoPago.TabIndex = 0;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(27, 42);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(153, 25);
            this.lblMetodoPago.TabIndex = 1;
            this.lblMetodoPago.Text = "Método de Pago";
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinal.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblTotalFinal.Location = new System.Drawing.Point(681, 90);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(92, 54);
            this.lblTotalFinal.TabIndex = 15;
            this.lblTotalFinal.Text = "100";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(687, 28);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(32, 25);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "10";
            // 
            // txtMontoAbonado
            // 
            this.txtMontoAbonado.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAbonado.Location = new System.Drawing.Point(303, 140);
            this.txtMontoAbonado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMontoAbonado.Name = "txtMontoAbonado";
            this.txtMontoAbonado.Size = new System.Drawing.Size(224, 29);
            this.txtMontoAbonado.TabIndex = 14;
            this.txtMontoAbonado.TextChanged += new System.EventHandler(this.TxtMontoAbonado_TextChanged);
            // 
            // lblMontoAbonado
            // 
            this.lblMontoAbonado.AutoSize = true;
            this.lblMontoAbonado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAbonado.Location = new System.Drawing.Point(298, 112);
            this.lblMontoAbonado.Name = "lblMontoAbonado";
            this.lblMontoAbonado.Size = new System.Drawing.Size(157, 25);
            this.lblMontoAbonado.TabIndex = 13;
            this.lblMontoAbonado.Text = "Monto Abonado:";
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.Honeydew;
            this.btnConfirmarVenta.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConfirmarVenta.FlatAppearance.BorderSize = 2;
            this.btnConfirmarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVenta.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConfirmarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarVenta.ImageIndex = 2;
            this.btnConfirmarVenta.ImageList = this.imageList2;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(693, 140);
            this.btnConfirmarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(418, 65);
            this.btnConfirmarVenta.TabIndex = 20;
            this.btnConfirmarVenta.Text = "CONFIRMAR Y REGISTRAR VENTA";
            this.btnConfirmarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarVenta.UseVisualStyleBackColor = false;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.BtnConfirmarVenta_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarVenta.BackColor = System.Drawing.Color.MistyRose;
            this.btnEliminarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEliminarVenta.FlatAppearance.BorderSize = 2;
            this.btnEliminarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVenta.ForeColor = System.Drawing.Color.IndianRed;
            this.btnEliminarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarVenta.ImageIndex = 1;
            this.btnEliminarVenta.ImageList = this.imageList2;
            this.btnEliminarVenta.Location = new System.Drawing.Point(1142, 140);
            this.btnEliminarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(192, 65);
            this.btnEliminarVenta.TabIndex = 21;
            this.btnEliminarVenta.Text = "ELIMINAR";
            this.btnEliminarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarVenta.UseVisualStyleBackColor = false;
            this.btnEliminarVenta.Click += new System.EventHandler(this.BtnEliminarVenta_Click);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(298, 42);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(170, 25);
            this.lblDescuento.TabIndex = 22;
            this.lblDescuento.Text = "Descuento (% / $):";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(303, 70);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(224, 29);
            this.txtDescuento.TabIndex = 23;
            this.txtDescuento.TextChanged += new System.EventHandler(this.TxtDescuento_TextChanged);
            // 
            // gbCobro
            // 
            this.gbCobro.Controls.Add(this.lblMontoFinal);
            this.gbCobro.Controls.Add(this.lblDescuentoFinal);
            this.gbCobro.Controls.Add(this.txtDescuento);
            this.gbCobro.Controls.Add(this.lblDescuento);
            this.gbCobro.Controls.Add(this.btnEliminarVenta);
            this.gbCobro.Controls.Add(this.btnConfirmarVenta);
            this.gbCobro.Controls.Add(this.lblMontoAbonado);
            this.gbCobro.Controls.Add(this.lblVuelto);
            this.gbCobro.Controls.Add(this.txtMontoAbonado);
            this.gbCobro.Controls.Add(this.lblSubtotal);
            this.gbCobro.Controls.Add(this.lblTotalFinal);
            this.gbCobro.Controls.Add(this.lblMetodoPago);
            this.gbCobro.Controls.Add(this.cbxMetodoPago);
            this.gbCobro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCobro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCobro.Location = new System.Drawing.Point(45, 6);
            this.gbCobro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 6);
            this.gbCobro.Name = "gbCobro";
            this.gbCobro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 6);
            this.gbCobro.Size = new System.Drawing.Size(1350, 218);
            this.gbCobro.TabIndex = 12;
            this.gbCobro.TabStop = false;
            this.gbCobro.Text = "RESUMEN Y COBRO";
            // 
            // lblMontoFinal
            // 
            this.lblMontoFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoFinal.AutoSize = true;
            this.lblMontoFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoFinal.Location = new System.Drawing.Point(687, 70);
            this.lblMontoFinal.Name = "lblMontoFinal";
            this.lblMontoFinal.Size = new System.Drawing.Size(32, 25);
            this.lblMontoFinal.TabIndex = 25;
            this.lblMontoFinal.Text = "10";
            // 
            // lblDescuentoFinal
            // 
            this.lblDescuentoFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescuentoFinal.AutoSize = true;
            this.lblDescuentoFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoFinal.Location = new System.Drawing.Point(974, 28);
            this.lblDescuentoFinal.Name = "lblDescuentoFinal";
            this.lblDescuentoFinal.Size = new System.Drawing.Size(32, 25);
            this.lblDescuentoFinal.TabIndex = 24;
            this.lblDescuentoFinal.Text = "10";
            // 
            // lblVuelto
            // 
            this.lblVuelto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.Location = new System.Drawing.Point(974, 70);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(32, 25);
            this.lblVuelto.TabIndex = 4;
            this.lblVuelto.Text = "10";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.btnVolver);
            this.pnlTitulo.Controls.Add(this.lblTituloVenta);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Padding = new System.Windows.Forms.Padding(45, 6, 45, 6);
            this.pnlTitulo.Size = new System.Drawing.Size(1440, 60);
            this.pnlTitulo.TabIndex = 13;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.gbInformacionProducto);
            this.panelInfo.Controls.Add(this.gbInformacionVenta);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 60);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(45, 6, 45, 6);
            this.panelInfo.Size = new System.Drawing.Size(1440, 196);
            this.panelInfo.TabIndex = 16;
            // 
            // pnlCobro
            // 
            this.pnlCobro.Controls.Add(this.gbCobro);
            this.pnlCobro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCobro.Location = new System.Drawing.Point(0, 590);
            this.pnlCobro.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCobro.Name = "pnlCobro";
            this.pnlCobro.Padding = new System.Windows.Forms.Padding(45, 6, 45, 6);
            this.pnlCobro.Size = new System.Drawing.Size(1440, 230);
            this.pnlCobro.TabIndex = 11;
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.dgvCarrito);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 256);
            this.pnlGrilla.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Padding = new System.Windows.Forms.Padding(45, 6, 45, 6);
            this.pnlGrilla.Size = new System.Drawing.Size(1440, 334);
            this.pnlGrilla.TabIndex = 11;
            // 
            // FormRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 820);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.pnlCobro);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1440, 820);
            this.Name = "FormRegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormRegistrarVenta_Load);
            this.Shown += new System.EventHandler(this.FormResitrarVenta_Shown);
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            this.gbInformacionProducto.ResumeLayout(false);
            this.gbInformacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.gbCobro.ResumeLayout(false);
            this.gbCobro.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.pnlCobro.ResumeLayout(false);
            this.pnlGrilla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloVenta;
        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.GroupBox gbInformacionProducto;
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
        private System.Windows.Forms.ComboBox cbxTipoVenta;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtMontoAbonado;
        private System.Windows.Forms.Label lblMontoAbonado;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.GroupBox gbCobro;
        private System.Windows.Forms.Label lblDescuentoFinal;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label lblMontoFinal;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel pnlCobro;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn colAccion;
    }
}