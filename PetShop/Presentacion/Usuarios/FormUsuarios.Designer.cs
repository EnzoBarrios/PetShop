namespace PetShop.Presentacion.Usuarios
{
    partial class FormUsuarios
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
            this.BEstado = new System.Windows.Forms.Button();
            this.BModificarUsuario = new System.Windows.Forms.Button();
            this.BNuevoUsuario = new System.Windows.Forms.Button();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.TBuscar = new System.Windows.Forms.TextBox();
            this.LBuscar = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(22, 16);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(96, 39);
            this.BVolver.TabIndex = 33;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // BEstado
            // 
            this.BEstado.Location = new System.Drawing.Point(613, 382);
            this.BEstado.Name = "BEstado";
            this.BEstado.Size = new System.Drawing.Size(153, 56);
            this.BEstado.TabIndex = 32;
            this.BEstado.Text = "Desactivar";
            this.BEstado.UseVisualStyleBackColor = true;
            this.BEstado.Click += new System.EventHandler(this.BEstado_Click);
            // 
            // BModificarUsuario
            // 
            this.BModificarUsuario.Location = new System.Drawing.Point(318, 382);
            this.BModificarUsuario.Name = "BModificarUsuario";
            this.BModificarUsuario.Size = new System.Drawing.Size(153, 56);
            this.BModificarUsuario.TabIndex = 31;
            this.BModificarUsuario.Text = "Modificar";
            this.BModificarUsuario.UseVisualStyleBackColor = true;
            this.BModificarUsuario.Click += new System.EventHandler(this.BModificar_Click);
            // 
            // BNuevoUsuario
            // 
            this.BNuevoUsuario.Location = new System.Drawing.Point(32, 382);
            this.BNuevoUsuario.Name = "BNuevoUsuario";
            this.BNuevoUsuario.Size = new System.Drawing.Size(132, 56);
            this.BNuevoUsuario.TabIndex = 30;
            this.BNuevoUsuario.Text = "Nuevo Usuario";
            this.BNuevoUsuario.UseVisualStyleBackColor = true;
            this.BNuevoUsuario.Click += new System.EventHandler(this.BNuevoUsuario_Click);
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.AllowUserToAddRows = false;
            this.DGVUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Location = new System.Drawing.Point(32, 123);
            this.DGVUsuarios.MultiSelect = false;
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.ReadOnly = true;
            this.DGVUsuarios.RowHeadersWidth = 62;
            this.DGVUsuarios.RowTemplate.Height = 28;
            this.DGVUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsuarios.Size = new System.Drawing.Size(734, 253);
            this.DGVUsuarios.TabIndex = 29;
            this.DGVUsuarios.SelectionChanged += new System.EventHandler(this.DGVUsuarios_SelectionChanged);
            // 
            // TBuscar
            // 
            this.TBuscar.Location = new System.Drawing.Point(111, 91);
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(217, 26);
            this.TBuscar.TabIndex = 28;
            this.TBuscar.TextChanged += new System.EventHandler(this.TBuscar_TextChanged);
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.LBuscar.Location = new System.Drawing.Point(40, 97);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(65, 20);
            this.LBuscar.TabIndex = 27;
            this.LBuscar.Text = "Buscar";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold);
            this.LTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.LTitulo.Location = new System.Drawing.Point(204, 7);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(417, 48);
            this.LTitulo.TabIndex = 26;
            this.LTitulo.Text = "GESTIÓN DE USUARIOS";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BEstado);
            this.Controls.Add(this.BModificarUsuario);
            this.Controls.Add(this.BNuevoUsuario);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.TBuscar);
            this.Controls.Add(this.LBuscar);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.DGVUsuarios);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Button BEstado;
        private System.Windows.Forms.Button BModificarUsuario;
        private System.Windows.Forms.Button BNuevoUsuario;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.TextBox TBuscar;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.Label LTitulo;
    }
}