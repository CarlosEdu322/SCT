namespace LibFormularios
{
    partial class FrmGenerarExpediente
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
            this.label1 = new System.Windows.Forms.Label();
            this.DgvTramitesDeInscripcion = new System.Windows.Forms.DataGridView();
            this.BtnGenerarTramite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramitesDeInscripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar Expediente";
            // 
            // DgvTramitesDeInscripcion
            // 
            this.DgvTramitesDeInscripcion.AllowUserToAddRows = false;
            this.DgvTramitesDeInscripcion.AllowUserToDeleteRows = false;
            this.DgvTramitesDeInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTramitesDeInscripcion.Location = new System.Drawing.Point(39, 177);
            this.DgvTramitesDeInscripcion.Name = "DgvTramitesDeInscripcion";
            this.DgvTramitesDeInscripcion.ReadOnly = true;
            this.DgvTramitesDeInscripcion.RowHeadersWidth = 51;
            this.DgvTramitesDeInscripcion.RowTemplate.Height = 24;
            this.DgvTramitesDeInscripcion.Size = new System.Drawing.Size(860, 150);
            this.DgvTramitesDeInscripcion.TabIndex = 1;
            // 
            // BtnGenerarTramite
            // 
            this.BtnGenerarTramite.Location = new System.Drawing.Point(59, 344);
            this.BtnGenerarTramite.Name = "BtnGenerarTramite";
            this.BtnGenerarTramite.Size = new System.Drawing.Size(159, 36);
            this.BtnGenerarTramite.TabIndex = 2;
            this.BtnGenerarTramite.Text = "Generar Tramite";
            this.BtnGenerarTramite.UseVisualStyleBackColor = true;
            this.BtnGenerarTramite.Click += new System.EventHandler(this.BtnGenerarTramite_Click);
            // 
            // FrmGenerarExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.BtnGenerarTramite);
            this.Controls.Add(this.DgvTramitesDeInscripcion);
            this.Controls.Add(this.label1);
            this.Name = "FrmGenerarExpediente";
            this.Text = "FrmGenerarExpediente";
            this.Load += new System.EventHandler(this.FrmGenerarExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramitesDeInscripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvTramitesDeInscripcion;
        private System.Windows.Forms.Button BtnGenerarTramite;
    }
}