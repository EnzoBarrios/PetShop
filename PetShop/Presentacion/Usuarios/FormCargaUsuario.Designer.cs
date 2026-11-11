namespace PetShop.Presentacion.Usuarios
{
    partial class FormCargaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargaUsuario));
            this.txtClave = new System.Windows.Forms.TextBox();
            this.LClave = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LRol = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.LConfirmar = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.txtpellido = new System.Windows.Forms.TextBox();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.lblPetShop = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.ImageList(this.components);
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.GBSeguridad = new System.Windows.Forms.GroupBox();
            this.btnVerConfirmar = new System.Windows.Forms.Button();
            this.btnVerClave = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.botones = new System.Windows.Forms.ImageList(this.components);
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.GBDatos.SuspendLayout();
            this.GBSeguridad.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClave.Location = new System.Drawing.Point(35, 52);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClave.MaxLength = 255;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(238, 27);
            this.txtClave.TabIndex = 78;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // LClave
            // 
            this.LClave.AutoSize = true;
            this.LClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LClave.Location = new System.Drawing.Point(30, 30);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(88, 20);
            this.LClave.TabIndex = 77;
            this.LClave.Text = "Contraseña";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(367, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(328, 41);
            this.lblTitulo.TabIndex = 73;
            this.lblTitulo.Text = "Cargar Nuevo Usuario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxRol
            // 
            this.cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(34, 112);
            this.cbxRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(280, 28);
            this.cbxRol.TabIndex = 72;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(34, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 27);
            this.txtNombre.TabIndex = 71;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(30, 90);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(32, 20);
            this.LRol.TabIndex = 70;
            this.LRol.Text = "Rol";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(30, 30);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(67, 20);
            this.LNombre.TabIndex = 69;
            this.LNombre.Text = "Nombre";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmar.Location = new System.Drawing.Point(402, 52);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmar.MaxLength = 255;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(238, 27);
            this.txtConfirmar.TabIndex = 82;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // LConfirmar
            // 
            this.LConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LConfirmar.AutoSize = true;
            this.LConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmar.Location = new System.Drawing.Point(400, 30);
            this.LConfirmar.Name = "LConfirmar";
            this.LConfirmar.Size = new System.Drawing.Size(161, 20);
            this.LConfirmar.TabIndex = 81;
            this.LConfirmar.Text = "Confirmar contraseña";
            // 
            // LApellido
            // 
            this.LApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LApellido.Location = new System.Drawing.Point(397, 30);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(67, 20);
            this.LApellido.TabIndex = 84;
            this.LApellido.Text = "Apellido";
            // 
            // txtpellido
            // 
            this.txtpellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpellido.Location = new System.Drawing.Point(401, 52);
            this.txtpellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpellido.MaxLength = 40;
            this.txtpellido.Name = "txtpellido";
            this.txtpellido.Size = new System.Drawing.Size(280, 27);
            this.txtpellido.TabIndex = 85;
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LNombreUsuario.Location = new System.Drawing.Point(30, 90);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(144, 20);
            this.LNombreUsuario.TabIndex = 86;
            this.LNombreUsuario.Text = "Nombre de usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(34, 112);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreUsuario.MaxLength = 50;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(280, 27);
            this.txtNombreUsuario.TabIndex = 87;
            // 
            // txtDni
            // 
            this.txtDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDni.Location = new System.Drawing.Point(402, 112);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(280, 27);
            this.txtDni.TabIndex = 89;
            // 
            // LDni
            // 
            this.LDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LDni.Location = new System.Drawing.Point(397, 90);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(37, 20);
            this.LDni.TabIndex = 88;
            this.LDni.Text = "DNI";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.Location = new System.Drawing.Point(402, 172);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(280, 27);
            this.txtCorreo.TabIndex = 91;
            // 
            // LCorreo
            // 
            this.LCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LCorreo.Location = new System.Drawing.Point(397, 150);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(56, 20);
            this.LCorreo.TabIndex = 90;
            this.LCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(34, 172);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(280, 27);
            this.txtTelefono.TabIndex = 93;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LTelefono.Location = new System.Drawing.Point(30, 150);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(70, 20);
            this.LTelefono.TabIndex = 92;
            this.LTelefono.Text = "Teléfono";
            // 
            // lblPetShop
            // 
            this.lblPetShop.BackColor = System.Drawing.Color.Transparent;
            this.lblPetShop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPetShop.ImageIndex = 0;
            this.lblPetShop.ImageList = this.titulo;
            this.lblPetShop.Location = new System.Drawing.Point(28, 10);
            this.lblPetShop.Name = "lblPetShop";
            this.lblPetShop.Size = new System.Drawing.Size(200, 60);
            this.lblPetShop.TabIndex = 94;
            this.lblPetShop.Text = "PetShop";
            this.lblPetShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titulo
            // 
            this.titulo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("titulo.ImageStream")));
            this.titulo.TransparentColor = System.Drawing.Color.Transparent;
            this.titulo.Images.SetKeyName(0, "Huella_Perro.png");
            // 
            // GBDatos
            // 
            this.GBDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBDatos.Controls.Add(this.txtDni);
            this.GBDatos.Controls.Add(this.LNombre);
            this.GBDatos.Controls.Add(this.txtCorreo);
            this.GBDatos.Controls.Add(this.txtTelefono);
            this.GBDatos.Controls.Add(this.LCorreo);
            this.GBDatos.Controls.Add(this.LTelefono);
            this.GBDatos.Controls.Add(this.txtNombre);
            this.GBDatos.Controls.Add(this.LApellido);
            this.GBDatos.Controls.Add(this.txtpellido);
            this.GBDatos.Controls.Add(this.LNombreUsuario);
            this.GBDatos.Controls.Add(this.txtNombreUsuario);
            this.GBDatos.Controls.Add(this.LDni);
            this.GBDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDatos.Location = new System.Drawing.Point(22, 15);
            this.GBDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBDatos.Size = new System.Drawing.Size(720, 210);
            this.GBDatos.TabIndex = 95;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos Personales y Contacto";
            // 
            // GBSeguridad
            // 
            this.GBSeguridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBSeguridad.Controls.Add(this.btnVerConfirmar);
            this.GBSeguridad.Controls.Add(this.btnVerClave);
            this.GBSeguridad.Controls.Add(this.txtClave);
            this.GBSeguridad.Controls.Add(this.LClave);
            this.GBSeguridad.Controls.Add(this.LConfirmar);
            this.GBSeguridad.Controls.Add(this.txtConfirmar);
            this.GBSeguridad.Controls.Add(this.cbxRol);
            this.GBSeguridad.Controls.Add(this.LRol);
            this.GBSeguridad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSeguridad.Location = new System.Drawing.Point(22, 239);
            this.GBSeguridad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSeguridad.Name = "GBSeguridad";
            this.GBSeguridad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSeguridad.Size = new System.Drawing.Size(720, 150);
            this.GBSeguridad.TabIndex = 96;
            this.GBSeguridad.TabStop = false;
            this.GBSeguridad.Text = "Seguridad y Roles";
            // 
            // btnVerConfirmar
            // 
            this.btnVerConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnVerConfirmar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVerConfirmar.Location = new System.Drawing.Point(646, 51);
            this.btnVerConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerConfirmar.Name = "btnVerConfirmar";
            this.btnVerConfirmar.Size = new System.Drawing.Size(34, 30);
            this.btnVerConfirmar.TabIndex = 84;
            this.btnVerConfirmar.Text = "👁";
            this.btnVerConfirmar.UseVisualStyleBackColor = false;
            this.btnVerConfirmar.Click += new System.EventHandler(this.BtnVerConfirmar_Click);
            // 
            // btnVerClave
            // 
            this.btnVerClave.BackColor = System.Drawing.Color.Transparent;
            this.btnVerClave.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVerClave.Location = new System.Drawing.Point(279, 51);
            this.btnVerClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerClave.Name = "btnVerClave";
            this.btnVerClave.Size = new System.Drawing.Size(34, 30);
            this.btnVerClave.TabIndex = 83;
            this.btnVerClave.Text = "👁";
            this.btnVerClave.UseVisualStyleBackColor = false;
            this.btnVerClave.Click += new System.EventHandler(this.BtnVerClave_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelContenedor.Controls.Add(this.btnVolver);
            this.PanelContenedor.Controls.Add(this.btnBorrar);
            this.PanelContenedor.Controls.Add(this.btnGuardar);
            this.PanelContenedor.Controls.Add(this.GBSeguridad);
            this.PanelContenedor.Controls.Add(this.GBDatos);
            this.PanelContenedor.Location = new System.Drawing.Point(149, 87);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(765, 480);
            this.PanelContenedor.TabIndex = 94;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.ImageIndex = 0;
            this.btnVolver.ImageList = this.botones;
            this.btnVolver.Location = new System.Drawing.Point(22, 403);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 60);
            this.btnVolver.TabIndex = 113;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // botones
            // 
            this.botones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("botones.ImageStream")));
            this.botones.TransparentColor = System.Drawing.Color.Transparent;
            this.botones.Images.SetKeyName(0, "Volver.png");
            this.botones.Images.SetKeyName(1, "Guardar.png");
            this.botones.Images.SetKeyName(2, "Eliminar.png");
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.ImageIndex = 2;
            this.btnBorrar.ImageList = this.botones;
            this.btnBorrar.Location = new System.Drawing.Point(625, 403);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(120, 60);
            this.btnBorrar.TabIndex = 112;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.ImageIndex = 1;
            this.btnGuardar.ImageList = this.botones;
            this.btnGuardar.Location = new System.Drawing.Point(483, 403);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 60);
            this.btnGuardar.TabIndex = 111;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FormCargaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 573);
            this.Controls.Add(this.lblPetShop);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.PanelContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(980, 600);
            this.Name = "FormCargaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormCargaUsuario_Load);
            this.GBDatos.ResumeLayout(false);
            this.GBDatos.PerformLayout();
            this.GBSeguridad.ResumeLayout(false);
            this.GBSeguridad.PerformLayout();
            this.PanelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label LClave;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label LConfirmar;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox txtpellido;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label lblPetShop;
        private System.Windows.Forms.GroupBox GBDatos;
        private System.Windows.Forms.GroupBox GBSeguridad;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button btnVerClave;
        private System.Windows.Forms.Button btnVerConfirmar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ImageList botones;
        private System.Windows.Forms.ImageList titulo;
    }
}