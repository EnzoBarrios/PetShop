namespace PetShop
{
    partial class FormModificarProducto
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
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TBPrecioCompra = new System.Windows.Forms.TextBox();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.CBEspecie = new System.Windows.Forms.ComboBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LPrecioVenta = new System.Windows.Forms.Label();
            this.LPrecioCompra = new System.Windows.Forms.Label();
            this.LProveedor = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LEspecie = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.LCodigo = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.BVolver = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.LEstado = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(420, 230);
            this.TBCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(70, 22);
            this.TBCantidad.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(420, 282);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 35;
            // 
            // TBPrecioCompra
            // 
            this.TBPrecioCompra.Location = new System.Drawing.Point(158, 282);
            this.TBPrecioCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPrecioCompra.Name = "TBPrecioCompra";
            this.TBPrecioCompra.Size = new System.Drawing.Size(136, 22);
            this.TBPrecioCompra.TabIndex = 34;
            // 
            // TBProveedor
            // 
            this.TBProveedor.Location = new System.Drawing.Point(129, 230);
            this.TBProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.Size = new System.Drawing.Size(165, 22);
            this.TBProveedor.TabIndex = 33;
            // 
            // CBCategoria
            // 
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Accesorio",
            "Alimento",
            "Higiene",
            "Juguete",
            "Salud"});
            this.CBCategoria.Location = new System.Drawing.Point(420, 175);
            this.CBCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(180, 24);
            this.CBCategoria.TabIndex = 32;
            // 
            // CBEspecie
            // 
            this.CBEspecie.FormattingEnabled = true;
            this.CBEspecie.Items.AddRange(new object[] {
            "Ave",
            "Conejo",
            "Gato",
            "Perro",
            "Pez"});
            this.CBEspecie.Location = new System.Drawing.Point(114, 175);
            this.CBEspecie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBEspecie.Name = "CBEspecie";
            this.CBEspecie.Size = new System.Drawing.Size(180, 24);
            this.CBEspecie.TabIndex = 31;
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(420, 80);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(247, 67);
            this.TBDescripcion.TabIndex = 30;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(114, 126);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(180, 22);
            this.TBNombre.TabIndex = 29;
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(150, 83);
            this.TBCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(144, 22);
            this.TBCodigo.TabIndex = 28;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.Location = new System.Drawing.Point(324, 234);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(72, 17);
            this.LCantidad.TabIndex = 27;
            this.LCantidad.Text = "Cantidad";
            // 
            // LPrecioVenta
            // 
            this.LPrecioVenta.AutoSize = true;
            this.LPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioVenta.Location = new System.Drawing.Point(324, 286);
            this.LPrecioVenta.Name = "LPrecioVenta";
            this.LPrecioVenta.Size = new System.Drawing.Size(99, 17);
            this.LPrecioVenta.TabIndex = 26;
            this.LPrecioVenta.Text = "Precio venta";
            this.LPrecioVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LPrecioCompra
            // 
            this.LPrecioCompra.AutoSize = true;
            this.LPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioCompra.Location = new System.Drawing.Point(44, 286);
            this.LPrecioCompra.Name = "LPrecioCompra";
            this.LPrecioCompra.Size = new System.Drawing.Size(112, 17);
            this.LPrecioCompra.TabIndex = 25;
            this.LPrecioCompra.Text = "Precio compra";
            // 
            // LProveedor
            // 
            this.LProveedor.AutoSize = true;
            this.LProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProveedor.Location = new System.Drawing.Point(44, 234);
            this.LProveedor.Name = "LProveedor";
            this.LProveedor.Size = new System.Drawing.Size(83, 17);
            this.LProveedor.TabIndex = 24;
            this.LProveedor.Text = "Proveedor";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.Location = new System.Drawing.Point(324, 182);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(78, 17);
            this.LCategoria.TabIndex = 23;
            this.LCategoria.Text = "Categoría";
            // 
            // LEspecie
            // 
            this.LEspecie.AutoSize = true;
            this.LEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEspecie.Location = new System.Drawing.Point(44, 182);
            this.LEspecie.Name = "LEspecie";
            this.LEspecie.Size = new System.Drawing.Size(65, 17);
            this.LEspecie.TabIndex = 22;
            this.LEspecie.Text = "Especie";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.Location = new System.Drawing.Point(324, 106);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(93, 17);
            this.LDescripcion.TabIndex = 21;
            this.LDescripcion.Text = "Descripción";
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigo.Location = new System.Drawing.Point(44, 88);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(102, 17);
            this.LCodigo.TabIndex = 20;
            this.LCodigo.Text = "Código barra";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(44, 130);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(64, 17);
            this.LNombre.TabIndex = 19;
            this.LNombre.Text = "Nombre";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LTitulo.Location = new System.Drawing.Point(227, 26);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(255, 31);
            this.LTitulo.TabIndex = 37;
            this.LTitulo.Text = "Modificar producto";
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(11, 8);
            this.BVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(85, 31);
            this.BVolver.TabIndex = 38;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(556, 358);
            this.BEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(133, 52);
            this.BEliminar.TabIndex = 40;
            this.BEliminar.Text = "Eliminar todo";
            this.BEliminar.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(403, 358);
            this.BGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(133, 52);
            this.BGuardar.TabIndex = 39;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(44, 348);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(58, 17);
            this.LEstado.TabIndex = 41;
            this.LEstado.Text = "Estado";
            // 
            // CBEstado
            // 
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBEstado.Location = new System.Drawing.Point(114, 342);
            this.CBEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(108, 24);
            this.CBEstado.TabIndex = 42;
            // 
            // FormModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 430);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.LEstado);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.TBCantidad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TBPrecioCompra);
            this.Controls.Add(this.TBProveedor);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.CBEspecie);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBCodigo);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.LPrecioVenta);
            this.Controls.Add(this.LPrecioCompra);
            this.Controls.Add(this.LProveedor);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.LEspecie);
            this.Controls.Add(this.LDescripcion);
            this.Controls.Add(this.LCodigo);
            this.Controls.Add(this.LNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModificarProducto";
            this.Text = "FormModificarProducto";
            this.Load += new System.EventHandler(this.FormModificarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TBPrecioCompra;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.ComboBox CBEspecie;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LPrecioVenta;
        private System.Windows.Forms.Label LPrecioCompra;
        private System.Windows.Forms.Label LProveedor;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LEspecie;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.ComboBox CBEstado;
    }
}