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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMiPerfil));
            this.lblPetShop = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BVolver = new System.Windows.Forms.Button();
            this.GBClave = new System.Windows.Forms.GroupBox();
            this.BVerConfirmar = new System.Windows.Forms.Button();
            this.BVerClave = new System.Windows.Forms.Button();
            this.TClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TConfirmar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GBDatosSistema = new System.Windows.Forms.GroupBox();
            this.TEstado = new System.Windows.Forms.TextBox();
            this.TRol = new System.Windows.Forms.TextBox();
            this.LRol = new System.Windows.Forms.Label();
            this.TNombreUsuario = new System.Windows.Forms.TextBox();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.LEstado = new System.Windows.Forms.Label();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TCorreo = new System.Windows.Forms.TextBox();
            this.LCorreo = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.PanelContenedor.SuspendLayout();
            this.GBClave.SuspendLayout();
            this.GBDatosSistema.SuspendLayout();
            this.GBDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPetShop
            // 
            this.lblPetShop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPetShop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShop.Image = ((System.Drawing.Image)(resources.GetObject("lblPetShop.Image")));
            this.lblPetShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPetShop.Location = new System.Drawing.Point(12, 9);
            this.lblPetShop.Name = "lblPetShop";
            this.lblPetShop.Size = new System.Drawing.Size(257, 72);
            this.lblPetShop.TabIndex = 109;
            this.lblPetShop.Text = "PetShop";
            this.lblPetShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LTitulo.Location = new System.Drawing.Point(312, 27);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(649, 40);
            this.LTitulo.TabIndex = 110;
            this.LTitulo.Text = "- MI PERFIL -";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.Controls.Add(this.BGuardar);
            this.PanelContenedor.Controls.Add(this.BVolver);
            this.PanelContenedor.Controls.Add(this.GBClave);
            this.PanelContenedor.Controls.Add(this.GBDatosSistema);
            this.PanelContenedor.Controls.Add(this.GBDatos);
            this.PanelContenedor.Location = new System.Drawing.Point(9, 100);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1214, 766);
            this.PanelContenedor.TabIndex = 111;
            // 
            // BGuardar
            // 
            this.BGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.BGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.Image = global::PetShop.Properties.Resources.guardar;
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(984, 674);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(204, 61);
            this.BGuardar.TabIndex = 112;
            this.BGuardar.Text = "Guardar cambios";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BVolver
            // 
            this.BVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVolver.Image = global::PetShop.Properties.Resources.volver;
            this.BVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVolver.Location = new System.Drawing.Point(26, 674);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(128, 61);
            this.BVolver.TabIndex = 111;
            this.BVolver.Text = "Volver";
            this.BVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // GBClave
            // 
            this.GBClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBClave.Controls.Add(this.BVerConfirmar);
            this.GBClave.Controls.Add(this.BVerClave);
            this.GBClave.Controls.Add(this.TClave);
            this.GBClave.Controls.Add(this.label3);
            this.GBClave.Controls.Add(this.TConfirmar);
            this.GBClave.Controls.Add(this.label4);
            this.GBClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBClave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBClave.Location = new System.Drawing.Point(26, 525);
            this.GBClave.Name = "GBClave";
            this.GBClave.Size = new System.Drawing.Size(1162, 109);
            this.GBClave.TabIndex = 109;
            this.GBClave.TabStop = false;
            this.GBClave.Text = "CAMBIAR CONTRASEÑA";
            // 
            // BVerConfirmar
            // 
            this.BVerConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BVerConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.BVerConfirmar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BVerConfirmar.Location = new System.Drawing.Point(1074, 54);
            this.BVerConfirmar.Name = "BVerConfirmar";
            this.BVerConfirmar.Size = new System.Drawing.Size(38, 38);
            this.BVerConfirmar.TabIndex = 107;
            this.BVerConfirmar.Text = "👁";
            this.BVerConfirmar.UseVisualStyleBackColor = false;
            this.BVerConfirmar.Click += new System.EventHandler(this.BVerConfirmar_Click);
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
            this.BVerClave.Click += new System.EventHandler(this.BVerClave_Click);
            // 
            // TClave
            // 
            this.TClave.Location = new System.Drawing.Point(53, 60);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(267, 26);
            this.TClave.TabIndex = 95;
            this.TClave.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "Contraseña";
            // 
            // TConfirmar
            // 
            this.TConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TConfirmar.Location = new System.Drawing.Point(798, 60);
            this.TConfirmar.Name = "TConfirmar";
            this.TConfirmar.Size = new System.Drawing.Size(267, 26);
            this.TConfirmar.TabIndex = 98;
            this.TConfirmar.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(794, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Confirmar contraseña";
            // 
            // GBDatosSistema
            // 
            this.GBDatosSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBDatosSistema.Controls.Add(this.TEstado);
            this.GBDatosSistema.Controls.Add(this.TRol);
            this.GBDatosSistema.Controls.Add(this.LRol);
            this.GBDatosSistema.Controls.Add(this.TNombreUsuario);
            this.GBDatosSistema.Controls.Add(this.LNombreUsuario);
            this.GBDatosSistema.Controls.Add(this.LEstado);
            this.GBDatosSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDatosSistema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBDatosSistema.Location = new System.Drawing.Point(26, 305);
            this.GBDatosSistema.Name = "GBDatosSistema";
            this.GBDatosSistema.Size = new System.Drawing.Size(1162, 190);
            this.GBDatosSistema.TabIndex = 108;
            this.GBDatosSistema.TabStop = false;
            this.GBDatosSistema.Text = "DATOS DEL SISTEMA";
            // 
            // TEstado
            // 
            this.TEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TEstado.Location = new System.Drawing.Point(798, 94);
            this.TEstado.Name = "TEstado";
            this.TEstado.Size = new System.Drawing.Size(314, 26);
            this.TEstado.TabIndex = 106;
            // 
            // TRol
            // 
            this.TRol.Location = new System.Drawing.Point(53, 139);
            this.TRol.Name = "TRol";
            this.TRol.Size = new System.Drawing.Size(314, 26);
            this.TRol.TabIndex = 105;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(49, 116);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(36, 20);
            this.LRol.TabIndex = 89;
            this.LRol.Text = "Rol";
            // 
            // TNombreUsuario
            // 
            this.TNombreUsuario.Location = new System.Drawing.Point(53, 62);
            this.TNombreUsuario.Name = "TNombreUsuario";
            this.TNombreUsuario.Size = new System.Drawing.Size(314, 26);
            this.TNombreUsuario.TabIndex = 103;
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(49, 39);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(160, 20);
            this.LNombreUsuario.TabIndex = 102;
            this.LNombreUsuario.Text = "Nombre de usuario";
            // 
            // LEstado
            // 
            this.LEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(794, 71);
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
            this.GBDatos.Controls.Add(this.TApellido);
            this.GBDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDatos.ForeColor = System.Drawing.Color.Black;
            this.GBDatos.Location = new System.Drawing.Point(26, 32);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(1162, 247);
            this.GBDatos.TabIndex = 107;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "DATOS PERSONALES Y CONTACTO";
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(53, 201);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(314, 26);
            this.TTelefono.TabIndex = 109;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(49, 178);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(79, 20);
            this.LTelefono.TabIndex = 108;
            this.LTelefono.Text = "Teléfono";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(53, 132);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(314, 26);
            this.TDni.TabIndex = 105;
            // 
            // TCorreo
            // 
            this.TCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TCorreo.Location = new System.Drawing.Point(798, 201);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Size = new System.Drawing.Size(314, 26);
            this.TCorreo.TabIndex = 107;
            // 
            // LCorreo
            // 
            this.LCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LCorreo.AutoSize = true;
            this.LCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreo.Location = new System.Drawing.Point(794, 178);
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
            this.LDni.Location = new System.Drawing.Point(49, 109);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(40, 20);
            this.LDni.TabIndex = 104;
            this.LDni.Text = "DNI";
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TNombre.Location = new System.Drawing.Point(53, 59);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(314, 26);
            this.TNombre.TabIndex = 90;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(49, 35);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(71, 20);
            this.LNombre.TabIndex = 88;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(794, 31);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(73, 20);
            this.LApellido.TabIndex = 100;
            this.LApellido.Text = "Apellido";
            // 
            // TApellido
            // 
            this.TApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TApellido.Location = new System.Drawing.Point(798, 59);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(314, 26);
            this.TApellido.TabIndex = 101;
            // 
            // FormMiPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1300, 1200);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1258, 564);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.lblPetShop);
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

        private System.Windows.Forms.Label lblPetShop;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.GroupBox GBDatos;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.TextBox TNombreUsuario;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TCorreo;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.GroupBox GBDatosSistema;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.GroupBox GBClave;
        private System.Windows.Forms.Button BVerConfirmar;
        private System.Windows.Forms.Button BVerClave;
        private System.Windows.Forms.TextBox TClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TConfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.TextBox TEstado;
        private System.Windows.Forms.TextBox TRol;
    }
}