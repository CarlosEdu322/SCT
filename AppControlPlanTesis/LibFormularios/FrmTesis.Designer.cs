﻿namespace LibFormularios
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
            this.TxtCodTesista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.LblTitulo.Location = new System.Drawing.Point(272, 20);
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
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.DgvTesis);
            this.panel3.Controls.Add(this.TxtCodTesista);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TxtDireccion);
            this.panel3.Controls.Add(this.TxtTelefono);
            this.panel3.Controls.Add(this.TxtDNI);
            this.panel3.Size = new System.Drawing.Size(937, 712);
            // 
            // TxtCodTesista
            // 
            this.TxtCodTesista.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtCodTesista.Location = new System.Drawing.Point(279, 95);
            this.TxtCodTesista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodTesista.Name = "TxtCodTesista";
            this.TxtCodTesista.Size = new System.Drawing.Size(591, 30);
            this.TxtCodTesista.TabIndex = 118;
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
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtDireccion.Location = new System.Drawing.Point(279, 202);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(591, 30);
            this.TxtDireccion.TabIndex = 133;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtTelefono.Location = new System.Drawing.Point(279, 238);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(591, 30);
            this.TxtTelefono.TabIndex = 125;
            // 
            // TxtDNI
            // 
            this.TxtDNI.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtDNI.Location = new System.Drawing.Point(279, 273);
            this.TxtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(591, 30);
            this.TxtDNI.TabIndex = 129;
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(279, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(591, 30);
            this.comboBox1.TabIndex = 135;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(279, 166);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(591, 30);
            this.comboBox2.TabIndex = 136;
            // 
            // FrmTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 712);
            this.Name = "FrmTesis";
            this.Text = "FrmTesis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodTesista;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.DataGridView DgvTesis;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}