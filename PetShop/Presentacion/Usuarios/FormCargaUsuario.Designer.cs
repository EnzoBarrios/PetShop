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
            this.TClave = new System.Windows.Forms.TextBox();
            this.LClave = new System.Windows.Forms.Label();
            this.BEliminarTodo = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BVolver = new System.Windows.Forms.Button();
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
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.GBSeguridad = new System.Windows.Forms.GroupBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.GBDatos.SuspendLayout();
            this.GBSeguridad.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // TClave
            // 
            this.TClave.Location = new System.Drawing.Point(16, 64);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(375, 26);
            this.TClave.TabIndex = 78;
            this.TClave.UseSystemPasswordChar = true;
            // 
            // LClave
            // 
            this.LClave.AutoSize = true;
            this.LClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LClave.Location = new System.Drawing.Point(12, 41);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(102, 20);
            this.LClave.TabIndex = 77;
            this.LClave.Text = "Contraseña";
            // 
            // BEliminarTodo
            // 
            this.BEliminarTodo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BEliminarTodo.Location = new System.Drawing.Point(671, 512);
            this.BEliminarTodo.Name = "BEliminarTodo";
            this.BEliminarTodo.Size = new System.Drawing.Size(167, 43);
            this.BEliminarTodo.TabIndex = 76;
            this.BEliminarTodo.Text = "Eliminar todo";
            this.BEliminarTodo.UseVisualStyleBackColor = true;
            this.BEliminarTodo.Click += new System.EventHandler(this.BEliminarTodo_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.BGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Location = new System.Drawing.Point(487, 512);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(167, 43);
            this.BGuardar.TabIndex = 75;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(25, 512);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(107, 43);
            this.BVolver.TabIndex = 74;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LTitulo.Location = new System.Drawing.Point(233, 57);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(550, 40);
            this.LTitulo.TabIndex = 73;
            this.LTitulo.Text = "- CARGAR NUEVO USUARIO -";
            this.LTitulo.Click += new System.EventHandler(this.LTitulo_Click);
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(16, 140);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(375, 28);
            this.CBRol.TabIndex = 72;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(16, 66);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(375, 26);
            this.TNombre.TabIndex = 71;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(12, 117);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(36, 20);
            this.LRol.TabIndex = 70;
            this.LRol.Text = "Rol";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(12, 43);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(71, 20);
            this.LNombre.TabIndex = 69;
            this.LNombre.Text = "Nombre";
            // 
            // TConfirmar
            // 
            this.TConfirmar.Location = new System.Drawing.Point(425, 64);
            this.TConfirmar.Name = "TConfirmar";
            this.TConfirmar.Size = new System.Drawing.Size(375, 26);
            this.TConfirmar.TabIndex = 82;
            this.TConfirmar.UseSystemPasswordChar = true;
            // 
            // LConfirmar
            // 
            this.LConfirmar.AutoSize = true;
            this.LConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmar.Location = new System.Drawing.Point(421, 41);
            this.LConfirmar.Name = "LConfirmar";
            this.LConfirmar.Size = new System.Drawing.Size(182, 20);
            this.LConfirmar.TabIndex = 81;
            this.LConfirmar.Text = "Confirmar contraseña";
            // 
            // LApellido
            // 
            this.LApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(421, 41);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(73, 20);
            this.LApellido.TabIndex = 84;
            this.LApellido.Text = "Apellido";
            // 
            // TApellido
            // 
            this.TApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TApellido.Location = new System.Drawing.Point(425, 66);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(377, 26);
            this.TApellido.TabIndex = 85;
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(12, 120);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(160, 20);
            this.LNombreUsuario.TabIndex = 86;
            this.LNombreUsuario.Text = "Nombre de usuario";
            // 
            // TNombreUsuario
            // 
            this.TNombreUsuario.Location = new System.Drawing.Point(16, 143);
            this.TNombreUsuario.Name = "TNombreUsuario";
            this.TNombreUsuario.Size = new System.Drawing.Size(375, 26);
            this.TNombreUsuario.TabIndex = 87;
            // 
            // TDni
            // 
            this.TDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TDni.Location = new System.Drawing.Point(425, 143);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(375, 26);
            this.TDni.TabIndex = 89;
            // 
            // LDni
            // 
            this.LDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(421, 120);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(40, 20);
            this.LDni.TabIndex = 88;
            this.LDni.Text = "DNI";
            // 
            // TCorreo
            // 
            this.TCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TCorreo.Location = new System.Drawing.Point(425, 214);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(375, 26);
            this.TCorreo.TabIndex = 91;
            // 
            // LCorreo
            // 
            this.LCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.Location = new System.Drawing.Point(421, 191);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(63, 20);
            this.LCorreo.TabIndex = 90;
            this.LCorreo.Text = "Correo";
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(16, 214);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(375, 26);
            this.TTelefono.TabIndex = 93;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(12, 191);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(79, 20);
            this.LTelefono.TabIndex = 92;
            this.LTelefono.Text = "Teléfono";
            // 
            // lblPetShop
            // 
            this.lblPetShop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPetShop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPetShop.ImageIndex = 0;
            this.lblPetShop.Location = new System.Drawing.Point(12, 9);
            this.lblPetShop.Name = "lblPetShop";
            this.lblPetShop.Size = new System.Drawing.Size(183, 48);
            this.lblPetShop.TabIndex = 94;
            this.lblPetShop.Text = "PetShop";
            this.lblPetShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.GBDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDatos.Location = new System.Drawing.Point(25, 19);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(813, 257);
            this.GBDatos.TabIndex = 95;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "DATOS PERSONALES Y CONTACTO";
            // 
            // GBSeguridad
            // 
            this.GBSeguridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBSeguridad.Controls.Add(this.TClave);
            this.GBSeguridad.Controls.Add(this.LClave);
            this.GBSeguridad.Controls.Add(this.LConfirmar);
            this.GBSeguridad.Controls.Add(this.TConfirmar);
            this.GBSeguridad.Controls.Add(this.CBRol);
            this.GBSeguridad.Controls.Add(this.LRol);
            this.GBSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSeguridad.Location = new System.Drawing.Point(25, 299);
            this.GBSeguridad.Name = "GBSeguridad";
            this.GBSeguridad.Size = new System.Drawing.Size(813, 189);
            this.GBSeguridad.TabIndex = 96;
            this.GBSeguridad.TabStop = false;
            this.GBSeguridad.Text = "SEGURIDAD Y ROLES";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelContenedor.Controls.Add(this.GBSeguridad);
            this.PanelContenedor.Controls.Add(this.BGuardar);
            this.PanelContenedor.Controls.Add(this.BEliminarTodo);
            this.PanelContenedor.Controls.Add(this.GBDatos);
            this.PanelContenedor.Controls.Add(this.BVolver);
            this.PanelContenedor.Location = new System.Drawing.Point(78, 109);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(861, 569);
            this.PanelContenedor.TabIndex = 94;
            // 
            // FormCargaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 699);
            this.Controls.Add(this.lblPetShop);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.PanelContenedor);
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
        private System.Windows.Forms.Button BEliminarTodo;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BVolver;
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
    }
}