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
        public FrmInformeJuradoEvaluador()
        {
            InitializeComponent();

            LlenarDatosCboCodRevisionDeTesis();
        }

        public void LlenarDatosCboCodRevisionDeTesis()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodJuradoEvaluador.DataSource = oEvaluacionTesis.ListarCodJuradosEvaluadores();
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
    
    }
}
