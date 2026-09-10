namespace PetShop.Presentacion
{
    partial class FormHistorialVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialVentas));
            this.gbInformacionVenta = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblTituloHistorialVentas = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.IdDetalleVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbonadoEfectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbonadoTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbonadoQR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbInformacionVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInformacionVenta
            // 
            this.gbInformacionVenta.Controls.Add(this.button1);
            this.gbInformacionVenta.Controls.Add(this.txtStock);
            this.gbInformacionVenta.Controls.Add(this.txtProducto);
            this.gbInformacionVenta.Controls.Add(this.lblBuscador);
            this.gbInformacionVenta.Controls.Add(this.lblFechaHasta);
            this.gbInformacionVenta.Controls.Add(this.txtCodProducto);
            this.gbInformacionVenta.Controls.Add(this.lblFechaDesde);
            this.gbInformacionVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacionVenta.Location = new System.Drawing.Point(20, 60);
            this.gbInformacionVenta.Name = "gbInformacionVenta";
            this.gbInformacionVenta.Size = new System.Drawing.Size(780, 100);
            this.gbInformacionVenta.TabIndex = 5;
            this.gbInformacionVenta.TabStop = false;
            this.gbInformacionVenta.Text = "Filtros de Busqueda";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(695, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Buscar.png");
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(525, 50);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(120, 25);
            this.txtStock.TabIndex = 14;
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(295, 50);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(120, 25);
            this.txtProducto.TabIndex = 12;
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.Location = new System.Drawing.Point(455, 53);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(65, 17);
            this.lblBuscador.TabIndex = 9;
            this.lblBuscador.Text = "Buscador:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(245, 50);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(44, 17);
            this.lblFechaHasta.TabIndex = 7;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(85, 50);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(120, 25);
            this.txtCodProducto.TabIndex = 6;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(30, 50);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(48, 17);
            this.lblFechaDesde.TabIndex = 5;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblTituloHistorialVentas
            // 
            this.lblTituloHistorialVentas.AutoSize = true;
            this.lblTituloHistorialVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHistorialVentas.Location = new System.Drawing.Point(12, 9);
            this.lblTituloHistorialVentas.Name = "lblTituloHistorialVentas";
            this.lblTituloHistorialVentas.Size = new System.Drawing.Size(191, 28);
            this.lblTituloHistorialVentas.TabIndex = 4;
            this.lblTituloHistorialVentas.Text = "Historial de Ventas";
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetalleVenta,
            this.Ticket,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.AbonadoEfectivo,
            this.AbonadoTransferencia,
            this.AbonadoQR,
            this.btnQuitarProducto});
            this.dgvVenta.Location = new System.Drawing.Point(20, 180);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersWidth = 51;
            this.dgvVenta.RowTemplate.Height = 24;
            this.dgvVenta.Size = new System.Drawing.Size(780, 400);
            this.dgvVenta.TabIndex = 6;
            // 
            // IdDetalleVenta
            // 
            this.IdDetalleVenta.HeaderText = "";
            this.IdDetalleVenta.MinimumWidth = 6;
            this.IdDetalleVenta.Name = "IdDetalleVenta";
            this.IdDetalleVenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdDetalleVenta.Visible = false;
            this.IdDetalleVenta.Width = 50;
            // 
            // Ticket
            // 
            this.Ticket.HeaderText = "Ticket";
            this.Ticket.MinimumWidth = 6;
            this.Ticket.Name = "Ticket";
            this.Ticket.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Fecha";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Hora";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Monto Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 125;
            // 
            // AbonadoEfectivo
            // 
            this.AbonadoEfectivo.HeaderText = "Abonado en Efectivo";
            this.AbonadoEfectivo.MinimumWidth = 6;
            this.AbonadoEfectivo.Name = "AbonadoEfectivo";
            this.AbonadoEfectivo.Width = 125;
            // 
            // AbonadoTransferencia
            // 
            this.AbonadoTransferencia.HeaderText = "Abonado en Transferencia";
            this.AbonadoTransferencia.MinimumWidth = 6;
            this.AbonadoTransferencia.Name = "AbonadoTransferencia";
            this.AbonadoTransferencia.Width = 125;
            // 
            // AbonadoQR
            // 
            this.AbonadoQR.HeaderText = "Abonado en QR";
            this.AbonadoQR.MinimumWidth = 6;
            this.AbonadoQR.Name = "AbonadoQR";
            this.AbonadoQR.Width = 125;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.HeaderText = "";
            this.btnQuitarProducto.MinimumWidth = 6;
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.ReadOnly = true;
            this.btnQuitarProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnQuitarProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnQuitarProducto.Width = 40;
            // 
            // FormHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 600);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.gbInformacionVenta);
            this.Controls.Add(this.lblTituloHistorialVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorialVentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHistorialVentas_Load);
            this.gbInformacionVenta.ResumeLayout(false);
            this.gbInformacionVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacionVenta;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblTituloHistorialVentas;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbonadoEfectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbonadoTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbonadoQR;
        private System.Windows.Forms.DataGridViewButtonColumn btnQuitarProducto;
    }
}