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
            this.BEstado = new System.Windows.Forms.Button();
            this.BModificarUsuario = new System.Windows.Forms.Button();
            this.BNuevoUsuario = new System.Windows.Forms.Button();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.TBuscar = new System.Windows.Forms.TextBox();
            this.LBuscar = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BEstado
            // 
            this.BEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BEstado.Location = new System.Drawing.Point(800, 7);
            this.BEstado.Name = "BEstado";
            this.BEstado.Size = new System.Drawing.Size(132, 56);
            this.BEstado.TabIndex = 32;
            this.BEstado.Text = "Desactivar";
            this.BEstado.UseVisualStyleBackColor = true;
            this.BEstado.Click += new System.EventHandler(this.BEstado_Click);
            // 
            // BModificarUsuario
            // 
            this.BModificarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BModificarUsuario.Location = new System.Drawing.Point(404, 3);
            this.BModificarUsuario.Name = "BModificarUsuario";
            this.BModificarUsuario.Size = new System.Drawing.Size(132, 60);
            this.BModificarUsuario.TabIndex = 31;
            this.BModificarUsuario.Text = "Modificar";
            this.BModificarUsuario.UseVisualStyleBackColor = true;
            this.BModificarUsuario.Click += new System.EventHandler(this.BModificar_Click);
            // 
            // BNuevoUsuario
            // 
            this.BNuevoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BNuevoUsuario.Location = new System.Drawing.Point(3, 7);
            this.BNuevoUsuario.Name = "BNuevoUsuario";
            this.BNuevoUsuario.Size = new System.Drawing.Size(132, 56);
            this.BNuevoUsuario.TabIndex = 30;
            this.BNuevoUsuario.Text = "Nuevo Usuario";
            this.BNuevoUsuario.UseVisualStyleBackColor = true;
            this.BNuevoUsuario.Click += new System.EventHandler(this.BNuevoUsuario_Click);
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
            this.DGVUsuarios.Size = new System.Drawing.Size(935, 279);
            this.DGVUsuarios.TabIndex = 29;
            this.DGVUsuarios.SelectionChanged += new System.EventHandler(this.DGVUsuarios_SelectionChanged);
            // 
            // TBuscar
            // 
            this.TBuscar.Location = new System.Drawing.Point(109, 64);
            this.TBuscar.Name = "TBuscar";
            this.TBuscar.Size = new System.Drawing.Size(217, 26);
            this.TBuscar.TabIndex = 28;
            this.TBuscar.TextChanged += new System.EventHandler(this.TBuscar_TextChanged);
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.ForeColor = System.Drawing.Color.Black;
            this.LBuscar.Location = new System.Drawing.Point(38, 70);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(65, 20);
            this.LBuscar.TabIndex = 27;
            this.LBuscar.Text = "Buscar";
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTitulo.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold);
            this.LTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.LTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LTitulo.Location = new System.Drawing.Point(263, 0);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(469, 48);
            this.LTitulo.TabIndex = 26;
            this.LTitulo.Text = "- GESTIÓN DE USUARIOS -";
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
            this.PanelSuperior.Controls.Add(this.LBuscar);
            this.PanelSuperior.Controls.Add(this.LTitulo);
            this.PanelSuperior.Controls.Add(this.TBuscar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(994, 93);
            this.PanelSuperior.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BModificarUsuario);
            this.panel1.Controls.Add(this.BNuevoUsuario);
            this.panel1.Controls.Add(this.BEstado);
            this.panel1.Location = new System.Drawing.Point(30, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 68);
            this.panel1.TabIndex = 36;
            // 
            // FormUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(800, 450);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.DGVUsuarios);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BEstado;
        private System.Windows.Forms.Button BModificarUsuario;
        private System.Windows.Forms.Button BNuevoUsuario;
        private System.Windows.Forms.DataGridView DGVUsuarios;
        private System.Windows.Forms.TextBox TBuscar;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel panel1;
    }
}