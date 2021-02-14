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
                CboCodComisionRevisora.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        public void LlemarDatosDocente()
        {
            TxtCodTesis.Text = oPlanDeTesis.MostrarCodTesis(CboCodComisionRevisora.Text);
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
            CboCodDocente.SelectedIndex = -1;
        }
        private void CboCodComisionRevisora_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlemarDatosDocente();
            }
            catch
            {

            }
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
        public void ConsultarDocente(TextBox tbox1, TextBox tbox2, TextBox tbox3, string codigotesista)
        {
            CDocente docente = new CDocente();
            if (codigotesista != "")
            {
                if (docente.ExisteClavePrimaria(codigotesista))
                {
                    //-- Recuperar atributos, el primer atributo es la clave 
                    tbox1.Text = docente.ValorAtributo("Nombres");
                    tbox2.Text = docente.ValorAtributo("Apellidos");
                    tbox3.Text = docente.ValorAtributo("Dni");
                }
                else
                {
                    tbox1.Clear(); tbox2.Clear(); tbox3.Clear();
                }
            }

        }
        public void RefrescarTxt()
        {
            TxtApellidosDocente.Text = "";
            TxtNombresDocente.Text = "";
            TxtDNIDocente.Text = "";
        }
        private void CboCodDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtDNIDocente, CboCodDocente.Text);
                if (oPlanDeTesis.VerificarSiEmitioEvaluacion(CboCodComisionRevisora.Text, CboCodDocente.Text))
                {
                    GbxRubrica.Enabled = false;
                    LblNotificacion.Visible = true;
                    LblNotificacion.Text = "Usted ya reviso este plan de tesis";
                }
                else
                {
                    GbxRubrica.Enabled = true;
                    LblNotificacion.Visible = false;
                }
                if (CboCodDocente.Text == "")
                    RefrescarTxt();
            }
            catch
            {

            }
        }

        private void TxtCodTesis_TextChanged(object sender, EventArgs e)
        {
            DgvInteresados.DataSource = oPlanDeTesis.ListarInteresados(TxtCodTesis.Text);
            DgvTesis.DataSource = oPlanDeTesis.ListarDatosTesis(TxtCodTesis.Text);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
