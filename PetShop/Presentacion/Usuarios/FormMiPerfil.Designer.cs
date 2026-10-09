namespace PetShop.Presentacion.Usuarios
{
    partial class FormMiPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMiPerfil));
            this.LTitulo = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.ImageList(this.components);
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Botones = new System.Windows.Forms.ImageList(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.GBClave = new System.Windows.Forms.GroupBox();
            this.BVerConfirmar = new System.Windows.Forms.Button();
            this.BVerClave = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GBDatosSistema = new System.Windows.Forms.GroupBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.LRol = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblPetShop = new System.Windows.Forms.Label();
            this.PanelContenedor.SuspendLayout();
            this.GBClave.SuspendLayout();
            this.GBDatosSistema.SuspendLayout();
            this.GBDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.ImageList = this.Titulo;
            this.LTitulo.Location = new System.Drawing.Point(362, 20);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(557, 41);
            this.LTitulo.TabIndex = 110;
            this.LTitulo.Text = "Mi Perfil";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titulo
            // 
            this.Titulo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Titulo.ImageStream")));
            this.Titulo.TransparentColor = System.Drawing.Color.Transparent;
            this.Titulo.Images.SetKeyName(0, "Huella_Perro.png");
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.Controls.Add(this.btnGuardar);
            this.PanelContenedor.Controls.Add(this.btnVolver);
            this.PanelContenedor.Controls.Add(this.GBClave);
            this.PanelContenedor.Controls.Add(this.GBDatosSistema);
            this.PanelContenedor.Controls.Add(this.GBDatos);
            this.PanelContenedor.Location = new System.Drawing.Point(111, 80);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1059, 538);
            this.PanelContenedor.TabIndex = 111;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.ImageIndex = 1;
            this.btnGuardar.ImageList = this.Botones;
            this.btnGuardar.Location = new System.Drawing.Point(916, 467);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 60);
            this.btnGuardar.TabIndex = 112;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Botones
            // 
            this.Botones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Botones.ImageStream")));
            this.Botones.TransparentColor = System.Drawing.Color.Transparent;
            this.Botones.Images.SetKeyName(0, "Volver.png");
            this.Botones.Images.SetKeyName(1, "Guardar.png");
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.ImageIndex = 0;
            this.btnVolver.ImageList = this.Botones;
            this.btnVolver.Location = new System.Drawing.Point(23, 467);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 60);
            this.btnVolver.TabIndex = 111;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // GBClave
            // 
            this.GBClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBClave.Controls.Add(this.BVerConfirmar);
            this.GBClave.Controls.Add(this.BVerClave);
            this.GBClave.Controls.Add(this.txtClave);
            this.GBClave.Controls.Add(this.label3);
            this.GBClave.Controls.Add(this.txtConfirmar);
            this.GBClave.Controls.Add(this.label4);
            this.GBClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GBClave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBClave.Location = new System.Drawing.Point(23, 353);
            this.GBClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBClave.Name = "GBClave";
            this.GBClave.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBClave.Size = new System.Drawing.Size(1013, 98);
            this.GBClave.TabIndex = 109;
            this.GBClave.TabStop = false;
            this.GBClave.Text = "Cambiar Contraseña";
            // 
            // BVerConfirmar
            // 
            this.BVerConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BVerConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.BVerConfirmar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BVerConfirmar.Location = new System.Drawing.Point(935, 47);
            this.BVerConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BVerConfirmar.Name = "BVerConfirmar";
            this.BVerConfirmar.Size = new System.Drawing.Size(34, 30);
            this.BVerConfirmar.TabIndex = 107;
            this.BVerConfirmar.Text = "👁";
            this.BVerConfirmar.UseVisualStyleBackColor = false;
            this.BVerConfirmar.Click += new System.EventHandler(this.BtnVerConfirmar_Click);
            // 
            // BVerClave
            // 
            this.BVerClave.BackColor = System.Drawing.Color.Transparent;
            this.BVerClave.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BVerClave.Location = new System.Drawing.Point(291, 47);
            this.BVerClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BVerClave.Name = "BVerClave";
            this.BVerClave.Size = new System.Drawing.Size(34, 30);
            this.BVerClave.TabIndex = 106;
            this.BVerClave.Text = "👁";
            this.BVerClave.UseVisualStyleBackColor = false;
            this.BVerClave.Click += new System.EventHandler(this.BtnVerClave_Click);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClave.Location = new System.Drawing.Point(47, 48);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(238, 27);
            this.txtClave.TabIndex = 95;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Contraseña";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmar.Location = new System.Drawing.Point(689, 48);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(238, 27);
            this.txtConfirmar.TabIndex = 98;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(686, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 97;
            this.label4.Text = "Confirmar contraseña";
            // 
            // GBDatosSistema
            // 
            this.GBDatosSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBDatosSistema.Controls.Add(this.txtRol);
            this.GBDatosSistema.Controls.Add(this.LRol);
            this.GBDatosSistema.Controls.Add(this.txtNombreUsuario);
            this.GBDatosSistema.Controls.Add(this.LNombreUsuario);
            this.GBDatosSistema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GBDatosSistema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBDatosSistema.Location = new System.Drawing.Point(23, 224);
            this.GBDatosSistema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBDatosSistema.Name = "GBDatosSistema";
            this.GBDatosSistema.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBDatosSistema.Size = new System.Drawing.Size(1013, 125);
            this.GBDatosSistema.TabIndex = 108;
            this.GBDatosSistema.TabStop = false;
            this.GBDatosSistema.Text = "Datos del Sistema";
            // 
            // txtRol
            // 
            this.txtRol.Enabled = false;
            this.txtRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRol.Location = new System.Drawing.Point(685, 64);
            this.txtRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRol.Name = "txtRol";
            this.txtRol.ReadOnly = true;
            this.txtRol.Size = new System.Drawing.Size(280, 27);
            this.txtRol.TabIndex = 105;
            this.txtRol.TabStop = false;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(682, 46);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(32, 17);
            this.LRol.TabIndex = 89;
            this.LRol.Text = "Rol";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(47, 64);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(280, 27);
            this.txtNombreUsuario.TabIndex = 103;
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(44, 45);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(146, 17);
            this.LNombreUsuario.TabIndex = 102;
            this.LNombreUsuario.Text = "Nombre de usuario";
            // 
            // GBDatos
            // 
            this.GBDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBDatos.BackColor = System.Drawing.Color.Transparent;
            this.GBDatos.Controls.Add(this.txtTelefono);
            this.GBDatos.Controls.Add(this.LTelefono);
            this.GBDatos.Controls.Add(this.txtDni);
            this.GBDatos.Controls.Add(this.txtCorreo);
            this.GBDatos.Controls.Add(this.LCorreo);
            this.GBDatos.Controls.Add(this.LDni);
            this.GBDatos.Controls.Add(this.txtNombre);
            this.GBDatos.Controls.Add(this.LNombre);
            this.GBDatos.Controls.Add(this.LApellido);
            this.GBDatos.Controls.Add(this.txtApellido);
            this.GBDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GBDatos.ForeColor = System.Drawing.Color.Black;
            this.GBDatos.Location = new System.Drawing.Point(23, 2);
            this.GBDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBDatos.Size = new System.Drawing.Size(1013, 218);
            this.GBDatos.TabIndex = 107;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos Personales y Contacto";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(47, 161);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(280, 27);
            this.txtTelefono.TabIndex = 109;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(44, 142);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(72, 17);
            this.LTelefono.TabIndex = 108;
            this.LTelefono.Text = "Teléfono";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDni.Location = new System.Drawing.Point(47, 106);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(280, 27);
            this.txtDni.TabIndex = 105;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.Location = new System.Drawing.Point(689, 161);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(280, 27);
            this.txtCorreo.TabIndex = 107;
            // 
            // LCorreo
            // 
            this.LCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.Location = new System.Drawing.Point(686, 142);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(57, 17);
            this.LCorreo.TabIndex = 106;
            this.LCorreo.Text = "Correo";
            // 
            // LDni
            // 
            this.LDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(44, 87);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(34, 17);
            this.LDni.TabIndex = 104;
            this.LDni.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(47, 47);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 27);
            this.txtNombre.TabIndex = 90;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(44, 28);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(64, 17);
            this.LNombre.TabIndex = 88;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(686, 25);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(66, 17);
            this.LApellido.TabIndex = 100;
            this.LApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.Location = new System.Drawing.Point(689, 47);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(280, 27);
            this.txtApellido.TabIndex = 101;
            // 
            // lblPetShop
            // 
            this.lblPetShop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPetShop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPetShop.ImageKey = "Huella_Perro.png";
            this.lblPetShop.ImageList = this.Titulo;
            this.lblPetShop.Location = new System.Drawing.Point(10, 5);
            this.lblPetShop.Name = "lblPetShop";
            this.lblPetShop.Size = new System.Drawing.Size(186, 72);
            this.lblPetShop.TabIndex = 113;
            this.lblPetShop.Text = "PetShop";
            this.lblPetShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMiPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.lblPetShop);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.LTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMiPerfil";
            this.Load += new System.EventHandler(this.FormMiPerfil_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.GBClave.ResumeLayout(false);
            this.GBClave.PerformLayout();
            this.GBDatosSistema.ResumeLayout(false);
            this.GBDatosSistema.PerformLayout();
            this.GBDatos.ResumeLayout(false);
            this.GBDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.GroupBox GBDatos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox GBDatosSistema;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.GroupBox GBClave;
        private System.Windows.Forms.Button BVerConfirmar;
        private System.Windows.Forms.Button BVerClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.ImageList Titulo;
        private System.Windows.Forms.Label lblPetShop;
        private System.Windows.Forms.ImageList Botones;
    }
}