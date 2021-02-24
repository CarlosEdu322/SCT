namespace LibFormularios
{
    partial class FrmResultadoEvaluacionSustentacionOral
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
            this.label8 = new System.Windows.Forms.Label();
            this.CboCodJuradoEvaluador = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DgvInteresados = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GbxRubrica = new System.Windows.Forms.GroupBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.TxtNotaFinal = new System.Windows.Forms.TextBox();
            this.NudDictaminante1 = new System.Windows.Forms.NumericUpDown();
            this.NudDictaminante2 = new System.Windows.Forms.NumericUpDown();
            this.NudDictaminante3 = new System.Windows.Forms.NumericUpDown();
            this.LblConsenso = new System.Windows.Forms.Label();
            this.LblNotificacion = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).BeginInit();
            this.GbxRubrica.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDictaminante1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDictaminante2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDictaminante3)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(816, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 22);
            this.label14.TabIndex = 224;
            this.label14.Text = "Codigo de la Tesis:";
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Enabled = false;
            this.TxtCodTesis.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TxtCodTesis.Location = new System.Drawing.Point(998, 8);
            this.TxtCodTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(100, 32);
            this.TxtCodTesis.TabIndex = 223;
            this.TxtCodTesis.TextChanged += new System.EventHandler(this.TxtCodTesis_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 23);
            this.label8.TabIndex = 220;
            this.label8.Text = "Codigo De Jurado Evaluador";
            // 
            // CboCodJuradoEvaluador
            // 
            this.CboCodJuradoEvaluador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodJuradoEvaluador.FormattingEnabled = true;
            this.CboCodJuradoEvaluador.Location = new System.Drawing.Point(422, 9);
            this.CboCodJuradoEvaluador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboCodJuradoEvaluador.Name = "CboCodJuradoEvaluador";
            this.CboCodJuradoEvaluador.Size = new System.Drawing.Size(344, 30);
            this.CboCodJuradoEvaluador.TabIndex = 219;
            this.CboCodJuradoEvaluador.SelectedIndexChanged += new System.EventHandler(this.CboCodJuradoEvaluador_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblNotificacion);
            this.groupBox2.Controls.Add(this.DgvTesis);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.DgvInteresados);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 45);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1068, 262);
            this.groupBox2.TabIndex = 226;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Tesis";
            // 
            // DgvTesis
            // 
            this.DgvTesis.AllowUserToAddRows = false;
            this.DgvTesis.AllowUserToDeleteRows = false;
            this.DgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(7, 183);
            this.DgvTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.ReadOnly = true;
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(993, 73);
            this.DgvTesis.TabIndex = 210;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 22);
            this.label15.TabIndex = 210;
            this.label15.Text = "Datos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 23);
            this.label13.TabIndex = 209;
            this.label13.Text = "Interesados:";
            // 
            // DgvInteresados
            // 
            this.DgvInteresados.AllowUserToAddRows = false;
            this.DgvInteresados.AllowUserToDeleteRows = false;
            this.DgvInteresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInteresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInteresados.Location = new System.Drawing.Point(152, 31);
            this.DgvInteresados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvInteresados.Name = "DgvInteresados";
            this.DgvInteresados.ReadOnly = true;
            this.DgvInteresados.RowHeadersWidth = 51;
            this.DgvInteresados.RowTemplate.Height = 24;
            this.DgvInteresados.Size = new System.Drawing.Size(848, 123);
            this.DgvInteresados.TabIndex = 208;
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
            this.BtnCerrar.Location = new System.Drawing.Point(556, 858);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(219, 59);
            this.BtnCerrar.TabIndex = 229;
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
            this.BtnGuardar.Location = new System.Drawing.Point(298, 858);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(219, 59);
            this.BtnGuardar.TabIndex = 228;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // GbxRubrica
            // 
            this.GbxRubrica.Controls.Add(this.NudDictaminante1);
            this.GbxRubrica.Controls.Add(this.label5);
            this.GbxRubrica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxRubrica.Location = new System.Drawing.Point(85, 331);
            this.GbxRubrica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxRubrica.Name = "GbxRubrica";
            this.GbxRubrica.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxRubrica.Size = new System.Drawing.Size(919, 111);
            this.GbxRubrica.TabIndex = 227;
            this.GbxRubrica.TabStop = false;
            this.GbxRubrica.Text = "Primer Dictaminante";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(233, 804);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(18, 17);
            this.LblEstado.TabIndex = 159;
            this.LblEstado.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 157;
            this.label5.Text = "Nota Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NudDictaminante2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 446);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(914, 116);
            this.groupBox1.TabIndex = 228;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Segundo Dictaminante";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(127, 235);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 23);
            this.label17.TabIndex = 159;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label18.Location = new System.Drawing.Point(11, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 21);
            this.label18.TabIndex = 157;
            this.label18.Text = "Nota Total";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NudDictaminante3);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(90, 586);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(914, 127);
            this.groupBox3.TabIndex = 228;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tercer Dictaminante";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(127, 235);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 23);
            this.label27.TabIndex = 159;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label28.Location = new System.Drawing.Point(11, 78);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(99, 21);
            this.label28.TabIndex = 157;
            this.label28.Text = "Nota Total";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label33.Location = new System.Drawing.Point(96, 760);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(94, 21);
            this.label33.TabIndex = 164;
            this.label33.Text = "Nota Final";
            // 
            // TxtNotaFinal
            // 
            this.TxtNotaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNotaFinal.Location = new System.Drawing.Point(872, 759);
            this.TxtNotaFinal.Name = "TxtNotaFinal";
            this.TxtNotaFinal.Size = new System.Drawing.Size(111, 28);
            this.TxtNotaFinal.TabIndex = 164;
            this.TxtNotaFinal.TextChanged += new System.EventHandler(this.TxtNotaFinal_TextChanged_1);
            // 
            // NudDictaminante1
            // 
            this.NudDictaminante1.Location = new System.Drawing.Point(787, 67);
            this.NudDictaminante1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudDictaminante1.Name = "NudDictaminante1";
            this.NudDictaminante1.Size = new System.Drawing.Size(120, 32);
            this.NudDictaminante1.TabIndex = 158;
            this.NudDictaminante1.ValueChanged += new System.EventHandler(this.NudNota);
            // 
            // NudDictaminante2
            // 
            this.NudDictaminante2.Location = new System.Drawing.Point(782, 52);
            this.NudDictaminante2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudDictaminante2.Name = "NudDictaminante2";
            this.NudDictaminante2.Size = new System.Drawing.Size(120, 32);
            this.NudDictaminante2.TabIndex = 159;
            this.NudDictaminante2.ValueChanged += new System.EventHandler(this.NudNota);
            // 
            // NudDictaminante3
            // 
            this.NudDictaminante3.Location = new System.Drawing.Point(782, 74);
            this.NudDictaminante3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudDictaminante3.Name = "NudDictaminante3";
            this.NudDictaminante3.Size = new System.Drawing.Size(120, 32);
            this.NudDictaminante3.TabIndex = 159;
            this.NudDictaminante3.ValueChanged += new System.EventHandler(this.NudNota);
            // 
            // LblConsenso
            // 
            this.LblConsenso.AutoSize = true;
            this.LblConsenso.Location = new System.Drawing.Point(474, 804);
            this.LblConsenso.Name = "LblConsenso";
            this.LblConsenso.Size = new System.Drawing.Size(18, 17);
            this.LblConsenso.TabIndex = 230;
            this.LblConsenso.Text = "R";
            // 
            // LblNotificacion
            // 
            this.LblNotificacion.AutoSize = true;
            this.LblNotificacion.ForeColor = System.Drawing.Color.Red;
            this.LblNotificacion.Location = new System.Drawing.Point(607, 154);
            this.LblNotificacion.Name = "LblNotificacion";
            this.LblNotificacion.Size = new System.Drawing.Size(72, 23);
            this.LblNotificacion.TabIndex = 211;
            this.LblNotificacion.Text = "label1";
            // 
            // FrmResultadoEvaluacionSustentacionOral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1143, 1055);
            this.Controls.Add(this.LblConsenso);
            this.Controls.Add(this.TxtNotaFinal);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.GbxRubrica);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtCodTesis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboCodJuradoEvaluador);
            this.Name = "FrmResultadoEvaluacionSustentacionOral";
            this.Text = "FrmResultadoEvaluacionSustentacionOral";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).EndInit();
            this.GbxRubrica.ResumeLayout(false);
            this.GbxRubrica.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDictaminante1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDictaminante2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDictaminante3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboCodJuradoEvaluador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvTesis;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DgvInteresados;
        protected System.Windows.Forms.Button BtnCerrar;
        protected System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.GroupBox GbxRubrica;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label27;
        protected System.Windows.Forms.Label label28;
        protected System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox TxtNotaFinal;
        private System.Windows.Forms.NumericUpDown NudDictaminante1;
        private System.Windows.Forms.NumericUpDown NudDictaminante2;
        private System.Windows.Forms.NumericUpDown NudDictaminante3;
        private System.Windows.Forms.Label LblConsenso;
        private System.Windows.Forms.Label LblNotificacion;
    }
}