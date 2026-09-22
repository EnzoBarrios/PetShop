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
            this.BVolver = new System.Windows.Forms.Button();
            this.TNombreUsuario = new System.Windows.Forms.TextBox();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.TConfirmar = new System.Windows.Forms.TextBox();
            this.LConfirmar = new System.Windows.Forms.Label();
            this.LFechaCreacion = new System.Windows.Forms.Label();
            this.TClave = new System.Windows.Forms.TextBox();
            this.LClave = new System.Windows.Forms.Label();
            this.BEliminarTodo = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LRol = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.GBSeguridad = new System.Windows.Forms.GroupBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.lblPetShop = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.GBDatos.SuspendLayout();
            this.GBSeguridad.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // BVolver
            // 
            this.BVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVolver.Location = new System.Drawing.Point(15, 526);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(107, 43);
            this.BVolver.TabIndex = 62;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // TNombreUsuario
            // 
            this.TNombreUsuario.Location = new System.Drawing.Point(20, 131);
            this.TNombreUsuario.Name = "TNombreUsuario";
            this.TNombreUsuario.Size = new System.Drawing.Size(375, 26);
            this.TNombreUsuario.TabIndex = 103;
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(16, 107);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(160, 20);
            this.LNombreUsuario.TabIndex = 102;
            this.LNombreUsuario.Text = "Nombre de usuario";
            // 
            // TApellido
            // 
            this.TApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TApellido.Location = new System.Drawing.Point(424, 59);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(375, 26);
            this.TApellido.TabIndex = 101;
            // 
            // LApellido
            // 
            this.LApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(420, 31);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(73, 20);
            this.LApellido.TabIndex = 100;
            this.LApellido.Text = "Apellido";
            // 
            // TConfirmar
            // 
            this.TConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TConfirmar.Location = new System.Drawing.Point(424, 60);
            this.TConfirmar.Name = "TConfirmar";
            this.TConfirmar.Size = new System.Drawing.Size(375, 26);
            this.TConfirmar.TabIndex = 98;
            this.TConfirmar.UseSystemPasswordChar = true;
            // 
            // LConfirmar
            // 
            this.LConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LConfirmar.AutoSize = true;
            this.LConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmar.Location = new System.Drawing.Point(420, 37);
            this.LConfirmar.Name = "LConfirmar";
            this.LConfirmar.Size = new System.Drawing.Size(182, 20);
            this.LConfirmar.TabIndex = 97;
            this.LConfirmar.Text = "Confirmar contraseña";
            // 
            // LFechaCreacion
            // 
            this.LFechaCreacion.AutoSize = true;
            this.LFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaCreacion.Location = new System.Drawing.Point(442, 29);
            this.LFechaCreacion.Name = "LFechaCreacion";
            this.LFechaCreacion.Size = new System.Drawing.Size(201, 20);
            this.LFechaCreacion.TabIndex = 96;
            this.LFechaCreacion.Text = "FECHA DE CREACIÓN:";
            // 
            // TClave
            // 
            this.TClave.Location = new System.Drawing.Point(20, 60);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(375, 26);
            this.TClave.TabIndex = 95;
            this.TClave.UseSystemPasswordChar = true;
            // 
            // LClave
            // 
            this.LClave.AutoSize = true;
            this.LClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LClave.Location = new System.Drawing.Point(16, 37);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(102, 20);
            this.LClave.TabIndex = 94;
            this.LClave.Text = "Contraseña";
            // 
            // BEliminarTodo
            // 
            this.BEliminarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BEliminarTodo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BEliminarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEliminarTodo.FlatAppearance.BorderSize = 0;
            this.BEliminarTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BEliminarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BEliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminarTodo.Location = new System.Drawing.Point(669, 526);
            this.BEliminarTodo.Name = "BEliminarTodo";
            this.BEliminarTodo.Size = new System.Drawing.Size(167, 43);
            this.BEliminarTodo.TabIndex = 93;
            this.BEliminarTodo.Text = "Restablecer";
            this.BEliminarTodo.UseVisualStyleBackColor = false;
            this.BEliminarTodo.Click += new System.EventHandler(this.BEliminarTodo_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BGuardar.Location = new System.Drawing.Point(476, 526);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(167, 43);
            this.BGuardar.TabIndex = 92;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(20, 122);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(375, 28);
            this.CBRol.TabIndex = 91;
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TNombre.Location = new System.Drawing.Point(20, 59);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(375, 26);
            this.TNombre.TabIndex = 90;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(16, 102);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(36, 20);
            this.LRol.TabIndex = 89;
            this.LRol.Text = "Rol";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(16, 35);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(71, 20);
            this.LNombre.TabIndex = 88;
            this.LNombre.Text = "Nombre";
            // 
            // CBEstado
            // 
            this.CBEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(424, 125);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(375, 28);
            this.CBEstado.TabIndex = 105;
            // 
            // LEstado
            // 
            this.LEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(420, 102);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(66, 20);
            this.LEstado.TabIndex = 104;
            this.LEstado.Text = "Estado";
            // 
            // GBDatos
            // 
            this.GBDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBDatos.BackColor = System.Drawing.Color.Transparent;
            this.GBDatos.Controls.Add(this.TTelefono);
            this.GBDatos.Controls.Add(this.LTelefono);
            this.GBDatos.Controls.Add(this.TDni);
            this.GBDatos.Controls.Add(this.TCorreo);
            this.GBDatos.Controls.Add(this.LCorreo);
            this.GBDatos.Controls.Add(this.LDni);
            this.GBDatos.Controls.Add(this.TNombre);
            this.GBDatos.Controls.Add(this.LNombre);
            this.GBDatos.Controls.Add(this.LApellido);
            this.GBDatos.Controls.Add(this.TNombreUsuario);
            this.GBDatos.Controls.Add(this.TApellido);
            this.GBDatos.Controls.Add(this.LNombreUsuario);
            this.GBDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDatos.ForeColor = System.Drawing.Color.Black;
            this.GBDatos.Location = new System.Drawing.Point(15, 52);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(821, 247);
            this.GBDatos.TabIndex = 106;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "DATOS PERSONALES";
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(20, 201);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(375, 26);
            this.TTelefono.TabIndex = 109;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(16, 178);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(79, 20);
            this.LTelefono.TabIndex = 108;
            this.LTelefono.Text = "Teléfono";
            // 
            // TDni
            // 
            this.TDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TDni.Location = new System.Drawing.Point(424, 131);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(375, 26);
            this.TDni.TabIndex = 105;
            // 
            // TCorreo
            // 
            this.TCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TCorreo.Location = new System.Drawing.Point(424, 201);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(375, 26);
            this.TCorreo.TabIndex = 107;
            // 
            // LCorreo
            // 
            this.LCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.Location = new System.Drawing.Point(420, 178);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(63, 20);
            this.LCorreo.TabIndex = 106;
            this.LCorreo.Text = "Correo";
            // 
            // LDni
            // 
            this.LDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(420, 107);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(40, 20);
            this.LDni.TabIndex = 104;
            this.LDni.Text = "DNI";
            // 
            // GBSeguridad
            // 
            this.GBSeguridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBSeguridad.Controls.Add(this.TClave);
            this.GBSeguridad.Controls.Add(this.LRol);
            this.GBSeguridad.Controls.Add(this.CBEstado);
            this.GBSeguridad.Controls.Add(this.CBRol);
            this.GBSeguridad.Controls.Add(this.LEstado);
            this.GBSeguridad.Controls.Add(this.LClave);
            this.GBSeguridad.Controls.Add(this.TConfirmar);
            this.GBSeguridad.Controls.Add(this.LConfirmar);
            this.GBSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSeguridad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBSeguridad.Location = new System.Drawing.Point(15, 327);
            this.GBSeguridad.Name = "GBSeguridad";
            this.GBSeguridad.Size = new System.Drawing.Size(821, 173);
            this.GBSeguridad.TabIndex = 107;
            this.GBSeguridad.TabStop = false;
            this.GBSeguridad.Text = "SEGURIDAD Y ROLES";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.AutoScrollMinSize = new System.Drawing.Size(830, 620);
            this.PanelContenedor.Controls.Add(this.GBDatos);
            this.PanelContenedor.Controls.Add(this.BVolver);
            this.PanelContenedor.Controls.Add(this.LFechaCreacion);
            this.PanelContenedor.Controls.Add(this.BEliminarTodo);
            this.PanelContenedor.Controls.Add(this.GBSeguridad);
            this.PanelContenedor.Controls.Add(this.BGuardar);
            this.PanelContenedor.Location = new System.Drawing.Point(73, 87);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(850, 580);
            this.PanelContenedor.TabIndex = 108;
            // 
            // lblPetShop
            // 
            this.lblPetShop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPetShop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPetShop.ImageIndex = 0;
            this.lblPetShop.Location = new System.Drawing.Point(-9, -8);
            this.lblPetShop.Name = "lblPetShop";
            this.lblPetShop.Size = new System.Drawing.Size(185, 56);
            this.lblPetShop.TabIndex = 108;
            this.lblPetShop.Text = "PetShop";
            this.lblPetShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LTitulo.Location = new System.Drawing.Point(252, 24);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(444, 40);
            this.LTitulo.TabIndex = 108;
            this.LTitulo.Text = "- MODIFICAR USUARIO -";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LTitulo.Click += new System.EventHandler(this.LTitulo_Click);
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(850, 900);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 489);
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
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.TextBox TNombreUsuario;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TConfirmar;
        private System.Windows.Forms.Label LConfirmar;
        private System.Windows.Forms.Label LFechaCreacion;
        private System.Windows.Forms.TextBox TClave;
        private System.Windows.Forms.Label LClave;
        private System.Windows.Forms.Button BEliminarTodo;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.GroupBox GBDatos;
        private System.Windows.Forms.GroupBox GBSeguridad;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TCorreo;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label lblPetShop;
    }
}