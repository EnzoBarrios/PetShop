namespace PetShop.Presentacion
{
    partial class FormProductos
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
            this.LTitulo = new System.Windows.Forms.Label();
            this.TBuscar = new System.Windows.Forms.TextBox();
            this.LBuscar = new System.Windows.Forms.Label();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.BNuevoProducto = new System.Windows.Forms.Button();
            this.BModificarProducto = new System.Windows.Forms.Button();
            this.BCambiarEstado = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.Location = new System.Drawing.Point(510, 20);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(260, 32);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Gestión de Productos";
            // 
            // TBuscar
            // 
            this.TBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TBuscar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.TBuscar.Location = new System.Drawing.Point(100, 78);
            this.TBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(193, 25);
            this.TBuscar.TabIndex = 12;
            this.TBuscar.TextChanged += new System.EventHandler(this.TBuscar_TextChanged);
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LBuscar.Location = new System.Drawing.Point(40, 80);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(49, 19);
            this.LBuscar.TabIndex = 11;
            this.LBuscar.Text = "Buscar";
            // 
            // DGVProductos
            // 
            this.DGVProductos.AllowUserToAddRows = false;
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(40, 110);
            this.DGVProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVProductos.MultiSelect = false;
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.ReadOnly = true;
            this.DGVProductos.RowHeadersWidth = 62;
            this.DGVProductos.RowTemplate.Height = 28;
            this.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductos.Size = new System.Drawing.Size(1200, 360);
            this.DGVProductos.TabIndex = 20;
            // 
            // BNuevoProducto
            // 
            this.BNuevoProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BNuevoProducto.Location = new System.Drawing.Point(250, 520);
            this.BNuevoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BNuevoProducto.Name = "BNuevoProducto";
            this.BNuevoProducto.Size = new System.Drawing.Size(150, 50);
            this.BNuevoProducto.TabIndex = 21;
            this.BNuevoProducto.Text = "Nuevo Producto";
            this.BNuevoProducto.UseVisualStyleBackColor = false;
            this.BNuevoProducto.Click += new System.EventHandler(this.BNuevoProducto_Click);
            // 
            // BModificarProducto
            // 
            this.BModificarProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BModificarProducto.Location = new System.Drawing.Point(565, 520);
            this.BModificarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BModificarProducto.Name = "BModificarProducto";
            this.BModificarProducto.Size = new System.Drawing.Size(150, 50);
            this.BModificarProducto.TabIndex = 22;
            this.BModificarProducto.Text = "Modificar";
            this.BModificarProducto.UseVisualStyleBackColor = false;
            this.BModificarProducto.Click += new System.EventHandler(this.BModificarProducto_Click);
            // 
            // BCambiarEstado
            // 
            this.BCambiarEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BCambiarEstado.Location = new System.Drawing.Point(880, 520);
            this.BCambiarEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BCambiarEstado.Name = "BCambiarEstado";
            this.BCambiarEstado.Size = new System.Drawing.Size(150, 50);
            this.BCambiarEstado.TabIndex = 23;
            this.BCambiarEstado.Text = "Desactivar";
            this.BCambiarEstado.UseVisualStyleBackColor = false;
            this.BCambiarEstado.Click += new System.EventHandler(this.BEliminarProducto_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(40, 20);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 32);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.BCambiarEstado);
            this.Controls.Add(this.BModificarProducto);
            this.Controls.Add(this.BNuevoProducto);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.TBuscar);
            this.Controls.Add(this.LBuscar);
            this.Controls.Add(this.LTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.TextBox TBuscar;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.Button BNuevoProducto;
        private System.Windows.Forms.Button BModificarProducto;
        private System.Windows.Forms.Button BCambiarEstado;
        private System.Windows.Forms.Button btnVolver;
    }
}