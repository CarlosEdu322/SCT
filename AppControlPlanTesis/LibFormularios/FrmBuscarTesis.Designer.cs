namespace LibFormularios
{
    partial class FrmBuscarTesis
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
            this.CodTesista2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCodTesista1 = new System.Windows.Forms.Label();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.CodTesista2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            this.SuspendLayout();
            // 
            // CodTesista2
            // 
            this.CodTesista2.Controls.Add(this.label1);
            this.CodTesista2.Controls.Add(this.CboCategoria);
            this.CodTesista2.Controls.Add(this.BtnSeleccionar);
            this.CodTesista2.Controls.Add(this.TxtBuscar);
            this.CodTesista2.Controls.Add(this.LblCodTesista1);
            this.CodTesista2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.CodTesista2.Location = new System.Drawing.Point(9, 9);
            this.CodTesista2.Margin = new System.Windows.Forms.Padding(2);
            this.CodTesista2.Name = "CodTesista2";
            this.CodTesista2.Padding = new System.Windows.Forms.Padding(2);
            this.CodTesista2.Size = new System.Drawing.Size(865, 75);
            this.CodTesista2.TabIndex = 159;
            this.CodTesista2.TabStop = false;
            this.CodTesista2.Text = "Buscar Tesis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(367, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 162;
            this.label1.Text = "por:";
            // 
            // CboCategoria
            // 
            this.CboCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Items.AddRange(new object[] {
            "Titulo",
            "Tema",
            "Observaciones"});
            this.CboCategoria.Location = new System.Drawing.Point(409, 27);
            this.CboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(281, 25);
            this.CboCategoria.TabIndex = 161;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Location = new System.Drawing.Point(694, 17);
            this.BtnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(164, 48);
            this.BtnSeleccionar.TabIndex = 176;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click_1);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtBuscar.Location = new System.Drawing.Point(74, 27);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(289, 25);
            this.TxtBuscar.TabIndex = 139;
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            // 
            // LblCodTesista1
            // 
            this.LblCodTesista1.AutoSize = true;
            this.LblCodTesista1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.LblCodTesista1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblCodTesista1.Location = new System.Drawing.Point(4, 30);
            this.LblCodTesista1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodTesista1.Name = "LblCodTesista1";
            this.LblCodTesista1.Size = new System.Drawing.Size(66, 20);
            this.LblCodTesista1.TabIndex = 141;
            this.LblCodTesista1.Text = " Buscar:";
            // 
            // DgvTesis
            // 
            this.DgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(16, 132);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.Size = new System.Drawing.Size(851, 217);
            this.DgvTesis.TabIndex = 160;
            // 
            // FrmBuscarTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 418);
            this.Controls.Add(this.DgvTesis);
            this.Controls.Add(this.CodTesista2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBuscarTesis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Tesis";
            this.CodTesista2.ResumeLayout(false);
            this.CodTesista2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CodTesista2;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCategoria;
        protected System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.TextBox TxtBuscar;
        protected System.Windows.Forms.Label LblCodTesista1;
        private System.Windows.Forms.DataGridView DgvTesis;
    }
}