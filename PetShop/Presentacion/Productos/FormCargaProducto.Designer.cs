namespace PetShop.Presentacion
{
    partial class FormCargaProducto
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
            this.LNombre = new System.Windows.Forms.Label();
            this.LCodigo = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.LEspecie = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.lblTamano = new System.Windows.Forms.Label();
            this.LPrecioCompra = new System.Windows.Forms.Label();
            this.LPrecioVenta = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.CBEspecie = new System.Windows.Forms.ComboBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.tbxTamano = new System.Windows.Forms.TextBox();
            this.TBPrecioCompra = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.BVolver = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LTitulo.Location = new System.Drawing.Point(203, 32);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(402, 37);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Carga de nuevo producto";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(49, 163);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(71, 20);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre";
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigo.Location = new System.Drawing.Point(49, 110);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(112, 20);
            this.LCodigo.TabIndex = 2;
            this.LCodigo.Text = "Código barra";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.Location = new System.Drawing.Point(364, 132);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(103, 20);
            this.LDescripcion.TabIndex = 3;
            this.LDescripcion.Text = "Descripción";
            // 
            // LEspecie
            // 
            this.LEspecie.AutoSize = true;
            this.LEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEspecie.Location = new System.Drawing.Point(49, 237);
            this.LEspecie.Name = "LEspecie";
            this.LEspecie.Size = new System.Drawing.Size(73, 20);
            this.LEspecie.TabIndex = 4;
            this.LEspecie.Text = "Especie";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.Location = new System.Drawing.Point(364, 237);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(87, 20);
            this.LCategoria.TabIndex = 5;
            this.LCategoria.Text = "Categoría";
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamano.Location = new System.Drawing.Point(49, 303);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(73, 20);
            this.lblTamano.TabIndex = 6;
            this.lblTamano.Text = "Tamaño";
            // 
            // LPrecioCompra
            // 
            this.LPrecioCompra.AutoSize = true;
            this.LPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioCompra.Location = new System.Drawing.Point(49, 368);
            this.LPrecioCompra.Name = "LPrecioCompra";
            this.LPrecioCompra.Size = new System.Drawing.Size(123, 20);
            this.LPrecioCompra.TabIndex = 7;
            this.LPrecioCompra.Text = "Precio compra";
            // 
            // LPrecioVenta
            // 
            this.LPrecioVenta.AutoSize = true;
            this.LPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioVenta.Location = new System.Drawing.Point(364, 368);
            this.LPrecioVenta.Name = "LPrecioVenta";
            this.LPrecioVenta.Size = new System.Drawing.Size(108, 20);
            this.LPrecioVenta.TabIndex = 8;
            this.LPrecioVenta.Text = "Precio venta";
            this.LPrecioVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.Location = new System.Drawing.Point(364, 303);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(81, 20);
            this.LCantidad.TabIndex = 9;
            this.LCantidad.Text = "Cantidad";
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(169, 104);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(161, 26);
            this.TBCodigo.TabIndex = 10;
            this.TBCodigo.TextChanged += new System.EventHandler(this.TBCodigo_TextChanged);
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(128, 157);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(202, 26);
            this.TBNombre.TabIndex = 11;
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(473, 100);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(277, 83);
            this.TBDescripcion.TabIndex = 12;
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
            this.CBEspecie.Location = new System.Drawing.Point(128, 229);
            this.CBEspecie.Name = "CBEspecie";
            this.CBEspecie.Size = new System.Drawing.Size(202, 28);
            this.CBEspecie.TabIndex = 13;
            this.CBEspecie.SelectedIndexChanged += new System.EventHandler(this.CBEspecie_SelectedIndexChanged);
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
            this.CBCategoria.Location = new System.Drawing.Point(473, 229);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(202, 28);
            this.CBCategoria.TabIndex = 14;
            // 
            // tbxTamano
            // 
            this.tbxTamano.Location = new System.Drawing.Point(145, 297);
            this.tbxTamano.Name = "tbxTamano";
            this.tbxTamano.Size = new System.Drawing.Size(185, 26);
            this.tbxTamano.TabIndex = 15;
            // 
            // TBPrecioCompra
            // 
            this.TBPrecioCompra.Location = new System.Drawing.Point(178, 362);
            this.TBPrecioCompra.Name = "TBPrecioCompra";
            this.TBPrecioCompra.Size = new System.Drawing.Size(152, 26);
            this.TBPrecioCompra.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 26);
            this.textBox1.TabIndex = 17;
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(473, 297);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(78, 26);
            this.TBCantidad.TabIndex = 18;
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(12, 12);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(96, 39);
            this.BVolver.TabIndex = 19;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(452, 438);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(150, 65);
            this.BGuardar.TabIndex = 20;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(624, 438);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(150, 65);
            this.BEliminar.TabIndex = 21;
            this.BEliminar.Text = "Eliminar todo";
            this.BEliminar.UseVisualStyleBackColor = true;
            // 
            // FormCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.TBCantidad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TBPrecioCompra);
            this.Controls.Add(this.tbxTamano);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.CBEspecie);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBCodigo);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.LPrecioVenta);
            this.Controls.Add(this.LPrecioCompra);
            this.Controls.Add(this.lblTamano);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.LEspecie);
            this.Controls.Add(this.LDescripcion);
            this.Controls.Add(this.LCodigo);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LTitulo);
            this.Name = "FormCargaProducto";
            this.Text = "FormCargaProducto";
            this.Load += new System.EventHandler(this.FormCargaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.Label LEspecie;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.Label LPrecioCompra;
        private System.Windows.Forms.Label LPrecioVenta;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.ComboBox CBEspecie;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.TextBox tbxTamano;
        private System.Windows.Forms.TextBox TBPrecioCompra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
    }
}