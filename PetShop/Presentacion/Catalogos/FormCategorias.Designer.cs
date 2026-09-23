namespace PetShop.Presentacion.Catalogos
{
    partial class FormCategorias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.gbFiltroCategoria = new System.Windows.Forms.GroupBox();
            this.clbCategorias = new System.Windows.Forms.CheckedListBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.lblTituloGestionCategoria = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.colIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbFiltroCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarCategoria.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarCategoria.ImageIndex = 1;
            this.btnModificarCategoria.ImageList = this.imageList1;
            this.btnModificarCategoria.Location = new System.Drawing.Point(200, 70);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(140, 90);
            this.btnModificarCategoria.TabIndex = 9;
            this.btnModificarCategoria.Text = "Modificar Categoria";
            this.btnModificarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Agregar_Venta.png");
            this.imageList1.Images.SetKeyName(1, "Modificar.png");
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCategoria.ImageIndex = 0;
            this.btnAgregarCategoria.ImageList = this.imageList1;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(40, 70);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(140, 90);
            this.btnAgregarCategoria.TabIndex = 8;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            // 
            // gbFiltroCategoria
            // 
            this.gbFiltroCategoria.Controls.Add(this.clbCategorias);
            this.gbFiltroCategoria.Controls.Add(this.btnAplicarFiltro);
            this.gbFiltroCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroCategoria.Location = new System.Drawing.Point(40, 180);
            this.gbFiltroCategoria.Name = "gbFiltroCategoria";
            this.gbFiltroCategoria.Size = new System.Drawing.Size(300, 400);
            this.gbFiltroCategoria.TabIndex = 6;
            this.gbFiltroCategoria.TabStop = false;
            this.gbFiltroCategoria.Text = "Selección de Categoria";
            // 
            // clbCategorias
            // 
            this.clbCategorias.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCategorias.FormattingEnabled = true;
            this.clbCategorias.Items.AddRange(new object[] {
            "Accesorios",
            "Alimentos",
            "Juguetes"});
            this.clbCategorias.Location = new System.Drawing.Point(10, 30);
            this.clbCategorias.Name = "clbCategorias";
            this.clbCategorias.Size = new System.Drawing.Size(280, 284);
            this.clbCategorias.TabIndex = 5;
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(40, 350);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(220, 40);
            this.btnAplicarFiltro.TabIndex = 5;
            this.btnAplicarFiltro.Text = "Aplicar Filtros";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            // 
            // lblTituloGestionCategoria
            // 
            this.lblTituloGestionCategoria.AutoSize = true;
            this.lblTituloGestionCategoria.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloGestionCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblTituloGestionCategoria.Location = new System.Drawing.Point(508, 20);
            this.lblTituloGestionCategoria.Name = "lblTituloGestionCategoria";
            this.lblTituloGestionCategoria.Size = new System.Drawing.Size(264, 32);
            this.lblTituloGestionCategoria.TabIndex = 5;
            this.lblTituloGestionCategoria.Text = "Gestión de Categorias";
            // 
            // dgvCategorias
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCategoria,
            this.colCategoria,
            this.colDescripcion,
            this.colEstado});
            this.dgvCategorias.Location = new System.Drawing.Point(380, 70);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(860, 510);
            this.dgvCategorias.TabIndex = 10;
            // 
            // colIdCategoria
            // 
            this.colIdCategoria.HeaderText = "Id Categoria";
            this.colIdCategoria.MinimumWidth = 6;
            this.colIdCategoria.Name = "colIdCategoria";
            this.colIdCategoria.Visible = false;
            this.colIdCategoria.Width = 125;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.MinimumWidth = 6;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 125;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 125;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 125;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(40, 20);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 32);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.gbFiltroCategoria);
            this.Controls.Add(this.lblTituloGestionCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.gbFiltroCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.GroupBox gbFiltroCategoria;
        private System.Windows.Forms.CheckedListBox clbCategorias;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Label lblTituloGestionCategoria;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Button btnVolver;
    }
}