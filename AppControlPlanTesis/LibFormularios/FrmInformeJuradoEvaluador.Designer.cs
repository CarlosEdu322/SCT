namespace LibFormularios
{
    partial class FrmInformeJuradoEvaluador
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CboCodJuradoEvaluador = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DgvInteresados = new System.Windows.Forms.DataGridView();
            this.GbxRubricaDeEvaluacion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtConsenso = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.LblCondicion = new System.Windows.Forms.Label();
            this.TxtJuicio = new System.Windows.Forms.TextBox();
            this.LblCodTesista1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtResolucion = new System.Windows.Forms.TextBox();
            this.btnEResolucionDeLosDictaminantes = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).BeginInit();
            this.GbxRubricaDeEvaluacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CboCodJuradoEvaluador);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtCodTesis);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox3.Location = new System.Drawing.Point(10, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 59);
            this.groupBox3.TabIndex = 229;
            this.groupBox3.TabStop = false;
            // 
            // CboCodJuradoEvaluador
            // 
            this.CboCodJuradoEvaluador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodJuradoEvaluador.FormattingEnabled = true;
            this.CboCodJuradoEvaluador.Location = new System.Drawing.Point(249, 23);
            this.CboCodJuradoEvaluador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboCodJuradoEvaluador.Name = "CboCodJuradoEvaluador";
            this.CboCodJuradoEvaluador.Size = new System.Drawing.Size(235, 25);
            this.CboCodJuradoEvaluador.TabIndex = 222;
            this.CboCodJuradoEvaluador.SelectedIndexChanged += new System.EventHandler(this.CboCodJuradoEvaluador_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 21);
            this.label8.TabIndex = 223;
            this.label8.Text = "Codigo de Jurado Evaluador:";
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Enabled = false;
            this.TxtCodTesis.Location = new System.Drawing.Point(637, 20);
            this.TxtCodTesis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(163, 27);
            this.TxtCodTesis.TabIndex = 225;
            this.TxtCodTesis.TextChanged += new System.EventHandler(this.TxtCodTesis_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(490, 25);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 20);
            this.label14.TabIndex = 226;
            this.label14.Text = "Codigo de la Tesis:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvTesis);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.DgvInteresados);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 226);
            this.groupBox2.TabIndex = 230;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Tesis:";
            // 
            // DgvTesis
            // 
            this.DgvTesis.AllowUserToAddRows = false;
            this.DgvTesis.AllowUserToDeleteRows = false;
            this.DgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(9, 164);
            this.DgvTesis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.ReadOnly = true;
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(791, 57);
            this.DgvTesis.TabIndex = 210;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 142);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 20);
            this.label15.TabIndex = 210;
            this.label15.Text = "Datos De La Tesis";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 21);
            this.label13.TabIndex = 209;
            this.label13.Text = "Interesados";
            // 
            // DgvInteresados
            // 
            this.DgvInteresados.AllowUserToAddRows = false;
            this.DgvInteresados.AllowUserToDeleteRows = false;
            this.DgvInteresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInteresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInteresados.Location = new System.Drawing.Point(110, 25);
            this.DgvInteresados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvInteresados.Name = "DgvInteresados";
            this.DgvInteresados.ReadOnly = true;
            this.DgvInteresados.RowHeadersWidth = 51;
            this.DgvInteresados.RowTemplate.Height = 24;
            this.DgvInteresados.Size = new System.Drawing.Size(690, 106);
            this.DgvInteresados.TabIndex = 208;
            // 
            // GbxRubricaDeEvaluacion
            // 
            this.GbxRubricaDeEvaluacion.Controls.Add(this.label2);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtConsenso);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtResultado);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.LblCondicion);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.TxtJuicio);
            this.GbxRubricaDeEvaluacion.Controls.Add(this.LblCodTesista1);
            this.GbxRubricaDeEvaluacion.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.GbxRubricaDeEvaluacion.Location = new System.Drawing.Point(10, 332);
            this.GbxRubricaDeEvaluacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxRubricaDeEvaluacion.Name = "GbxRubricaDeEvaluacion";
            this.GbxRubricaDeEvaluacion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbxRubricaDeEvaluacion.Size = new System.Drawing.Size(805, 132);
            this.GbxRubricaDeEvaluacion.TabIndex = 231;
            this.GbxRubricaDeEvaluacion.TabStop = false;
            this.GbxRubricaDeEvaluacion.Text = "Resultados de la Evaluacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(275, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 174;
            this.label2.Text = "Consenso";
            // 
            // TxtConsenso
            // 
            this.TxtConsenso.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtConsenso.Location = new System.Drawing.Point(364, 95);
            this.TxtConsenso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtConsenso.Name = "TxtConsenso";
            this.TxtConsenso.ReadOnly = true;
            this.TxtConsenso.Size = new System.Drawing.Size(217, 25);
            this.TxtConsenso.TabIndex = 173;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtResultado.Location = new System.Drawing.Point(364, 57);
            this.TxtResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(217, 25);
            this.TxtResultado.TabIndex = 172;
            // 
            // LblCondicion
            // 
            this.LblCondicion.AutoSize = true;
            this.LblCondicion.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.LblCondicion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblCondicion.Location = new System.Drawing.Point(275, 57);
            this.LblCondicion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCondicion.Name = "LblCondicion";
            this.LblCondicion.Size = new System.Drawing.Size(81, 20);
            this.LblCondicion.TabIndex = 171;
            this.LblCondicion.Text = "Resultado";
            // 
            // TxtJuicio
            // 
            this.TxtJuicio.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtJuicio.Location = new System.Drawing.Point(364, 22);
            this.TxtJuicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtJuicio.Name = "TxtJuicio";
            this.TxtJuicio.ReadOnly = true;
            this.TxtJuicio.Size = new System.Drawing.Size(217, 25);
            this.TxtJuicio.TabIndex = 160;
            // 
            // LblCodTesista1
            // 
            this.LblCodTesista1.AutoSize = true;
            this.LblCodTesista1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.LblCodTesista1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblCodTesista1.Location = new System.Drawing.Point(305, 25);
            this.LblCodTesista1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodTesista1.Name = "LblCodTesista1";
            this.LblCodTesista1.Size = new System.Drawing.Size(49, 20);
            this.LblCodTesista1.TabIndex = 143;
            this.LblCodTesista1.Text = "Nota:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(19, 467);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(314, 54);
            this.groupBox1.TabIndex = 232;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha Actual";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(290, 25);
            this.dateTimePicker2.TabIndex = 229;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnGenerar.FlatAppearance.BorderSize = 0;
            this.BtnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerar.Location = new System.Drawing.Point(608, 495);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(110, 24);
            this.BtnGenerar.TabIndex = 236;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Visible = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(344, 470);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 235;
            this.label1.Text = "Resolucion de Tesis aprobada y concluida:";
            // 
            // TxtResolucion
            // 
            this.TxtResolucion.Enabled = false;
            this.TxtResolucion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResolucion.Location = new System.Drawing.Point(346, 493);
            this.TxtResolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtResolucion.Name = "TxtResolucion";
            this.TxtResolucion.Size = new System.Drawing.Size(258, 27);
            this.TxtResolucion.TabIndex = 234;
            // 
            // btnEResolucionDeLosDictaminantes
            // 
            this.btnEResolucionDeLosDictaminantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.btnEResolucionDeLosDictaminantes.FlatAppearance.BorderSize = 0;
            this.btnEResolucionDeLosDictaminantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.btnEResolucionDeLosDictaminantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEResolucionDeLosDictaminantes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEResolucionDeLosDictaminantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.btnEResolucionDeLosDictaminantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEResolucionDeLosDictaminantes.Location = new System.Drawing.Point(480, 561);
            this.btnEResolucionDeLosDictaminantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEResolucionDeLosDictaminantes.Name = "btnEResolucionDeLosDictaminantes";
            this.btnEResolucionDeLosDictaminantes.Size = new System.Drawing.Size(164, 48);
            this.btnEResolucionDeLosDictaminantes.TabIndex = 238;
            this.btnEResolucionDeLosDictaminantes.Text = "Emitir Resolucion";
            this.btnEResolucionDeLosDictaminantes.UseVisualStyleBackColor = false;
            this.btnEResolucionDeLosDictaminantes.Click += new System.EventHandler(this.btnEResolucionDeLosDictaminantes_Click);
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
            this.BtnCerrar.Location = new System.Drawing.Point(651, 561);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(164, 48);
            this.BtnCerrar.TabIndex = 237;
            this.BtnCerrar.Text = "Cerrar Ventana";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmInformeJuradoEvaluador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 636);
            this.Controls.Add(this.btnEResolucionDeLosDictaminantes);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtResolucion);
            this.Controls.Add(this.GbxRubricaDeEvaluacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInformeJuradoEvaluador";
            this.Text = "FrmInformeJuradoEvaluador";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).EndInit();
            this.GbxRubricaDeEvaluacion.ResumeLayout(false);
            this.GbxRubricaDeEvaluacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CboCodJuradoEvaluador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvTesis;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DgvInteresados;
        private System.Windows.Forms.GroupBox GbxRubricaDeEvaluacion;
        protected System.Windows.Forms.Label LblCondicion;
        private System.Windows.Forms.TextBox TxtJuicio;
        protected System.Windows.Forms.Label LblCodTesista1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        protected System.Windows.Forms.Button BtnGenerar;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtResolucion;
        private System.Windows.Forms.TextBox TxtResultado;
        protected System.Windows.Forms.Button btnEResolucionDeLosDictaminantes;
        protected System.Windows.Forms.Button BtnCerrar;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtConsenso;
    }
}