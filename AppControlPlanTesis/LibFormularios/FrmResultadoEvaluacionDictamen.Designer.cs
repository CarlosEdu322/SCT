﻿namespace LibFormularios
{
    partial class FrmResultadoEvaluacionDictamen
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
            this.label14 = new System.Windows.Forms.Label();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DgvInteresados = new System.Windows.Forms.DataGridView();
            this.GbxDatosDelDocente = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDNIDocente = new System.Windows.Forms.TextBox();
            this.TxtApellidosDocente = new System.Windows.Forms.TextBox();
            this.LblNotificacion = new System.Windows.Forms.Label();
            this.TxtNombresDocente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CboCodDocente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboCodDictaminantes = new System.Windows.Forms.ComboBox();
            this.GbxRubrica = new System.Windows.Forms.GroupBox();
            this.RbDesaprobado = new System.Windows.Forms.RadioButton();
            this.RbAprobado = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).BeginInit();
            this.GbxDatosDelDocente.SuspendLayout();
            this.GbxRubrica.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(495, 25);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 20);
            this.label14.TabIndex = 226;
            this.label14.Text = "Codigo de la Tesis:";
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Enabled = false;
            this.TxtCodTesis.Location = new System.Drawing.Point(642, 20);
            this.TxtCodTesis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(159, 27);
            this.TxtCodTesis.TabIndex = 225;
            this.TxtCodTesis.TextChanged += new System.EventHandler(this.TxtCodTesis_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvTesis);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.DgvInteresados);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 236);
            this.groupBox2.TabIndex = 228;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Tesis";
            // 
            // DgvTesis
            // 
            this.DgvTesis.AllowUserToAddRows = false;
            this.DgvTesis.AllowUserToDeleteRows = false;
            this.DgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(5, 178);
            this.DgvTesis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.ReadOnly = true;
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(797, 53);
            this.DgvTesis.TabIndex = 210;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 156);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 210;
            this.label15.Text = "Datos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 21);
            this.label13.TabIndex = 209;
            this.label13.Text = "Interesados:";
            // 
            // DgvInteresados
            // 
            this.DgvInteresados.AllowUserToAddRows = false;
            this.DgvInteresados.AllowUserToDeleteRows = false;
            this.DgvInteresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInteresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInteresados.Location = new System.Drawing.Point(5, 48);
            this.DgvInteresados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvInteresados.Name = "DgvInteresados";
            this.DgvInteresados.ReadOnly = true;
            this.DgvInteresados.RowHeadersWidth = 51;
            this.DgvInteresados.RowTemplate.Height = 24;
            this.DgvInteresados.Size = new System.Drawing.Size(797, 106);
            this.DgvInteresados.TabIndex = 208;
            // 
            // GbxDatosDelDocente
            // 
            this.GbxDatosDelDocente.Controls.Add(this.label10);
            this.GbxDatosDelDocente.Controls.Add(this.label12);
            this.GbxDatosDelDocente.Controls.Add(this.TxtDNIDocente);
            this.GbxDatosDelDocente.Controls.Add(this.TxtApellidosDocente);
            this.GbxDatosDelDocente.Controls.Add(this.LblNotificacion);
            this.GbxDatosDelDocente.Controls.Add(this.TxtNombresDocente);
            this.GbxDatosDelDocente.Controls.Add(this.label11);
            this.GbxDatosDelDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxDatosDelDocente.Location = new System.Drawing.Point(11, 101);
            this.GbxDatosDelDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxDatosDelDocente.Name = "GbxDatosDelDocente";
            this.GbxDatosDelDocente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxDatosDelDocente.Size = new System.Drawing.Size(807, 87);
            this.GbxDatosDelDocente.TabIndex = 227;
            this.GbxDatosDelDocente.TabStop = false;
            this.GbxDatosDelDocente.Text = "Datos del Docente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(5, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 213;
            this.label10.Text = "Nombres:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(183, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 212;
            this.label12.Text = "Apellidos:";
            // 
            // TxtDNIDocente
            // 
            this.TxtDNIDocente.Enabled = false;
            this.TxtDNIDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtDNIDocente.Location = new System.Drawing.Point(360, 51);
            this.TxtDNIDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDNIDocente.Name = "TxtDNIDocente";
            this.TxtDNIDocente.Size = new System.Drawing.Size(136, 25);
            this.TxtDNIDocente.TabIndex = 217;
            // 
            // TxtApellidosDocente
            // 
            this.TxtApellidosDocente.Enabled = false;
            this.TxtApellidosDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtApellidosDocente.Location = new System.Drawing.Point(187, 51);
            this.TxtApellidosDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtApellidosDocente.Name = "TxtApellidosDocente";
            this.TxtApellidosDocente.Size = new System.Drawing.Size(169, 25);
            this.TxtApellidosDocente.TabIndex = 215;
            // 
            // LblNotificacion
            // 
            this.LblNotificacion.AutoSize = true;
            this.LblNotificacion.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.LblNotificacion.ForeColor = System.Drawing.Color.Red;
            this.LblNotificacion.Location = new System.Drawing.Point(500, 54);
            this.LblNotificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNotificacion.Name = "LblNotificacion";
            this.LblNotificacion.Size = new System.Drawing.Size(98, 20);
            this.LblNotificacion.TabIndex = 218;
            this.LblNotificacion.Text = "Notificacion";
            // 
            // TxtNombresDocente
            // 
            this.TxtNombresDocente.Enabled = false;
            this.TxtNombresDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNombresDocente.Location = new System.Drawing.Point(8, 51);
            this.TxtNombresDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombresDocente.Name = "TxtNombresDocente";
            this.TxtNombresDocente.Size = new System.Drawing.Size(175, 25);
            this.TxtNombresDocente.TabIndex = 216;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(362, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 214;
            this.label11.Text = "DNI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 21);
            this.label9.TabIndex = 224;
            this.label9.Text = "Codigo del Docente:";
            // 
            // CboCodDocente
            // 
            this.CboCodDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodDocente.FormattingEnabled = true;
            this.CboCodDocente.Location = new System.Drawing.Point(226, 52);
            this.CboCodDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboCodDocente.Name = "CboCodDocente";
            this.CboCodDocente.Size = new System.Drawing.Size(259, 25);
            this.CboCodDocente.TabIndex = 223;
            this.CboCodDocente.SelectedIndexChanged += new System.EventHandler(this.CboCodDocente_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 21);
            this.label8.TabIndex = 222;
            this.label8.Text = "Codigo De Dictaminantes:";
            // 
            // CboCodDictaminantes
            // 
            this.CboCodDictaminantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodDictaminantes.FormattingEnabled = true;
            this.CboCodDictaminantes.Location = new System.Drawing.Point(226, 23);
            this.CboCodDictaminantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboCodDictaminantes.Name = "CboCodDictaminantes";
            this.CboCodDictaminantes.Size = new System.Drawing.Size(259, 25);
            this.CboCodDictaminantes.TabIndex = 221;
            this.CboCodDictaminantes.SelectedIndexChanged += new System.EventHandler(this.CboCodDictaminantes_SelectedIndexChanged);
            // 
            // GbxRubrica
            // 
            this.GbxRubrica.Controls.Add(this.RbDesaprobado);
            this.GbxRubrica.Controls.Add(this.RbAprobado);
            this.GbxRubrica.Controls.Add(this.label20);
            this.GbxRubrica.Controls.Add(this.TxtObservaciones);
            this.GbxRubrica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxRubrica.Location = new System.Drawing.Point(12, 434);
            this.GbxRubrica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxRubrica.Name = "GbxRubrica";
            this.GbxRubrica.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxRubrica.Size = new System.Drawing.Size(807, 149);
            this.GbxRubrica.TabIndex = 229;
            this.GbxRubrica.TabStop = false;
            this.GbxRubrica.Text = "Juicio";
            // 
            // RbDesaprobado
            // 
            this.RbDesaprobado.AutoSize = true;
            this.RbDesaprobado.Location = new System.Drawing.Point(406, 24);
            this.RbDesaprobado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbDesaprobado.Name = "RbDesaprobado";
            this.RbDesaprobado.Size = new System.Drawing.Size(124, 25);
            this.RbDesaprobado.TabIndex = 1;
            this.RbDesaprobado.TabStop = true;
            this.RbDesaprobado.Text = "Insuficiencia";
            this.RbDesaprobado.UseVisualStyleBackColor = true;
            // 
            // RbAprobado
            // 
            this.RbAprobado.AutoSize = true;
            this.RbAprobado.Location = new System.Drawing.Point(291, 24);
            this.RbAprobado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbAprobado.Name = "RbAprobado";
            this.RbAprobado.Size = new System.Drawing.Size(111, 25);
            this.RbAprobado.TabIndex = 0;
            this.RbAprobado.TabStop = true;
            this.RbAprobado.Text = "Suficiencia";
            this.RbAprobado.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label20.Location = new System.Drawing.Point(4, 53);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 20);
            this.label20.TabIndex = 230;
            this.label20.Text = "Observaciones:";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObservaciones.Location = new System.Drawing.Point(133, 53);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(669, 92);
            this.TxtObservaciones.TabIndex = 231;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrar.Location = new System.Drawing.Point(655, 587);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(164, 48);
            this.BtnCerrar.TabIndex = 233;
            this.BtnCerrar.Text = "Cerrar Ventana";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
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
            this.BtnGuardar.Location = new System.Drawing.Point(487, 587);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(164, 48);
            this.BtnGuardar.TabIndex = 232;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CboCodDictaminantes);
            this.groupBox1.Controls.Add(this.CboCodDocente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtCodTesis);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 84);
            this.groupBox1.TabIndex = 234;
            this.groupBox1.TabStop = false;
            // 
            // FrmResultadoEvaluacionDictamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 680);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GbxRubrica);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbxDatosDelDocente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmResultadoEvaluacionDictamen";
            this.Text = "FrmResultadoEvaluacionDictamen";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).EndInit();
            this.GbxDatosDelDocente.ResumeLayout(false);
            this.GbxDatosDelDocente.PerformLayout();
            this.GbxRubrica.ResumeLayout(false);
            this.GbxRubrica.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvTesis;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DgvInteresados;
        private System.Windows.Forms.GroupBox GbxDatosDelDocente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDNIDocente;
        private System.Windows.Forms.TextBox TxtApellidosDocente;
        private System.Windows.Forms.Label LblNotificacion;
        private System.Windows.Forms.TextBox TxtNombresDocente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboCodDocente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboCodDictaminantes;
        private System.Windows.Forms.GroupBox GbxRubrica;
        private System.Windows.Forms.RadioButton RbDesaprobado;
        private System.Windows.Forms.RadioButton RbAprobado;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtObservaciones;
        protected System.Windows.Forms.Button BtnCerrar;
        protected System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}