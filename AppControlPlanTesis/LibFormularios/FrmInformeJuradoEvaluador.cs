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
    public partial class FrmInformeJuradoEvaluador : Form
    {
        private CEvaluacionTesis oEvaluacionTesis = new CEvaluacionTesis();
        private CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
        public FrmInformeJuradoEvaluador()
        {
            InitializeComponent();

            LlenarDatosCboCodRevisionDeTesis();
            CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
            String NResolucion = "D-" + oPlanDeTesis.GenerarCodigoResolucionNombramientoDictaminantes() + "-2021-FIEEIM-UNSAAC";
            TxtResolucion.Text = NResolucion;
        }

        public void LlenarDatosCboCodRevisionDeTesis()
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
                TxtCodTesis.Text = oEvaluacionTesis.MostrarCodTesis(CboCodJuradoEvaluador.Text);
                TxtExpediente.Text = oPlanDeTesis.ObtenerCodExpedienteJuradoEvaluador(CboCodJuradoEvaluador.Text);
            }
            catch
            {

            }
        }

        private void TxtCodTesis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DgvInteresados.DataSource = oEvaluacionTesis.ListarInteresados(TxtCodTesis.Text);
                DgvTesis.DataSource = oEvaluacionTesis.ListarDatosTesis(TxtCodTesis.Text);
                DgvTesis.Columns["CodTesis"].Visible = false;
                DgvTesis.Columns["CodDocente"].Visible = false;
                DgvTesis.Columns["Estado"].Visible = false;


                List<string> atributos = oEvaluacionTesis.LlenarCamposSustentacionOral(CboCodJuradoEvaluador.Text);
                TxtResultado.Text = atributos[0];
                TxtJuicio.Text = atributos[1];
                TxtConsenso.Text = atributos[2];

            }
            catch
            {

            }
        }


        private void btnEResolucionDeLosDictaminantes_Click(object sender, EventArgs e)
        {
            CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
            try
            {
                if (Double.Parse(TxtJuicio.Text) >= 14)
                {
                    if ((TxtCodTesis.Text != "") || (TxtResolucion.Text != ""))
                    {
                        if (oPlanDeTesis.VerificarSiEmitioResolucionAprobacionFinalTesis(TxtCodTesis.Text) == false)
                        {


                            oPlanDeTesis.EmitirResolucionAprobacion(TxtResolucion.Text, TxtCodTesis.Text);
                            oPlanDeTesis.UpdateEstadoExpediente(TxtExpediente.Text, "TESIS CONCLUIDA");
                            oPlanDeTesis.UpdateTesis(TxtCodTesis.Text, "TESIS CONCLUIDA");
                            //actualizar el estado del tramite a atendido
                            //oPlanDeTesis.ActualizarEstadoDelTramite(TxtCodTramite.Text, TxtCodTesis.Text);
                            MessageBox.Show("Resolucion: " + TxtResolucion.Text + " EMITIDA EXITOSAMENTE", "CONFIRMACION");
                            //RellenarTablaTramites();
                        }
                        else
                        {
                            MessageBox.Show("YA SE EMITIO UNA RESOLUCION PARA ESTE PROCESO", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("EXISTEN CAMPOS VACIOS, CARGUE LOS DATOS", "ERROR AL REALIZAR LA OPERACION");
                    }
                }
                else
                {
                    MessageBox.Show("SU TESIS NO ESTA APROBADA");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("EXISTEN CAMPOS VACIOS, CARGUE LOS DATOS", "ERROR AL REALIZAR LA OPERACION");
            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
            String NResolucion = "D-" + oPlanDeTesis.GenerarCodigoResolucionNombramientoDictaminantes() + "-2021-FIEEIM-UNSAAC";
            TxtResolucion.Text = NResolucion;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
