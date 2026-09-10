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
            this.BVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LTitulo.Location = new System.Drawing.Point(219, 30);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(337, 35);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Gestión de productos";
            // 
            // TBuscar
            // 
            this.TBuscar.Location = new System.Drawing.Point(111, 92);
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(217, 26);
            this.TBuscar.TabIndex = 12;
            this.TBuscar.TextChanged += new System.EventHandler(this.TBuscar_TextChanged);
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.Location = new System.Drawing.Point(40, 98);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(65, 20);
            this.LBuscar.TabIndex = 11;
            this.LBuscar.Text = "Buscar";
            // 
            // DGVProductos
            // 
            this.DGVProductos.AllowUserToAddRows = false;
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(32, 124);
            this.DGVProductos.MultiSelect = false;
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.ReadOnly = true;
            this.DGVProductos.RowHeadersWidth = 62;
            this.DGVProductos.RowTemplate.Height = 28;
            this.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductos.Size = new System.Drawing.Size(734, 274);
            this.DGVProductos.TabIndex = 20;
            // 
            // BNuevoProducto
            // 
            this.BNuevoProducto.Location = new System.Drawing.Point(32, 404);
            this.BNuevoProducto.Name = "BNuevoProducto";
            this.BNuevoProducto.Size = new System.Drawing.Size(132, 56);
            this.BNuevoProducto.TabIndex = 21;
            this.BNuevoProducto.Text = "Nuevo Producto";
            this.BNuevoProducto.UseVisualStyleBackColor = true;
            this.BNuevoProducto.Click += new System.EventHandler(this.BNuevoProducto_Click);
            // 
            // BModificarProducto
            // 
            this.BModificarProducto.Location = new System.Drawing.Point(309, 404);
            this.BModificarProducto.Name = "BModificarProducto";
            this.BModificarProducto.Size = new System.Drawing.Size(153, 56);
            this.BModificarProducto.TabIndex = 22;
            this.BModificarProducto.Text = "Modificar";
            this.BModificarProducto.UseVisualStyleBackColor = true;
            this.BModificarProducto.Click += new System.EventHandler(this.BModificarProducto_Click);
            // 
            // BCambiarEstado
            // 
            this.BCambiarEstado.Location = new System.Drawing.Point(613, 404);
            this.BCambiarEstado.Name = "BCambiarEstado";
            this.BCambiarEstado.Size = new System.Drawing.Size(153, 56);
            this.BCambiarEstado.TabIndex = 23;
            this.BCambiarEstado.Text = "Desactivar";
            this.BCambiarEstado.UseVisualStyleBackColor = true;
            this.BCambiarEstado.Click += new System.EventHandler(this.BEliminarProducto_Click);
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(9, 12);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(96, 39);
            this.BVolver.TabIndex = 25;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.BCambiarEstado);
            this.Controls.Add(this.BModificarProducto);
            this.Controls.Add(this.BNuevoProducto);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.TBuscar);
            this.Controls.Add(this.LBuscar);
            this.Controls.Add(this.LTitulo);
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
        private System.Windows.Forms.Button BVolver;
    }
}