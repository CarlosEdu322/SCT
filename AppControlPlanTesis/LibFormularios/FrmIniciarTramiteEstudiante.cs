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
        private CTesis oTesis;
        private CDictaminanteDeTesis oDictaminanteDeTesis;
        //private TextBox codigoBusquedaDocente;
        //private TextBox codigoBusquedaTesista1;
        //private TextBox codigoBusquedaTesista2;
        //private TextBox codigoBusquedaTesista3;
        public string aBusqueda;
        //public TextBox CodigoBusqueda { get => codigoBusquedaDocente; set => codigoBusquedaDocente = value; }
        //public TextBox CodigoBusquedaTesista1 { get => codigoBusquedaTesista1; set => codigoBusquedaTesista1 = value; }
        //public TextBox CodigoBusquedaTesista2 { get => codigoBusquedaTesista2; set => codigoBusquedaTesista2 = value; }
        //public TextBox CodigoBusquedaTesista3 { get => codigoBusquedaTesista3; set => codigoBusquedaTesista3 = value; }
        public FrmIniciarTramiteEstudiante()
        {
            InitializeComponent();
            InicializarCamposCboNroEstudiantes();
            oTramite = new CTramite();
            oRequsitosXTramite = new CRequisitoXTramite();
            oDocente = new CDocente();
            oTesis = new CTesis();
            oDictaminanteDeTesis = new CDictaminanteDeTesis();
            LlenarCboTramites();
            CboNroEstudiantes.SelectedIndex = 0;
            CboCodTramite.SelectedIndex = 0;
            //GbxTramiteDeInscripcion.Visible = false;
        }
        public void InicializarCamposCboNroEstudiantes()
        {
            TxtCodTesista2.Enabled = false;
            TxtCodTesista3.Enabled = false;
            BtnBuscarT2.Enabled = false;
            BtnBuscarT3.Enabled = false;

        }

        private void CboNroEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //InicializarCamposCboNroEstudiantes();
            if (CboNroEstudiantes.Text == "1")
            {

                BtnBuscarT2.Enabled = false;
                BtnBuscarT3.Enabled = false;
                TxtCodTesista2.Enabled = false;
                TxtCodTesista3.Enabled = false;
                TxtCodTesista2.Text = "";
                TxtCodTesista3.Text = "";
            }

            if (CboNroEstudiantes.Text == "2")
            {
                BtnBuscarT2.Enabled = true;
                BtnBuscarT3.Enabled = false;
                TxtCodTesista2.Enabled = true;
                TxtCodTesista3.Enabled = false;
                //TxtCodTesista2.Text = "";
                TxtCodTesista3.Text = "";
            }
            if (CboNroEstudiantes.Text == "3")
            {
                BtnBuscarT2.Enabled = true;
                TxtCodTesista2.Enabled = true;
                BtnBuscarT3.Enabled = true;
                TxtCodTesista3.Enabled = true;
            }



        }

        public void LlenarCboTramites()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodTramite.DataSource = oTramite.ListaGeneral();
                //CboCodDocente.DisplayMember = "Tipo";
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
        public void ConsultarEstudiante(TextBox tbox1, TextBox tbox2, TextBox tbox3, string codigotesista)
        {
            CTesista tesista = new CTesista();
            if (tesista.ExisteClavePrimaria(codigotesista))
            {
                //MessageBox.Show("Codigo encontrado", "Se actualizaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-- Recuperar atributos, el primer atributo es la clave 
                tbox1.Text = tesista.ValorAtributo("Nombres");
                tbox2.Text = tesista.ValorAtributo("Apellidos");
                tbox3.Text = tesista.ValorAtributo("Dni");
            }
            else
            {
                //MessageBox.Show("No se pudo encontrar el codigo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbox1.Clear(); tbox2.Clear(); tbox3.Clear();
            }
        }
        public void ConsultarTesis(TextBox tbox1, TextBox tbox2, TextBox tbox3, string stringCodigoTesis)
        {
            CTesis tesis = new CTesis();
            if (tesis.ExisteClavePrimaria(stringCodigoTesis))
            {
                //MessageBox.Show("Codigo encontrado", "Se actualizaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-- Recuperar atributos, el primer atributo es la clave 
                tbox1.Text = tesis.ValorAtributo("Titulo");
                tbox2.Text = tesis.ValorAtributo("Tema");
                tbox3.Text = tesis.ValorAtributo("Observaciones");
            }
            else
            {
                //MessageBox.Show("No se pudo encontrar el codigo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FrmBuscarTesista A = new FrmBuscarTesista();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtCodTesista1;


            ConsultarEstudiante(TxtNombreTesista1, TxtApeTesista1, TxtDniTesista1, TxtCodTesista1.Text);
        }

        private void BtnBuscarT2_Click(object sender, EventArgs e)
        {
            FrmBuscarTesista A = new FrmBuscarTesista();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtCodTesista2;
            /*
            if (ComprobarDuplicidad(TxtCodTesista1, TxtCodTesista2) == false)
            {
                ConsultarEstudiante(TxtNombreTesista2, TxtApeTesista2, TxtDniTesista2, TxtCodTesista2.Text);
            }
            */
        }

        private void BtnBuscarT3_Click(object sender, EventArgs e)
        {
            FrmBuscarTesista A = new FrmBuscarTesista();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtCodTesista3;

            /*
            if ((ComprobarDuplicidad(TxtCodTesista1, TxtCodTesista2) == false) && (ComprobarDuplicidad(TxtCodTesista1, TxtCodTesista3) == false) && (ComprobarDuplicidad(TxtCodTesista2, TxtCodTesista3) == false))
            {
                ConsultarEstudiante(TxtNombreTesista3, TxtApeTesista3, TxtDniTesista3, TxtCodTesista3.Text);
            }*/
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool VerificarRequisitos()
        {
            bool cumpletodoslosrequisitos = true;
            for (int j = 0; j < ChlRequisitosXTramite.Items.Count; j++)
            {
                DataRowView drv = ChlRequisitosXTramite.Items[j] as DataRowView;
                if (!ChlRequisitosXTramite.GetItemChecked(j))
                {
                    cumpletodoslosrequisitos = false;
                }

            }
            return cumpletodoslosrequisitos;
        }
        private void BtnIniciarTramite_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodTesis.Text != "")
                {
                    if (VerificarRequisitos())
                    {
                        //Agregar a la tbla tesis
                        //insert into TTesis values ('tema','coddocente','titulo','','')
                        List<string> CadenaTesis = new List<string>();
                        CadenaTesis.Add(TxtCodTesis.Text);
                        CadenaTesis.Add(TxtTema.Text);
                        CadenaTesis.Add(txtCodDocente.Text);
                        CadenaTesis.Add(TxtTitulo.Text);
                        oTesis.AgregarTesis(CadenaTesis);



                        //Agregar a la tabla TesisXTesista
                        List<string> CadenaTesisXTesista = new List<string>();
                        if (CboNroEstudiantes.Text == "1")
                        {
                            CadenaTesisXTesista.Add(TxtCodTesista1.Text);
                        }
                        if (CboNroEstudiantes.Text == "2")
                        {
                            CadenaTesisXTesista.Add(TxtCodTesista1.Text);
                            CadenaTesisXTesista.Add(TxtCodTesista2.Text);
                        }
                        if (CboNroEstudiantes.Text == "3")
                        {
                            CadenaTesisXTesista.Add(TxtCodTesista1.Text);
                            CadenaTesisXTesista.Add(TxtCodTesista2.Text);
                            CadenaTesisXTesista.Add(TxtCodTesista3.Text);
                        }
                        oTesis.GuardarCambiosTesisXTesista(TxtCodTesis.Text, CadenaTesisXTesista);


                        List<string> IniciarTramiteInscripcionPlanDeTesis = new List<string>();
                        DataRowView oDataRowView = CboCodTramite.SelectedItem as DataRowView;
                        string codTramite = string.Empty;

                        if (oDataRowView != null)
                        {
                            codTramite = oDataRowView.Row["CodTramite"] as string;
                        }
                        string CodTrInscripcionDeTemaDeTesis;

                        CodTrInscripcionDeTemaDeTesis = oTesis.GenerarCodigoTrInscripcionDeTemaDeTesis();
                        MessageBox.Show("Nro de Tesis " + TxtCodTesis.Text + " ESTADO: POR REVISAR");
                        IniciarTramiteInscripcionPlanDeTesis.Add(CodTrInscripcionDeTemaDeTesis);
                        IniciarTramiteInscripcionPlanDeTesis.Add(codTramite);
                        IniciarTramiteInscripcionPlanDeTesis.Add(TxtCodTesis.Text);
                        IniciarTramiteInscripcionPlanDeTesis.Add(TxtObservaciones.Text);
                        //insert into TIniciarTramiteInscripcionPlanDeTesis values ('TR0001','124813','124219','150409','100005','NINGUNA')
                        oTesis.AgregarTramiteDeInscripcionDePlanDeTesis(IniciarTramiteInscripcionPlanDeTesis);
                        MessageBox.Show("HA REGISTRADO EL TRAMITE", "CONFIRMACION");
                        //FrmPrincipal f = new FrmPrincipal();
                        //f.abrirFormHijoEnPanel(new FrmIniciarTramiteEstudiante());
                    }
                    else
                    {
                        MessageBox.Show("Tiene que cumplir todos los requisitos");
                    }

                }
                else
                {
                    MessageBox.Show("GENERE VALOR PARA CODIGO DE TESIS", "ALERTA");
                }
            }
            catch (Exception eRROR)
            {
                MessageBox.Show(eRROR.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente;

        }

        private void FrmIniciarTramiteEstudiante_Load(object sender, EventArgs e)
        {
            //Inicializar variable global para transferir dato del form hijo
            //codigoBusquedaDocente = txtCodDocente;
            //codigoBusquedaTesista1 = TxtCodTesista1;
            //codigoBusquedaTesista2 = TxtCodTesista2;
            //codigoBusquedaTesista3 = TxtCodTesista3;
        }

        private void txtCodDocente_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtDNIDocente, txtCodDocente.Text);
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            string codigo = oTesis.GenerarCodigoTesis();


            TxtCodTesis.Text = codigo;
        }

        private void TxtCodTesista1_TextChanged(object sender, EventArgs e)
        {
            ConsultarEstudiante(TxtNombreTesista1, TxtApeTesista1, TxtDniTesista1, TxtCodTesista1.Text);
        }

        private void TxtCodTesista2_TextChanged(object sender, EventArgs e)
        {
            ConsultarEstudiante(TxtNombreTesista2, TxtApeTesista2, TxtDniTesista2, TxtCodTesista2.Text);
        }

        private void TxtCodTesista3_TextChanged(object sender, EventArgs e)
        {
            ConsultarEstudiante(TxtNombreTesista3, TxtApeTesista3, TxtDniTesista3, TxtCodTesista3.Text);
        }

        private void ChlRequisitosXTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = CboCodTramite.SelectedIndex;
            if (indice == 0)
            {
                TbCTramites.SelectedIndex = 0;
            }
            if (indice == 1)
            {
                TbCTramites.SelectedIndex = 1;
            }
            /*
            if(VerificarRequisitos())
            {
                GbxTramiteDeInscripcion.Visible = true;
            }
            else
            {
                GbxTramiteDeInscripcion.Visible = false;
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBuscarExpediente A = new FrmBuscarExpediente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtNroExpediente;







            //ConsultarEstudiante(TxtNombreTesista1, TxtApeTesista1, TxtDniTesista1, TxtCodTesista1.Text);
        }

        private void RbMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbMarcarTodo.Checked == true)
            {
                for (int j = 0; j < ChlRequisitosXTramite.Items.Count; j++)
                {
                    ChlRequisitosXTramite.SetItemChecked(j, true);
                }
            }
        }

        private void RbDesmarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDesmarcarTodo.Checked == true)
            {
                for (int j = 0; j < ChlRequisitosXTramite.Items.Count; j++)
                {
                    ChlRequisitosXTramite.SetItemChecked(j, false);
                }
            }
        }

        private void TxtNroExpediente_TextChanged(object sender, EventArgs e)
        {
            dicTxtCodTesis.Text = oDictaminanteDeTesis.BuscarTesisXExpediente(TxtNroExpediente.Text);
            ConsultarTesis(dicTxtTituloTesis,dicTxtTemaTesis,dicTxtObservacionesTesis,dicTxtCodTesis.Text);

        }

        private void dicTxtCodTesis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //buscar Estudiantes Interesados
                DataTable d1 = oDictaminanteDeTesis.ListarInteresados(dicTxtCodTesis.Text);
                //MessageBox.Show(d1.Rows.Count.ToString());
                if (d1.Rows.Count == 1)
                {
                    //aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
                    dicTxtCodTesista1.Text = d1.Rows[0]["CodTesista"].ToString();
                    ConsultarEstudiante(dicTxtNombreTesista1, dicTxtApeTesista1, dicTxtDniTesista1, dicTxtCodTesista1.Text);
                }
                if (d1.Rows.Count == 2)
                {
                    //aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
                    dicTxtCodTesista1.Text = d1.Rows[0]["CodTesista"].ToString();
                    dicTxtCodTesista2.Text = d1.Rows[1]["CodTesista"].ToString();
                    ConsultarEstudiante(dicTxtNombreTesista1, dicTxtApeTesista1, dicTxtDniTesista1, dicTxtCodTesista1.Text);
                    ConsultarEstudiante(dicTxtNombreTesista2, dicTxtApeTesista2, dicTxtDniTesista2, dicTxtCodTesista2.Text);
                }
                if (d1.Rows.Count == 3)
                {
                    //aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
                    dicTxtCodTesista1.Text = d1.Rows[0]["CodTesista"].ToString();
                    dicTxtCodTesista2.Text = d1.Rows[1]["CodTesista"].ToString();
                    dicTxtCodTesista3.Text = d1.Rows[2]["CodTesista"].ToString();
                    ConsultarEstudiante(dicTxtNombreTesista1, dicTxtApeTesista1, dicTxtDniTesista1, dicTxtCodTesista1.Text);
                    ConsultarEstudiante(dicTxtNombreTesista2, dicTxtApeTesista2, dicTxtDniTesista2, dicTxtCodTesista2.Text);
                    ConsultarEstudiante(dicTxtNombreTesista3, dicTxtApeTesista3, dicTxtDniTesista3, dicTxtCodTesista3.Text);
                }
                //CARGAR Datos del docente
                dicTxtCodDocente.Text = oDictaminanteDeTesis.BuscarDocenteAsesorPorTesis(dicTxtCodTesis.Text);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }

        private void dicTxtCodDocente_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(dicTxtNombresDocente, dicTxtApellidosDocente, dicTxtDNIDocente, dicTxtCodDocente.Text);
        }
    }
}
