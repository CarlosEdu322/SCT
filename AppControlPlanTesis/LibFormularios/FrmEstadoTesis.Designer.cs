
namespace LibFormularios
{
    partial class FrmEstadoTesis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTesis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chartTesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTesis
            // 
            this.chartTesis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTesis.BackColor = System.Drawing.Color.Transparent;
            chartArea12.BackColor = System.Drawing.Color.Transparent;
            chartArea12.Name = "ChartArea1";
            this.chartTesis.ChartAreas.Add(chartArea12);
            legend12.Alignment = System.Drawing.StringAlignment.Center;
            legend12.BackColor = System.Drawing.Color.Transparent;
            legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend12.IsTextAutoFit = false;
            legend12.Name = "Legend1";
            legend12.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            legend12.Title = "Cantidad de Tesis";
            legend12.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend12.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            this.chartTesis.Legends.Add(legend12);
            this.chartTesis.Location = new System.Drawing.Point(484, 353);
            this.chartTesis.Name = "chartTesis";
            this.chartTesis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartTesis.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(56)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(129)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(223)))), ((int)(((byte)(68)))))};
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            series12.IsValueShownAsLabel = true;
            series12.LabelForeColor = System.Drawing.Color.White;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            series12.YValuesPerPoint = 4;
            this.chartTesis.Series.Add(series12);
            this.chartTesis.Size = new System.Drawing.Size(330, 325);
            this.chartTesis.TabIndex = 0;
            this.chartTesis.Text = "chart1";
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(155)))), ((int)(((byte)(64)))));
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(826, 31);
            this.LblTitulo.TabIndex = 235;
            this.LblTitulo.Text = "Reportes: Estado de Tesis";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(30, 378);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(448, 300);
            this.chart1.TabIndex = 236;
            this.chart1.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar1.Location = new System.Drawing.Point(238, 158);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(381, 23);
            this.progressBar1.TabIndex = 237;
            this.progressBar1.Value = 50;
            // 
            // FrmEstadoTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 690);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.chartTesis);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F);
            this.Name = "FrmEstadoTesis";
            this.Text = "FrmEstadoTesis";
            this.Load += new System.EventHandler(this.FrmEstadoTesis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTesis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTesis;
        protected System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}