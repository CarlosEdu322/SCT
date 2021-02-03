namespace LibFormularios
{
    partial class FrmTesis
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
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.CboCodTesista = new System.Windows.Forms.ComboBox();
            this.CboCodDocente = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(937, 78);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(394, 38);
            this.LblTitulo.Text = "MANTENIMIENTO TESIS";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 628);
            this.panel2.Size = new System.Drawing.Size(937, 84);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnBuscar);
            this.panel3.Controls.Add(this.CboCodDocente);
            this.panel3.Controls.Add(this.CboCodTesista);
            this.panel3.Controls.Add(this.DgvTesis);
            this.panel3.Controls.Add(this.TxtCodTesis);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TxtTitulo);
            this.panel3.Controls.Add(this.TxtEstado);
            this.panel3.Controls.Add(this.TxtObservaciones);
            this.panel3.Size = new System.Drawing.Size(937, 712);
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtCodTesis.Location = new System.Drawing.Point(279, 95);
            this.TxtCodTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(209, 30);
            this.TxtCodTesis.TabIndex = 118;
            this.TxtCodTesis.Leave += new System.EventHandler(this.TxtCodTesis_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(89, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 132;
            this.label10.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(89, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 120;
            this.label2.Text = "CodTesis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(89, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 128;
            this.label5.Text = "Observaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(89, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 127;
            this.label6.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(89, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 121;
            this.label3.Text = "CodTesista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(89, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 122;
            this.label4.Text = "CodDocente:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtTitulo.Location = new System.Drawing.Point(279, 202);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(500, 30);
            this.TxtTitulo.TabIndex = 133;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtEstado.Location = new System.Drawing.Point(279, 238);
            this.TxtEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(500, 30);
            this.TxtEstado.TabIndex = 125;
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtObservaciones.Location = new System.Drawing.Point(279, 273);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(500, 30);
            this.TxtObservaciones.TabIndex = 129;
            // 
            // DgvTesis
            // 
            this.DgvTesis.AllowUserToAddRows = false;
            this.DgvTesis.AllowUserToDeleteRows = false;
            this.DgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(85, 333);
            this.DgvTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.ReadOnly = true;
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(807, 277);
            this.DgvTesis.TabIndex = 134;
            // 
            // CboCodTesista
            // 
            this.CboCodTesista.BackColor = System.Drawing.SystemColors.Control;
            this.CboCodTesista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCodTesista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodTesista.FormattingEnabled = true;
            this.CboCodTesista.Location = new System.Drawing.Point(279, 130);
            this.CboCodTesista.Name = "CboCodTesista";
            this.CboCodTesista.Size = new System.Drawing.Size(500, 30);
            this.CboCodTesista.TabIndex = 135;
            // 
            // CboCodDocente
            // 
            this.CboCodDocente.BackColor = System.Drawing.SystemColors.Control;
            this.CboCodDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCodDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodDocente.FormattingEnabled = true;
            this.CboCodDocente.Location = new System.Drawing.Point(279, 166);
            this.CboCodDocente.Name = "CboCodDocente";
            this.CboCodDocente.Size = new System.Drawing.Size(500, 30);
            this.CboCodDocente.TabIndex = 136;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(510, 93);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(92, 32);
            this.BtnBuscar.TabIndex = 137;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 712);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTesis";
            this.Text = "FrmTesis";
            this.Load += new System.EventHandler(this.FrmTesis_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.DataGridView DgvTesis;
        private System.Windows.Forms.ComboBox CboCodDocente;
        private System.Windows.Forms.ComboBox CboCodTesista;
        private System.Windows.Forms.Button BtnBuscar;
    }
}