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
    public partial class FrmInformeDictaminantesDeTesis : Form
    {
        private CDictaminanteDeTesis oDictaminanteDeTesis = new CDictaminanteDeTesis();
        private CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
        private CEvaluacionTesis oEvaluacionTesis=new CEvaluacionTesis();
        public FrmInformeDictaminantesDeTesis()
        {
            InitializeComponent();

            LlenarDatosCboCodRevisionDeTesis();
            GenerarResoluicion();
        }

        private void CboCodTramDictamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TxtCodTesis.Text = oDictaminanteDeTesis.MostrarCodTesis(CboCodTramDictamen.Text);
                TxtExpediente.Text = oPlanDeTesis.ObtenerCodExpedienteDictaminantes(CboCodTramDictamen.Text);
                List<string> Resultados = oDictaminanteDeTesis.ObtenerResultadoDictamen(CboCodTramDictamen.Text);
                //MessageBox.Show(Resultados[0]);

                TxtJuicio.Text = Resultados[0];

                if (Resultados[1].ToString().CompareTo("1") == 0)
                {
                    LblCondicion.Text = "1 dictaminante ha emitido juicio";
                }
                else if (Resultados[1].ToString().CompareTo("2") == 0)
                {
                    LblCondicion.Text = "2 dictaminante ha emitido juicio";
                }
                else if (Resultados[1].ToString().CompareTo("3") == 0)
                {
                    LblCondicion.Text = "3 dictaminante ha emitido juicio";
                }
                else
                {
                    LblCondicion.Text = "A uno de sus dictaminantes de falta emitir juicio";
                }
            }
            catch { }
            //catch ()//Exception exx)
            //{
            //    MessageBox.Show(exx.ToString(), "ERROR AL REALIZAR LA OPERACION");
            //}
        }
        public void LlenarDatosCboCodRevisionDeTesis()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                //CboCodTramDictamen.DataSource = oDictaminanteDeTesis.ListarCodDictamenesPendientes();
                CboCodTramDictamen.DataSource = oDictaminanteDeTesis.ListarCodDictamenesPendientes();
                CboCodTramDictamen.DisplayMember = "CodDictamenDeTesis";
                CboCodTramDictamen.ValueMember = "CodDictamenDeTesis";
                //-- dejar el combo sin libro seleccionado
                CboCodTramDictamen.SelectedIndex = -1;
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

        private void btnEResolucionDeLosDictaminantes_Click(object sender, EventArgs e)
        {
            CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
            try
            {
                if (TxtJuicio.Text.CompareTo("APROBADO") == 0)
                {
                    if ((TxtCodTesis.Text != "") || (TxtResolucion.Text != ""))
                    {
                        if (oPlanDeTesis.VerificarSiEmitioResolucionSuficienciaTesis(TxtCodTesis.Text) == false)
                        {


                            oPlanDeTesis.EmitirResolucionSuficienciaTesis(TxtResolucion.Text, TxtCodTesis.Text);
                            oPlanDeTesis.UpdateEstadoExpediente(TxtExpediente.Text, "TESIS APROBADA POR DICTAMINANTES");
                            oPlanDeTesis.UpdateTesis(TxtCodTesis.Text, "TESIS APROBADA POR DICTAMINANTES");
                            //actualizar el estado del tramite a atendido
                            //oPlanDeTesis.ActualizarEstadoDelTramite(TxtCodTramite.Text, TxtCodTesis.Text);
                            MessageBox.Show("Resolucion: " + TxtResolucion.Text + " EMITIDA EXITOSAMENTE", "CONFIRMACION");
                            //RellenarTablaTramites();
                        }
                        else
                        {
                            MessageBox.Show("YA SE EMITIO UNA RESOLUCION PARA ESTE DICTAMEN", "ERROR");
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarResoluciones_Click(object sender, EventArgs e)
        {
            FrmMostrarResolucion A = new FrmMostrarResolucion();
            A.Show();
        }
        public void GenerarResoluicion()
        {
            CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
            String NResolucion = "D-" + oPlanDeTesis.GenerarCodigoResolucionNombramientoDictaminantes() + "-2021-FIEEIM-UNSAAC";
            TxtResolucion.Text = NResolucion;
        }
        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            GenerarResoluicion();

        }
    }
}