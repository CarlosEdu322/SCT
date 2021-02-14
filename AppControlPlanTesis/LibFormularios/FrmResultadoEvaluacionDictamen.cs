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
        }

        private void CboCodDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtDNIDocente, CboCodDocente.Text);
                if (oDictaminanteDeTesis.VerificarSiEmitioEvaluacion(CboCodDictaminantes.Text, CboCodDocente.Text))
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
