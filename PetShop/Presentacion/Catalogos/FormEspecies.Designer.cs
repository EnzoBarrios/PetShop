namespace PetShop.Presentacion.Catalogos
{
    partial class FormEspecies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEspecies));
            this.lblTituloGestionEspecies = new System.Windows.Forms.Label();
            this.gbFiltroCategoria = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.dgvEspecies = new System.Windows.Forms.DataGridView();
            this.colIdEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdTamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnModificarEspecie = new System.Windows.Forms.Button();
            this.btnAgregarEspecie = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbFiltroCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecies)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloGestionEspecies
            // 
            this.lblTituloGestionEspecies.AutoSize = true;
            this.lblTituloGestionEspecies.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGestionEspecies.ForeColor = System.Drawing.Color.Black;
            this.lblTituloGestionEspecies.Location = new System.Drawing.Point(521, 20);
            this.lblTituloGestionEspecies.Name = "lblTituloGestionEspecies";
            this.lblTituloGestionEspecies.Size = new System.Drawing.Size(238, 32);
            this.lblTituloGestionEspecies.TabIndex = 0;
            this.lblTituloGestionEspecies.Text = "Gestión de Especies";
            // 
            // gbFiltroCategoria
            // 
            this.gbFiltroCategoria.Controls.Add(this.checkedListBox1);
            this.gbFiltroCategoria.Controls.Add(this.btnAplicarFiltro);
            this.gbFiltroCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroCategoria.Location = new System.Drawing.Point(40, 180);
            this.gbFiltroCategoria.Name = "gbFiltroCategoria";
            this.gbFiltroCategoria.Size = new System.Drawing.Size(300, 400);
            this.gbFiltroCategoria.TabIndex = 1;
            this.gbFiltroCategoria.TabStop = false;
            this.gbFiltroCategoria.Text = "Selección de Especie";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Pez",
            "Loro"});
            this.checkedListBox1.Location = new System.Drawing.Point(10, 30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(280, 304);
            this.checkedListBox1.TabIndex = 5;
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
            // dgvEspecies
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdEspecie,
            this.colIdTamano,
            this.colEspecie,
            this.colTamano,
            this.colEstado});
            this.dgvEspecies.Location = new System.Drawing.Point(380, 70);
            this.dgvEspecies.Name = "dgvEspecies";
            this.dgvEspecies.RowHeadersWidth = 51;
            this.dgvEspecies.RowTemplate.Height = 24;
            this.dgvEspecies.Size = new System.Drawing.Size(860, 510);
            this.dgvEspecies.TabIndex = 2;
            // 
            // colIdEspecie
            // 
            this.colIdEspecie.HeaderText = "Id Especie";
            this.colIdEspecie.MinimumWidth = 6;
            this.colIdEspecie.Name = "colIdEspecie";
            this.colIdEspecie.Visible = false;
            this.colIdEspecie.Width = 125;
            // 
            // colIdTamano
            // 
            this.colIdTamano.HeaderText = "Id Tamaño";
            this.colIdTamano.MinimumWidth = 6;
            this.colIdTamano.Name = "colIdTamano";
            this.colIdTamano.Visible = false;
            this.colIdTamano.Width = 125;
            // 
            // colEspecie
            // 
            this.colEspecie.HeaderText = "Especie";
            this.colEspecie.MinimumWidth = 6;
            this.colEspecie.Name = "colEspecie";
            this.colEspecie.Width = 125;
            // 
            // colTamano
            // 
            this.colTamano.HeaderText = "Tamaño";
            this.colTamano.MinimumWidth = 6;
            this.colTamano.Name = "colTamano";
            this.colTamano.Width = 125;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 125;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Agregar_Venta.png");
            this.imageList1.Images.SetKeyName(1, "Modificar.png");
            // 
            // btnModificarEspecie
            // 
            this.btnModificarEspecie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarEspecie.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEspecie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarEspecie.ImageIndex = 1;
            this.btnModificarEspecie.ImageList = this.imageList1;
            this.btnModificarEspecie.Location = new System.Drawing.Point(200, 70);
            this.btnModificarEspecie.Name = "btnModificarEspecie";
            this.btnModificarEspecie.Size = new System.Drawing.Size(140, 90);
            this.btnModificarEspecie.TabIndex = 4;
            this.btnModificarEspecie.Text = "Modificar Especie/Tamaño";
            this.btnModificarEspecie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarEspecie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificarEspecie.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEspecie
            // 
            this.btnAgregarEspecie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarEspecie.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspecie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarEspecie.ImageIndex = 0;
            this.btnAgregarEspecie.ImageList = this.imageList1;
            this.btnAgregarEspecie.Location = new System.Drawing.Point(40, 70);
            this.btnAgregarEspecie.Name = "btnAgregarEspecie";
            this.btnAgregarEspecie.Size = new System.Drawing.Size(140, 90);
            this.btnAgregarEspecie.TabIndex = 3;
            this.btnAgregarEspecie.Text = "Agregar Especie/Tamaño";
            this.btnAgregarEspecie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarEspecie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarEspecie.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(40, 20);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 32);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // FormEspecies
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificarEspecie);
            this.Controls.Add(this.btnAgregarEspecie);
            this.Controls.Add(this.dgvEspecies);
            this.Controls.Add(this.gbFiltroCategoria);
            this.Controls.Add(this.lblTituloGestionEspecies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEspecies";
            this.Text = "Gestión de Categorias";
            this.gbFiltroCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloGestionEspecies;
        private System.Windows.Forms.GroupBox gbFiltroCategoria;
        private System.Windows.Forms.DataGridView dgvEspecies;
        private System.Windows.Forms.Button btnAgregarEspecie;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Button btnModificarEspecie;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTamano;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamano;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Button btnVolver;
    }
}