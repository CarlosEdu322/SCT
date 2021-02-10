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

namespace LibFormularios
{
    public partial class FrmResultadoEvaluacionPlanTesis : Form
    {
        private CPlanDeTesis oPlanDeTesis;
        public FrmResultadoEvaluacionPlanTesis()
        {
            InitializeComponent();
            oPlanDeTesis = new CPlanDeTesis();
            LlenarDatosCboCodRevisionDeTesis();
        }
        public void LlenarDatosCboCodRevisionDeTesis()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodComisionRevisora.DataSource = oPlanDeTesis.ListarCodComisionRevisora();
                CboCodComisionRevisora.DisplayMember = "CodEvaluacionPlanDeTesis";
                CboCodComisionRevisora.ValueMember = "CodEvaluacionPlanDeTesis";
                //-- dejar el combo sin libro seleccionado
                CboCodComisionRevisora.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void CboCodComisionRevisora_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView oDataRowView = CboCodComisionRevisora.SelectedItem as DataRowView;
            string sValue = string.Empty;

            if (oDataRowView != null)
            {
                sValue = oDataRowView.Row["CodEvaluacionPlanDeTesis"] as string;
            }
            CboCodDocente.DataSource = oPlanDeTesis.ListarDocenteComisionRevisora(sValue);
            CboCodDocente.DisplayMember = "CodDocente";
            CboCodDocente.ValueMember = "CodDocente";
            //-- dejar el combo sin libro seleccionado
            CboCodDocente.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> Lista = new List<string>();
                DataRowView oDataRowView = CboCodComisionRevisora.SelectedItem as DataRowView;
                string CodEvaluacionPlanDeTesis = string.Empty;

                if (oDataRowView != null)
                {
                    CodEvaluacionPlanDeTesis = oDataRowView.Row["CodEvaluacionPlanDeTesis"] as string;
                }
                Lista.Add(CodEvaluacionPlanDeTesis);
                DataRowView oDataRowView2 = CboCodDocente.SelectedItem as DataRowView;
                string CodDocente = string.Empty;

                if (oDataRowView != null)
                {
                    CodDocente = oDataRowView2.Row["CodDocente"] as string;
                }

                Lista.Add(CodDocente);
                Lista.Add(NudNotaIdentificacionProblema.Value.ToString());
                Lista.Add(NudNotaHipotesis.Value.ToString());
                Lista.Add(NudNotaAlcanceResultados.Value.ToString());
                Lista.Add(NudNotaMetodologia.Value.ToString());
                Lista.Add(NudNotaRevisionBibliografica.Value.ToString());
                Lista.Add(NudNotaRecursosPresupuesto.Value.ToString());
                Lista.Add(NudNotaImpacto.Value.ToString());
                Lista.Add(NudNotaOrganizacionDocTesis.Value.ToString());
                oPlanDeTesis.AgregarEvaluacionPlanDeTesis(Lista);
                MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
            }
            catch (Exception eRR)
            {
                MessageBox.Show(eRR.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
    }
}
