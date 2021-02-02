namespace LibFormularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelLogos = new System.Windows.Forms.Panel();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.panelSubMenuMantenimiento = new System.Windows.Forms.Panel();
            this.btnManTesista = new System.Windows.Forms.Button();
            this.btnManDocente = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSubMenuOperaciones = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Panel_Contenedor.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.panelSubMenuMantenimiento.SuspendLayout();
            this.panelSubMenuOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(186, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido al sistema de seguimiento de plan de tesis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.Controls.Add(this.label1);
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Contenedor.Location = new System.Drawing.Point(256, 0);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(823, 687);
            this.Panel_Contenedor.TabIndex = 1;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenuLateral.Controls.Add(this.btnSalir);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuOperaciones);
            this.panelMenuLateral.Controls.Add(this.button1);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuMantenimiento);
            this.panelMenuLateral.Controls.Add(this.btnMantenimiento);
            this.panelMenuLateral.Controls.Add(this.panelLogos);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 687);
            this.panelMenuLateral.TabIndex = 2;
            // 
            // panelLogos
            // 
            this.panelLogos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelLogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogos.Location = new System.Drawing.Point(0, 0);
            this.panelLogos.Name = "panelLogos";
            this.panelLogos.Size = new System.Drawing.Size(250, 100);
            this.panelLogos.TabIndex = 4;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnMantenimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento.Image")));
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 100);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMantenimiento.Size = new System.Drawing.Size(250, 45);
            this.btnMantenimiento.TabIndex = 6;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // panelSubMenuMantenimiento
            // 
            this.panelSubMenuMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelSubMenuMantenimiento.Controls.Add(this.button7);
            this.panelSubMenuMantenimiento.Controls.Add(this.button6);
            this.panelSubMenuMantenimiento.Controls.Add(this.btnManDocente);
            this.panelSubMenuMantenimiento.Controls.Add(this.btnManTesista);
            this.panelSubMenuMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuMantenimiento.Location = new System.Drawing.Point(0, 145);
            this.panelSubMenuMantenimiento.Name = "panelSubMenuMantenimiento";
            this.panelSubMenuMantenimiento.Size = new System.Drawing.Size(250, 160);
            this.panelSubMenuMantenimiento.TabIndex = 7;
            // 
            // btnManTesista
            // 
            this.btnManTesista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManTesista.FlatAppearance.BorderSize = 0;
            this.btnManTesista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManTesista.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnManTesista.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManTesista.Image = ((System.Drawing.Image)(resources.GetObject("btnManTesista.Image")));
            this.btnManTesista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManTesista.Location = new System.Drawing.Point(0, 0);
            this.btnManTesista.Name = "btnManTesista";
            this.btnManTesista.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManTesista.Size = new System.Drawing.Size(250, 40);
            this.btnManTesista.TabIndex = 0;
            this.btnManTesista.Text = "Mantenimiento Tesista";
            this.btnManTesista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManTesista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManTesista.UseVisualStyleBackColor = true;
            this.btnManTesista.Click += new System.EventHandler(this.btnManTesista_Click);
            // 
            // btnManDocente
            // 
            this.btnManDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManDocente.FlatAppearance.BorderSize = 0;
            this.btnManDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManDocente.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnManDocente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManDocente.Image = ((System.Drawing.Image)(resources.GetObject("btnManDocente.Image")));
            this.btnManDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManDocente.Location = new System.Drawing.Point(0, 40);
            this.btnManDocente.Name = "btnManDocente";
            this.btnManDocente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManDocente.Size = new System.Drawing.Size(250, 40);
            this.btnManDocente.TabIndex = 1;
            this.btnManDocente.Text = "Mantenimiento Docente";
            this.btnManDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManDocente.UseVisualStyleBackColor = true;
            this.btnManDocente.Click += new System.EventHandler(this.btnManDocente_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 80);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(250, 40);
            this.button6.TabIndex = 2;
            this.button6.Text = "Mantenimiento X";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 120);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(250, 40);
            this.button7.TabIndex = 3;
            this.button7.Text = "Mantenimiento Y";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 305);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Operaciones";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSubMenuOperaciones
            // 
            this.panelSubMenuOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelSubMenuOperaciones.Controls.Add(this.button8);
            this.panelSubMenuOperaciones.Controls.Add(this.button9);
            this.panelSubMenuOperaciones.Controls.Add(this.button10);
            this.panelSubMenuOperaciones.Controls.Add(this.button11);
            this.panelSubMenuOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuOperaciones.Location = new System.Drawing.Point(0, 350);
            this.panelSubMenuOperaciones.Name = "panelSubMenuOperaciones";
            this.panelSubMenuOperaciones.Size = new System.Drawing.Size(250, 160);
            this.panelSubMenuOperaciones.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(0, 120);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(250, 40);
            this.button8.TabIndex = 3;
            this.button8.Text = "button8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(0, 80);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(250, 40);
            this.button9.TabIndex = 2;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(0, 40);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(250, 40);
            this.button10.TabIndex = 1;
            this.button10.Text = "button10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(250, 40);
            this.button11.TabIndex = 0;
            this.button11.Text = "button11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(0, 642);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(250, 45);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 687);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.Panel_Contenedor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de seguimiento de plan de tesis";
            this.Panel_Contenedor.ResumeLayout(false);
            this.Panel_Contenedor.PerformLayout();
            this.panelMenuLateral.ResumeLayout(false);
            this.panelSubMenuMantenimiento.ResumeLayout(false);
            this.panelSubMenuOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Contenedor;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelLogos;
        private System.Windows.Forms.Panel panelSubMenuMantenimiento;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnManDocente;
        private System.Windows.Forms.Button btnManTesista;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelSubMenuOperaciones;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnSalir;
    }
}