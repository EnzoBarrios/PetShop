namespace PetShop
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
            this.LTitulo = new System.Windows.Forms.Label();
            this.TNombreUsuario = new System.Windows.Forms.TextBox();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.TConfirmar = new System.Windows.Forms.TextBox();
            this.LConfirmar = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
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
            this.GBSeguridad = new System.Windows.Forms.GroupBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.GBDatos.SuspendLayout();
            this.GBSeguridad.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // BVolver
            // 
            this.BVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVolver.Location = new System.Drawing.Point(24, 453);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(107, 43);
            this.BVolver.TabIndex = 62;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            // 
            // LTitulo
            // 
            this.LTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.LTitulo.Location = new System.Drawing.Point(0, 0);
            this.LTitulo.Margin = new System.Windows.Forms.Padding(11, 0, 7, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Padding = new System.Windows.Forms.Padding(15, 20, 0, 0);
            this.LTitulo.Size = new System.Drawing.Size(889, 48);
            this.LTitulo.TabIndex = 61;
            this.LTitulo.Text = "- MODIFICAR USUARIO -";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LTitulo.Click += new System.EventHandler(this.LTitulo_Click);
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
            this.TApellido.Location = new System.Drawing.Point(432, 56);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(366, 26);
            this.TApellido.TabIndex = 101;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(428, 31);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(73, 20);
            this.LApellido.TabIndex = 100;
            this.LApellido.Text = "Apellido";
            // 
            // TConfirmar
            // 
            this.TConfirmar.Location = new System.Drawing.Point(20, 61);
            this.TConfirmar.Name = "TConfirmar";
            this.TConfirmar.Size = new System.Drawing.Size(375, 26);
            this.TConfirmar.TabIndex = 98;
            // 
            // LConfirmar
            // 
            this.LConfirmar.AutoSize = true;
            this.LConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmar.Location = new System.Drawing.Point(428, 37);
            this.LConfirmar.Name = "LConfirmar";
            this.LConfirmar.Size = new System.Drawing.Size(182, 20);
            this.LConfirmar.TabIndex = 97;
            this.LConfirmar.Text = "Confirmar contraseña";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.Location = new System.Drawing.Point(428, 137);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(162, 20);
            this.LFecha.TabIndex = 96;
            this.LFecha.Text = "Fecha de creación:";
            this.LFecha.Click += new System.EventHandler(this.LFecha_Click);
            // 
            // TClave
            // 
            this.TClave.Location = new System.Drawing.Point(432, 61);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(366, 26);
            this.TClave.TabIndex = 95;
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
            this.BEliminarTodo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BEliminarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEliminarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminarTodo.Location = new System.Drawing.Point(675, 453);
            this.BEliminarTodo.Name = "BEliminarTodo";
            this.BEliminarTodo.Size = new System.Drawing.Size(167, 43);
            this.BEliminarTodo.TabIndex = 93;
            this.BEliminarTodo.Text = "Eliminar todo";
            this.BEliminarTodo.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGuardar.Location = new System.Drawing.Point(495, 453);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(167, 43);
            this.BGuardar.TabIndex = 92;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = false;
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
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
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBEstado.Location = new System.Drawing.Point(432, 122);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(366, 28);
            this.CBEstado.TabIndex = 105;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(428, 102);
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
            this.GBDatos.Controls.Add(this.TNombre);
            this.GBDatos.Controls.Add(this.LNombre);
            this.GBDatos.Controls.Add(this.LApellido);
            this.GBDatos.Controls.Add(this.TNombreUsuario);
            this.GBDatos.Controls.Add(this.TApellido);
            this.GBDatos.Controls.Add(this.LNombreUsuario);
            this.GBDatos.Controls.Add(this.LFecha);
            this.GBDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDatos.ForeColor = System.Drawing.Color.AliceBlue;
            this.GBDatos.Location = new System.Drawing.Point(24, 16);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(818, 176);
            this.GBDatos.TabIndex = 106;
            this.GBDatos.TabStop = false;
            this.GBDatos.Text = "DATOS PERSONALES";
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
            this.GBSeguridad.ForeColor = System.Drawing.Color.AliceBlue;
            this.GBSeguridad.Location = new System.Drawing.Point(24, 239);
            this.GBSeguridad.Name = "GBSeguridad";
            this.GBSeguridad.Size = new System.Drawing.Size(818, 173);
            this.GBSeguridad.TabIndex = 107;
            this.GBSeguridad.TabStop = false;
            this.GBSeguridad.Text = "SEGURIDAD Y ROLES";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelContenedor.Controls.Add(this.GBDatos);
            this.PanelContenedor.Controls.Add(this.BVolver);
            this.PanelContenedor.Controls.Add(this.BEliminarTodo);
            this.PanelContenedor.Controls.Add(this.GBSeguridad);
            this.PanelContenedor.Controls.Add(this.BGuardar);
            this.PanelContenedor.Location = new System.Drawing.Point(12, 68);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(863, 512);
            this.PanelContenedor.TabIndex = 108;
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(889, 627);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.LTitulo);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModificarUsuario";
            this.Text = "Modificar Usuario ";
            this.Load += new System.EventHandler(this.FormModificarUsuario_Load);
            this.GBDatos.ResumeLayout(false);
            this.GBDatos.PerformLayout();
            this.GBSeguridad.ResumeLayout(false);
            this.GBSeguridad.PerformLayout();
            this.PanelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.TextBox TNombreUsuario;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TConfirmar;
        private System.Windows.Forms.Label LConfirmar;
        private System.Windows.Forms.Label LFecha;
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
    }
}