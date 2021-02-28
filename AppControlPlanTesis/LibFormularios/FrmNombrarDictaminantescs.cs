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
    public partial class FrmNombrarDictaminantescs : Form
    {
        private CDictaminanteDeTesis oDictaminanteDeTesis;
        public FrmNombrarDictaminantescs()
        {
            InitializeComponent();
            oDictaminanteDeTesis = new CDictaminanteDeTesis();
            LlenarTesisPendientes();
            DgvEvaluadoresDePlanDeTesis.Visible = false;
        }
        public void LlenarTesisPendientes()
        {
            DgvTesisPendientesDeDictaminantes.DataSource = oDictaminanteDeTesis.TesisPendientesDeDictamen();
            DgvTesisPendientesDeDictaminantes.Columns["CodTesis"].Visible = false;
            DgvTesisPendientesDeDictaminantes.Columns["CodEvaluacionPlanDeTesis"].Visible = false;
            //checks
            DataGridViewCheckBoxColumn CBColumn = new DataGridViewCheckBoxColumn();
            CBColumn.HeaderText = "";
            CBColumn.FalseValue = "0";
            CBColumn.TrueValue = "1";
            DgvTesisPendientesDeDictaminantes.Columns.Insert(0, CBColumn);
            if (DgvEvaluadoresDePlanDeTesis.DataSource == null)
            {
                //BtnCargar.Enabled = false;
                //BtnNombrarCR.Enabled = false;
            }
            /*
            DgvTesisPendientesDeCR.Columns["CodDictamenDeTesis"].Visible = false;
            DgvTesisPendientesDeCR.Columns["CodSustentacionOral"].Visible = false;
            */
        }
        private void btnBuscarDocente1_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente1;
            List<string> ListaDocentes = new List<string>();
            ListaDocentes.Add(txtCodDocente1.Text);
            ListaDocentes.Add(txtCodDocente2.Text);
            ListaDocentes.Add(txtCodDocente3.Text);
            A.ListaDocentes = ListaDocentes;
        }

        private void btnBuscarDocente2_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente2;
            List<string> ListaDocentes = new List<string>();
            ListaDocentes.Add(txtCodDocente1.Text);
            ListaDocentes.Add(txtCodDocente2.Text);
            ListaDocentes.Add(txtCodDocente3.Text);
            A.ListaDocentes = ListaDocentes;
        }

        private void btnBuscarDocente3_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente3;
            List<string> ListaDocentes = new List<string>();
            ListaDocentes.Add(txtCodDocente1.Text);
            ListaDocentes.Add(txtCodDocente2.Text);
            ListaDocentes.Add(txtCodDocente3.Text);
            A.ListaDocentes = ListaDocentes;
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

        private void txtCodDocente2_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente2, TxtApellidosDocente2, TxtDNIDocente2, txtCodDocente2.Text);
        }

        private void txtCodDocente3_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente3, TxtApellidosDocente3, TxtDNIDocente3, txtCodDocente3.Text);
        }

        private void txtCodDocente1_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente1, TxtApellidosDocente1, TxtDNIDocente1, txtCodDocente1.Text);
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                //int filat= DgvTramitesDeInscripcion.CurrentRow.Index;
                TxtCodTesis.Text = DgvTesisPendientesDeDictaminantes.CurrentRow.Cells["CodTesis"].Value.ToString();
                TxtExpediente.Text = DgvTesisPendientesDeDictaminantes.CurrentRow.Cells["NroExpediente"].Value.ToString();
                //DgvDocentes.DataSource= oPlanDeTesis.ListarTesistasXTesis();
                DgvInteresados.DataSource = oDictaminanteDeTesis.ListarInteresados(TxtCodTesis.Text);
            }
            catch
            {
                MessageBox.Show("NO HA SELECCIONADO", "ERROR");
            }

            //
            //TxtCodTesis.Text = oPlanDeTesis.GenerarCodigoNombrarComisionRevisora();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            string codigo = oDictaminanteDeTesis.GenerarCodigoNombrarComisionRevisora();


            TxtCodDictaminantesDeTesis.Text = codigo;
        }

        private void BtnNombrarCR_Click(object sender, EventArgs e)
        {
            try
            {
                if (!((TxtCodDictaminantesDeTesis.Text == "") || (txtCodDocente1.Text == "") || (txtCodDocente2.Text == "") ))
                {
                    //AGREGAR EXPEDIENTE
                    oDictaminanteDeTesis.UpdateExpediente(TxtExpediente.Text, TxtCodDictaminantesDeTesis.Text);

                    //Agregamos Docentes a la Comision Revisora
                    List<string> ComisionRevisora = new List<string>();
                    ComisionRevisora.Add(txtCodDocente1.Text);
                    ComisionRevisora.Add(txtCodDocente2.Text);
                    if(txtCodDocente2.Text.CompareTo("")!=0)
                        ComisionRevisora.Add(txtCodDocente3.Text);
                    oDictaminanteDeTesis.AgregarDocentesDictaminantes(ComisionRevisora, TxtCodDictaminantesDeTesis.Text);
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    LlenarTesisPendientes();
                }
                else
                {
                    MessageBox.Show("GENERE CODIGO PARA LA EVALUACION DE PLAN DE TESIS", "ALERTA");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConsultarEvaluadores_Click(object sender, EventArgs e)
        {
            if (DgvEvaluadoresDePlanDeTesis.Visible == false)
            {
                DgvEvaluadoresDePlanDeTesis.DataSource = oDictaminanteDeTesis.ListarRevisores(TxtExpediente.Text);
                DgvEvaluadoresDePlanDeTesis.Columns["Correo"].Visible = false;
                DgvEvaluadoresDePlanDeTesis.Columns["Telefono"].Visible = false;
                DgvEvaluadoresDePlanDeTesis.Visible = true;
            }
            else
            {
                DgvEvaluadoresDePlanDeTesis.Visible = false;
            }
        }


    }
}
