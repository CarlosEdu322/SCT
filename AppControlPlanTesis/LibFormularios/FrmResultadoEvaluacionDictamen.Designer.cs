namespace LibFormularios
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtFundamento = new System.Windows.Forms.TextBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).BeginInit();
            this.GbxDatosDelDocente.SuspendLayout();
            this.GbxRubrica.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(857, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 22);
            this.label14.TabIndex = 226;
            this.label14.Text = "Codigo de la Tesis:";
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Location = new System.Drawing.Point(861, 49);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(100, 22);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1044, 260);
            this.groupBox2.TabIndex = 228;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Tesis:";
            // 
            // DgvTesis
            // 
            this.DgvTesis.AllowUserToAddRows = false;
            this.DgvTesis.AllowUserToDeleteRows = false;
            this.DgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(39, 186);
            this.DgvTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.ReadOnly = true;
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(962, 62);
            this.DgvTesis.TabIndex = 210;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-1, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 22);
            this.label15.TabIndex = 210;
            this.label15.Text = "Datos De La Tesis";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 23);
            this.label13.TabIndex = 209;
            this.label13.Text = "Interesados";
            // 
            // DgvInteresados
            // 
            this.DgvInteresados.AllowUserToAddRows = false;
            this.DgvInteresados.AllowUserToDeleteRows = false;
            this.DgvInteresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInteresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInteresados.Location = new System.Drawing.Point(159, 31);
            this.DgvInteresados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvInteresados.Name = "DgvInteresados";
            this.DgvInteresados.ReadOnly = true;
            this.DgvInteresados.RowHeadersWidth = 51;
            this.DgvInteresados.RowTemplate.Height = 24;
            this.DgvInteresados.Size = new System.Drawing.Size(842, 130);
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
            this.GbxDatosDelDocente.Location = new System.Drawing.Point(57, 109);
            this.GbxDatosDelDocente.Name = "GbxDatosDelDocente";
            this.GbxDatosDelDocente.Size = new System.Drawing.Size(994, 107);
            this.GbxDatosDelDocente.TabIndex = 227;
            this.GbxDatosDelDocente.TabStop = false;
            this.GbxDatosDelDocente.Text = "Datos del Docente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(24, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 22);
            this.label10.TabIndex = 213;
            this.label10.Text = "Nombres";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(279, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 22);
            this.label12.TabIndex = 212;
            this.label12.Text = "Apellidos:";
            // 
            // TxtDNIDocente
            // 
            this.TxtDNIDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtDNIDocente.Location = new System.Drawing.Point(525, 66);
            this.TxtDNIDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDNIDocente.Name = "TxtDNIDocente";
            this.TxtDNIDocente.Size = new System.Drawing.Size(180, 30);
            this.TxtDNIDocente.TabIndex = 217;
            // 
            // TxtApellidosDocente
            // 
            this.TxtApellidosDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtApellidosDocente.Location = new System.Drawing.Point(283, 66);
            this.TxtApellidosDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellidosDocente.Name = "TxtApellidosDocente";
            this.TxtApellidosDocente.Size = new System.Drawing.Size(224, 30);
            this.TxtApellidosDocente.TabIndex = 215;
            // 
            // LblNotificacion
            // 
            this.LblNotificacion.AutoSize = true;
            this.LblNotificacion.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.LblNotificacion.ForeColor = System.Drawing.Color.Red;
            this.LblNotificacion.Location = new System.Drawing.Point(711, 71);
            this.LblNotificacion.Name = "LblNotificacion";
            this.LblNotificacion.Size = new System.Drawing.Size(119, 22);
            this.LblNotificacion.TabIndex = 218;
            this.LblNotificacion.Text = "Notificacion";
            // 
            // TxtNombresDocente
            // 
            this.TxtNombresDocente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNombresDocente.Location = new System.Drawing.Point(28, 63);
            this.TxtNombresDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombresDocente.Name = "TxtNombresDocente";
            this.TxtNombresDocente.Size = new System.Drawing.Size(232, 30);
            this.TxtNombresDocente.TabIndex = 216;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(521, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 22);
            this.label11.TabIndex = 214;
            this.label11.Text = "DNI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 23);
            this.label9.TabIndex = 224;
            this.label9.Text = "Codigo del Docente";
            // 
            // CboCodDocente
            // 
            this.CboCodDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodDocente.FormattingEnabled = true;
            this.CboCodDocente.Location = new System.Drawing.Point(464, 60);
            this.CboCodDocente.Name = "CboCodDocente";
            this.CboCodDocente.Size = new System.Drawing.Size(344, 30);
            this.CboCodDocente.TabIndex = 223;
            this.CboCodDocente.SelectedIndexChanged += new System.EventHandler(this.CboCodDocente_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 23);
            this.label8.TabIndex = 222;
            this.label8.Text = "Codigo De Dictaminantes:";
            // 
            // CboCodDictaminantes
            // 
            this.CboCodDictaminantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodDictaminantes.FormattingEnabled = true;
            this.CboCodDictaminantes.Location = new System.Drawing.Point(464, 24);
            this.CboCodDictaminantes.Name = "CboCodDictaminantes";
            this.CboCodDictaminantes.Size = new System.Drawing.Size(344, 30);
            this.CboCodDictaminantes.TabIndex = 221;
            this.CboCodDictaminantes.SelectedIndexChanged += new System.EventHandler(this.CboCodDictaminantes_SelectedIndexChanged);
            // 
            // GbxRubrica
            // 
            this.GbxRubrica.Controls.Add(this.radioButton2);
            this.GbxRubrica.Controls.Add(this.radioButton1);
            this.GbxRubrica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxRubrica.Location = new System.Drawing.Point(326, 490);
            this.GbxRubrica.Name = "GbxRubrica";
            this.GbxRubrica.Size = new System.Drawing.Size(393, 92);
            this.GbxRubrica.TabIndex = 229;
            this.GbxRubrica.TabStop = false;
            this.GbxRubrica.Text = "Juicio";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(110, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Suficiencia";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(110, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(148, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Insuficiencia";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label20.Location = new System.Drawing.Point(55, 615);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 22);
            this.label20.TabIndex = 230;
            this.label20.Text = "Fundamento:";
            // 
            // TxtFundamento
            // 
            this.TxtFundamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFundamento.Location = new System.Drawing.Point(256, 598);
            this.TxtFundamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFundamento.Multiline = true;
            this.TxtFundamento.Name = "TxtFundamento";
            this.TxtFundamento.Size = new System.Drawing.Size(722, 60);
            this.TxtFundamento.TabIndex = 231;
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
            this.BtnCerrar.Location = new System.Drawing.Point(552, 701);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(219, 59);
            this.BtnCerrar.TabIndex = 233;
            this.BtnCerrar.Text = "Cerrar Ventana";
            this.BtnCerrar.UseVisualStyleBackColor = false;
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
            this.BtnGuardar.Location = new System.Drawing.Point(256, 701);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(219, 59);
            this.BtnGuardar.TabIndex = 232;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmResultadoEvaluacionDictamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 837);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TxtFundamento);
            this.Controls.Add(this.GbxRubrica);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtCodTesis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbxDatosDelDocente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CboCodDocente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboCodDictaminantes);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtFundamento;
        protected System.Windows.Forms.Button BtnCerrar;
        protected System.Windows.Forms.Button BtnGuardar;
    }
}