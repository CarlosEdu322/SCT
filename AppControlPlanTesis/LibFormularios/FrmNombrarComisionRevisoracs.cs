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
    public partial class FrmNombrarComisionRevisoracs : Form
    {
        private CPlanDeTesis oPlanDeTesis;
        public FrmNombrarComisionRevisoracs()
        {
            InitializeComponent();
            oPlanDeTesis = new CPlanDeTesis();
            LlenarTesisPendientes();
        }
        public void LlenarTesisPendientes()
        {
            DgvTesisPendientesDeCR.DataSource = oPlanDeTesis.TesisPendientesDeDCR();
            DgvTesisPendientesDeCR.Columns["CodTesis"].Visible = false;
            DgvTesisPendientesDeCR.Columns["CodEvaluacionPlanDeTesis"].Visible = false;
            if (DgvTesisPendientesDeCR.Rows.Count == 0)
            {
                BtnCargar.Enabled = false;
                BtnGenerar.Enabled = false;
                BtnNombrarCR.Enabled = false;
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
        }

        private void btnBuscarDocente2_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente2;
        }

        private void btnBuscarDocente3_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente3;
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
        private void txtCodDocente1_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente1, TxtApellidosDocente1, TxtDNIDocente1, txtCodDocente1.Text);
        }

        private void txtCodDocente2_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente2, TxtApellidosDocente2, TxtDNIDocente2, txtCodDocente2.Text);
        }

        private void txtCodDocente3_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente3, TxtApellidosDocente3, TxtDNIDocente3, txtCodDocente3.Text);
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            string codigo = oPlanDeTesis.GenerarCodigoNombrarComisionRevisora();


            TxtCodEvaluacionPlanDeTesis.Text = codigo;
        }

        private void BtnNombrarCR_Click(object sender, EventArgs e)
        {
            try
            {
                if(!((TxtCodEvaluacionPlanDeTesis.Text=="")||(txtCodDocente1.Text=="") || (txtCodDocente2.Text == "") || (txtCodDocente3.Text == "")))
                {
                    //AGREGAR EXPEDIENTE
                    oPlanDeTesis.UpdateExpediente(TxtExpediente.Text, TxtCodEvaluacionPlanDeTesis.Text);

                    //Agregamos Docentes a la Comision Revisora
                    List<string> ComisionRevisora = new List<string>();
                    ComisionRevisora.Add(txtCodDocente1.Text);
                    ComisionRevisora.Add(txtCodDocente2.Text);
                    ComisionRevisora.Add(txtCodDocente3.Text);
                    oPlanDeTesis.AgregarDocentesCR(ComisionRevisora, TxtCodEvaluacionPlanDeTesis.Text);
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    LlenarTesisPendientes();
                }
                else
                {
                    MessageBox.Show("GENERE CODIGO PARA LA EVALUACION DE PLAN DE TESIS", "ALERTA");
                }
                
            }
            catch
            {
                MessageBox.Show("EL CODIGO DE REVISION DE PLAN DE TESIS SE HA REPETIDO VUELVA A CARGAR EL CODIGO", "ALERTA");
            }

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                //int filat= DgvTramitesDeInscripcion.CurrentRow.Index;
                TxtCodTesis.Text = DgvTesisPendientesDeCR.CurrentRow.Cells["CodTesis"].Value.ToString();
                TxtExpediente.Text = DgvTesisPendientesDeCR.CurrentRow.Cells["NroExpediente"].Value.ToString();
                //DgvDocentes.DataSource= oPlanDeTesis.ListarTesistasXTesis();
                DgvInteresados.DataSource = oPlanDeTesis.ListarInteresados(TxtCodTesis.Text);
            }
            catch
            {
                MessageBox.Show("NO HA SELECCIONADO", "ERROR");
            }

            //
            //TxtCodTesis.Text = oPlanDeTesis.GenerarCodigoNombrarComisionRevisora();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
