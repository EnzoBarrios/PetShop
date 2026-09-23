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
            this.TClave = new System.Windows.Forms.TextBox();
            this.LClave = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LRol = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TConfirmar = new System.Windows.Forms.TextBox();
            this.LConfirmar = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.TNombreUsuario = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.lblPetShop = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.ImageList(this.components);
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.GBSeguridad = new System.Windows.Forms.GroupBox();
            this.BVerConfirmar = new System.Windows.Forms.Button();
            this.BVerClave = new System.Windows.Forms.Button();
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
            // TClave
            // 
            this.TClave.Location = new System.Drawing.Point(42, 51);
            this.TClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(238, 27);
            this.TClave.TabIndex = 78;
            this.TClave.UseSystemPasswordChar = true;
            // 
            // LClave
            // 
            this.LClave.AutoSize = true;
            this.LClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LClave.Location = new System.Drawing.Point(38, 33);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(91, 17);
            this.LClave.TabIndex = 77;
            this.LClave.Text = "Contraseña";
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.Location = new System.Drawing.Point(343, 26);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(328, 41);
            this.LTitulo.TabIndex = 73;
            this.LTitulo.Text = "Cargar Nuevo Usuario";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(42, 112);
            this.CBRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(280, 28);
            this.CBRol.TabIndex = 72;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(42, 53);
            this.TNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TNombre.MaxLength = 40;
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(280, 27);
            this.TNombre.TabIndex = 71;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(38, 94);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(32, 17);
            this.LRol.TabIndex = 70;
            this.LRol.Text = "Rol";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(38, 34);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(64, 17);
            this.LNombre.TabIndex = 69;
            this.LNombre.Text = "Nombre";
            // 
            // TConfirmar
            // 
            this.TConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TConfirmar.Location = new System.Drawing.Point(405, 51);
            this.TConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TConfirmar.Name = "TConfirmar";
            this.TConfirmar.Size = new System.Drawing.Size(238, 27);
            this.TConfirmar.TabIndex = 82;
            this.TConfirmar.UseSystemPasswordChar = true;
            // 
            // LConfirmar
            // 
            this.LConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LConfirmar.AutoSize = true;
            this.LConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmar.Location = new System.Drawing.Point(402, 33);
            this.LConfirmar.Name = "LConfirmar";
            this.LConfirmar.Size = new System.Drawing.Size(164, 17);
            this.LConfirmar.TabIndex = 81;
            this.LConfirmar.Text = "Confirmar contraseña";
            // 
            // LApellido
            // 
            this.LApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(402, 33);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(66, 17);
            this.LApellido.TabIndex = 84;
            this.LApellido.Text = "Apellido";
            // 
            // TApellido
            // 
            this.TApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TApellido.Location = new System.Drawing.Point(405, 53);
            this.TApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TApellido.MaxLength = 40;
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(280, 27);
            this.TApellido.TabIndex = 85;
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(38, 96);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(146, 17);
            this.LNombreUsuario.TabIndex = 86;
            this.LNombreUsuario.Text = "Nombre de usuario";
            // 
            // TNombreUsuario
            // 
            this.TNombreUsuario.Location = new System.Drawing.Point(42, 114);
            this.TNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TNombreUsuario.MaxLength = 15;
            this.TNombreUsuario.Name = "TNombreUsuario";
            this.TNombreUsuario.Size = new System.Drawing.Size(280, 27);
            this.TNombreUsuario.TabIndex = 87;
            // 
            // TDni
            // 
            this.TDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TDni.Location = new System.Drawing.Point(405, 114);
            this.TDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDni.MaxLength = 8;
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(280, 27);
            this.TDni.TabIndex = 89;
            // 
            // LDni
            // 
            this.LDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(402, 96);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(34, 17);
            this.LDni.TabIndex = 88;
            this.LDni.Text = "DNI";
            // 
            // TCorreo
            // 
            this.TCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TCorreo.Location = new System.Drawing.Point(405, 171);
            this.TCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TCorreo.MaxLength = 40;
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(280, 27);
            this.TCorreo.TabIndex = 91;
            // 
            // LCorreo
            // 
            this.LCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.Location = new System.Drawing.Point(402, 153);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(57, 17);
            this.LCorreo.TabIndex = 90;
            this.LCorreo.Text = "Correo";
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(42, 171);
            this.TTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TTelefono.MaxLength = 15;
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(280, 27);
            this.TTelefono.TabIndex = 93;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(38, 153);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(72, 17);
            this.LTelefono.TabIndex = 92;
            this.LTelefono.Text = "Teléfono";
            // 
            // lblPetShop
            // 
            this.lblPetShop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPetShop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPetShop.ImageIndex = 0;
            this.lblPetShop.ImageList = this.titulo;
            this.lblPetShop.Location = new System.Drawing.Point(11, 7);
            this.lblPetShop.Name = "lblPetShop";
            this.lblPetShop.Size = new System.Drawing.Size(189, 78);
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
            this.GBDatos.Controls.Add(this.TDni);
            this.GBDatos.Controls.Add(this.LNombre);
            this.GBDatos.Controls.Add(this.TCorreo);
            this.GBDatos.Controls.Add(this.TTelefono);
            this.GBDatos.Controls.Add(this.LCorreo);
            this.GBDatos.Controls.Add(this.LTelefono);
            this.GBDatos.Controls.Add(this.TNombre);
            this.GBDatos.Controls.Add(this.LApellido);
            this.GBDatos.Controls.Add(this.TApellido);
            this.GBDatos.Controls.Add(this.LNombreUsuario);
            this.GBDatos.Controls.Add(this.TNombreUsuario);
            this.GBDatos.Controls.Add(this.LDni);
            this.GBDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDatos.Location = new System.Drawing.Point(22, 15);
            this.GBDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBDatos.Size = new System.Drawing.Size(723, 206);
            this.GBDatos.TabIndex = 95;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos Personales y Contacto";
            // 
            // GBSeguridad
            // 
            this.GBSeguridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBSeguridad.Controls.Add(this.BVerConfirmar);
            this.GBSeguridad.Controls.Add(this.BVerClave);
            this.GBSeguridad.Controls.Add(this.TClave);
            this.GBSeguridad.Controls.Add(this.LClave);
            this.GBSeguridad.Controls.Add(this.LConfirmar);
            this.GBSeguridad.Controls.Add(this.TConfirmar);
            this.GBSeguridad.Controls.Add(this.CBRol);
            this.GBSeguridad.Controls.Add(this.LRol);
            this.GBSeguridad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSeguridad.Location = new System.Drawing.Point(22, 239);
            this.GBSeguridad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSeguridad.Name = "GBSeguridad";
            this.GBSeguridad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSeguridad.Size = new System.Drawing.Size(723, 151);
            this.GBSeguridad.TabIndex = 96;
            this.GBSeguridad.TabStop = false;
            this.GBSeguridad.Text = "Seguridad y Roles";
            // 
            // BVerConfirmar
            // 
            this.BVerConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BVerConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.BVerConfirmar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BVerConfirmar.Location = new System.Drawing.Point(651, 46);
            this.BVerConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BVerConfirmar.Name = "BVerConfirmar";
            this.BVerConfirmar.Size = new System.Drawing.Size(34, 30);
            this.BVerConfirmar.TabIndex = 84;
            this.BVerConfirmar.Text = "👁";
            this.BVerConfirmar.UseVisualStyleBackColor = false;
            this.BVerConfirmar.Click += new System.EventHandler(this.BVerConfirmar_Click);
            // 
            // BVerClave
            // 
            this.BVerClave.BackColor = System.Drawing.Color.Transparent;
            this.BVerClave.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BVerClave.Location = new System.Drawing.Point(287, 46);
            this.BVerClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BVerClave.Name = "BVerClave";
            this.BVerClave.Size = new System.Drawing.Size(34, 30);
            this.BVerClave.TabIndex = 83;
            this.BVerClave.Text = "👁";
            this.BVerClave.UseVisualStyleBackColor = false;
            this.BVerClave.Click += new System.EventHandler(this.BVerClave_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelContenedor.Controls.Add(this.btnVolver);
            this.PanelContenedor.Controls.Add(this.btnBorrar);
            this.PanelContenedor.Controls.Add(this.btnGuardar);
            this.PanelContenedor.Controls.Add(this.GBSeguridad);
            this.PanelContenedor.Controls.Add(this.GBDatos);
            this.PanelContenedor.Location = new System.Drawing.Point(136, 94);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(765, 466);
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
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1036, 559);
            this.Controls.Add(this.lblPetShop);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.PanelContenedor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCargaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCargaUsuario";
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
        private System.Windows.Forms.TextBox TClave;
        private System.Windows.Forms.Label LClave;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TConfirmar;
        private System.Windows.Forms.Label LConfirmar;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.TextBox TNombreUsuario;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TCorreo;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label lblPetShop;
        private System.Windows.Forms.GroupBox GBDatos;
        private System.Windows.Forms.GroupBox GBSeguridad;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button BVerClave;
        private System.Windows.Forms.Button BVerConfirmar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ImageList botones;
        private System.Windows.Forms.ImageList titulo;
    }
}