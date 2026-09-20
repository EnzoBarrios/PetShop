using System.Windows.Forms;

namespace PetShop.Presentacion
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
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbSesionIniciada = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblPetShop = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.msPrincipal.SuspendLayout();
            this.gbSesionIniciada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.AutoSize = false;
            this.msPrincipal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.msPrincipal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem,
            this.catalogoToolStripMenuItem1,
            this.ventaToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 75);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msPrincipal.Size = new System.Drawing.Size(1440, 100);
            this.msPrincipal.TabIndex = 4;
            this.msPrincipal.Text = "PetShop";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(108, 96);
            this.catalogoToolStripMenuItem.Text = "Usuarios";
            this.catalogoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.catalogoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.catalogoToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // catalogoToolStripMenuItem1
            // 
            this.catalogoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.especiesToolStripMenuItem});
            this.catalogoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("catalogoToolStripMenuItem1.Image")));
            this.catalogoToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.catalogoToolStripMenuItem1.Name = "catalogoToolStripMenuItem1";
            this.catalogoToolStripMenuItem1.Size = new System.Drawing.Size(112, 96);
            this.catalogoToolStripMenuItem1.Text = "Catálogo";
            this.catalogoToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.catalogoToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem.Image")));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(222, 42);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriasToolStripMenuItem.Image")));
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(222, 42);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // especiesToolStripMenuItem
            // 
            this.especiesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("especiesToolStripMenuItem.Image")));
            this.especiesToolStripMenuItem.Name = "especiesToolStripMenuItem";
            this.especiesToolStripMenuItem.Size = new System.Drawing.Size(222, 42);
            this.especiesToolStripMenuItem.Text = "Especies";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.historialDeVentasToolStripMenuItem});
            this.ventaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaToolStripMenuItem.Image")));
            this.ventaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(91, 96);
            this.ventaToolStripMenuItem.Text = "Ventas";
            this.ventaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ventaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevaVentaToolStripMenuItem.Image")));
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(297, 42);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click_1);
            // 
            // historialDeVentasToolStripMenuItem
            // 
            this.historialDeVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historialDeVentasToolStripMenuItem.Image")));
            this.historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            this.historialDeVentasToolStripMenuItem.Size = new System.Drawing.Size(297, 42);
            this.historialDeVentasToolStripMenuItem.Text = "Historial de Ventas";
            this.historialDeVentasToolStripMenuItem.Click += new System.EventHandler(this.historialDeVentasToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gestionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionToolStripMenuItem.Image")));
            this.gestionToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(143, 96);
            this.gestionToolStripMenuItem.Text = "Proveedores";
            this.gestionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gestionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(110, 96);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sistemaToolStripMenuItem.Image")));
            this.sistemaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(101, 96);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sistemaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesiónToolStripMenuItem.Image")));
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(246, 42);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(246, 42);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbSesionIniciada
            // 
            this.gbSesionIniciada.Controls.Add(this.pictureBox2);
            this.gbSesionIniciada.Controls.Add(this.pictureBox1);
            this.gbSesionIniciada.Controls.Add(this.label5);
            this.gbSesionIniciada.Controls.Add(this.lblUsuarioLogueado);
            this.gbSesionIniciada.Controls.Add(this.label1);
            this.gbSesionIniciada.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSesionIniciada.Location = new System.Drawing.Point(17, 6);
            this.gbSesionIniciada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSesionIniciada.Name = "gbSesionIniciada";
            this.gbSesionIniciada.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSesionIniciada.Size = new System.Drawing.Size(225, 112);
            this.gbSesionIniciada.TabIndex = 11;
            this.gbSesionIniciada.TabStop = false;
            this.gbSesionIniciada.Text = "Sesión Iniciada";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Administrador";
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogueado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuarioLogueado.ImageIndex = 0;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(39, 31);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(74, 30);
            this.lblUsuarioLogueado.TabIndex = 12;
            this.lblUsuarioLogueado.Text = "Admin";
            this.lblUsuarioLogueado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(954, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(450, 112);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha y Hora";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(17, 31);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 24);
            this.lblHora.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(17, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 24);
            this.lblFecha.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbSesionIniciada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 950);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 125);
            this.panel1.TabIndex = 10;
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 175);
            this.contenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1440, 775);
            this.contenedor.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1440, 75);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblPetShop
            // 
            this.lblPetShop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPetShop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPetShop.ImageIndex = 0;
            this.lblPetShop.ImageList = this.imageList2;
            this.lblPetShop.Location = new System.Drawing.Point(11, 12);
            this.lblPetShop.Name = "lblPetShop";
            this.lblPetShop.Size = new System.Drawing.Size(225, 50);
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
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 1075);
            this.Controls.Add(this.lblPetShop);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShop - Sistema de Gestión Veterinaria";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.gbSesionIniciada.ResumeLayout(false);
            this.gbSesionIniciada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel object_e3c5580b_6d24_4dcc_8c22_cda8350d0a46;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Timer timer1;
        private GroupBox gbSesionIniciada;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label lblUsuarioLogueado;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblHora;
        private Label lblFecha;
        private Panel panel1;
        private Panel contenedor;
        private MenuStrip menuStrip1;
        private Label lblPetShop;
        private ImageList imageList2;
    }
}



