using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibClases;
using Microsoft.Reporting.WinForms;

namespace LibFormularios
{
    public partial class FrmReportesVariios : Form
    {
        public FrmReportesVariios()
        {
            InitializeComponent();
        }

        private void FrmReportesVariios_Load(object sender, EventArgs e)
        {
            CReportes oReportes = new CReportes();
            DataTable Resultado = oReportes.TesisNoConcluidas();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DsReportes_TTesisPendientes";
            rds.Value = Resultado;
            RvwReporteTesisPendientes.LocalReport.DataSources.Clear();
            RvwReporteTesisPendientes.LocalReport.DataSources.Add(rds);
            string RutaRDLC = Application.StartupPath;
            int idx = RutaRDLC.IndexOf(@"AppControlPlanTesis\bin\Debug");
            RutaRDLC = RutaRDLC.Substring(0, idx - 1) + @"\LibFormularios\RrtListaTesisPendientes.rdlc";

            RvwReporteTesisPendientes.LocalReport.ReportPath = RutaRDLC;
            RvwReporteTesisPendientes.RefreshReport();
            //this.RvwReporteTesisPendientes.RefreshReport();
        }


    }
}
