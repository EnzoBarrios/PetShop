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
            this.MiPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Titulo = new System.Windows.Forms.ImageList(this.components);
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.gbSesionIniciada = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRolLogeado = new System.Windows.Forms.Label();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.gbFechaHora = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.msTitulo = new System.Windows.Forms.MenuStrip();
            this.lblPetShop = new System.Windows.Forms.Label();
            this.listaAccesoRapido = new System.Windows.Forms.ImageList(this.components);
            this.lblUsuarioBienvenida = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.grpAccesoRapido = new System.Windows.Forms.GroupBox();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnHistorialVentas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.tlbEstructuraPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.msPrincipal.SuspendLayout();
            this.gbSesionIniciada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFechaHora.SuspendLayout();
            this.contenedor.SuspendLayout();
            this.grpAccesoRapido.SuspendLayout();
            this.tlbEstructuraPrincipal.SuspendLayout();
            this.pnlHeader.SuspendLayout();
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
            this.msPrincipal.Size = new System.Drawing.Size(1282, 80);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "PetShop";
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.AutoSize = false;
            this.UsuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UsuariosToolStripMenuItem.Image")));
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(70, 70);
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
            this.CatalogoToolStripMenuItem.Size = new System.Drawing.Size(70, 70);
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
            this.VentaToolStripMenuItem.Size = new System.Drawing.Size(70, 70);
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
            this.ReportesToolStripMenuItem.Size = new System.Drawing.Size(70, 70);
            this.ReportesToolStripMenuItem.Text = "Reportes";
            this.ReportesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReportesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReportesToolStripMenuItem.Click += new System.EventHandler(this.ReportesToolStripMenuItem_Click);
            // 
            // SistemaToolStripMenuItem
            // 
            this.SistemaToolStripMenuItem.AutoSize = false;
            this.SistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiPerfilToolStripMenuItem,
            this.CerrarSesiónToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.SistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SistemaToolStripMenuItem.Image")));
            this.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem";
            this.SistemaToolStripMenuItem.Size = new System.Drawing.Size(70, 70);
            this.SistemaToolStripMenuItem.Text = "Sistema";
            this.SistemaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SistemaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MiPerfilToolStripMenuItem
            // 
            this.MiPerfilToolStripMenuItem.Image = global::PetShop.Properties.Resources.hombre;
            this.MiPerfilToolStripMenuItem.Name = "MiPerfilToolStripMenuItem";
            this.MiPerfilToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.MiPerfilToolStripMenuItem.Text = "Mi Perfil";
            this.MiPerfilToolStripMenuItem.Click += new System.EventHandler(this.MiPerfilToolStripMenuItem_Click);
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
            // Titulo
            // 
            this.Titulo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Titulo.ImageStream")));
            this.Titulo.TransparentColor = System.Drawing.Color.Transparent;
            this.Titulo.Images.SetKeyName(0, "Huella_Perro.png");
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(62, 20);
            this.toolStripStatusLabel.Text = "Usuario:";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // gbSesionIniciada
            // 
            this.gbSesionIniciada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSesionIniciada.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbSesionIniciada.Controls.Add(this.pictureBox2);
            this.gbSesionIniciada.Controls.Add(this.pictureBox1);
            this.gbSesionIniciada.Controls.Add(this.lblRolLogeado);
            this.gbSesionIniciada.Controls.Add(this.lblUsuarioLogueado);
            this.gbSesionIniciada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSesionIniciada.Location = new System.Drawing.Point(900, 60);
            this.gbSesionIniciada.Name = "gbSesionIniciada";
            this.gbSesionIniciada.Size = new System.Drawing.Size(232, 78);
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
            // gbFechaHora
            // 
            this.gbFechaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFechaHora.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbFechaHora.Controls.Add(this.lblHora);
            this.gbFechaHora.Controls.Add(this.lblFecha);
            this.gbFechaHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFechaHora.Location = new System.Drawing.Point(519, 60);
            this.gbFechaHora.Name = "gbFechaHora";
            this.gbFechaHora.Size = new System.Drawing.Size(343, 80);
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
            // msTitulo
            // 
            this.msTitulo.AutoSize = false;
            this.msTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.msTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msTitulo.Location = new System.Drawing.Point(0, 0);
            this.msTitulo.Name = "msTitulo";
            this.msTitulo.Size = new System.Drawing.Size(1282, 60);
            this.msTitulo.TabIndex = 4;
            this.msTitulo.Text = "titulo";
            // 
            // lblPetShop
            // 
            this.lblPetShop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPetShop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPetShop.ImageIndex = 0;
            this.lblPetShop.ImageList = this.Titulo;
            this.lblPetShop.Location = new System.Drawing.Point(5, 10);
            this.lblPetShop.Name = "lblPetShop";
            this.lblPetShop.Size = new System.Drawing.Size(200, 40);
            this.lblPetShop.TabIndex = 17;
            this.lblPetShop.Text = "PetShop";
            this.lblPetShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listaAccesoRapido
            // 
            this.listaAccesoRapido.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaAccesoRapido.ImageStream")));
            this.listaAccesoRapido.TransparentColor = System.Drawing.Color.Transparent;
            this.listaAccesoRapido.Images.SetKeyName(0, "Ventas.png");
            this.listaAccesoRapido.Images.SetKeyName(1, "Historial_Ventas.png");
            this.listaAccesoRapido.Images.SetKeyName(2, "Reportes_Stock.png");
            // 
            // lblUsuarioBienvenida
            // 
            this.lblUsuarioBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioBienvenida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioBienvenida.Location = new System.Drawing.Point(0, 100);
            this.lblUsuarioBienvenida.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuarioBienvenida.Name = "lblUsuarioBienvenida";
            this.lblUsuarioBienvenida.Size = new System.Drawing.Size(1282, 40);
            this.lblUsuarioBienvenida.TabIndex = 1;
            this.lblUsuarioBienvenida.Text = "¡Bienvenido, Usuario!";
            this.lblUsuarioBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contenedor
            // 
            this.contenedor.AutoScroll = true;
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Controls.Add(this.grpAccesoRapido);
            this.contenedor.Controls.Add(this.lblUsuarioBienvenida);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 140);
            this.contenedor.Margin = new System.Windows.Forms.Padding(0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1282, 713);
            this.contenedor.TabIndex = 3;
            // 
            // grpAccesoRapido
            // 
            this.grpAccesoRapido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAccesoRapido.Controls.Add(this.btnRealizarVenta);
            this.grpAccesoRapido.Controls.Add(this.btnHistorialVentas);
            this.grpAccesoRapido.Controls.Add(this.btnReportes);
            this.grpAccesoRapido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccesoRapido.Location = new System.Drawing.Point(201, 208);
            this.grpAccesoRapido.Name = "grpAccesoRapido";
            this.grpAccesoRapido.Size = new System.Drawing.Size(901, 150);
            this.grpAccesoRapido.TabIndex = 5;
            this.grpAccesoRapido.TabStop = false;
            this.grpAccesoRapido.Text = "Acceso Rapido";
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRealizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarVenta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRealizarVenta.ImageIndex = 0;
            this.btnRealizarVenta.ImageList = this.listaAccesoRapido;
            this.btnRealizarVenta.Location = new System.Drawing.Point(40, 30);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(200, 100);
            this.btnRealizarVenta.TabIndex = 2;
            this.btnRealizarVenta.Text = "Realizar Nueva Venta";
            this.btnRealizarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            this.btnRealizarVenta.Click += new System.EventHandler(this.BtnRealizarVenta_Click);
            // 
            // btnHistorialVentas
            // 
            this.btnHistorialVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHistorialVentas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHistorialVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialVentas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHistorialVentas.ImageIndex = 1;
            this.btnHistorialVentas.ImageList = this.listaAccesoRapido;
            this.btnHistorialVentas.Location = new System.Drawing.Point(340, 30);
            this.btnHistorialVentas.Name = "btnHistorialVentas";
            this.btnHistorialVentas.Size = new System.Drawing.Size(200, 100);
            this.btnHistorialVentas.TabIndex = 3;
            this.btnHistorialVentas.Text = "Visualizar Ventas Recientes";
            this.btnHistorialVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHistorialVentas.UseVisualStyleBackColor = false;
            this.btnHistorialVentas.Click += new System.EventHandler(this.BtnHistorialVentas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReportes.ImageIndex = 2;
            this.btnReportes.ImageList = this.listaAccesoRapido;
            this.btnReportes.Location = new System.Drawing.Point(640, 30);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 100);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Visualizar Reportes Recientes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // tlbEstructuraPrincipal
            // 
            this.tlbEstructuraPrincipal.ColumnCount = 1;
            this.tlbEstructuraPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbEstructuraPrincipal.Controls.Add(this.pnlHeader, 0, 0);
            this.tlbEstructuraPrincipal.Controls.Add(this.contenedor, 0, 1);
            this.tlbEstructuraPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbEstructuraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlbEstructuraPrincipal.Name = "tlbEstructuraPrincipal";
            this.tlbEstructuraPrincipal.RowCount = 2;
            this.tlbEstructuraPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlbEstructuraPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbEstructuraPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbEstructuraPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbEstructuraPrincipal.Size = new System.Drawing.Size(1282, 853);
            this.tlbEstructuraPrincipal.TabIndex = 20;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblPetShop);
            this.pnlHeader.Controls.Add(this.gbFechaHora);
            this.pnlHeader.Controls.Add(this.gbSesionIniciada);
            this.pnlHeader.Controls.Add(this.msPrincipal);
            this.pnlHeader.Controls.Add(this.msTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1282, 140);
            this.pnlHeader.TabIndex = 0;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.tlbEstructuraPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msTitulo;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
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
            this.contenedor.ResumeLayout(false);
            this.grpAccesoRapido.ResumeLayout(false);
            this.tlbEstructuraPrincipal.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
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
        private System.Windows.Forms.ImageList Titulo;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EspeciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistorialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private Timer Timer;
        private GroupBox gbSesionIniciada;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblRolLogeado;
        private Label lblUsuarioLogueado;
        private GroupBox gbFechaHora;
        private Label lblHora;
        private Label lblFecha;
        private MenuStrip msTitulo;
        private Label lblPetShop;
        private ImageList listaAccesoRapido;
        private Label lblUsuarioBienvenida;
        private Panel contenedor;
        private Button btnRealizarVenta;
        private Button btnReportes;
        private Button btnHistorialVentas;
        private GroupBox grpAccesoRapido;
        private ToolStripMenuItem MiPerfilToolStripMenuItem;
        private TableLayoutPanel tlbEstructuraPrincipal;
        private Panel pnlHeader;
    }
}



