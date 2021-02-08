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
            this.ChlRequisitosXTramite.Location = new System.Drawing.Point(196, 128);
            this.ChlRequisitosXTramite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChlRequisitosXTramite.Name = "ChlRequisitosXTramite";
            this.ChlRequisitosXTramite.Size = new System.Drawing.Size(212, 184);
            this.ChlRequisitosXTramite.TabIndex = 0;
            // 
            // CboCodTramite
            // 
            this.CboCodTramite.BackColor = System.Drawing.SystemColors.Control;
            this.CboCodTramite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCodTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodTramite.FormattingEnabled = true;
            this.CboCodTramite.Location = new System.Drawing.Point(231, 46);
            this.CboCodTramite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboCodTramite.Name = "CboCodTramite";
            this.CboCodTramite.Size = new System.Drawing.Size(251, 25);
            this.CboCodTramite.TabIndex = 147;
            this.CboCodTramite.SelectedIndexChanged += new System.EventHandler(this.CboCodTramite_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(120, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 146;
            this.label4.Text = "CodTramite:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(244, 330);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(164, 48);
            this.BtnGuardar.TabIndex = 177;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmEditarRegistrosXTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(730, 418);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CboCodTramite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChlRequisitosXTramite);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        protected System.Windows.Forms.Button BtnGuardar;
    }
}