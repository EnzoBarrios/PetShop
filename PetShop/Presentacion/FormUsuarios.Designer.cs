namespace PetShop.Presentacion
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
            this.BCambiarEstado = new System.Windows.Forms.Button();
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
            // 
            // BCambiarEstado
            // 
            this.BCambiarEstado.Location = new System.Drawing.Point(614, 375);
            this.BCambiarEstado.Name = "BCambiarEstado";
            this.BCambiarEstado.Size = new System.Drawing.Size(153, 56);
            this.BCambiarEstado.TabIndex = 32;
            this.BCambiarEstado.Text = "Desactivar";
            this.BCambiarEstado.UseVisualStyleBackColor = true;
            // 
            // BModificarUsuario
            // 
            this.BModificarUsuario.Location = new System.Drawing.Point(319, 375);
            this.BModificarUsuario.Name = "BModificarUsuario";
            this.BModificarUsuario.Size = new System.Drawing.Size(153, 56);
            this.BModificarUsuario.TabIndex = 31;
            this.BModificarUsuario.Text = "Modificar";
            this.BModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // BNuevoUsuario
            // 
            this.BNuevoUsuario.Location = new System.Drawing.Point(33, 375);
            this.BNuevoUsuario.Name = "BNuevoUsuario";
            this.BNuevoUsuario.Size = new System.Drawing.Size(132, 56);
            this.BNuevoUsuario.TabIndex = 30;
            this.BNuevoUsuario.Text = "Nuevo Usuario";
            this.BNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.AllowUserToAddRows = false;
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Location = new System.Drawing.Point(33, 159);
            this.DGVUsuarios.MultiSelect = false;
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.ReadOnly = true;
            this.DGVUsuarios.RowHeadersWidth = 62;
            this.DGVUsuarios.RowTemplate.Height = 28;
            this.DGVUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsuarios.Size = new System.Drawing.Size(734, 210);
            this.DGVUsuarios.TabIndex = 29;
            // 
            // TBuscar
            // 
            this.TBuscar.Location = new System.Drawing.Point(112, 119);
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(217, 26);
            this.TBuscar.TabIndex = 28;
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.Location = new System.Drawing.Point(41, 125);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(65, 20);
            this.LBuscar.TabIndex = 27;
            this.LBuscar.Text = "Buscar";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LTitulo.Location = new System.Drawing.Point(232, 34);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(318, 35);
            this.LTitulo.TabIndex = 26;
            this.LTitulo.Text = "Gestión de usuarios";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.BCambiarEstado);
            this.Controls.Add(this.BModificarUsuario);
            this.Controls.Add(this.BNuevoUsuario);
            this.Controls.Add(this.DGVUsuarios);
            this.Controls.Add(this.TBuscar);
            this.Controls.Add(this.LBuscar);
            this.Controls.Add(this.LTitulo);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Button BCambiarEstado;
        private System.Windows.Forms.Button BModificarUsuario;
        private System.Windows.Forms.Button BNuevoUsuario;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.TextBox TBuscar;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.Label LTitulo;
    }
}