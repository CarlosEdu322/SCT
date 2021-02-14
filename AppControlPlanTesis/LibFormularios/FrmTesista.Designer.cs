namespace LibFormularios
{
    partial class FrmTesista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTesista));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtCodTesista = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.DgvTesista = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnGuardar.Location = new System.Drawing.Point(426, 22);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnNuevo.Location = new System.Drawing.Point(650, 22);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnSalir.Location = new System.Drawing.Point(12, 22);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Size = new System.Drawing.Size(825, 85);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LblTitulo.Size = new System.Drawing.Size(825, 85);
            this.LblTitulo.Text = "MANTENIMIENTO TESISTA";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 571);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Size = new System.Drawing.Size(825, 88);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.DgvTesista);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Size = new System.Drawing.Size(825, 659);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "Codigo del Tesista:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(4, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(4, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(4, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Nombres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(4, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 111;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(4, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 112;
            this.label5.Text = "DNI:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtTelefono.Location = new System.Drawing.Point(186, 138);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(362, 25);
            this.TxtTelefono.TabIndex = 109;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtCorreo.Location = new System.Drawing.Point(186, 107);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(362, 25);
            this.TxtCorreo.TabIndex = 108;
            // 
            // TxtDNI
            // 
            this.TxtDNI.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtDNI.Location = new System.Drawing.Point(186, 167);
            this.TxtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(362, 25);
            this.TxtDNI.TabIndex = 113;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtApellidos.Location = new System.Drawing.Point(186, 50);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(362, 25);
            this.TxtApellidos.TabIndex = 103;
            // 
            // TxtCodTesista
            // 
            this.TxtCodTesista.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtCodTesista.Location = new System.Drawing.Point(186, 21);
            this.TxtCodTesista.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodTesista.Name = "TxtCodTesista";
            this.TxtCodTesista.Size = new System.Drawing.Size(327, 25);
            this.TxtCodTesista.TabIndex = 102;
            this.TxtCodTesista.Leave += new System.EventHandler(this.TxtCodTesista_Leave);
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNombres.Location = new System.Drawing.Point(186, 80);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(362, 25);
            this.TxtNombres.TabIndex = 107;
            // 
            // DgvTesista
            // 
            this.DgvTesista.AllowUserToAddRows = false;
            this.DgvTesista.AllowUserToDeleteRows = false;
            this.DgvTesista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesista.Location = new System.Drawing.Point(14, 337);
            this.DgvTesista.Margin = new System.Windows.Forms.Padding(2);
            this.DgvTesista.Name = "DgvTesista";
            this.DgvTesista.ReadOnly = true;
            this.DgvTesista.RowHeadersWidth = 51;
            this.DgvTesista.RowTemplate.Height = 24;
            this.DgvTesista.Size = new System.Drawing.Size(711, 211);
            this.DgvTesista.TabIndex = 118;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(517, 14);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(32, 32);
            this.BtnBuscar.TabIndex = 138;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtCodTesista);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtApellidos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNombres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.TxtDNI);
            this.groupBox1.Controls.Add(this.TxtCorreo);
            this.groupBox1.Location = new System.Drawing.Point(26, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(578, 210);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Tesista";
            // 
            // FrmTesista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 659);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTesista";
            this.Text = "FrmTesista";
            this.Load += new System.EventHandler(this.FrmTesista_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtCodTesista;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.DataGridView DgvTesista;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}