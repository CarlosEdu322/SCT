﻿namespace LibFormularios
{
    partial class FrmDocente
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
            this.DgvDocentes = new System.Windows.Forms.DataGridView();
            this.TxtImpedimento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCodDocente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CboEspecialidad = new System.Windows.Forms.ComboBox();
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
            this.BtnGuardar.Location = new System.Drawing.Point(568, 27);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnNuevo.Location = new System.Drawing.Point(867, 27);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnSalir.Location = new System.Drawing.Point(16, 27);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Size = new System.Drawing.Size(1108, 105);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(462, 38);
            this.LblTitulo.Text = "MANTENIMIENTO DOCENTE";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 771);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Size = new System.Drawing.Size(1108, 100);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CboEspecialidad);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.CboCategoria);
            this.panel3.Controls.Add(this.DgvDocentes);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TxtImpedimento);
            this.panel3.Controls.Add(this.TxtTelefono);
            this.panel3.Controls.Add(this.TxtCorreo);
            this.panel3.Controls.Add(this.TxtDNI);
            this.panel3.Controls.Add(this.TxtApellidos);
            this.panel3.Controls.Add(this.TxtCodDocente);
            this.panel3.Controls.Add(this.TxtNombres);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Size = new System.Drawing.Size(1108, 871);
            // 
            // DgvDocentes
            // 
            this.DgvDocentes.AllowUserToAddRows = false;
            this.DgvDocentes.AllowUserToDeleteRows = false;
            this.DgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocentes.Location = new System.Drawing.Point(16, 490);
            this.DgvDocentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvDocentes.Name = "DgvDocentes";
            this.DgvDocentes.ReadOnly = true;
            this.DgvDocentes.RowHeadersWidth = 51;
            this.DgvDocentes.RowTemplate.Height = 24;
            this.DgvDocentes.Size = new System.Drawing.Size(1071, 258);
            this.DgvDocentes.TabIndex = 102;
            // 
            // TxtImpedimento
            // 
            this.TxtImpedimento.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtImpedimento.Location = new System.Drawing.Point(265, 447);
            this.TxtImpedimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtImpedimento.Name = "TxtImpedimento";
            this.TxtImpedimento.Size = new System.Drawing.Size(730, 30);
            this.TxtImpedimento.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(103, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 22);
            this.label7.TabIndex = 100;
            this.label7.Text = "Impedimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(103, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 99;
            this.label8.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(103, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 94;
            this.label1.Text = "Correo:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtTelefono.Location = new System.Drawing.Point(265, 273);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(730, 30);
            this.TxtTelefono.TabIndex = 93;
            // 
            // TxtDNI
            // 
            this.TxtDNI.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtDNI.Location = new System.Drawing.Point(265, 308);
            this.TxtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(730, 30);
            this.TxtDNI.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(103, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 96;
            this.label5.Text = "DNI:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtCorreo.Location = new System.Drawing.Point(265, 237);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(730, 30);
            this.TxtCorreo.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(101, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 95;
            this.label6.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(101, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 88;
            this.label2.Text = "CodDocente:";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtApellidos.Location = new System.Drawing.Point(265, 165);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(730, 30);
            this.TxtApellidos.TabIndex = 87;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNombres.Location = new System.Drawing.Point(265, 201);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(730, 30);
            this.TxtNombres.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(101, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 90;
            this.label4.Text = "Nombres:";
            // 
            // TxtCodDocente
            // 
            this.TxtCodDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtCodDocente.Location = new System.Drawing.Point(265, 130);
            this.TxtCodDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodDocente.Name = "TxtCodDocente";
            this.TxtCodDocente.Size = new System.Drawing.Size(730, 30);
            this.TxtCodDocente.TabIndex = 86;
            this.TxtCodDocente.Leave += new System.EventHandler(this.TxtCodDocente_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(103, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 89;
            this.label3.Text = "Apellidos:";
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Items.AddRange(new object[] {
            "Contratado",
            "Nombrado"});
            this.CboCategoria.Location = new System.Drawing.Point(265, 355);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(730, 30);
            this.CboCategoria.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(103, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 22);
            this.label9.TabIndex = 104;
            this.label9.Text = "Especialidad:";
            // 
            // CboEspecialidad
            // 
            this.CboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEspecialidad.FormattingEnabled = true;
            this.CboEspecialidad.Items.AddRange(new object[] {
            "Auditoria en Redes",
            "Ingenieria de Software",
            "Gestion de Tecnologias de la Informacion",
            "Ciencias de la Computacion"});
            this.CboEspecialidad.Location = new System.Drawing.Point(265, 400);
            this.CboEspecialidad.Name = "CboEspecialidad";
            this.CboEspecialidad.Size = new System.Drawing.Size(730, 30);
            this.CboEspecialidad.TabIndex = 105;
            // 
            // FrmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 871);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmDocente";
            this.Text = "FrmDocente";
            this.Load += new System.EventHandler(this.FrmDocente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDocentes;
        private System.Windows.Forms.TextBox TxtImpedimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodDocente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.ComboBox CboEspecialidad;
        private System.Windows.Forms.Label label9;
    }
}