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
        }


        public void CalcularNota()
        {
            double nota = (double.Parse(NudDictaminante1.Value.ToString())+ double.Parse(NudDictaminante2.Value.ToString())+double.Parse(NudDictaminante3.Value.ToString()))/3;
            TxtNotaFinal.Text = Math.Round((nota),0).ToString();
        }

        private void NudNota(object sender, EventArgs e)
        {
            CalcularNota();
            Evaluar();
        }


        public void LlenarDatosCboCodDictamen()
        {
            try
            {
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
                    LblNotificacion.Text = "Ya se ha emitido votacion secreta";
                }
                else
                {
                    
                    LblNotificacion.Visible = false;
                }
                TxtCodTesis.Text = oEvaluacionTesis.MostrarCodTesis(CboCodJuradoEvaluador.Text);
            }
            catch
            {

            }
        }

        private void TxtCodTesis_TextChanged(object sender, EventArgs e)
        {
            DgvInteresados.DataSource = oEvaluacionTesis.ListarInteresados(TxtCodTesis.Text);
            DgvTesis.DataSource = oEvaluacionTesis.ListarDatosTesis(TxtCodTesis.Text);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
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
            Lista.Add(TxtNotaFinal.Text);
            Lista.Add(LblConsenso.Text);
            //GuardarDeliberacion
            //insert into TActaSustentacionOral values ('250000','APROBADO',20,'APROBADO POR UNANIMIDAD')
            oEvaluacionTesis.GuardarDeliberacion(Lista);
            MessageBox.Show("OPERACION REALIZADA CON EXITO", "CONFIRMACION");



        }
        public void Evaluar()
        {
            //estado segun nota
            if ((0 <= double.Parse(TxtNotaFinal.Text)) && (double.Parse(TxtNotaFinal.Text) <= 13))
            {
                LblEstado.Text = "DESAPROBADO";
            }
            if ((14 <= double.Parse(TxtNotaFinal.Text)) && (double.Parse(TxtNotaFinal.Text) <= 15))
            {
                LblEstado.Text = "APROBADO";
            }
            if ((15 <= double.Parse(TxtNotaFinal.Text)) && (double.Parse(TxtNotaFinal.Text) <= 17))
            {
                LblEstado.Text = "APROBADO CON DISTINCION";
            }
            if ((18 <= double.Parse(TxtNotaFinal.Text)) && (double.Parse(TxtNotaFinal.Text) <= 20))
            {
                LblEstado.Text = "APROBADO CON EXCELENCIA";
            }
            //consenso de docentes
            bool consenso = true;
            if (double.Parse(NudDictaminante1.Value.ToString()) <= 14)
            {
                consenso = false;
                //MessageBox.Show("GOLA1");
            }
            if (double.Parse(NudDictaminante2.Value.ToString()) <= 14)
            {
                consenso = false;
                //MessageBox.Show("GOLA2");
            }
            if (double.Parse(NudDictaminante3.Value.ToString()) <= 14)
            {
                consenso = false;
                //MessageBox.Show("GOLA3");
            }
            if (double.Parse(TxtNotaFinal.Text) >= 14)
            {
                if (consenso)
                {
                    LblConsenso.Text = "APROBADO POR UNANIMIDAD";

                }
                else
                {
                    LblConsenso.Text = "APROBADO POR MAYORIA";
                }
            }
            else
            {
                LblConsenso.Text = "DESAPROBADO POR MAYORIA";
            }
        }
        private void TxtNotaFinal_TextChanged_1(object sender, EventArgs e)
        {

            Evaluar();
        }
    }
}
