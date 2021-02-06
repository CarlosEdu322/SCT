namespace LibFormularios
{
    partial class FrmEditarRegistroXTramite
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
            this.ChlRequisitosXTramite = new System.Windows.Forms.CheckedListBox();
            this.CboCodTramite = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(892, 78);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(892, 78);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Size = new System.Drawing.Size(892, 84);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CboCodTramite);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ChlRequisitosXTramite);
            this.panel3.Size = new System.Drawing.Size(892, 504);
            // 
            // ChlRequisitosXTramite
            // 
            this.ChlRequisitosXTramite.FormattingEnabled = true;
            this.ChlRequisitosXTramite.Location = new System.Drawing.Point(263, 159);
            this.ChlRequisitosXTramite.Name = "ChlRequisitosXTramite";
            this.ChlRequisitosXTramite.Size = new System.Drawing.Size(396, 242);
            this.ChlRequisitosXTramite.TabIndex = 0;
            // 
            // CboCodTramite
            // 
            this.CboCodTramite.BackColor = System.Drawing.SystemColors.Control;
            this.CboCodTramite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCodTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodTramite.FormattingEnabled = true;
            this.CboCodTramite.Location = new System.Drawing.Point(344, 105);
            this.CboCodTramite.Name = "CboCodTramite";
            this.CboCodTramite.Size = new System.Drawing.Size(333, 30);
            this.CboCodTramite.TabIndex = 147;
            this.CboCodTramite.SelectedIndexChanged += new System.EventHandler(this.CboCodTramite_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(167, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 146;
            this.label4.Text = "CodTramite:";
            // 
            // FrmEditarRegistroXTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 508);
            this.Name = "FrmEditarRegistroXTramite";
            this.Text = "FrmEditarRegistroXTramite";
            this.Load += new System.EventHandler(this.FrmEditarRegistroXTramite_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChlRequisitosXTramite;
        private System.Windows.Forms.ComboBox CboCodTramite;
        protected System.Windows.Forms.Label label4;
    }
}