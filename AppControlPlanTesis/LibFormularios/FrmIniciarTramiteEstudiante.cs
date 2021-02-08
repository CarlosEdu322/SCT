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
        private CDocente oDocente;
        private CRequisitoXTramite oRequsitosXTramite;
        public FrmIniciarTramiteEstudiante()
        {
            InitializeComponent();
            InicializarCamposCboNroEstudiantes();
            oTramite = new CTramite();
            oRequsitosXTramite = new CRequisitoXTramite();
            oDocente = new CDocente();
            LlenarCboTramites();
            LlenarCboDocentes();

        }
        public void InicializarCamposCboNroEstudiantes()
        {
            TxtCodTesista2.Enabled = false;
            TxtCodTesista3.Enabled = false;
            BtnBuscarT2.Enabled = false;
            BtnBuscarT3.Enabled = false;
            //Tesista1
            TxtCodTesista1.Clear(); TxtNombreTesista1.Clear(); TxtApeTesista1.Clear(); TxtDniTesista1.Clear();
            //Tesista2
            TxtCodTesista2.Clear(); TxtNombreTesista2.Clear(); TxtApeTesista2.Clear(); TxtDniTesista2.Clear();
            //Tesista3 
            TxtCodTesista3.Clear(); TxtNombreTesista3.Clear(); TxtApeTesista3.Clear(); TxtDniTesista3.Clear();
        }

        private void CboNroEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicializarCamposCboNroEstudiantes();
            if (CboNroEstudiantes.Text == "1")
            {
                
                BtnBuscarT2.Enabled = false;
                BtnBuscarT3.Enabled = false;
            }

            if (CboNroEstudiantes.Text == "2")
            {
                //LblCodTesista2.Enabled = true;
                TxtCodTesista2.Enabled = true;
                TxtCodTesista3.Enabled = false;
                BtnBuscarT2.Enabled = true;
                BtnBuscarT3.Enabled = false;
                TxtCodTesista3.Clear(); TxtNombreTesista3.Clear(); TxtApeTesista3.Clear(); TxtDniTesista3.Clear();
            }
            if (CboNroEstudiantes.Text == "3")
            {
                TxtCodTesista2.Enabled = true;
                TxtCodTesista3.Enabled = true;
                BtnBuscarT2.Enabled = true;
                BtnBuscarT3.Enabled = true;
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
        public void LlenarCboDocentes()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodDocente.DataSource = oDocente.ListaGeneral();
                //CboCodDocente.DisplayMember = "Correo";
                CboCodDocente.ValueMember = "CodDocente";
                //-- dejar el combo sin libro seleccionado
                CboCodDocente.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        public void ProcesarClave()
        {

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
        public void ConsultarEstudiante(TextBox tbox1, TextBox tbox2, TextBox tbox3, string codigotesista)
        {
            CTesista tesista = new CTesista();
            if (tesista.ExisteClavePrimaria(codigotesista))
            {
                MessageBox.Show("Codigo encontrado", "Se actualizaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-- Recuperar atributos, el primer atributo es la clave 
                tbox1.Text = tesista.ValorAtributo("Nombres");
                tbox2.Text = tesista.ValorAtributo("Apellidos");
                tbox3.Text = tesista.ValorAtributo("Dni");
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el codigo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbox1.Clear(); tbox2.Clear(); tbox3.Clear();
            }
        }

        public bool ComprobarDuplicidad(TextBox txb1, TextBox txb2)
        {
            if ((txb1.Text == txb2.Text))
            {
                MessageBox.Show("El codigo ya ha sido insertado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnBuscarT1_Click(object sender, EventArgs e)
        {
            ConsultarEstudiante(TxtNombreTesista1, TxtApeTesista1, TxtDniTesista1, TxtCodTesista1.Text);
        }

        private void BtnBuscarT2_Click(object sender, EventArgs e)
        {
            if (ComprobarDuplicidad(TxtCodTesista1, TxtCodTesista2) == false)
            {
                ConsultarEstudiante(TxtNombreTesista2, TxtApeTesista2, TxtDniTesista2, TxtCodTesista2.Text);
            }
        }

        private void BtnBuscarT3_Click(object sender, EventArgs e)
        {
            if ((ComprobarDuplicidad(TxtCodTesista1, TxtCodTesista2) == false) && (ComprobarDuplicidad(TxtCodTesista1, TxtCodTesista3) == false) && (ComprobarDuplicidad(TxtCodTesista2, TxtCodTesista3) == false))
            {
                ConsultarEstudiante(TxtNombreTesista3, TxtApeTesista3, TxtDniTesista3, TxtCodTesista3.Text);
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
        private void CboCodDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
                ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtDNIDocente, CboCodDocente.Text);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
