namespace LibFormularios
{
    partial class FrmEditarRegistrosXTramite
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChlRequisitosXTramite
            // 
            this.ChlRequisitosXTramite.FormattingEnabled = true;
            this.ChlRequisitosXTramite.Location = new System.Drawing.Point(262, 157);
            this.ChlRequisitosXTramite.Name = "ChlRequisitosXTramite";
            this.ChlRequisitosXTramite.Size = new System.Drawing.Size(282, 242);
            this.ChlRequisitosXTramite.TabIndex = 0;
            // 
            // CboCodTramite
            // 
            this.CboCodTramite.BackColor = System.Drawing.SystemColors.Control;
            this.CboCodTramite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCodTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodTramite.FormattingEnabled = true;
            this.CboCodTramite.Location = new System.Drawing.Point(308, 56);
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
            this.label4.Location = new System.Drawing.Point(160, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 146;
            this.label4.Text = "CodTramite:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(347, 405);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 46);
            this.BtnGuardar.TabIndex = 148;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmEditarRegistrosXTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 514);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CboCodTramite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChlRequisitosXTramite);
            this.Name = "FrmEditarRegistrosXTramite";
            this.Text = "d";
            this.Load += new System.EventHandler(this.FrmEditarRegistrosXTramite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChlRequisitosXTramite;
        private System.Windows.Forms.ComboBox CboCodTramite;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuardar;
    }
}