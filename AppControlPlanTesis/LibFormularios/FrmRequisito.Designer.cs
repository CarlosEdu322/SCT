namespace LibFormularios
{
    partial class FrmRequisito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequisito));
            this.TxtCodRequisito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTipoRequisito = new System.Windows.Forms.TextBox();
            this.DgvDocentes = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocentes)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Size = new System.Drawing.Size(736, 63);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LblTitulo.Size = new System.Drawing.Size(736, 63);
            this.LblTitulo.Text = "MANTENIMIENTO REQUISITOS TRAMITE";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Size = new System.Drawing.Size(736, 68);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnBuscar);
            this.panel3.Controls.Add(this.DgvDocentes);
            this.panel3.Controls.Add(this.TxtCodRequisito);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtTipoRequisito);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Size = new System.Drawing.Size(736, 479);
            // 
            // TxtCodRequisito
            // 
            this.TxtCodRequisito.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtCodRequisito.Location = new System.Drawing.Point(184, 125);
            this.TxtCodRequisito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCodRequisito.Name = "TxtCodRequisito";
            this.TxtCodRequisito.Size = new System.Drawing.Size(201, 25);
            this.TxtCodRequisito.TabIndex = 106;
            this.TxtCodRequisito.Leave += new System.EventHandler(this.TxtCodRequisito_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(39, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 108;
            this.label2.Text = "Codigo Requisito:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(39, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 109;
            this.label3.Text = "Nombre Requisito:";
            // 
            // TxtTipoRequisito
            // 
            this.TxtTipoRequisito.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtTipoRequisito.Location = new System.Drawing.Point(184, 167);
            this.TxtTipoRequisito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTipoRequisito.Name = "TxtTipoRequisito";
            this.TxtTipoRequisito.Size = new System.Drawing.Size(512, 25);
            this.TxtTipoRequisito.TabIndex = 107;
            // 
            // DgvDocentes
            // 
            this.DgvDocentes.AllowUserToAddRows = false;
            this.DgvDocentes.AllowUserToDeleteRows = false;
            this.DgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocentes.Location = new System.Drawing.Point(42, 259);
            this.DgvDocentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvDocentes.Name = "DgvDocentes";
            this.DgvDocentes.ReadOnly = true;
            this.DgvDocentes.RowHeadersWidth = 51;
            this.DgvDocentes.RowTemplate.Height = 24;
            this.DgvDocentes.Size = new System.Drawing.Size(652, 132);
            this.DgvDocentes.TabIndex = 110;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(389, 121);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(32, 32);
            this.BtnBuscar.TabIndex = 140;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // FrmRequisito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 479);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRequisito";
            this.Text = "FrmRequisito";
            this.Load += new System.EventHandler(this.FrmRequisito_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodRequisito;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTipoRequisito;
        private System.Windows.Forms.DataGridView DgvDocentes;
        private System.Windows.Forms.Button BtnBuscar;
    }
}