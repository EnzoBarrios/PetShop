using System.Windows.Forms;

namespace PetShop.Presentacion.Menu
{
    partial class FormMenuPrincipal : Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.UsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EspeciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistorialDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.gbSesionIniciada = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRolLogeado = new System.Windows.Forms.Label();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFechaHora = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblPetShop = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblUsuarioBienvenida = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnHistorialVentas = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msPrincipal.SuspendLayout();
            this.gbSesionIniciada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFechaHora.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contenedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.AutoSize = false;
            this.msPrincipal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.msPrincipal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosToolStripMenuItem,
            this.CatalogoToolStripMenuItem,
            this.VentaToolStripMenuItem,
            this.ReportesToolStripMenuItem,
            this.SistemaToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 60);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1280, 80);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "PetShop";
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.AutoSize = false;
            this.UsuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UsuariosToolStripMenuItem.Image")));
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(89, 76);
            this.UsuariosToolStripMenuItem.Text = "Usuarios";
            this.UsuariosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UsuariosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UsuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // CatalogoToolStripMenuItem
            // 
            this.CatalogoToolStripMenuItem.AutoSize = false;
            this.CatalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductosToolStripMenuItem,
            this.CategoriasToolStripMenuItem,
            this.EspeciesToolStripMenuItem});
            this.CatalogoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CatalogoToolStripMenuItem.Image")));
            this.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem";
            this.CatalogoToolStripMenuItem.Size = new System.Drawing.Size(95, 76);
            this.CatalogoToolStripMenuItem.Text = "Catálogo";
            this.CatalogoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CatalogoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ProductosToolStripMenuItem
            // 
            this.ProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProductosToolStripMenuItem.Image")));
            this.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            this.ProductosToolStripMenuItem.Size = new System.Drawing.Size(187, 38);
            this.ProductosToolStripMenuItem.Text = "Productos";
            this.ProductosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // CategoriasToolStripMenuItem
            // 
            this.CategoriasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CategoriasToolStripMenuItem.Image")));
            this.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem";
            this.CategoriasToolStripMenuItem.Size = new System.Drawing.Size(187, 38);
            this.CategoriasToolStripMenuItem.Text = "Categorias";
            this.CategoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // EspeciesToolStripMenuItem
            // 
            this.EspeciesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EspeciesToolStripMenuItem.Image")));
            this.EspeciesToolStripMenuItem.Name = "EspeciesToolStripMenuItem";
            this.EspeciesToolStripMenuItem.Size = new System.Drawing.Size(187, 38);
            this.EspeciesToolStripMenuItem.Text = "Especies";
            this.EspeciesToolStripMenuItem.Click += new System.EventHandler(this.EspeciesToolStripMenuItem_Click);
            // 
            // VentaToolStripMenuItem
            // 
            this.VentaToolStripMenuItem.AutoSize = false;
            this.VentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevaVentaToolStripMenuItem,
            this.HistorialDeVentasToolStripMenuItem});
            this.VentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("VentaToolStripMenuItem.Image")));
            this.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem";
            this.VentaToolStripMenuItem.Size = new System.Drawing.Size(95, 76);
            this.VentaToolStripMenuItem.Text = "Ventas";
            this.VentaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VentaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // NuevaVentaToolStripMenuItem
            // 
            this.NuevaVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NuevaVentaToolStripMenuItem.Image")));
            this.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem";
            this.NuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(248, 38);
            this.NuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.NuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.NuevaVentaToolStripMenuItem_Click_1);
            // 
            // HistorialDeVentasToolStripMenuItem
            // 
            this.HistorialDeVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HistorialDeVentasToolStripMenuItem.Image")));
            this.HistorialDeVentasToolStripMenuItem.Name = "HistorialDeVentasToolStripMenuItem";
            this.HistorialDeVentasToolStripMenuItem.Size = new System.Drawing.Size(248, 38);
            this.HistorialDeVentasToolStripMenuItem.Text = "Historial de Ventas";
            this.HistorialDeVentasToolStripMenuItem.Click += new System.EventHandler(this.HistorialDeVentasToolStripMenuItem_Click);
            // 
            // ReportesToolStripMenuItem
            // 
            this.ReportesToolStripMenuItem.AutoSize = false;
            this.ReportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReportesToolStripMenuItem.Image")));
            this.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem";
            this.ReportesToolStripMenuItem.Size = new System.Drawing.Size(95, 76);
            this.ReportesToolStripMenuItem.Text = "Reportes";
            this.ReportesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReportesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReportesToolStripMenuItem.Click += new System.EventHandler(this.ReportesToolStripMenuItem_Click);
            // 
            // SistemaToolStripMenuItem
            // 
            this.SistemaToolStripMenuItem.AutoSize = false;
            this.SistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CerrarSesiónToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.SistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SistemaToolStripMenuItem.Image")));
            this.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem";
            this.SistemaToolStripMenuItem.Size = new System.Drawing.Size(95, 76);
            this.SistemaToolStripMenuItem.Text = "Sistema";
            this.SistemaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SistemaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // CerrarSesiónToolStripMenuItem
            // 
            this.CerrarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CerrarSesiónToolStripMenuItem.Image")));
            this.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem";
            this.CerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.CerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesiónToolStripMenuItem_Click);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripMenuItem.Image")));
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Usuario.png");
            this.imageList1.Images.SetKeyName(1, "Rol.png");
            // 
            // object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46
            // 
            this.object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46.AccessibleName = "toolStripStatusLabel1";
            this.object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46.Name = "object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46";
            this.object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46.Size = new System.Drawing.Size(151, 22);
            this.object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 20);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // gbSesionIniciada
            // 
            this.gbSesionIniciada.Controls.Add(this.pictureBox2);
            this.gbSesionIniciada.Controls.Add(this.pictureBox1);
            this.gbSesionIniciada.Controls.Add(this.lblRolLogeado);
            this.gbSesionIniciada.Controls.Add(this.lblUsuarioLogueado);
            this.gbSesionIniciada.Controls.Add(this.label1);
            this.gbSesionIniciada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSesionIniciada.Location = new System.Drawing.Point(15, 5);
            this.gbSesionIniciada.Name = "gbSesionIniciada";
            this.gbSesionIniciada.Size = new System.Drawing.Size(400, 90);
            this.gbSesionIniciada.TabIndex = 11;
            this.gbSesionIniciada.TabStop = false;
            this.gbSesionIniciada.Text = "Sesión Iniciada";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblRolLogeado
            // 
            this.lblRolLogeado.AutoSize = true;
            this.lblRolLogeado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolLogeado.Location = new System.Drawing.Point(35, 55);
            this.lblRolLogeado.Name = "lblRolLogeado";
            this.lblRolLogeado.Size = new System.Drawing.Size(118, 23);
            this.lblRolLogeado.TabIndex = 13;
            this.lblRolLogeado.Text = "Administrador";
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogueado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuarioLogueado.ImageIndex = 0;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(35, 25);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(60, 23);
            this.lblUsuarioLogueado.TabIndex = 12;
            this.lblUsuarioLogueado.Text = "Admin";
            this.lblUsuarioLogueado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 11;
            // 
            // gbFechaHora
            // 
            this.gbFechaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFechaHora.Controls.Add(this.lblHora);
            this.gbFechaHora.Controls.Add(this.lblFecha);
            this.gbFechaHora.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFechaHora.Location = new System.Drawing.Point(848, 5);
            this.gbFechaHora.Name = "gbFechaHora";
            this.gbFechaHora.Size = new System.Drawing.Size(400, 90);
            this.gbFechaHora.TabIndex = 12;
            this.gbFechaHora.TabStop = false;
            this.gbFechaHora.Text = "Fecha y Hora";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(15, 25);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 20);
            this.lblHora.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 55);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 20);
            this.lblFecha.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.gbFechaHora);
            this.panel1.Controls.Add(this.gbSesionIniciada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 760);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 100);
            this.panel1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 60);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblPetShop
            // 
            this.lblPetShop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPetShop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPetShop.ImageIndex = 0;
            this.lblPetShop.ImageList = this.imageList2;
            this.lblPetShop.Location = new System.Drawing.Point(10, 10);
            this.lblPetShop.Name = "lblPetShop";
            this.lblPetShop.Size = new System.Drawing.Size(200, 40);
            this.lblPetShop.TabIndex = 17;
            this.lblPetShop.Text = "PetShop";
            this.lblPetShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Huella_Perro.png");
            // 
            // lblUsuarioBienvenida
            // 
            this.lblUsuarioBienvenida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioBienvenida.Location = new System.Drawing.Point(0, 100);
            this.lblUsuarioBienvenida.Name = "lblUsuarioBienvenida";
            this.lblUsuarioBienvenida.Size = new System.Drawing.Size(1280, 40);
            this.lblUsuarioBienvenida.TabIndex = 1;
            this.lblUsuarioBienvenida.Text = "¡Bienvenido, Usuario!";
            this.lblUsuarioBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contenedor
            // 
            this.contenedor.AutoScroll = true;
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Controls.Add(this.groupBox1);
            this.contenedor.Controls.Add(this.lblUsuarioBienvenida);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 140);
            this.contenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Padding = new System.Windows.Forms.Padding(15);
            this.contenedor.Size = new System.Drawing.Size(1280, 620);
            this.contenedor.TabIndex = 3;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReportes.ImageIndex = 2;
            this.btnReportes.ImageList = this.imageList3;
            this.btnReportes.Location = new System.Drawing.Point(640, 30);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 100);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Visualizar Reportes Recientes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Nueva_Venta.png");
            this.imageList3.Images.SetKeyName(1, "Historial_Ventas.png");
            this.imageList3.Images.SetKeyName(2, "Reportes_Recaudacion.png");
            // 
            // btnHistorialVentas
            // 
            this.btnHistorialVentas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHistorialVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialVentas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHistorialVentas.ImageIndex = 1;
            this.btnHistorialVentas.ImageList = this.imageList3;
            this.btnHistorialVentas.Location = new System.Drawing.Point(340, 30);
            this.btnHistorialVentas.Name = "btnHistorialVentas";
            this.btnHistorialVentas.Size = new System.Drawing.Size(200, 100);
            this.btnHistorialVentas.TabIndex = 3;
            this.btnHistorialVentas.Text = "Visualizar Ventas Recientes";
            this.btnHistorialVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHistorialVentas.UseVisualStyleBackColor = false;
            this.btnHistorialVentas.Click += new System.EventHandler(this.BtnHistorialVentas_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRealizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarVenta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRealizarVenta.ImageIndex = 0;
            this.btnRealizarVenta.ImageList = this.imageList3;
            this.btnRealizarVenta.Location = new System.Drawing.Point(40, 30);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(200, 100);
            this.btnRealizarVenta.TabIndex = 2;
            this.btnRealizarVenta.Text = "Realizar Nueva Venta";
            this.btnRealizarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            this.btnRealizarVenta.Click += new System.EventHandler(this.BtnRealizarVenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRealizarVenta);
            this.groupBox1.Controls.Add(this.btnHistorialVentas);
            this.groupBox1.Controls.Add(this.btnReportes);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(200, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso Rapidos";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 860);
            this.Controls.Add(this.lblPetShop);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShop - Sistema de Gestión Veterinaria";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.Shown += new System.EventHandler(this.FormMenuPrincipal_Shown);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.gbSesionIniciada.ResumeLayout(false);
            this.gbSesionIniciada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFechaHora.ResumeLayout(false);
            this.gbFechaHora.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contenedor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem UsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CatalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SistemaToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EspeciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistorialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Timer Timer;
        private GroupBox gbSesionIniciada;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblRolLogeado;
        private Label lblUsuarioLogueado;
        private Label label1;
        private GroupBox gbFechaHora;
        private Label lblHora;
        private Label lblFecha;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private Label lblPetShop;
        private ImageList imageList2;
        private Label lblUsuarioBienvenida;
        private Panel contenedor;
        private Button btnRealizarVenta;
        private Button btnReportes;
        private Button btnHistorialVentas;
        private ImageList imageList3;
        private GroupBox groupBox1;
    }
}



