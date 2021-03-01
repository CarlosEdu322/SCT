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
    public partial class FrmResultadoEvaluacionSustentacionOral : Form
    {
        private CEvaluacionTesis oEvaluacionTesis;
        public FrmResultadoEvaluacionSustentacionOral()
        {
            InitializeComponent();
            oEvaluacionTesis = new CEvaluacionTesis();
            LlenarDatosCboCodDictamen();

            //Evaluar();
        }




        public void LlenarDatosCboCodDictamen()
        {
            try
            {
                //CboCodJuradoEvaluador.SelectedIndex = 0;
                //-- muestra la lista de libros en el combo
                CboCodJuradoEvaluador.DataSource = oEvaluacionTesis.ListarCodJuradoEvaluador();
                CboCodJuradoEvaluador.DisplayMember = "CodSustentacionOral";
                CboCodJuradoEvaluador.ValueMember = "CodSustentacionOral";
                //-- dejar el combo sin libro seleccionado
                CboCodJuradoEvaluador.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        
        private void CboCodJuradoEvaluador_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (oEvaluacionTesis.VerificarSiEmitioEvaluoJuradoEvaluador(CboCodJuradoEvaluador.Text))
                {
                    LblNotificacion.Visible = true;
                    LblNotificacion.Text = "Ya se ha emitido una calificacion";
                    BtnGuardar.Enabled = false;
                    cbxConsenso.Enabled = false;
                    LblEstado.Enabled = false;
                    NudNotaFinal.Enabled = false;

                    List<string> ListaResultado = oEvaluacionTesis.ConsultarNotas(CboCodJuradoEvaluador.Text);
                    cbxConsenso.Text = ListaResultado[0];
                    NudNotaFinal.Value = int.Parse(ListaResultado[1]);
                    LblEstado.Text = ListaResultado[2];
                }
                else
                {
                    cbxConsenso.Text = "";
                    NudNotaFinal.Value = 0;
                    LblEstado.Text = "";

                    cbxConsenso.Enabled = true;
                    LblNotificacion.Visible = false;
                    LblEstado.Enabled = true;
                    NudNotaFinal.Enabled = true;
                    BtnGuardar.Enabled = true;
                }
                TxtCodTesis.Text = oEvaluacionTesis.MostrarCodTesis(CboCodJuradoEvaluador.Text);
                TxtLogin.Text = "-";
            }
            catch
            {
            }
        }

        private void TxtCodTesis_TextChanged(object sender, EventArgs e)
        {
            DgvInteresados.DataSource = oEvaluacionTesis.ListarInteresados(TxtCodTesis.Text);
            DgvTesis.DataSource = oEvaluacionTesis.ListarDatosTesis(TxtCodTesis.Text);
            DgvTesis.Columns["CodTesis"].Visible = false;
            DgvTesis.Columns["Estado"].Visible = false;
            DgvTesis.Columns["CodDocente"].Visible = false;
            List<string>p1= oEvaluacionTesis.ListarDocentesJuradoEvaluador(CboCodJuradoEvaluador.Text);
            txtCodDictaminante1.Text = p1[0];

            txtCodDictaminante2.Text = p1[1];
            txtCodDictaminante3.Text = p1[2];
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtLogin.Text.CompareTo("LOGUEADO") == 0)
            {
                List<string> Lista = new List<string>();
                DataRowView oDataRowView = CboCodJuradoEvaluador.SelectedItem as DataRowView;
                string CodJuradoEvaluados = string.Empty;

                if (oDataRowView != null)
                {
                    CodJuradoEvaluados = oDataRowView.Row["CodSustentacionOral"] as string;
                }
                Lista.Add(CodJuradoEvaluados);
                Lista.Add(LblEstado.Text);
                Lista.Add(NudNotaFinal.Text);
                //Lista.Add(LblConsenso.Text);
                Lista.Add(cbxConsenso.SelectedItem.ToString());
                //GuardarDeliberacion
                //insert into TActaSustentacionOral values ('250000','APROBADO',20,'APROBADO POR UNANIMIDAD')
                oEvaluacionTesis.GuardarDeliberacion(Lista);
                CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
                string codExpediente = oPlanDeTesis.ObtenerCodExpedienteJuradoEvaluador(CboCodJuradoEvaluador.Text);
                oPlanDeTesis.UpdateEstadoExpediente(codExpediente, "TESIS CON CORRECCION DE OBSERVACIONES PENDIENTE");
                MessageBox.Show("OPERACION REALIZADA CON EXITO", "CONFIRMACION");

            }

            else
            {
                MessageBox.Show("DEBE LOGUEARSE", "ALERTA");
            }

        }
        public void Evaluar()
        {
            //estado segun nota
            if ((14 <= double.Parse(NudNotaFinal.Value.ToString())) && (double.Parse(NudNotaFinal.Value.ToString()) < 16))
            {
                LblEstado.Text = "APROBADO";
            }
            else if ((16 <= double.Parse(NudNotaFinal.Value.ToString())) && (double.Parse(NudNotaFinal.Value.ToString()) < 18))
            {
                LblEstado.Text = "APROBADO CON DISTINCION";
            }
            else if ((18 <= double.Parse(NudNotaFinal.Value.ToString())) && (double.Parse(NudNotaFinal.Value.ToString()) <= 20))
            {
                LblEstado.Text = "APROBADO CON EXCELENCIA";
            }
            else if(double.Parse(NudNotaFinal.Value.ToString()) < 14)
            {
                LblEstado.Text = "DESAPROBADO";
            }
            //consenso de docentes

        }
        private void TxtNotaFinal_TextChanged_1(object sender, EventArgs e)
        {
        
        }
        public void ConsultarDocente(TextBox tbox1, TextBox tbox2, string codigotesista)
        {
            CDocente docente = new CDocente();
            if (codigotesista != "")
            {
                if (docente.ExisteClavePrimaria(codigotesista))
                {
                    //-- Recuperar atributos, el primer atributo es la clave 
                    tbox1.Text = docente.ValorAtributo("Nombres");
                    tbox2.Text = docente.ValorAtributo("Apellidos");
                }
                else
                {
                    tbox1.Clear(); tbox2.Clear();
                }
            }
        }
        private void txtCodDictaminante1_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDictaminante1, TxtApellidosDictaminante1, txtCodDictaminante1.Text);
        }

        private void txtCodDictaminante2_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDictaminante2, TxtApellidosDictaminante2, txtCodDictaminante2.Text);
        }

        private void txtCodDictaminante3_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDictaminante3, TxtApellidosDictaminante3, txtCodDictaminante3.Text);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxConsenso_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (cbxConsenso.SelectedItem.ToString() == "DESAPROBADO")
            {
                NudNotaFinal.Enabled = false;
                LblEstado.Enabled = false;
            }
            else
            {
                NudNotaFinal.Enabled = true;
                LblEstado.Enabled = true;
            }*/
            if (cbxConsenso.Text.CompareTo("APROBADO POR UNANIMIDAD") == 0)
            {
                NudNotaFinal.Value = 14;
            }
            if (cbxConsenso.Text.CompareTo("APROBADO POR MAYORIA") == 0)
            {
                NudNotaFinal.Value = 14;
            }
            if (cbxConsenso.Text.CompareTo("DESAPROBADO") == 0)
            {
                NudNotaFinal.Value = 0;
            }
        }

        private void TxtNotaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (NudNotaFinal.Text != "")
            {
                
            }
            else
            {
                cbxConsenso.Items.Clear();
                LblEstado.Text = "-";
            }
            Evaluar();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FrmLoginDocente A = new FrmLoginDocente(CboCodJuradoEvaluador.Text);
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtLogin;
        }
    }
}
