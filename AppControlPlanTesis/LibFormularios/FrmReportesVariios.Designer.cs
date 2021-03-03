namespace LibFormularios
{
    partial class FrmReportesVariios
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.RvwReporteTesisPendientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RvwReporteTesisPendientes);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 523);
            this.panel2.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.LblTitulo.Location = new System.Drawing.Point(0, 21);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(851, 54);
            this.LblTitulo.TabIndex = 239;
            this.LblTitulo.Text = "Tesis no Concluidas";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RvwReporteTesisPendientes
            // 
            this.RvwReporteTesisPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvwReporteTesisPendientes.Location = new System.Drawing.Point(0, 100);
            this.RvwReporteTesisPendientes.Name = "RvwReporteTesisPendientes";
            this.RvwReporteTesisPendientes.ServerReport.BearerToken = null;
            this.RvwReporteTesisPendientes.Size = new System.Drawing.Size(851, 423);
            this.RvwReporteTesisPendientes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 100);
            this.panel1.TabIndex = 240;
            // 
            // FrmReportesVariios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 523);
            this.Controls.Add(this.panel2);
            this.Name = "FrmReportesVariios";
            this.Text = "FrmReportesVariios";
            this.Load += new System.EventHandler(this.FrmReportesVariios_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer RvwReporteTesisPendientes;
        protected System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel panel1;
    }
}