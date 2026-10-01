namespace PetShop.Presentacion.Usuarios
{
    partial class FormModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarUsuario));
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.LConfirmar = new System.Windows.Forms.Label();
            this.LFechaCreacion = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.LClave = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.LRol = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.GBSeguridad = new System.Windows.Forms.GroupBox();
            this.BVerConfirmar = new System.Windows.Forms.Button();
            this.BVerClave = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.LTitulo = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblPetShop = new System.Windows.Forms.Label();
            this.GBDatos.SuspendLayout();
            this.GBSeguridad.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(53, 131);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(314, 27);
            this.txtNombreUsuario.TabIndex = 103;
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(49, 107);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(144, 20);
            this.LNombreUsuario.TabIndex = 102;
            this.LNombreUsuario.Text = "Nombre de usuario";
            // 
            // textApellido
            // 
            this.textApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textApellido.Location = new System.Drawing.Point(574, 59);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(314, 27);
            this.textApellido.TabIndex = 101;
            // 
            // LApellido
            // 
            this.LApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(570, 31);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(67, 20);
            this.LApellido.TabIndex = 100;
            this.LApellido.Text = "Apellido";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmar.Location = new System.Drawing.Point(574, 60);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(267, 27);
            this.txtConfirmar.TabIndex = 98;
            this.txtConfirmar.UseSystemPasswordChar = true;
            this.txtConfirmar.Click += new System.EventHandler(this.BtnVerConfirmar_Click);
            // 
            // LConfirmar
            // 
            this.LConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LConfirmar.AutoSize = true;
            this.LConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmar.Location = new System.Drawing.Point(570, 37);
            this.LConfirmar.Name = "LConfirmar";
            this.LConfirmar.Size = new System.Drawing.Size(163, 20);
            this.LConfirmar.TabIndex = 97;
            this.LConfirmar.Text = "Confirmar Contraseña";
            // 
            // LFechaCreacion
            // 
            this.LFechaCreacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LFechaCreacion.AutoSize = true;
            this.LFechaCreacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaCreacion.Location = new System.Drawing.Point(431, 29);
            this.LFechaCreacion.Name = "LFechaCreacion";
            this.LFechaCreacion.Size = new System.Drawing.Size(140, 20);
            this.LFechaCreacion.TabIndex = 96;
            this.LFechaCreacion.Text = "Fecha De Creación:";
            this.LFechaCreacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClave.Location = new System.Drawing.Point(53, 60);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(267, 27);
            this.txtClave.TabIndex = 95;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.Click += new System.EventHandler(this.BtnVerClave_Click);
            // 
            // LClave
            // 
            this.LClave.AutoSize = true;
            this.LClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LClave.Location = new System.Drawing.Point(49, 37);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(88, 20);
            this.LClave.TabIndex = 94;
            this.LClave.Text = "Contraseña";
            // 
            // cbxRol
            // 
            this.cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(53, 125);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(314, 28);
            this.cbxRol.TabIndex = 91;
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textNombre.Location = new System.Drawing.Point(53, 59);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(314, 27);
            this.textNombre.TabIndex = 90;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LRol.Location = new System.Drawing.Point(49, 102);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(32, 20);
            this.LRol.TabIndex = 89;
            this.LRol.Text = "Rol";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(49, 35);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(67, 20);
            this.LNombre.TabIndex = 88;
            this.LNombre.Text = "Nombre";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(574, 125);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(314, 28);
            this.cbxEstado.TabIndex = 105;
            // 
            // LEstado
            // 
            this.LEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LEstado.Location = new System.Drawing.Point(570, 102);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(56, 20);
            this.LEstado.TabIndex = 104;
            this.LEstado.Text = "Estado";
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
            this.GBDatos.Controls.Add(this.textNombre);
            this.GBDatos.Controls.Add(this.LNombre);
            this.GBDatos.Controls.Add(this.LApellido);
            this.GBDatos.Controls.Add(this.txtNombreUsuario);
            this.GBDatos.Controls.Add(this.textApellido);
            this.GBDatos.Controls.Add(this.LNombreUsuario);
            this.GBDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDatos.ForeColor = System.Drawing.Color.Black;
            this.GBDatos.Location = new System.Drawing.Point(24, 52);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(938, 247);
            this.GBDatos.TabIndex = 106;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "Datos Personales";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(53, 201);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(314, 27);
            this.txtTelefono.TabIndex = 109;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(49, 178);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(70, 20);
            this.LTelefono.TabIndex = 108;
            this.LTelefono.Text = "Teléfono";
            // 
            // txtDni
            // 
            this.txtDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDni.Location = new System.Drawing.Point(574, 131);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(314, 27);
            this.txtDni.TabIndex = 105;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.Location = new System.Drawing.Point(574, 201);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(314, 27);
            this.txtCorreo.TabIndex = 107;
            // 
            // LCorreo
            // 
            this.LCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.Location = new System.Drawing.Point(570, 178);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(56, 20);
            this.LCorreo.TabIndex = 106;
            this.LCorreo.Text = "Correo";
            // 
            // LDni
            // 
            this.LDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(570, 107);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(37, 20);
            this.LDni.TabIndex = 104;
            this.LDni.Text = "DNI";
            // 
            // GBSeguridad
            // 
            this.GBSeguridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBSeguridad.Controls.Add(this.BVerConfirmar);
            this.GBSeguridad.Controls.Add(this.BVerClave);
            this.GBSeguridad.Controls.Add(this.txtClave);
            this.GBSeguridad.Controls.Add(this.LRol);
            this.GBSeguridad.Controls.Add(this.cbxEstado);
            this.GBSeguridad.Controls.Add(this.cbxRol);
            this.GBSeguridad.Controls.Add(this.LEstado);
            this.GBSeguridad.Controls.Add(this.LClave);
            this.GBSeguridad.Controls.Add(this.txtConfirmar);
            this.GBSeguridad.Controls.Add(this.LConfirmar);
            this.GBSeguridad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GBSeguridad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBSeguridad.Location = new System.Drawing.Point(24, 327);
            this.GBSeguridad.Name = "GBSeguridad";
            this.GBSeguridad.Size = new System.Drawing.Size(938, 173);
            this.GBSeguridad.TabIndex = 107;
            this.GBSeguridad.TabStop = false;
            this.GBSeguridad.Text = "Seguridad y Roles";
            // 
            // BVerConfirmar
            // 
            this.BVerConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BVerConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.BVerConfirmar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BVerConfirmar.Location = new System.Drawing.Point(850, 54);
            this.BVerConfirmar.Name = "BVerConfirmar";
            this.BVerConfirmar.Size = new System.Drawing.Size(38, 38);
            this.BVerConfirmar.TabIndex = 107;
            this.BVerConfirmar.Text = "👁";
            this.BVerConfirmar.UseVisualStyleBackColor = false;
            this.BVerConfirmar.Click += new System.EventHandler(this.BtnVerConfirmar_Click);
            // 
            // BVerClave
            // 
            this.BVerClave.BackColor = System.Drawing.Color.Transparent;
            this.BVerClave.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BVerClave.Location = new System.Drawing.Point(329, 54);
            this.BVerClave.Name = "BVerClave";
            this.BVerClave.Size = new System.Drawing.Size(38, 38);
            this.BVerClave.TabIndex = 106;
            this.BVerClave.Text = "👁";
            this.BVerClave.UseVisualStyleBackColor = false;
            this.BVerClave.Click += new System.EventHandler(this.BtnVerClave_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelContenedor.Controls.Add(this.btnVolver);
            this.PanelContenedor.Controls.Add(this.btnBorrar);
            this.PanelContenedor.Controls.Add(this.btnGuardar);
            this.PanelContenedor.Controls.Add(this.GBDatos);
            this.PanelContenedor.Controls.Add(this.LFechaCreacion);
            this.PanelContenedor.Controls.Add(this.GBSeguridad);
            this.PanelContenedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PanelContenedor.Location = new System.Drawing.Point(-9, 87);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(987, 611);
            this.PanelContenedor.TabIndex = 108;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.ImageIndex = 0;
            this.btnVolver.ImageList = this.imageList2;
            this.btnVolver.Location = new System.Drawing.Point(24, 515);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 60);
            this.btnVolver.TabIndex = 110;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Volver.png");
            this.imageList2.Images.SetKeyName(1, "Guardar.png");
            this.imageList2.Images.SetKeyName(2, "Eliminar.png");
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
            this.btnBorrar.ImageList = this.imageList2;
            this.btnBorrar.Location = new System.Drawing.Point(842, 515);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(120, 60);
            this.btnBorrar.TabIndex = 109;
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
            this.btnGuardar.ImageList = this.imageList2;
            this.btnGuardar.Location = new System.Drawing.Point(665, 515);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 60);
            this.btnGuardar.TabIndex = 108;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.Location = new System.Drawing.Point(340, 24);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(305, 40);
            this.LTitulo.TabIndex = 108;
            this.LTitulo.Text = "Modificar Usuario";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Huella_Perro.png");
            // 
            // lblPetShop
            // 
            this.lblPetShop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPetShop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPetShop.ImageKey = "Huella_Perro.png";
            this.lblPetShop.ImageList = this.imageList1;
            this.lblPetShop.Location = new System.Drawing.Point(10, 6);
            this.lblPetShop.Name = "lblPetShop";
            this.lblPetShop.Size = new System.Drawing.Size(186, 72);
            this.lblPetShop.TabIndex = 108;
            this.lblPetShop.Text = "PetShop";
            this.lblPetShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1100, 700);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 544);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.lblPetShop);
            this.Controls.Add(this.PanelContenedor);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Usuario ";
            this.Load += new System.EventHandler(this.FormModificarUsuario_Load);
            this.GBDatos.ResumeLayout(false);
            this.GBDatos.PerformLayout();
            this.GBSeguridad.ResumeLayout(false);
            this.GBSeguridad.PerformLayout();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label LConfirmar;
        private System.Windows.Forms.Label LFechaCreacion;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label LClave;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.GroupBox GBDatos;
        private System.Windows.Forms.GroupBox GBSeguridad;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label lblPetShop;
        private System.Windows.Forms.Button BVerClave;
        private System.Windows.Forms.Button BVerConfirmar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}