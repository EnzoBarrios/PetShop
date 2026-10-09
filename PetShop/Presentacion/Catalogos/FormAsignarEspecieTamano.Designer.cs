namespace PetShop.Presentacion.Catalogos
{
    partial class FormAsignarEspecieTamano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignarEspecieTamano));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.imgListBotones = new System.Windows.Forms.ImageList(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblAltaCategoria = new System.Windows.Forms.Label();
            this.lblTamano = new System.Windows.Forms.Label();
            this.cbxEspecie = new System.Windows.Forms.ComboBox();
            this.cbxTamano = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageIndex = 1;
            this.btnCancelar.ImageList = this.imgListBotones;
            this.btnCancelar.Location = new System.Drawing.Point(416, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 50);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // imgListBotones
            // 
            this.imgListBotones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListBotones.ImageStream")));
            this.imgListBotones.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListBotones.Images.SetKeyName(0, "Guardar.png");
            this.imgListBotones.Images.SetKeyName(1, "Cancelar_Venta.png");
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageIndex = 0;
            this.btnGuardar.ImageList = this.imgListBotones;
            this.btnGuardar.Location = new System.Drawing.Point(290, 228);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 50);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(64, 90);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(147, 19);
            this.lblEspecie.TabIndex = 23;
            this.lblEspecie.Text = "Seleccionar Especie: ";
            // 
            // lblAltaCategoria
            // 
            this.lblAltaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAltaCategoria.AutoSize = true;
            this.lblAltaCategoria.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCategoria.Location = new System.Drawing.Point(111, 20);
            this.lblAltaCategoria.Name = "lblAltaCategoria";
            this.lblAltaCategoria.Size = new System.Drawing.Size(379, 41);
            this.lblAltaCategoria.TabIndex = 22;
            this.lblAltaCategoria.Text = "Asignar Especie y Tamaño";
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamano.Location = new System.Drawing.Point(332, 90);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(151, 19);
            this.lblTamano.TabIndex = 27;
            this.lblTamano.Text = "Seleccionar Tamaño: ";
            // 
            // cbxEspecie
            // 
            this.cbxEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecie.FormattingEnabled = true;
            this.cbxEspecie.Location = new System.Drawing.Point(68, 113);
            this.cbxEspecie.Name = "cbxEspecie";
            this.cbxEspecie.Size = new System.Drawing.Size(200, 24);
            this.cbxEspecie.TabIndex = 29;
            this.cbxEspecie.SelectedIndexChanged += new System.EventHandler(this.CbxEspecie_SelectedIndexChanged);
            // 
            // cbxTamano
            // 
            this.cbxTamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTamano.FormattingEnabled = true;
            this.cbxTamano.Location = new System.Drawing.Point(336, 112);
            this.cbxTamano.Name = "cbxTamano";
            this.cbxTamano.Size = new System.Drawing.Size(200, 24);
            this.cbxTamano.TabIndex = 30;
            this.cbxTamano.SelectedIndexChanged += new System.EventHandler(this.CbxTamano_SelectedIndexChanged);
            // 
            // FormAsignarEspecieTamano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.cbxTamano);
            this.Controls.Add(this.cbxEspecie);
            this.Controls.Add(this.lblTamano);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblAltaCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAsignarEspecieTamano";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAsignarEspecieTamano_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblAltaCategoria;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.ImageList imgListBotones;
        private System.Windows.Forms.ComboBox cbxEspecie;
        private System.Windows.Forms.ComboBox cbxTamano;
    }
}