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
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.TConfirmar = new System.Windows.Forms.TextBox();
            this.LConfirmar = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.TClave = new System.Windows.Forms.TextBox();
            this.LClave = new System.Windows.Forms.Label();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LRol = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(12, 12);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(96, 39);
            this.BVolver.TabIndex = 62;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LTitulo.Location = new System.Drawing.Point(269, 35);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(279, 37);
            this.LTitulo.TabIndex = 61;
            this.LTitulo.Text = "Modificar usuario";
            this.LTitulo.Click += new System.EventHandler(this.LTitulo_Click);
            // 
            // TNombreUsuario
            // 
            this.TNombreUsuario.Location = new System.Drawing.Point(214, 189);
            this.TNombreUsuario.Name = "TNombreUsuario";
            this.TNombreUsuario.Size = new System.Drawing.Size(203, 26);
            this.TNombreUsuario.TabIndex = 103;
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(42, 195);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(160, 20);
            this.LNombreUsuario.TabIndex = 102;
            this.LNombreUsuario.Text = "Nombre de usuario";
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(450, 109);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(233, 26);
            this.TApellido.TabIndex = 101;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(371, 115);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(73, 20);
            this.LApellido.TabIndex = 100;
            this.LApellido.Text = "Apellido";
            // 
            // DTFecha
            // 
            this.DTFecha.Location = new System.Drawing.Point(205, 424);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(147, 26);
            this.DTFecha.TabIndex = 99;
            // 
            // TConfirmar
            // 
            this.TConfirmar.Location = new System.Drawing.Point(554, 268);
            this.TConfirmar.Name = "TConfirmar";
            this.TConfirmar.Size = new System.Drawing.Size(202, 26);
            this.TConfirmar.TabIndex = 98;
            // 
            // LConfirmar
            // 
            this.LConfirmar.AutoSize = true;
            this.LConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmar.Location = new System.Drawing.Point(366, 274);
            this.LConfirmar.Name = "LConfirmar";
            this.LConfirmar.Size = new System.Drawing.Size(182, 20);
            this.LConfirmar.TabIndex = 97;
            this.LConfirmar.Text = "Confirmar contraseña";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.Location = new System.Drawing.Point(42, 430);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(157, 20);
            this.LFecha.TabIndex = 96;
            this.LFecha.Text = "Fecha de creación";
            // 
            // TClave
            // 
            this.TClave.Location = new System.Drawing.Point(150, 268);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(202, 26);
            this.TClave.TabIndex = 95;
            // 
            // LClave
            // 
            this.LClave.AutoSize = true;
            this.LClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LClave.Location = new System.Drawing.Point(42, 274);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(102, 20);
            this.LClave.TabIndex = 94;
            this.LClave.Text = "Contraseña";
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(606, 397);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(150, 65);
            this.BEliminar.TabIndex = 93;
            this.BEliminar.Text = "Eliminar todo";
            this.BEliminar.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(436, 397);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(150, 65);
            this.BGuardar.TabIndex = 92;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // CBRol
            // 
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.CBRol.Location = new System.Drawing.Point(84, 338);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(231, 28);
            this.CBRol.TabIndex = 91;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(119, 112);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(233, 26);
            this.TBNombre.TabIndex = 90;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(42, 346);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(36, 20);
            this.LRol.TabIndex = 89;
            this.LRol.Text = "Rol";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(42, 118);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(71, 20);
            this.LNombre.TabIndex = 88;
            this.LNombre.Text = "Nombre";
            // 
            // CBEstado
            // 
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBEstado.Location = new System.Drawing.Point(445, 338);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(121, 28);
            this.CBEstado.TabIndex = 105;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(366, 346);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(66, 20);
            this.LEstado.TabIndex = 104;
            this.LEstado.Text = "Estado";
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.LEstado);
            this.Controls.Add(this.TNombreUsuario);
            this.Controls.Add(this.LNombreUsuario);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.DTFecha);
            this.Controls.Add(this.TConfirmar);
            this.Controls.Add(this.LConfirmar);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.TClave);
            this.Controls.Add(this.LClave);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LRol);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.LTitulo);
            this.Name = "FormModificarUsuario";
            this.Text = " FormModificarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.TextBox TNombreUsuario;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.TextBox TConfirmar;
        private System.Windows.Forms.Label LConfirmar;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.TextBox TClave;
        private System.Windows.Forms.Label LClave;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LEstado;
    }
}