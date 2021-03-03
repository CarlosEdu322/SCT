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
                CboCodComisionRevisora.DataSource = oPlanDeTesis.ListarCodComisionRevisoraEstadoCRRevisionpendiente();
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
        public void RefrescarVentana()
        {
            
            NudNotaIdentificacionProblema.Value = 0;
            NudNotaHipotesis.Value = 0;
            NudNotaAlcanceResultados.Value = 0;
            NudNotaMetodologia.Value = 0;
            NudNotaRevisionBibliografica.Value = 0;
            NudNotaRecursosPresupuesto.Value = 0;
            NudNotaImpacto.Value = 0;
            NudNotaOrganizacionDocTesis.Value = 0;
        }
        private void CboCodComisionRevisora_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                LlemarDatosDocente();
                LlenarGrids();
            }
            catch
            {

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtLogin.Text.CompareTo("LOGUEADO") == 0)
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
                    RefrescarVentana();
                    LlenarDatosEvaluacionPlanTesis();
                }
                else
                {
                    MessageBox.Show("DEBE LOGUEARSE", "ALERTA");
                }
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
        public void LlenarDatosEvaluacionPlanTesis()
        {
            ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtDNIDocente, CboCodDocente.Text);
            if (oPlanDeTesis.VerificarSiEmitioEvaluacion(CboCodComisionRevisora.Text, CboCodDocente.Text))
            {
                DesactivarVotacion();
                LblNotificacion.Visible = true;
                LblNotificacion.Text = "Usted ya reviso este plan de tesis";
                List<string> ListaNotas = oPlanDeTesis.ConsultarNotas(CboCodComisionRevisora.Text, CboCodDocente.Text);
                NudNotaIdentificacionProblema.Text = ListaNotas[0];
                NudNotaHipotesis.Text = ListaNotas[1];
                NudNotaAlcanceResultados.Text = ListaNotas[2];
                NudNotaMetodologia.Text = ListaNotas[3];
                NudNotaRevisionBibliografica.Text = ListaNotas[4];
                NudNotaRecursosPresupuesto.Text = ListaNotas[5];
                NudNotaImpacto.Text = ListaNotas[6];
                NudNotaOrganizacionDocTesis.Text = ListaNotas[7];
                BtnGuardar.Enabled = false;
                LlenarGrids();
            }
            else
            {
                BtnGuardar.Enabled = true;
                ActivarVotacion();
                LblNotificacion.Visible = false;
            }
            if (CboCodDocente.Text == "")
                RefrescarTxt();
            TxtLogin.Text = "-";
        }

        public void DesactivarVotacion()
        {
            NudNotaIdentificacionProblema.ReadOnly = true;
            NudNotaHipotesis.ReadOnly = true;
            NudNotaAlcanceResultados.ReadOnly = true;
            NudNotaMetodologia.ReadOnly = true;
            NudNotaRevisionBibliografica.ReadOnly = true;
            NudNotaRecursosPresupuesto.ReadOnly = true;
            NudNotaImpacto.ReadOnly = true;
            NudNotaOrganizacionDocTesis.ReadOnly = true;
        }
        public void ActivarVotacion()
        {
            NudNotaIdentificacionProblema.ReadOnly = false;
            NudNotaHipotesis.ReadOnly = false;
            NudNotaAlcanceResultados.ReadOnly = false;
            NudNotaMetodologia.ReadOnly = false;
            NudNotaRevisionBibliografica.ReadOnly = false;
            NudNotaRecursosPresupuesto.ReadOnly = false;
            NudNotaImpacto.ReadOnly = false;
            NudNotaOrganizacionDocTesis.ReadOnly = false;
        }
        private void CboCodDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarDatosEvaluacionPlanTesis();
            }
            catch
            {

            }
        }
        public void VaciarGrids()
        {
            DgvInteresados.DataSource = null;
            DgvTesis.DataSource = null;
        }
        public void LlenarGrids()
        {
            DgvInteresados.DataSource = oPlanDeTesis.ListarInteresados(TxtCodTesis.Text);
            DgvTesis.DataSource = oPlanDeTesis.ListarDatosTesis(TxtCodTesis.Text);
        }
        private void TxtCodTesis_TextChanged(object sender, EventArgs e)
        {
            LlenarGrids();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FrmLoginDocente A = new FrmLoginDocente(CboCodDocente.Text);
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtLogin;
        }
    }
}
