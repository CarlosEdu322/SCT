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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CodTesista2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGenerarTramite = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtNombreTesis = new System.Windows.Forms.TextBox();
            this.LblCodTesista1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramitesDeInscripcion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CodTesista2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTramitesDeInscripcion
            // 
            this.DgvTramitesDeInscripcion.AllowUserToAddRows = false;
            this.DgvTramitesDeInscripcion.AllowUserToDeleteRows = false;
            this.DgvTramitesDeInscripcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTramitesDeInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTramitesDeInscripcion.Location = new System.Drawing.Point(63, 414);
            this.DgvTramitesDeInscripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvTramitesDeInscripcion.Name = "DgvTramitesDeInscripcion";
            this.DgvTramitesDeInscripcion.ReadOnly = true;
            this.DgvTramitesDeInscripcion.RowHeadersWidth = 51;
            this.DgvTramitesDeInscripcion.RowTemplate.Height = 24;
            this.DgvTramitesDeInscripcion.Size = new System.Drawing.Size(405, 122);
            this.DgvTramitesDeInscripcion.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.TxtNombreTesis);
            this.groupBox1.Controls.Add(this.LblCodTesista1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expediente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.groupBox2.Location = new System.Drawing.Point(311, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expediente";
            // 
            // CodTesista2
            // 
            this.CodTesista2.Controls.Add(this.dataGridView1);
            this.CodTesista2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.CodTesista2.Location = new System.Drawing.Point(11, 192);
            this.CodTesista2.Margin = new System.Windows.Forms.Padding(2);
            this.CodTesista2.Name = "CodTesista2";
            this.CodTesista2.Padding = new System.Windows.Forms.Padding(2);
            this.CodTesista2.Size = new System.Drawing.Size(799, 201);
            this.CodTesista2.TabIndex = 159;
            this.CodTesista2.TabStop = false;
            this.CodTesista2.Text = "Comision Revisora:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 173);
            this.dataGridView1.TabIndex = 160;
            // 
            // BtnGenerarTramite
            // 
            this.BtnGenerarTramite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnGenerarTramite.FlatAppearance.BorderSize = 0;
            this.BtnGenerarTramite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnGenerarTramite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarTramite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarTramite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnGenerarTramite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerarTramite.Location = new System.Drawing.Point(641, 622);
            this.BtnGenerarTramite.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerarTramite.Name = "BtnGenerarTramite";
            this.BtnGenerarTramite.Size = new System.Drawing.Size(164, 48);
            this.BtnGenerarTramite.TabIndex = 177;
            this.BtnGenerarTramite.Text = "Generar Expediente";
            this.BtnGenerarTramite.UseVisualStyleBackColor = false;
            this.BtnGenerarTramite.Click += new System.EventHandler(this.BtnGenerarTramite_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 178;
            // 
            // TxtNombreTesis
            // 
            this.TxtNombreTesis.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNombreTesis.Location = new System.Drawing.Point(58, 53);
            this.TxtNombreTesis.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreTesis.Name = "TxtNombreTesis";
            this.TxtNombreTesis.Size = new System.Drawing.Size(230, 25);
            this.TxtNombreTesis.TabIndex = 142;
            // 
            // LblCodTesista1
            // 
            this.LblCodTesista1.AutoSize = true;
            this.LblCodTesista1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.LblCodTesista1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblCodTesista1.Location = new System.Drawing.Point(11, 56);
            this.LblCodTesista1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodTesista1.Name = "LblCodTesista1";
            this.LblCodTesista1.Size = new System.Drawing.Size(43, 20);
            this.LblCodTesista1.TabIndex = 143;
            this.LblCodTesista1.Text = "Tesis:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.textBox1.Location = new System.Drawing.Point(161, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 25);
            this.textBox1.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 145;
            this.label1.Text = "NroExpediente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(224, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 146;
            this.label2.Text = "Fecha:";
            // 
            // FrmGenerarExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 682);
            this.Controls.Add(this.BtnGenerarTramite);
            this.Controls.Add(this.CodTesista2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvTramitesDeInscripcion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGenerarExpediente";
            this.Text = "FrmGenerarExpediente";
            this.Load += new System.EventHandler(this.FrmGenerarExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTramitesDeInscripcion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.CodTesista2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvTramitesDeInscripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox CodTesista2;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button BtnGenerarTramite;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtNombreTesis;
        protected System.Windows.Forms.Label LblCodTesista1;
        protected System.Windows.Forms.Label label2;
    }
}