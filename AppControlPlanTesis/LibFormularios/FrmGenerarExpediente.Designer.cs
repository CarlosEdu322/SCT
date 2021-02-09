namespace LibFormularios
{
    partial class FrmGenerarExpediente
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
            this.DgvTramitesDeInscripcion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNroExpediente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ccf = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.BtnGenerarExpediente = new System.Windows.Forms.Button();
            this.TxtCodTramite = new System.Windows.Forms.TextBox();
            this.DgvDocentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramitesDeInscripcion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ccf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTramitesDeInscripcion
            // 
            this.DgvTramitesDeInscripcion.AllowUserToAddRows = false;
            this.DgvTramitesDeInscripcion.AllowUserToDeleteRows = false;
            this.DgvTramitesDeInscripcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTramitesDeInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTramitesDeInscripcion.Location = new System.Drawing.Point(48, 20);
            this.DgvTramitesDeInscripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvTramitesDeInscripcion.Name = "DgvTramitesDeInscripcion";
            this.DgvTramitesDeInscripcion.ReadOnly = true;
            this.DgvTramitesDeInscripcion.RowHeadersWidth = 51;
            this.DgvTramitesDeInscripcion.RowTemplate.Height = 24;
            this.DgvTramitesDeInscripcion.Size = new System.Drawing.Size(540, 150);
            this.DgvTramitesDeInscripcion.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGenerar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNroExpediente);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(56, 505);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1056, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expediente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 145;
            this.label1.Text = "NroExpediente:";
            // 
            // TxtNroExpediente
            // 
            this.TxtNroExpediente.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNroExpediente.Location = new System.Drawing.Point(171, 28);
            this.TxtNroExpediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNroExpediente.Name = "TxtNroExpediente";
            this.TxtNroExpediente.Size = new System.Drawing.Size(168, 30);
            this.TxtNroExpediente.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(684, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 146;
            this.label2.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(769, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 30);
            this.dateTimePicker1.TabIndex = 178;
            // 
            // ccf
            // 
            this.ccf.Controls.Add(this.dataGridView1);
            this.ccf.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ccf.Location = new System.Drawing.Point(119, 698);
            this.ccf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccf.Name = "ccf";
            this.ccf.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccf.Size = new System.Drawing.Size(957, 167);
            this.ccf.TabIndex = 159;
            this.ccf.TabStop = false;
            this.ccf.Text = "Comision Revisora:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 172);
            this.dataGridView1.TabIndex = 160;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCargar);
            this.groupBox3.Controls.Add(this.DgvTramitesDeInscripcion);
            this.groupBox3.Location = new System.Drawing.Point(56, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(746, 202);
            this.groupBox3.TabIndex = 178;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // BtnCargar
            // 
            this.BtnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnCargar.FlatAppearance.BorderSize = 0;
            this.BtnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCargar.Location = new System.Drawing.Point(615, 20);
            this.BtnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(125, 59);
            this.BtnCargar.TabIndex = 179;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = false;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvDocentes);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.groupBox4.Location = new System.Drawing.Point(56, 250);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1044, 249);
            this.groupBox4.TabIndex = 179;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Interesado(s):";
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnGenerar.FlatAppearance.BorderSize = 0;
            this.BtnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerar.Location = new System.Drawing.Point(354, 22);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(114, 37);
            this.BtnGenerar.TabIndex = 181;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Location = new System.Drawing.Point(825, 223);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(179, 22);
            this.TxtCodTesis.TabIndex = 180;
            // 
            // BtnGenerarExpediente
            // 
            this.BtnGenerarExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnGenerarExpediente.FlatAppearance.BorderSize = 0;
            this.BtnGenerarExpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnGenerarExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarExpediente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarExpediente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnGenerarExpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerarExpediente.Location = new System.Drawing.Point(443, 599);
            this.BtnGenerarExpediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGenerarExpediente.Name = "BtnGenerarExpediente";
            this.BtnGenerarExpediente.Size = new System.Drawing.Size(229, 59);
            this.BtnGenerarExpediente.TabIndex = 180;
            this.BtnGenerarExpediente.Text = "Generar Expediente";
            this.BtnGenerarExpediente.UseVisualStyleBackColor = false;
            this.BtnGenerarExpediente.Click += new System.EventHandler(this.BtnGenerarExpediente_Click);
            // 
            // TxtCodTramite
            // 
            this.TxtCodTramite.Location = new System.Drawing.Point(825, 63);
            this.TxtCodTramite.Name = "TxtCodTramite";
            this.TxtCodTramite.Size = new System.Drawing.Size(179, 22);
            this.TxtCodTramite.TabIndex = 181;
            // 
            // DgvDocentes
            // 
            this.DgvDocentes.AllowUserToAddRows = false;
            this.DgvDocentes.AllowUserToDeleteRows = false;
            this.DgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocentes.Location = new System.Drawing.Point(34, 37);
            this.DgvDocentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvDocentes.Name = "DgvDocentes";
            this.DgvDocentes.ReadOnly = true;
            this.DgvDocentes.RowHeadersWidth = 51;
            this.DgvDocentes.RowTemplate.Height = 24;
            this.DgvDocentes.Size = new System.Drawing.Size(939, 178);
            this.DgvDocentes.TabIndex = 103;
            // 
            // FrmGenerarExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 669);
            this.Controls.Add(this.BtnGenerarExpediente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtCodTesis);
            this.Controls.Add(this.TxtCodTramite);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ccf);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGenerarExpediente";
            this.Text = "FrmGenerarExpediente";
            this.Load += new System.EventHandler(this.FrmGenerarExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramitesDeInscripcion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ccf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvTramitesDeInscripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ccf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNroExpediente;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.GroupBox groupBox4;
        protected System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.TextBox TxtCodTesis;
        protected System.Windows.Forms.Button BtnGenerarExpediente;
        private System.Windows.Forms.TextBox TxtCodTramite;
        private System.Windows.Forms.DataGridView DgvDocentes;
    }
}