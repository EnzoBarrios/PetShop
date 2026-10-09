namespace PetShop.Presentacion.Catalogos
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgListBotones = new System.Windows.Forms.ImageList(this.components);
            this.gbFiltroCategoria = new System.Windows.Forms.GroupBox();
            this.rbInactivos = new System.Windows.Forms.RadioButton();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblTituloGestionCategoria = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.imgListEstado = new System.Windows.Forms.ImageList(this.components);
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.gbFiltroCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // imgListBotones
            // 
            this.imgListBotones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListBotones.ImageStream")));
            this.imgListBotones.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListBotones.Images.SetKeyName(0, "Agregar_Venta.png");
            this.imgListBotones.Images.SetKeyName(1, "Modificar.png");
            // 
            // gbFiltroCategoria
            // 
            this.gbFiltroCategoria.Controls.Add(this.rbInactivos);
            this.gbFiltroCategoria.Controls.Add(this.rbActivos);
            this.gbFiltroCategoria.Controls.Add(this.label2);
            this.gbFiltroCategoria.Controls.Add(this.rbTodos);
            this.gbFiltroCategoria.Controls.Add(this.txtBuscar);
            this.gbFiltroCategoria.Controls.Add(this.lblBuscar);
            this.gbFiltroCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroCategoria.Location = new System.Drawing.Point(40, 290);
            this.gbFiltroCategoria.Name = "gbFiltroCategoria";
            this.gbFiltroCategoria.Size = new System.Drawing.Size(300, 290);
            this.gbFiltroCategoria.TabIndex = 6;
            this.gbFiltroCategoria.TabStop = false;
            this.gbFiltroCategoria.Text = "Filtros y Busqueda";
            // 
            // rbInactivos
            // 
            this.rbInactivos.AutoSize = true;
            this.rbInactivos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbInactivos.Location = new System.Drawing.Point(20, 240);
            this.rbInactivos.Name = "rbInactivos";
            this.rbInactivos.Size = new System.Drawing.Size(88, 24);
            this.rbInactivos.TabIndex = 15;
            this.rbInactivos.TabStop = true;
            this.rbInactivos.Text = "Inactivos";
            this.rbInactivos.UseVisualStyleBackColor = true;
            this.rbInactivos.CheckedChanged += new System.EventHandler(this.RbEstado_CheckedChange);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbActivos.Location = new System.Drawing.Point(20, 190);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(78, 24);
            this.rbActivos.TabIndex = 14;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.RbEstado_CheckedChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estado";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbTodos.Location = new System.Drawing.Point(20, 140);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(70, 24);
            this.rbTodos.TabIndex = 13;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.RbEstado_CheckedChange);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(80, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 27);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuscar.Location = new System.Drawing.Point(20, 40);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(52, 20);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
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
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCategoria,
            this.colDescripcion,
            this.colEstado});
            this.dgvCategorias.Location = new System.Drawing.Point(380, 70);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(860, 510);
            this.dgvCategorias.TabIndex = 10;
            this.dgvCategorias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvCategorias_CellFormatting);
            this.dgvCategorias.SelectionChanged += new System.EventHandler(this.DgvCategorias_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 100;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.FillWeight = 9.625671F;
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.MinimumWidth = 180;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "Descrip";
            this.colDescripcion.FillWeight = 280.7487F;
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.MinimumWidth = 200;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.FillWeight = 9.625671F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 120;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
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
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstado.Enabled = false;
            this.btnEstado.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEstado.ImageIndex = 0;
            this.btnEstado.ImageList = this.imgListEstado;
            this.btnEstado.Location = new System.Drawing.Point(40, 180);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(300, 90);
            this.btnEstado.TabIndex = 12;
            this.btnEstado.Text = "Cambiar Estado";
            this.btnEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.BtnEstado_Click);
            // 
            // imgListEstado
            // 
            this.imgListEstado.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListEstado.ImageStream")));
            this.imgListEstado.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListEstado.Images.SetKeyName(0, "Actualizar_Estado.png");
            this.imgListEstado.Images.SetKeyName(1, "Encendido.png");
            this.imgListEstado.Images.SetKeyName(2, "Apagado.png");
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarCategoria.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnModificarCategoria.ImageIndex = 1;
            this.btnModificarCategoria.ImageList = this.imgListBotones;
            this.btnModificarCategoria.Location = new System.Drawing.Point(200, 70);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(140, 90);
            this.btnModificarCategoria.TabIndex = 9;
            this.btnModificarCategoria.Text = "Modificar Categoria";
            this.btnModificarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnAgregarCategoria.ImageIndex = 0;
            this.btnAgregarCategoria.ImageList = this.imgListBotones;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(40, 70);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(140, 90);
            this.btnAgregarCategoria.TabIndex = 8;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.gbFiltroCategoria);
            this.Controls.Add(this.lblTituloGestionCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoria";
            this.Text = "FormCategorias";
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            this.gbFiltroCategoria.ResumeLayout(false);
            this.gbFiltroCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.GroupBox gbFiltroCategoria;
        private System.Windows.Forms.Label lblTituloGestionCategoria;
        private System.Windows.Forms.ImageList imgListBotones;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.RadioButton rbInactivos;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.ImageList imgListEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}