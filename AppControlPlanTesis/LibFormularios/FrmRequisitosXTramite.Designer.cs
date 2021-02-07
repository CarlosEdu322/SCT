namespace LibFormularios
{
    partial class FrmRequisitosXTramite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequisitosXTramite));
            this.TxtCodTramite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtCodRequisito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChlRequisitosXTramite = new System.Windows.Forms.CheckedListBox();
            this.CboCodTramite = new System.Windows.Forms.ComboBox();
            this.DgvTramiteXRequisito = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramiteXRequisito)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnGuardar.Visible = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnNuevo.Visible = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1114, 78);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(1114, 78);
            this.LblTitulo.Text = "Requisitos X Tramite";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 608);
            this.panel2.Size = new System.Drawing.Size(1114, 84);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DgvTramiteXRequisito);
            this.panel3.Controls.Add(this.CboCodTramite);
            this.panel3.Controls.Add(this.ChlRequisitosXTramite);
            this.panel3.Controls.Add(this.TxtCodRequisito);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.BtnBuscar);
            this.panel3.Controls.Add(this.TxtCodTramite);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Size = new System.Drawing.Size(1114, 692);
            // 
            // TxtCodTramite
            // 
            this.TxtCodTramite.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtCodTramite.Location = new System.Drawing.Point(16, 94);
            this.TxtCodTramite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodTramite.Name = "TxtCodTramite";
            this.TxtCodTramite.Size = new System.Drawing.Size(279, 30);
            this.TxtCodTramite.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(260, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 127;
            this.label4.Text = "CodTramite:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(312, 94);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(49, 41);
            this.BtnBuscar.TabIndex = 140;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCodRequisito
            // 
            this.TxtCodRequisito.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtCodRequisito.Location = new System.Drawing.Point(441, 216);
            this.TxtCodRequisito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodRequisito.Name = "TxtCodRequisito";
            this.TxtCodRequisito.Size = new System.Drawing.Size(279, 30);
            this.TxtCodRequisito.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(260, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 143;
            this.label2.Text = "NombreTramite:";
            // 
            // ChlRequisitosXTramite
            // 
            this.ChlRequisitosXTramite.FormattingEnabled = true;
            this.ChlRequisitosXTramite.Location = new System.Drawing.Point(264, 268);
            this.ChlRequisitosXTramite.Name = "ChlRequisitosXTramite";
            this.ChlRequisitosXTramite.Size = new System.Drawing.Size(486, 276);
            this.ChlRequisitosXTramite.TabIndex = 144;
            // 
            // CboCodTramite
            // 
            this.CboCodTramite.BackColor = System.Drawing.SystemColors.Control;
            this.CboCodTramite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCodTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodTramite.FormattingEnabled = true;
            this.CboCodTramite.Location = new System.Drawing.Point(387, 155);
            this.CboCodTramite.Name = "CboCodTramite";
            this.CboCodTramite.Size = new System.Drawing.Size(333, 30);
            this.CboCodTramite.TabIndex = 145;
            this.CboCodTramite.SelectedIndexChanged += new System.EventHandler(this.CboCodTramite_SelectedIndexChanged);
            this.CboCodTramite.TextChanged += new System.EventHandler(this.CboCodTramite_TextChanged);
            // 
            // DgvTramiteXRequisito
            // 
            this.DgvTramiteXRequisito.AllowUserToAddRows = false;
            this.DgvTramiteXRequisito.AllowUserToDeleteRows = false;
            this.DgvTramiteXRequisito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTramiteXRequisito.Location = new System.Drawing.Point(111, 361);
            this.DgvTramiteXRequisito.Name = "DgvTramiteXRequisito";
            this.DgvTramiteXRequisito.ReadOnly = true;
            this.DgvTramiteXRequisito.RowHeadersWidth = 51;
            this.DgvTramiteXRequisito.RowTemplate.Height = 24;
            this.DgvTramiteXRequisito.Size = new System.Drawing.Size(822, 207);
            this.DgvTramiteXRequisito.TabIndex = 146;
            // 
            // FrmRequisitosXTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 692);
            this.Name = "FrmRequisitosXTramite";
            this.Text = "FrmRequisitosXTramite";
            this.Load += new System.EventHandler(this.FrmRequisitosXTramite_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramiteXRequisito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtCodTramite;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtCodRequisito;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ChlRequisitosXTramite;
        private System.Windows.Forms.ComboBox CboCodTramite;
        private System.Windows.Forms.DataGridView DgvTramiteXRequisito;
    }
}