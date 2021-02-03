﻿namespace LibFormularios
{
    partial class FrmTramite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTramite));
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTramite = new System.Windows.Forms.DataGridView();
            this.TxtCodTramite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramite)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(951, 78);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(443, 38);
            this.LblTitulo.Text = "MANTENIMIENTO TRAMITE";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 545);
            this.panel2.Size = new System.Drawing.Size(951, 84);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnBuscar);
            this.panel3.Controls.Add(this.TxtCodTramite);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtTipo);
            this.panel3.Controls.Add(this.DgvTramite);
            this.panel3.Size = new System.Drawing.Size(951, 629);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodRequisito";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodRequisito";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TipoRequisito";
            this.dataGridViewTextBoxColumn2.HeaderText = "TipoRequisito";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // DgvTramite
            // 
            this.DgvTramite.AllowUserToAddRows = false;
            this.DgvTramite.AllowUserToDeleteRows = false;
            this.DgvTramite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTramite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTramite.Location = new System.Drawing.Point(50, 308);
            this.DgvTramite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvTramite.Name = "DgvTramite";
            this.DgvTramite.ReadOnly = true;
            this.DgvTramite.RowHeadersWidth = 51;
            this.DgvTramite.RowTemplate.Height = 24;
            this.DgvTramite.Size = new System.Drawing.Size(871, 216);
            this.DgvTramite.TabIndex = 119;
            // 
            // TxtCodTramite
            // 
            this.TxtCodTramite.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtCodTramite.Location = new System.Drawing.Point(229, 185);
            this.TxtCodTramite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodTramite.Name = "TxtCodTramite";
            this.TxtCodTramite.Size = new System.Drawing.Size(279, 30);
            this.TxtCodTramite.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(48, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 122;
            this.label4.Text = "CodTramite:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(48, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 123;
            this.label3.Text = "Tipo:";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtTipo.Location = new System.Drawing.Point(229, 236);
            this.TxtTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(693, 30);
            this.TxtTipo.TabIndex = 121;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(533, 168);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(45, 50);
            this.BtnBuscar.TabIndex = 139;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 629);
            this.Name = "FrmTramite";
            this.Text = "FrmTramite";
            this.Load += new System.EventHandler(this.FrmTramite_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView DgvTramite;
        private System.Windows.Forms.TextBox TxtCodTramite;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Button BtnBuscar;
    }
}