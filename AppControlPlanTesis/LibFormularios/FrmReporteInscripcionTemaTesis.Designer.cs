namespace LibFormularios
{
    partial class FrmReporteInscripcionTemaTesis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteInscripcionTemaTesis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodTesis = new System.Windows.Forms.TextBox();
            this.BtnBuscarTesis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RvwReporteInscripcionTemaTesis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 106);
            this.panel1.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(871, 106);
            this.LblTitulo.TabIndex = 240;
            this.LblTitulo.Text = "Informacion de una tesis inscrita";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(14, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 292;
            this.label8.Text = "Tesis N°:";
            // 
            // txtCodTesis
            // 
            this.txtCodTesis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodTesis.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCodTesis.Location = new System.Drawing.Point(156, 27);
            this.txtCodTesis.Name = "txtCodTesis";
            this.txtCodTesis.ReadOnly = true;
            this.txtCodTesis.Size = new System.Drawing.Size(124, 32);
            this.txtCodTesis.TabIndex = 291;
            // 
            // BtnBuscarTesis
            // 
            this.BtnBuscarTesis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBuscarTesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnBuscarTesis.FlatAppearance.BorderSize = 0;
            this.BtnBuscarTesis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnBuscarTesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarTesis.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBuscarTesis.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarTesis.Image")));
            this.BtnBuscarTesis.Location = new System.Drawing.Point(285, 25);
            this.BtnBuscarTesis.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscarTesis.Name = "BtnBuscarTesis";
            this.BtnBuscarTesis.Size = new System.Drawing.Size(32, 32);
            this.BtnBuscarTesis.TabIndex = 290;
            this.BtnBuscarTesis.UseVisualStyleBackColor = false;
            this.BtnBuscarTesis.Click += new System.EventHandler(this.BtnBuscarTesis_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnGenerarReporte);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.BtnBuscarTesis);
            this.panel2.Controls.Add(this.txtCodTesis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 88);
            this.panel2.TabIndex = 293;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RvwReporteInscripcionTemaTesis);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 440);
            this.panel3.TabIndex = 294;
            // 
            // RvwReporteInscripcionTemaTesis
            // 
            this.RvwReporteInscripcionTemaTesis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvwReporteInscripcionTemaTesis.Location = new System.Drawing.Point(0, 0);
            this.RvwReporteInscripcionTemaTesis.Name = "RvwReporteInscripcionTemaTesis";
            this.RvwReporteInscripcionTemaTesis.ServerReport.BearerToken = null;
            this.RvwReporteInscripcionTemaTesis.Size = new System.Drawing.Size(871, 440);
            this.RvwReporteInscripcionTemaTesis.TabIndex = 0;
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.BtnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarReporte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnGenerarReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerarReporte.Location = new System.Drawing.Point(629, 12);
            this.BtnGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(242, 59);
            this.BtnGenerarReporte.TabIndex = 293;
            this.BtnGenerarReporte.Text = "Generar Reporte";
            this.BtnGenerarReporte.UseVisualStyleBackColor = false;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // FrmReporteInscripcionTemaTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 634);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReporteInscripcionTemaTesis";
            this.Text = "Reporte Inscripcion de Tesis";
            this.Load += new System.EventHandler(this.FrmReporteInscripcionTemaTesis_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodTesis;
        private System.Windows.Forms.Button BtnBuscarTesis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Reporting.WinForms.ReportViewer RvwReporteInscripcionTemaTesis;
        protected System.Windows.Forms.Button BtnGenerarReporte;
    }
}