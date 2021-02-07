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
    public partial class FrmIniciarTramiteEstudiante : Form
    {
        private CTramite oTramite;
        private CRequisitoXTramite oRequsitosXTramite;
        public FrmIniciarTramiteEstudiante()
        {
            InitializeComponent();
            InicializarCamposCboNroEstudiantes();
            oTramite = new CTramite();
            oRequsitosXTramite = new CRequisitoXTramite();
            LlenarCboTramites();
            
        }
        public void InicializarCamposCboNroEstudiantes()
        {
            LblCodTesista2.Visible = false;
            LblCodTesista3.Visible = false;
            TxtCodTesista2.Visible = false;
            TxtCodTesista3.Visible = false;
        }

        private void CboNroEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {

            InicializarCamposCboNroEstudiantes();
            if (CboNroEstudiantes.Text == "2")
            {
                LblCodTesista2.Visible = true;
                TxtCodTesista2.Visible = true;
            }
            if (CboNroEstudiantes.Text == "3")
            {
                LblCodTesista2.Visible = true;
                TxtCodTesista2.Visible = true;
                LblCodTesista3.Visible = true;
                TxtCodTesista3.Visible = true;
            }



        }
        public void LlenarCboTramites()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodTramite.DataSource = oTramite.ListaGeneral();
                //CboCodDocente.DisplayMember = "Correo";
                CboCodTramite.ValueMember = "Tipo";
                //-- dejar el combo sin libro seleccionado
                CboCodTramite.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        
        public void RellenarRequisitosXTramite()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                /*
                DataRowView drv = CboCodTramite.SelectedItem as DataRowView;
                //string CodigoTramite = drv["CodTramite"].ToString();
                string CodigoTramite = drv["CodTramite"].ToString();
                MessageBox.Show(CodigoTramite);
                */
                DataRowView oDataRowView = CboCodTramite.SelectedItem as DataRowView;
                string sValue = string.Empty;

                if (oDataRowView != null)
                {
                    sValue = oDataRowView.Row["CodTramite"] as string;
                }



                ChlRequisitosXTramite.DataSource = oRequsitosXTramite.ListarRequisitoXTramiteNombres(sValue);
                //ChlRequisitosXTramite.DataSource = oRequsitosXTramite.ListaGeneral();
                ChlRequisitosXTramite.DisplayMember = "TipoRequisito";
                ChlRequisitosXTramite.ValueMember = "TipoRequisito";
                //-- dejar el combo sin libro seleccionado
                ChlRequisitosXTramite.SelectedIndex = -1;
                
            }
            catch
            {
                //MessageBox.Show("error");
            }
        }
        private void CboCodTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            RellenarRequisitosXTramite();
        }
    }
}
