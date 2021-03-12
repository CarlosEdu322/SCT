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
    public partial class FrmReporteInscripcionTemaTesis : Form
    {
        FrmBuscarTesis A;
        public FrmReporteInscripcionTemaTesis()
        {
            InitializeComponent();
        }

        private void BtnBuscarTesis_Click(object sender, EventArgs e)
        {
            A = new FrmBuscarTesis();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodTesis;
        }

        private void FrmReporteInscripcionTemaTesis_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            //generamos lista de datos
            CReportes oReportes = new CReportes();
            DataTable Resultado = oReportes.EstadoTesisInscrita(txtCodTesis.Text);
            DataTable Resultado2= oReportes.ConsultarAsesor(txtCodTesis.Text);
            DataTable Resultado3 = oReportes.ConsultarDatosTesistas(txtCodTesis.Text);
            DataTable Resultado4 = oReportes.ConsultarEstadoTesis(txtCodTesis.Text);
            
            //Configuramos datos de origen
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DsReportes_TReporteInscipcionTemaTesis";
            rds.Value = Resultado;
            ReportDataSource rds2 = new ReportDataSource();
            rds2.Name = "DsReportes_TReporteDatosDocenteAsesor";
            rds2.Value = Resultado2;
            ReportDataSource rds3 = new ReportDataSource();
            rds3.Name = "DsReportes_TReporteDatosTesistasDeUnaTesis";
            rds3.Value = Resultado3;
            ReportDataSource rds4 = new ReportDataSource();
            rds4.Name = "DsReportes_TReporteDatosEstadoDeUnaTesis";
            rds4.Value = Resultado4;

            //limpiamos antes de agregar los datos
            RvwReporteInscripcionTemaTesis.LocalReport.DataSources.Clear();
            RvwReporteInscripcionTemaTesis.LocalReport.DataSources.Add(rds);
            RvwReporteInscripcionTemaTesis.LocalReport.DataSources.Add(rds2);
            RvwReporteInscripcionTemaTesis.LocalReport.DataSources.Add(rds3);
            RvwReporteInscripcionTemaTesis.LocalReport.DataSources.Add(rds4);


            //Formato de Impresion
            RvwReporteInscripcionTemaTesis.SetDisplayMode(DisplayMode.PrintLayout);
            RvwReporteInscripcionTemaTesis.ZoomMode = ZoomMode.PageWidth;
            //**establecemos tura del archivo
            string RutaRDLC = Application.StartupPath;
            int idx = RutaRDLC.IndexOf(@"AppControlPlanTesis\bin\Debug");
            RutaRDLC = RutaRDLC.Substring(0, idx - 1) + @"\LibFormularios\RptEstadoInscripcionTemaTesis.rdlc";

            //configuramos ruta del archivo
            RvwReporteInscripcionTemaTesis.LocalReport.ReportPath = RutaRDLC;

            RvwReporteInscripcionTemaTesis.RefreshReport();
        }
    }
}
