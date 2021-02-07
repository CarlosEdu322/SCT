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
    public partial class FrmEditarRegistrosXTramite : Form
    {
        private CRequisitoXTramite oRequisitoXTramite;
        private CTramite oTramite;
        private CRequisito cRequisito;
        public FrmEditarRegistrosXTramite()
        {
            InitializeComponent();
            oRequisitoXTramite = new CRequisitoXTramite();
            oTramite = new CTramite();
        }
        public void LlenarListaRequisitos()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                ChlRequisitosXTramite.DataSource = oRequisitoXTramite.ListarRequisitoXTramite(CboCodTramite.Text);
                ChlRequisitosXTramite.DisplayMember = "CodRequisito";
                ChlRequisitosXTramite.ValueMember = "CodTramite";
                //-- dejar el combo sin libro seleccionado
                ChlRequisitosXTramite.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        public void LlenarCboTramites()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodTramite.DataSource = oTramite.ListaGeneral();
                //CboCodDocente.DisplayMember = "Correo";
                CboCodTramite.ValueMember = "CodTramite";
                //-- dejar el combo sin libro seleccionado
                CboCodTramite.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        private void CboCodTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarListaRequisitos();
        }

        private void FrmEditarRegistrosXTramite_Load(object sender, EventArgs e)
        {
            LlenarListaRequisitos();
            LlenarCboTramites();
        }
    }
}
