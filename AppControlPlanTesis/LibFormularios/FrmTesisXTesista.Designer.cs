namespace LibFormularios
{
    partial class FrmTesisXTesista
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
            this.DgvTesisXTesista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesisXTesista)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTesisXTesista
            // 
            this.DgvTesisXTesista.AllowUserToAddRows = false;
            this.DgvTesisXTesista.AllowUserToDeleteRows = false;
            this.DgvTesisXTesista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesisXTesista.Location = new System.Drawing.Point(208, 110);
            this.DgvTesisXTesista.Name = "DgvTesisXTesista";
            this.DgvTesisXTesista.ReadOnly = true;
            this.DgvTesisXTesista.RowHeadersWidth = 51;
            this.DgvTesisXTesista.RowTemplate.Height = 24;
            this.DgvTesisXTesista.Size = new System.Drawing.Size(408, 208);
            this.DgvTesisXTesista.TabIndex = 0;
            // 
            // FrmTesisXTesista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 576);
            this.Controls.Add(this.DgvTesisXTesista);
            this.Name = "FrmTesisXTesista";
            this.Text = "FrmTesisXTesista";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesisXTesista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTesisXTesista;
    }
}