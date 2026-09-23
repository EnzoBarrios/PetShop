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
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.TBuscar = new System.Windows.Forms.TextBox();
            this.LBuscar = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEstado
            // 
            this.btnEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEstado.Location = new System.Drawing.Point(1086, 7);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(132, 56);
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
            this.btnModificarUsuario.Location = new System.Drawing.Point(547, 3);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(132, 60);
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
            this.btnNuevoUsuario.Location = new System.Drawing.Point(3, 7);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(132, 56);
            this.btnNuevoUsuario.TabIndex = 30;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.BtnNuevoUsuario_Click);
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.AllowUserToAddRows = false;
            this.DGVUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Location = new System.Drawing.Point(30, 93);
            this.DGVUsuarios.MultiSelect = false;
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.ReadOnly = true;
            this.DGVUsuarios.RowHeadersWidth = 62;
            this.DGVUsuarios.RowTemplate.Height = 28;
            this.DGVUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsuarios.Size = new System.Drawing.Size(1221, 397);
            this.DGVUsuarios.TabIndex = 29;
            this.DGVUsuarios.SelectionChanged += new System.EventHandler(this.DGVUsuarios_SelectionChanged);
            // 
            // TBuscar
            // 
            this.TBuscar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.TBuscar.Location = new System.Drawing.Point(109, 64);
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(217, 25);
            this.TBuscar.TabIndex = 28;
            this.TBuscar.TextChanged += new System.EventHandler(this.TBuscar_TextChanged);
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LBuscar.ForeColor = System.Drawing.Color.Black;
            this.LBuscar.Location = new System.Drawing.Point(29, 64);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(49, 19);
            this.LBuscar.TabIndex = 27;
            this.LBuscar.Text = "Buscar";
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LTitulo.Location = new System.Drawing.Point(263, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(755, 48);
            this.LTitulo.TabIndex = 26;
            this.LTitulo.Text = "Gestión de Usuarios";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // PanelSuperior
            // 
            this.PanelSuperior.Controls.Add(this.btnVolver);
            this.PanelSuperior.Controls.Add(this.LBuscar);
            this.PanelSuperior.Controls.Add(this.LTitulo);
            this.PanelSuperior.Controls.Add(this.TBuscar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1280, 93);
            this.PanelSuperior.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnModificarUsuario);
            this.panel1.Controls.Add(this.btnNuevoUsuario);
            this.panel1.Controls.Add(this.btnEstado);
            this.panel1.Location = new System.Drawing.Point(30, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 68);
            this.panel1.TabIndex = 36;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(30, 20);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 32);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(800, 450);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.DGVUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.TextBox TBuscar;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
    }
}