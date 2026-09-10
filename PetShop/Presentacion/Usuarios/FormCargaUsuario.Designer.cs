namespace PetShop
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
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BVolver = new System.Windows.Forms.Button();
            this.LTitulo = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LRol = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TConfirmar = new System.Windows.Forms.TextBox();
            this.LConfirmar = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.TNombreUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TClave
            // 
            this.TClave.Location = new System.Drawing.Point(154, 263);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(202, 26);
            this.TClave.TabIndex = 78;
            // 
            // LClave
            // 
            this.LClave.AutoSize = true;
            this.LClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LClave.Location = new System.Drawing.Point(46, 269);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(102, 20);
            this.LClave.TabIndex = 77;
            this.LClave.Text = "Contraseña";
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(610, 392);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(150, 65);
            this.BEliminar.TabIndex = 76;
            this.BEliminar.Text = "Eliminar todo";
            this.BEliminar.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(440, 392);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(150, 65);
            this.BGuardar.TabIndex = 75;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(12, 10);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(96, 39);
            this.BVolver.TabIndex = 74;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LTitulo.Location = new System.Drawing.Point(223, 33);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(346, 37);
            this.LTitulo.TabIndex = 73;
            this.LTitulo.Text = "Cargar nuevo usuario";
            this.LTitulo.Click += new System.EventHandler(this.LTitulo_Click);
            // 
            // CBRol
            // 
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.CBRol.Location = new System.Drawing.Point(88, 333);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(231, 28);
            this.CBRol.TabIndex = 72;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(123, 107);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(233, 26);
            this.TBNombre.TabIndex = 71;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(46, 341);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(36, 20);
            this.LRol.TabIndex = 70;
            this.LRol.Text = "Rol";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(46, 113);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(71, 20);
            this.LNombre.TabIndex = 69;
            this.LNombre.Text = "Nombre";
            // 
            // TConfirmar
            // 
            this.TConfirmar.Location = new System.Drawing.Point(558, 263);
            this.TConfirmar.Name = "TConfirmar";
            this.TConfirmar.Size = new System.Drawing.Size(202, 26);
            this.TConfirmar.TabIndex = 82;
            // 
            // LConfirmar
            // 
            this.LConfirmar.AutoSize = true;
            this.LConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmar.Location = new System.Drawing.Point(370, 269);
            this.LConfirmar.Name = "LConfirmar";
            this.LConfirmar.Size = new System.Drawing.Size(182, 20);
            this.LConfirmar.TabIndex = 81;
            this.LConfirmar.Text = "Confirmar contraseña";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(375, 110);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(73, 20);
            this.LApellido.TabIndex = 84;
            this.LApellido.Text = "Apellido";
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(454, 104);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(233, 26);
            this.TApellido.TabIndex = 85;
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(46, 190);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(160, 20);
            this.LNombreUsuario.TabIndex = 86;
            this.LNombreUsuario.Text = "Nombre de usuario";
            // 
            // TNombreUsuario
            // 
            this.TNombreUsuario.Location = new System.Drawing.Point(218, 184);
            this.TNombreUsuario.Name = "TNombreUsuario";
            this.TNombreUsuario.Size = new System.Drawing.Size(203, 26);
            this.TNombreUsuario.TabIndex = 87;
            // 
            // FormCargaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.TNombreUsuario);
            this.Controls.Add(this.LNombreUsuario);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.TConfirmar);
            this.Controls.Add(this.LConfirmar);
            this.Controls.Add(this.TClave);
            this.Controls.Add(this.LClave);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LRol);
            this.Controls.Add(this.LNombre);
            this.Name = "FormCargaUsuario";
            this.Text = "FormCargaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TClave;
        private System.Windows.Forms.Label LClave;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TConfirmar;
        private System.Windows.Forms.Label LConfirmar;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.TextBox TNombreUsuario;
    }
}