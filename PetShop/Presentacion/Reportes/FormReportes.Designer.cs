namespace PetShop.Presentacion
{
    partial class FormReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTituloReportesStock = new System.Windows.Forms.Label();
            this.gbSeleccionReporte = new System.Windows.Forms.GroupBox();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.gbFiltroStock = new System.Windows.Forms.GroupBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.chkRangoFecha = new System.Windows.Forms.CheckBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvIdTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNroTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbSeleccionReporte.SuspendLayout();
            this.gbFiltroStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ingresar.png");
            this.imageList1.Images.SetKeyName(1, "Cancelar.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTituloReportesStock
            // 
            this.lblTituloReportesStock.AutoSize = true;
            this.lblTituloReportesStock.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloReportesStock.ForeColor = System.Drawing.Color.Black;
            this.lblTituloReportesStock.Location = new System.Drawing.Point(531, 20);
            this.lblTituloReportesStock.Name = "lblTituloReportesStock";
            this.lblTituloReportesStock.Size = new System.Drawing.Size(219, 32);
            this.lblTituloReportesStock.TabIndex = 5;
            this.lblTituloReportesStock.Text = "Reportes de Stock";
            // 
            // gbSeleccionReporte
            // 
            this.gbSeleccionReporte.Controls.Add(this.cboTipoReporte);
            this.gbSeleccionReporte.Controls.Add(this.lblTipoReporte);
            this.gbSeleccionReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionReporte.Location = new System.Drawing.Point(40, 70);
            this.gbSeleccionReporte.Name = "gbSeleccionReporte";
            this.gbSeleccionReporte.Size = new System.Drawing.Size(360, 170);
            this.gbSeleccionReporte.TabIndex = 6;
            this.gbSeleccionReporte.TabStop = false;
            this.gbSeleccionReporte.Text = "Seleccion de Reporte de Stock";
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoReporte.FormattingEnabled = true;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "Stock Bajo Minimo",
            "Stock por Categoria",
            "Stock por Especie",
            "Stock Mensual"});
            this.cboTipoReporte.Location = new System.Drawing.Point(140, 38);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(200, 25);
            this.cboTipoReporte.TabIndex = 9;
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.Location = new System.Drawing.Point(20, 40);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(109, 19);
            this.lblTipoReporte.TabIndex = 8;
            this.lblTipoReporte.Text = "Tipo de Reporte:";
            // 
            // gbFiltroStock
            // 
            this.gbFiltroStock.Controls.Add(this.cboEspecie);
            this.gbFiltroStock.Controls.Add(this.cboCategoria);
            this.gbFiltroStock.Controls.Add(this.dtpHasta);
            this.gbFiltroStock.Controls.Add(this.dtpDesde);
            this.gbFiltroStock.Controls.Add(this.chkRangoFecha);
            this.gbFiltroStock.Controls.Add(this.btnGenerarReporte);
            this.gbFiltroStock.Controls.Add(this.lblEspecie);
            this.gbFiltroStock.Controls.Add(this.lblCategoria);
            this.gbFiltroStock.Controls.Add(this.lblHasta);
            this.gbFiltroStock.Controls.Add(this.lblDesde);
            this.gbFiltroStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroStock.Location = new System.Drawing.Point(40, 260);
            this.gbFiltroStock.Name = "gbFiltroStock";
            this.gbFiltroStock.Size = new System.Drawing.Size(360, 340);
            this.gbFiltroStock.TabIndex = 7;
            this.gbFiltroStock.TabStop = false;
            this.gbFiltroStock.Text = "Filtros de Stock";
            // 
            // cboEspecie
            // 
            this.cboEspecie.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Loro",
            "Pez"});
            this.cboEspecie.Location = new System.Drawing.Point(140, 222);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(200, 25);
            this.cboEspecie.TabIndex = 11;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Accesorios",
            "Alimentos",
            "Juguetes"});
            this.cboCategoria.Location = new System.Drawing.Point(140, 160);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(200, 25);
            this.cboCategoria.TabIndex = 10;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(213, 95);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(120, 25);
            this.dtpHasta.TabIndex = 7;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(20, 95);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(120, 25);
            this.dtpDesde.TabIndex = 6;
            // 
            // chkRangoFecha
            // 
            this.chkRangoFecha.AutoSize = true;
            this.chkRangoFecha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRangoFecha.Location = new System.Drawing.Point(20, 40);
            this.chkRangoFecha.Name = "chkRangoFecha";
            this.chkRangoFecha.Size = new System.Drawing.Size(183, 23);
            this.chkRangoFecha.TabIndex = 5;
            this.chkRangoFecha.Text = "Habilitar Rango de Fecha";
            this.chkRangoFecha.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(40, 294);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(280, 40);
            this.btnGenerarReporte.TabIndex = 4;
            this.btnGenerarReporte.Text = "Generar Reporte de Stock";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(20, 225);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(56, 19);
            this.lblEspecie.TabIndex = 3;
            this.lblEspecie.Text = "Especie:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(20, 160);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(71, 19);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(213, 70);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(47, 19);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(20, 70);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(50, 19);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdTicket,
            this.dgvNroTicket,
            this.dgvFechaTicket,
            this.producto,
            this.categoria,
            this.especie,
            this.stockActual,
            this.stockMinimo,
            this.diferencia,
            this.estado});
            this.dataGridView1.Location = new System.Drawing.Point(420, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(810, 540);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvIdTicket
            // 
            this.dgvIdTicket.HeaderText = "IdTicket";
            this.dgvIdTicket.MinimumWidth = 6;
            this.dgvIdTicket.Name = "dgvIdTicket";
            this.dgvIdTicket.Visible = false;
            this.dgvIdTicket.Width = 125;
            // 
            // dgvNroTicket
            // 
            this.dgvNroTicket.HeaderText = "N° Ticket";
            this.dgvNroTicket.MinimumWidth = 6;
            this.dgvNroTicket.Name = "dgvNroTicket";
            this.dgvNroTicket.Width = 125;
            // 
            // dgvFechaTicket
            // 
            this.dgvFechaTicket.HeaderText = "Fecha";
            this.dgvFechaTicket.MinimumWidth = 6;
            this.dgvFechaTicket.Name = "dgvFechaTicket";
            this.dgvFechaTicket.Width = 125;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.Width = 125;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.Width = 125;
            // 
            // especie
            // 
            this.especie.HeaderText = "Especie";
            this.especie.MinimumWidth = 6;
            this.especie.Name = "especie";
            this.especie.Width = 125;
            // 
            // stockActual
            // 
            this.stockActual.HeaderText = "Stock Actual";
            this.stockActual.MinimumWidth = 6;
            this.stockActual.Name = "stockActual";
            this.stockActual.Width = 125;
            // 
            // stockMinimo
            // 
            this.stockMinimo.HeaderText = "Stock Minimo";
            this.stockMinimo.MinimumWidth = 6;
            this.stockMinimo.Name = "stockMinimo";
            this.stockMinimo.Width = 125;
            // 
            // diferencia
            // 
            this.diferencia.HeaderText = "Diferencia";
            this.diferencia.MinimumWidth = 6;
            this.diferencia.Name = "diferencia";
            this.diferencia.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(40, 20);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 32);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbFiltroStock);
            this.Controls.Add(this.gbSeleccionReporte);
            this.Controls.Add(this.lblTituloReportesStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesión";
            this.gbSeleccionReporte.ResumeLayout(false);
            this.gbSeleccionReporte.PerformLayout();
            this.gbFiltroStock.ResumeLayout(false);
            this.gbFiltroStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTituloReportesStock;
        private System.Windows.Forms.GroupBox gbSeleccionReporte;
        private System.Windows.Forms.GroupBox gbFiltroStock;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.CheckBox chkRangoFecha;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNroTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnVolver;
    }
}