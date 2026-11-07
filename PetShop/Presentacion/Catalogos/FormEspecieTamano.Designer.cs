namespace PetShop.Presentacion.Catalogos
{
    partial class FormEspecieTamano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEspecieTamano));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgListBotones = new System.Windows.Forms.ImageList(this.components);
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvEspecieTamano = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarEspecie = new System.Windows.Forms.Button();
            this.btnAgregarEspecie = new System.Windows.Forms.Button();
            this.gbFiltroMascota = new System.Windows.Forms.GroupBox();
            this.rbInactivos = new System.Windows.Forms.RadioButton();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rbTodosEstado = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblTituloGestionEspecie = new System.Windows.Forms.Label();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.imgListEstado = new System.Windows.Forms.ImageList(this.components);
            this.cmsOpcionesAgregar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAgregarEspecie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAgregarTamano = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOpcionesModificar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiModificarEspecie = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarTamano = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarTamano = new System.Windows.Forms.Button();
            this.btnModificarTamano = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecieTamano)).BeginInit();
            this.gbFiltroMascota.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgListBotones
            // 
            this.imgListBotones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListBotones.ImageStream")));
            this.imgListBotones.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListBotones.Images.SetKeyName(0, "Agregar_Venta.png");
            this.imgListBotones.Images.SetKeyName(1, "Modificar.png");
            this.imgListBotones.Images.SetKeyName(2, "Asignar.png");
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ImageIndex = 2;
            this.btnModificar.ImageList = this.imgListBotones;
            this.btnModificar.Location = new System.Drawing.Point(40, 180);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 75);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Asignar Combinación";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnAsignarCombinacion_Click);
            // 
            // dgvEspecieTamano
            // 
            this.dgvEspecieTamano.AllowUserToAddRows = false;
            this.dgvEspecieTamano.AllowUserToDeleteRows = false;
            this.dgvEspecieTamano.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecieTamano.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEspecieTamano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecieTamano.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colEspecie,
            this.colTamano,
            this.colEstado});
            this.dgvEspecieTamano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecieTamano.Location = new System.Drawing.Point(20, 10);
            this.dgvEspecieTamano.MultiSelect = false;
            this.dgvEspecieTamano.Name = "dgvEspecieTamano";
            this.dgvEspecieTamano.ReadOnly = true;
            this.dgvEspecieTamano.RowHeadersWidth = 51;
            this.dgvEspecieTamano.RowTemplate.Height = 24;
            this.dgvEspecieTamano.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecieTamano.Size = new System.Drawing.Size(860, 530);
            this.dgvEspecieTamano.TabIndex = 17;
            this.dgvEspecieTamano.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvMascotas_CellFormatting);
            this.dgvEspecieTamano.SelectionChanged += new System.EventHandler(this.DgvMascotas_SelectionChanged);
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
            // colEspecie
            // 
            this.colEspecie.DataPropertyName = "colEspecie";
            this.colEspecie.HeaderText = "Especie";
            this.colEspecie.MinimumWidth = 200;
            this.colEspecie.Name = "colEspecie";
            this.colEspecie.ReadOnly = true;
            // 
            // colTamano
            // 
            this.colTamano.DataPropertyName = "colTamano";
            this.colTamano.HeaderText = "Tamaño";
            this.colTamano.MinimumWidth = 200;
            this.colTamano.Name = "colTamano";
            this.colTamano.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "colEstado";
            this.colEstado.FillWeight = 9.625671F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 120;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // btnModificarEspecie
            // 
            this.btnModificarEspecie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarEspecie.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEspecie.ImageIndex = 1;
            this.btnModificarEspecie.ImageList = this.imgListBotones;
            this.btnModificarEspecie.Location = new System.Drawing.Point(190, 95);
            this.btnModificarEspecie.Name = "btnModificarEspecie";
            this.btnModificarEspecie.Size = new System.Drawing.Size(140, 75);
            this.btnModificarEspecie.TabIndex = 16;
            this.btnModificarEspecie.Text = "Modificar Especie";
            this.btnModificarEspecie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarEspecie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificarEspecie.UseVisualStyleBackColor = false;
            this.btnModificarEspecie.Click += new System.EventHandler(this.BtnModificarEspecie_Click);
            // 
            // btnAgregarEspecie
            // 
            this.btnAgregarEspecie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarEspecie.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspecie.ImageIndex = 0;
            this.btnAgregarEspecie.ImageList = this.imgListBotones;
            this.btnAgregarEspecie.Location = new System.Drawing.Point(40, 10);
            this.btnAgregarEspecie.Name = "btnAgregarEspecie";
            this.btnAgregarEspecie.Size = new System.Drawing.Size(140, 75);
            this.btnAgregarEspecie.TabIndex = 15;
            this.btnAgregarEspecie.Text = "Agregar Especie";
            this.btnAgregarEspecie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarEspecie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarEspecie.UseVisualStyleBackColor = false;
            this.btnAgregarEspecie.Click += new System.EventHandler(this.BtnAgregarEspecie_Click);
            // 
            // gbFiltroMascota
            // 
            this.gbFiltroMascota.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbFiltroMascota.Controls.Add(this.rbInactivos);
            this.gbFiltroMascota.Controls.Add(this.rbActivos);
            this.gbFiltroMascota.Controls.Add(this.lblEstado);
            this.gbFiltroMascota.Controls.Add(this.rbTodosEstado);
            this.gbFiltroMascota.Controls.Add(this.txtBuscar);
            this.gbFiltroMascota.Controls.Add(this.lblBuscar);
            this.gbFiltroMascota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroMascota.Location = new System.Drawing.Point(40, 280);
            this.gbFiltroMascota.Name = "gbFiltroMascota";
            this.gbFiltroMascota.Size = new System.Drawing.Size(300, 257);
            this.gbFiltroMascota.TabIndex = 14;
            this.gbFiltroMascota.TabStop = false;
            this.gbFiltroMascota.Text = "Filtros y Busqueda";
            // 
            // rbInactivos
            // 
            this.rbInactivos.AutoSize = true;
            this.rbInactivos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbInactivos.Location = new System.Drawing.Point(24, 205);
            this.rbInactivos.Name = "rbInactivos";
            this.rbInactivos.Size = new System.Drawing.Size(88, 24);
            this.rbInactivos.TabIndex = 19;
            this.rbInactivos.TabStop = true;
            this.rbInactivos.Text = "Inactivos";
            this.rbInactivos.UseVisualStyleBackColor = true;
            this.rbInactivos.CheckedChanged += new System.EventHandler(this.RbEstado_CheckedChanged);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbActivos.Location = new System.Drawing.Point(24, 160);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(78, 24);
            this.rbActivos.TabIndex = 18;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.RbEstado_CheckedChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(20, 80);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 20);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado";
            // 
            // rbTodosEstado
            // 
            this.rbTodosEstado.AutoSize = true;
            this.rbTodosEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbTodosEstado.Location = new System.Drawing.Point(24, 115);
            this.rbTodosEstado.Name = "rbTodosEstado";
            this.rbTodosEstado.Size = new System.Drawing.Size(70, 24);
            this.rbTodosEstado.TabIndex = 17;
            this.rbTodosEstado.TabStop = true;
            this.rbTodosEstado.Text = "Todos";
            this.rbTodosEstado.UseVisualStyleBackColor = true;
            this.rbTodosEstado.CheckedChanged += new System.EventHandler(this.RbEstado_CheckedChanged);
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
            // lblTituloGestionEspecie
            // 
            this.lblTituloGestionEspecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloGestionEspecie.AutoSize = true;
            this.lblTituloGestionEspecie.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloGestionEspecie.ForeColor = System.Drawing.Color.Black;
            this.lblTituloGestionEspecie.Location = new System.Drawing.Point(463, 15);
            this.lblTituloGestionEspecie.Name = "lblTituloGestionEspecie";
            this.lblTituloGestionEspecie.Size = new System.Drawing.Size(355, 32);
            this.lblTituloGestionEspecie.TabIndex = 13;
            this.lblTituloGestionEspecie.Text = "Gestión de Especies y Tamaño";
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCambiarEstado.Enabled = false;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.ImageIndex = 0;
            this.btnCambiarEstado.ImageList = this.imgListEstado;
            this.btnCambiarEstado.Location = new System.Drawing.Point(190, 180);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(140, 75);
            this.btnCambiarEstado.TabIndex = 20;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambiarEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.BtnCambiarEstado_Click);
            // 
            // imgListEstado
            // 
            this.imgListEstado.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListEstado.ImageStream")));
            this.imgListEstado.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListEstado.Images.SetKeyName(0, "Actualizar_Estado.png");
            this.imgListEstado.Images.SetKeyName(1, "Encendido.png");
            this.imgListEstado.Images.SetKeyName(2, "Apagado.png");
            // 
            // cmsOpcionesAgregar
            // 
            this.cmsOpcionesAgregar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOpcionesAgregar.Name = "cmsOpcionesAgregar";
            this.cmsOpcionesAgregar.Size = new System.Drawing.Size(61, 4);
            // 
            // tsmiAgregarEspecie
            // 
            this.tsmiAgregarEspecie.Name = "tsmiAgregarEspecie";
            this.tsmiAgregarEspecie.Size = new System.Drawing.Size(32, 19);
            // 
            // tsmiAgregarTamano
            // 
            this.tsmiAgregarTamano.Name = "tsmiAgregarTamano";
            this.tsmiAgregarTamano.Size = new System.Drawing.Size(32, 19);
            // 
            // cmsOpcionesModificar
            // 
            this.cmsOpcionesModificar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOpcionesModificar.Name = "cmsOpcionesModificar";
            this.cmsOpcionesModificar.Size = new System.Drawing.Size(61, 4);
            // 
            // tsmiModificarEspecie
            // 
            this.tsmiModificarEspecie.Name = "tsmiModificarEspecie";
            this.tsmiModificarEspecie.Size = new System.Drawing.Size(32, 19);
            // 
            // tsmiModificarTamano
            // 
            this.tsmiModificarTamano.Name = "tsmiModificarTamano";
            this.tsmiModificarTamano.Size = new System.Drawing.Size(32, 19);
            // 
            // btnAgregarTamano
            // 
            this.btnAgregarTamano.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarTamano.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTamano.ImageIndex = 0;
            this.btnAgregarTamano.ImageList = this.imgListBotones;
            this.btnAgregarTamano.Location = new System.Drawing.Point(40, 95);
            this.btnAgregarTamano.Name = "btnAgregarTamano";
            this.btnAgregarTamano.Size = new System.Drawing.Size(140, 75);
            this.btnAgregarTamano.TabIndex = 23;
            this.btnAgregarTamano.Text = "Agregar Tamaño";
            this.btnAgregarTamano.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarTamano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarTamano.UseVisualStyleBackColor = false;
            this.btnAgregarTamano.Click += new System.EventHandler(this.BtnAgregarTamano_Click);
            // 
            // btnModificarTamano
            // 
            this.btnModificarTamano.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarTamano.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTamano.ImageIndex = 1;
            this.btnModificarTamano.ImageList = this.imgListBotones;
            this.btnModificarTamano.Location = new System.Drawing.Point(190, 10);
            this.btnModificarTamano.Name = "btnModificarTamano";
            this.btnModificarTamano.Size = new System.Drawing.Size(140, 75);
            this.btnModificarTamano.TabIndex = 24;
            this.btnModificarTamano.Text = "Modificar Tamaño";
            this.btnModificarTamano.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarTamano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificarTamano.UseVisualStyleBackColor = false;
            this.btnModificarTamano.Click += new System.EventHandler(this.BtnModificarTamano_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.btnVolver);
            this.pnlTitulo.Controls.Add(this.lblTituloGestionEspecie);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Padding = new System.Windows.Forms.Padding(40, 5, 40, 10);
            this.pnlTitulo.Size = new System.Drawing.Size(1280, 60);
            this.pnlTitulo.TabIndex = 28;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(40, 15);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 40);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnModificarEspecie);
            this.pnlAcciones.Controls.Add(this.btnModificar);
            this.pnlAcciones.Controls.Add(this.btnAgregarTamano);
            this.pnlAcciones.Controls.Add(this.btnCambiarEstado);
            this.pnlAcciones.Controls.Add(this.btnAgregarEspecie);
            this.pnlAcciones.Controls.Add(this.btnModificarTamano);
            this.pnlAcciones.Controls.Add(this.gbFiltroMascota);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 60);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Padding = new System.Windows.Forms.Padding(40, 10, 20, 20);
            this.pnlAcciones.Size = new System.Drawing.Size(360, 560);
            this.pnlAcciones.TabIndex = 29;
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.dgvEspecieTamano);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(360, 60);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Padding = new System.Windows.Forms.Padding(20, 10, 40, 20);
            this.pnlGrilla.Size = new System.Drawing.Size(920, 560);
            this.pnlGrilla.TabIndex = 30;
            // 
            // FormEspecieTamano
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEspecieTamano";
            this.Text = "Gestión de Categorias";
            this.Load += new System.EventHandler(this.FormEspecieTamano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecieTamano)).EndInit();
            this.gbFiltroMascota.ResumeLayout(false);
            this.gbFiltroMascota.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlGrilla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgListBotones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvEspecieTamano;
        private System.Windows.Forms.Button btnModificarEspecie;
        private System.Windows.Forms.Button btnAgregarEspecie;
        private System.Windows.Forms.GroupBox gbFiltroMascota;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblTituloGestionEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamano;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.RadioButton rbInactivos;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.RadioButton rbTodosEstado;
        private System.Windows.Forms.ImageList imgListEstado;
        private System.Windows.Forms.ContextMenuStrip cmsOpcionesAgregar;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarEspecie;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarTamano;
        private System.Windows.Forms.ContextMenuStrip cmsOpcionesModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarEspecie;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarTamano;
        private System.Windows.Forms.Button btnAgregarTamano;
        private System.Windows.Forms.Button btnModificarTamano;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.Button btnVolver;
    }
}