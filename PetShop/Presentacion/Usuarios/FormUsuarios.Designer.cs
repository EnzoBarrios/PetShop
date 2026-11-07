namespace PetShop.Presentacion.Usuarios
{
    partial class FormUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEstado
            // 
            this.btnEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEstado.Location = new System.Drawing.Point(1120, 10);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(120, 50);
            this.btnEstado.TabIndex = 32;
            this.btnEstado.Text = "Desactivar";
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.BtnEstado_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificarUsuario.Location = new System.Drawing.Point(580, 10);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(120, 50);
            this.btnModificarUsuario.TabIndex = 31;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevoUsuario.Location = new System.Drawing.Point(40, 10);
            this.btnNuevoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(120, 50);
            this.btnNuevoUsuario.TabIndex = 30;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.BtnNuevoUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colApellido,
            this.colUsuario,
            this.colRol,
            this.colEstado,
            this.colFecha});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(40, 10);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1200, 430);
            this.dgvUsuarios.TabIndex = 29;
            this.dgvUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvUsuarios_CellFormatting);
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.DgvUsuarios_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "colId";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "colNombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.DataPropertyName = "colApellido";
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.MinimumWidth = 6;
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.DataPropertyName = "colUsuario";
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.MinimumWidth = 6;
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colRol
            // 
            this.colRol.DataPropertyName = "colRol";
            this.colRol.HeaderText = "Rol";
            this.colRol.MinimumWidth = 6;
            this.colRol.Name = "colRol";
            this.colRol.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "colEstado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "colFecha";
            this.colFecha.HeaderText = "Fecha Creación";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtBuscar.Location = new System.Drawing.Point(89, 54);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(217, 25);
            this.txtBuscar.TabIndex = 28;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(36, 56);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(49, 19);
            this.lblBuscar.TabIndex = 27;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitulo.Location = new System.Drawing.Point(533, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 32);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Gestión de Usuarios";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.Transparent;
            this.PanelBotones.ForeColor = System.Drawing.Color.Transparent;
            this.PanelBotones.Location = new System.Drawing.Point(32, 441);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(0, 0);
            this.PanelBotones.TabIndex = 33;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.btnVolver);
            this.pnlTitulo.Controls.Add(this.lblBuscar);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.txtBuscar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Padding = new System.Windows.Forms.Padding(36, 4, 36, 4);
            this.pnlTitulo.Size = new System.Drawing.Size(1280, 80);
            this.pnlTitulo.TabIndex = 35;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.Location = new System.Drawing.Point(36, 12);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(67, 32);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnModificarUsuario);
            this.pnlBotones.Controls.Add(this.btnNuevoUsuario);
            this.pnlBotones.Controls.Add(this.btnEstado);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 540);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Padding = new System.Windows.Forms.Padding(40, 10, 40, 20);
            this.pnlBotones.Size = new System.Drawing.Size(1280, 80);
            this.pnlBotones.TabIndex = 36;
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.dgvUsuarios);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 80);
            this.pnlGrilla.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Padding = new System.Windows.Forms.Padding(40, 10, 40, 20);
            this.pnlGrilla.Size = new System.Drawing.Size(1280, 460);
            this.pnlGrilla.TabIndex = 37;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlGrilla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.Button btnVolver;
    }
}