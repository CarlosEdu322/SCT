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
            this.LblNotificacion = new System.Windows.Forms.Label();
            this.DgvTesis = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DgvInteresados = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GbxRubrica = new System.Windows.Forms.GroupBox();
            this.TxtApellidosDictaminante1 = new System.Windows.Forms.TextBox();
            this.TxtNombresDictaminante1 = new System.Windows.Forms.TextBox();
            this.txtCodDictaminante1 = new System.Windows.Forms.TextBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtApellidosDictaminante2 = new System.Windows.Forms.TextBox();
            this.TxtNombresDictaminante2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCodDictaminante2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtApellidosDictaminante3 = new System.Windows.Forms.TextBox();
            this.TxtNombresDictaminante3 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCodDictaminante3 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCondicion = new System.Windows.Forms.Label();
            this.LblCodTesista1 = new System.Windows.Forms.Label();
            this.cbxConsenso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.NudNotaFinal = new System.Windows.Forms.NumericUpDown();
            this.GbxResultadoEvaluacion = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInteresados)).BeginInit();
            this.GbxRubrica.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNotaFinal)).BeginInit();
            this.GbxResultadoEvaluacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(723, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 22);
            this.label14.TabIndex = 224;
            this.label14.Text = "Codigo de la Tesis:";
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCodTesis.Enabled = false;
            this.TxtCodTesis.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TxtCodTesis.Location = new System.Drawing.Point(916, 55);
            this.TxtCodTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(100, 32);
            this.TxtCodTesis.TabIndex = 223;
            this.TxtCodTesis.TextChanged += new System.EventHandler(this.TxtCodTesis_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 23);
            this.label8.TabIndex = 220;
            this.label8.Text = "Codigo De Jurado Evaluador";
            // 
            // CboCodJuradoEvaluador
            // 
            this.CboCodJuradoEvaluador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CboCodJuradoEvaluador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCodJuradoEvaluador.FormattingEnabled = true;
            this.CboCodJuradoEvaluador.Location = new System.Drawing.Point(351, 55);
            this.CboCodJuradoEvaluador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboCodJuradoEvaluador.Name = "CboCodJuradoEvaluador";
            this.CboCodJuradoEvaluador.Size = new System.Drawing.Size(344, 30);
            this.CboCodJuradoEvaluador.TabIndex = 219;
            this.CboCodJuradoEvaluador.SelectedIndexChanged += new System.EventHandler(this.CboCodJuradoEvaluador_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LblNotificacion);
            this.groupBox2.Controls.Add(this.DgvTesis);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.DgvInteresados);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 94);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1068, 262);
            this.groupBox2.TabIndex = 226;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Tesis";
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
            // DgvTesis
            // 
            this.DgvTesis.AllowUserToAddRows = false;
            this.DgvTesis.AllowUserToDeleteRows = false;
            this.DgvTesis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesis.Location = new System.Drawing.Point(7, 183);
            this.DgvTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvTesis.Name = "DgvTesis";
            this.DgvTesis.ReadOnly = true;
            this.DgvTesis.RowHeadersWidth = 51;
            this.DgvTesis.RowTemplate.Height = 24;
            this.DgvTesis.Size = new System.Drawing.Size(1055, 73);
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
            this.DgvInteresados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvInteresados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInteresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInteresados.Location = new System.Drawing.Point(152, 31);
            this.DgvInteresados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvInteresados.Name = "DgvInteresados";
            this.DgvInteresados.ReadOnly = true;
            this.DgvInteresados.RowHeadersWidth = 51;
            this.DgvInteresados.RowTemplate.Height = 24;
            this.DgvInteresados.Size = new System.Drawing.Size(909, 123);
            this.DgvInteresados.TabIndex = 208;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrar.Location = new System.Drawing.Point(865, 785);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(219, 59);
            this.BtnCerrar.TabIndex = 229;
            this.BtnCerrar.Text = "Cerrar Ventana";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(641, 785);
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
            this.GbxRubrica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GbxRubrica.Controls.Add(this.TxtApellidosDictaminante1);
            this.GbxRubrica.Controls.Add(this.TxtNombresDictaminante1);
            this.GbxRubrica.Controls.Add(this.txtCodDictaminante1);
            this.GbxRubrica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxRubrica.Location = new System.Drawing.Point(128, 391);
            this.GbxRubrica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxRubrica.Name = "GbxRubrica";
            this.GbxRubrica.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxRubrica.Size = new System.Drawing.Size(873, 71);
            this.GbxRubrica.TabIndex = 227;
            this.GbxRubrica.TabStop = false;
            this.GbxRubrica.Text = "Primer Dictaminante";
            // 
            // TxtApellidosDictaminante1
            // 
            this.TxtApellidosDictaminante1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtApellidosDictaminante1.Enabled = false;
            this.TxtApellidosDictaminante1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtApellidosDictaminante1.Location = new System.Drawing.Point(659, 18);
            this.TxtApellidosDictaminante1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellidosDictaminante1.Name = "TxtApellidosDictaminante1";
            this.TxtApellidosDictaminante1.Size = new System.Drawing.Size(208, 30);
            this.TxtApellidosDictaminante1.TabIndex = 231;
            // 
            // TxtNombresDictaminante1
            // 
            this.TxtNombresDictaminante1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNombresDictaminante1.Enabled = false;
            this.TxtNombresDictaminante1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNombresDictaminante1.Location = new System.Drawing.Point(409, 18);
            this.TxtNombresDictaminante1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombresDictaminante1.Name = "TxtNombresDictaminante1";
            this.TxtNombresDictaminante1.Size = new System.Drawing.Size(229, 30);
            this.TxtNombresDictaminante1.TabIndex = 232;
            // 
            // txtCodDictaminante1
            // 
            this.txtCodDictaminante1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodDictaminante1.Enabled = false;
            this.txtCodDictaminante1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtCodDictaminante1.Location = new System.Drawing.Point(281, 18);
            this.txtCodDictaminante1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodDictaminante1.Name = "txtCodDictaminante1";
            this.txtCodDictaminante1.Size = new System.Drawing.Size(103, 30);
            this.txtCodDictaminante1.TabIndex = 233;
            this.txtCodDictaminante1.TextChanged += new System.EventHandler(this.txtCodDictaminante1_TextChanged);
            // 
            // LblEstado
            // 
            this.LblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(176, 104);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(14, 20);
            this.LblEstado.TabIndex = 159;
            this.LblEstado.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.TxtApellidosDictaminante2);
            this.groupBox1.Controls.Add(this.TxtNombresDictaminante2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtCodDictaminante2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(132, 468);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(869, 71);
            this.groupBox1.TabIndex = 228;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Segundo Dictaminante";
            // 
            // TxtApellidosDictaminante2
            // 
            this.TxtApellidosDictaminante2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtApellidosDictaminante2.Enabled = false;
            this.TxtApellidosDictaminante2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtApellidosDictaminante2.Location = new System.Drawing.Point(655, 16);
            this.TxtApellidosDictaminante2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellidosDictaminante2.Name = "TxtApellidosDictaminante2";
            this.TxtApellidosDictaminante2.Size = new System.Drawing.Size(208, 30);
            this.TxtApellidosDictaminante2.TabIndex = 234;
            // 
            // TxtNombresDictaminante2
            // 
            this.TxtNombresDictaminante2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNombresDictaminante2.Enabled = false;
            this.TxtNombresDictaminante2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNombresDictaminante2.Location = new System.Drawing.Point(404, 17);
            this.TxtNombresDictaminante2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombresDictaminante2.Name = "TxtNombresDictaminante2";
            this.TxtNombresDictaminante2.Size = new System.Drawing.Size(229, 30);
            this.TxtNombresDictaminante2.TabIndex = 235;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(127, 235);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 23);
            this.label17.TabIndex = 159;
            // 
            // txtCodDictaminante2
            // 
            this.txtCodDictaminante2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodDictaminante2.Enabled = false;
            this.txtCodDictaminante2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtCodDictaminante2.Location = new System.Drawing.Point(276, 16);
            this.txtCodDictaminante2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodDictaminante2.Name = "txtCodDictaminante2";
            this.txtCodDictaminante2.Size = new System.Drawing.Size(103, 30);
            this.txtCodDictaminante2.TabIndex = 236;
            this.txtCodDictaminante2.TextChanged += new System.EventHandler(this.txtCodDictaminante2_TextChanged);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label18.Location = new System.Drawing.Point(797, 370);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 21);
            this.label18.TabIndex = 157;
            this.label18.Text = "Apellidos";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.TxtApellidosDictaminante3);
            this.groupBox3.Controls.Add(this.TxtNombresDictaminante3);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.txtCodDictaminante3);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(132, 556);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(869, 66);
            this.groupBox3.TabIndex = 228;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tercer Dictaminante";
            // 
            // TxtApellidosDictaminante3
            // 
            this.TxtApellidosDictaminante3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtApellidosDictaminante3.Enabled = false;
            this.TxtApellidosDictaminante3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtApellidosDictaminante3.Location = new System.Drawing.Point(655, 18);
            this.TxtApellidosDictaminante3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellidosDictaminante3.Name = "TxtApellidosDictaminante3";
            this.TxtApellidosDictaminante3.Size = new System.Drawing.Size(208, 30);
            this.TxtApellidosDictaminante3.TabIndex = 237;
            // 
            // TxtNombresDictaminante3
            // 
            this.TxtNombresDictaminante3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNombresDictaminante3.Enabled = false;
            this.TxtNombresDictaminante3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TxtNombresDictaminante3.Location = new System.Drawing.Point(404, 18);
            this.TxtNombresDictaminante3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombresDictaminante3.Name = "TxtNombresDictaminante3";
            this.TxtNombresDictaminante3.Size = new System.Drawing.Size(229, 30);
            this.TxtNombresDictaminante3.TabIndex = 238;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(127, 235);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 23);
            this.label27.TabIndex = 159;
            // 
            // txtCodDictaminante3
            // 
            this.txtCodDictaminante3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodDictaminante3.Enabled = false;
            this.txtCodDictaminante3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.txtCodDictaminante3.Location = new System.Drawing.Point(276, 18);
            this.txtCodDictaminante3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodDictaminante3.Name = "txtCodDictaminante3";
            this.txtCodDictaminante3.Size = new System.Drawing.Size(103, 30);
            this.txtCodDictaminante3.TabIndex = 239;
            this.txtCodDictaminante3.TextChanged += new System.EventHandler(this.txtCodDictaminante3_TextChanged);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label28.Location = new System.Drawing.Point(548, 370);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(84, 21);
            this.label28.TabIndex = 157;
            this.label28.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(420, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 231;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 234;
            this.label2.Text = "Consenso:";
            // 
            // LblCondicion
            // 
            this.LblCondicion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCondicion.AutoSize = true;
            this.LblCondicion.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.LblCondicion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblCondicion.Location = new System.Drawing.Point(29, 102);
            this.LblCondicion.Name = "LblCondicion";
            this.LblCondicion.Size = new System.Drawing.Size(106, 22);
            this.LblCondicion.TabIndex = 233;
            this.LblCondicion.Text = "Resultado:";
            // 
            // LblCodTesista1
            // 
            this.LblCodTesista1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCodTesista1.AutoSize = true;
            this.LblCodTesista1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.LblCodTesista1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblCodTesista1.Location = new System.Drawing.Point(31, 64);
            this.LblCodTesista1.Name = "LblCodTesista1";
            this.LblCodTesista1.Size = new System.Drawing.Size(61, 22);
            this.LblCodTesista1.TabIndex = 232;
            this.LblCodTesista1.Text = "Nota:";
            // 
            // cbxConsenso
            // 
            this.cbxConsenso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxConsenso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConsenso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxConsenso.FormattingEnabled = true;
            this.cbxConsenso.Items.AddRange(new object[] {
            "APROBADO POR UNANIMIDAD",
            "APROBADO POR MAYORIA",
            "DESAPROBADO"});
            this.cbxConsenso.Location = new System.Drawing.Point(179, 29);
            this.cbxConsenso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxConsenso.Name = "cbxConsenso";
            this.cbxConsenso.Size = new System.Drawing.Size(281, 28);
            this.cbxConsenso.TabIndex = 235;
            this.cbxConsenso.SelectedIndexChanged += new System.EventHandler(this.cbxConsenso_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(35, 769);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 22);
            this.label3.TabIndex = 291;
            this.label3.Text = "Fecha y Hora Actual:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.CustomFormat = "dddd, dd/M/yyyy hh:mm:ss tt";
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(39, 798);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(372, 30);
            this.dateTimePicker3.TabIndex = 290;
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(1143, 38);
            this.LblTitulo.TabIndex = 292;
            this.LblTitulo.Text = "Evaluacion del Jurado Evaluador de Tesis";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NudNotaFinal
            // 
            this.NudNotaFinal.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudNotaFinal.Location = new System.Drawing.Point(180, 62);
            this.NudNotaFinal.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudNotaFinal.Name = "NudNotaFinal";
            this.NudNotaFinal.Size = new System.Drawing.Size(120, 30);
            this.NudNotaFinal.TabIndex = 293;
            this.NudNotaFinal.ValueChanged += new System.EventHandler(this.TxtNotaFinal_ValueChanged);
            // 
            // GbxResultadoEvaluacion
            // 
            this.GbxResultadoEvaluacion.Controls.Add(this.LblCondicion);
            this.GbxResultadoEvaluacion.Controls.Add(this.NudNotaFinal);
            this.GbxResultadoEvaluacion.Controls.Add(this.LblEstado);
            this.GbxResultadoEvaluacion.Controls.Add(this.LblCodTesista1);
            this.GbxResultadoEvaluacion.Controls.Add(this.label2);
            this.GbxResultadoEvaluacion.Controls.Add(this.cbxConsenso);
            this.GbxResultadoEvaluacion.Location = new System.Drawing.Point(340, 627);
            this.GbxResultadoEvaluacion.Name = "GbxResultadoEvaluacion";
            this.GbxResultadoEvaluacion.Size = new System.Drawing.Size(542, 135);
            this.GbxResultadoEvaluacion.TabIndex = 294;
            this.GbxResultadoEvaluacion.TabStop = false;
            // 
            // FrmResultadoEvaluacionSustentacionOral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1143, 862);
            this.Controls.Add(this.GbxResultadoEvaluacion);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GbxRubrica);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtCodTesis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboCodJuradoEvaluador);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.NudNotaFinal)).EndInit();
            this.GbxResultadoEvaluacion.ResumeLayout(false);
            this.GbxResultadoEvaluacion.PerformLayout();
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
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label27;
        protected System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label LblNotificacion;
        private System.Windows.Forms.TextBox TxtApellidosDictaminante1;
        private System.Windows.Forms.TextBox TxtNombresDictaminante1;
        private System.Windows.Forms.TextBox txtCodDictaminante1;
        private System.Windows.Forms.TextBox TxtApellidosDictaminante2;
        private System.Windows.Forms.TextBox TxtNombresDictaminante2;
        private System.Windows.Forms.TextBox txtCodDictaminante2;
        private System.Windows.Forms.TextBox TxtApellidosDictaminante3;
        private System.Windows.Forms.TextBox TxtNombresDictaminante3;
        private System.Windows.Forms.TextBox txtCodDictaminante3;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label LblCondicion;
        protected System.Windows.Forms.Label LblCodTesista1;
        private System.Windows.Forms.ComboBox cbxConsenso;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        protected System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.NumericUpDown NudNotaFinal;
        private System.Windows.Forms.GroupBox GbxResultadoEvaluacion;
    }
}