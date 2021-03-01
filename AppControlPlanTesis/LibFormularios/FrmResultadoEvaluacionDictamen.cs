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
    public partial class FrmResultadoEvaluacionDictamen : Form
    {
        private CDictaminanteDeTesis oDictaminanteDeTesis;
        public FrmResultadoEvaluacionDictamen()
        {
            InitializeComponent();
            oDictaminanteDeTesis = new CDictaminanteDeTesis();
            LlenarDatosCboCodDictamenDeTesis();
        }
        public void LlemarDatosDocente()
        {
            TxtCodTesis.Text = oDictaminanteDeTesis.MostrarCodTesis(CboCodDictaminantes.Text);
            DataRowView oDataRowView = CboCodDictaminantes.SelectedItem as DataRowView;
            string sValue = string.Empty;

            if (oDataRowView != null)
            {
                sValue = oDataRowView.Row["CodDictamenDeTesis"] as string;
            }
            CboCodDocente.DataSource = oDictaminanteDeTesis.ListarDocentesDictaminantes(sValue);
            CboCodDocente.DisplayMember = "CodDocente";
            CboCodDocente.ValueMember = "CodDocente";
            //-- dejar el combo sin libro seleccionado
            CboCodDocente.SelectedIndex = -1;
        }
        public void LlenarDatosCboCodDictamenDeTesis()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodDictaminantes.DataSource = oDictaminanteDeTesis.ListarCodGrupoDictaminantes();
                CboCodDictaminantes.DisplayMember = "CodDictamenDeTesis";
                CboCodDictaminantes.ValueMember = "CodDictamenDeTesis";
                //-- dejar el combo sin libro seleccionado
                CboCodDictaminantes.SelectedIndex = -1;
            }
            catch
            {

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
        private void CboCodDictaminantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlemarDatosDocente();
            }
            catch
            {

            }
        }

        private void TxtCodTesis_TextChanged(object sender, EventArgs e)
        {
            DgvInteresados.DataSource = oDictaminanteDeTesis.ListarInteresados(TxtCodTesis.Text);
            DgvTesis.DataSource = oDictaminanteDeTesis.ListarDatosTesis(TxtCodTesis.Text);
            DgvTesis.Columns["Estado"].Visible = false;
            DgvTesis.Columns["CodTesis"].Visible = false;
            DgvTesis.Columns["CodDocente"].Visible = false;
        }

        private void CboCodDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtDNIDocente, CboCodDocente.Text);
                if (oDictaminanteDeTesis.VerificarSiEmitioEvaluacionDictamen(CboCodDictaminantes.Text, CboCodDocente.Text))
                {
                    GbxRubrica.Enabled = false;
                    LblNotificacion.Visible = true;
                    LblNotificacion.Text = "Usted ya dictamino esta tesis";
                    List<string> ListaNotas = oDictaminanteDeTesis.ConsultarNotas(CboCodDictaminantes.Text, CboCodDocente.Text);
                    if (ListaNotas[0].CompareTo("APROBADO")==0)
                    {
                        RbAprobado.Checked = true;
                    }
                    else
                    {
                        RbDesaprobado.Checked = true;
                    }
                }
                else
                {
                    GbxRubrica.Enabled = true;
                    LblNotificacion.Visible = false;
                }
                if (CboCodDocente.Text == "")
                    RefrescarTxt();
                TxtLogin.Text = "-";
            }
            catch (Exception eRR)
            {
                MessageBox.Show(eRR.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //insert into TActaDictamenDeTesis values('350000','D00001',0,'puede mejorar')
            try
            {
                if (TxtLogin.Text.CompareTo("LOGUEADO") == 0)
                {
                    List<string> Lista = new List<string>();
                    DataRowView oDataRowView = CboCodDictaminantes.SelectedItem as DataRowView;
                    string CodEvaluacionDictamenDeTesis = string.Empty;

                    if (oDataRowView != null)
                    {
                        CodEvaluacionDictamenDeTesis = oDataRowView.Row["CodDictamenDeTesis"] as string;
                    }
                    Lista.Add(CodEvaluacionDictamenDeTesis);
                    DataRowView oDataRowView2 = CboCodDocente.SelectedItem as DataRowView;
                    string CodDocente = string.Empty;

                    if (oDataRowView != null)
                    {
                        CodDocente = oDataRowView2.Row["CodDocente"] as string;
                    }



                    Lista.Add(CodDocente);
                    string juicio;
                    //emitir juicio
                    if (RbAprobado.Checked)
                    {
                        juicio = "APROBADO";
                    }
                    else
                    {
                        juicio = "DESAPROBADO";
                    }


                    Lista.Add(juicio);
                    Lista.Add(TxtObservaciones.Text);

                    oDictaminanteDeTesis.AgregarDictamenPlanDeTesis(Lista);
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");

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
