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
    public partial class FrmGenerarExpediente : Form
    {
        private CTramite oTramite;
        CDocente oDocente = new CDocente();
        CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
        public FrmGenerarExpediente()
        {
            InitializeComponent();
            oTramite = new CTramite();
            // Create new Checkbox Column
            DataGridViewCheckBoxColumn CBColumn = new DataGridViewCheckBoxColumn();
            CBColumn.HeaderText = "";
            CBColumn.FalseValue = "0";
            CBColumn.TrueValue = "1";
            dataGridView1.Columns.Insert(0, CBColumn);
            //InicializarGrid();
            ccf.Visible = false;
        }

        public void InicializarGrid()
        {
            dataGridView1.DataSource = oDocente.ListaGeneral();
            dataGridView1.Columns["CodDocente"].Visible = false;
            dataGridView1.Columns["Correo"].Visible = false;
            dataGridView1.Columns["Telefono"].Visible = false;
            dataGridView1.Columns["Dni"].Visible = false;
        }
        private void RellenarTablaTramites()
        {
            DgvTramitesDeInscripcion.DataSource = oTramite.ListaTramitesDeInscripcionDeTesis();
            DgvTramitesDeInscripcion.Columns["CodTesis"].Visible = false;
        }


        /*private void RellenarTablaTramites()
        {
            DgvTramitesDeInscripcion.DataSource = oTramite.ListaTramitesDeInscripcionDeTesis();
        }*/
        private void FrmGenerarExpediente_Load(object sender, EventArgs e)
        {
            RellenarTablaTramites();
        }

        private void BtnGenerarTramite_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();

            //oTramite.GenerarExpediente(lista);
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            TxtNroExpediente.Text = oPlanDeTesis.GenerarCodigoTesis();
        }

        private void BtnGenerarExpediente_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNroExpediente.Text != "")
                {


                    //generar expediente
                    List<string> listaExpediente = new List<string>();
                    listaExpediente.Add(TxtNroExpediente.Text);
                    listaExpediente.Add(TxtCodTesis.Text);
                    oPlanDeTesis.GenerarExpediente(listaExpediente);
                    //actualizar el estado del tramite a atendido
                    oPlanDeTesis.ActualizarEstadoDelTramite(TxtCodTramite.Text, TxtCodTesis.Text);
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    RellenarTablaTramites();
                }
                else
                {
                    MessageBox.Show("INGRESE UN NUMERO DE EXPEDIENTE", "ALERTA");
                }
            }
            catch
            {
                MessageBox.Show("NUMERO DE EXPEDIENTE YA EXISTE", "ERROR");
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                //int filat= DgvTramitesDeInscripcion.CurrentRow.Index;
                TxtCodTesis.Text = DgvTramitesDeInscripcion.CurrentRow.Cells["CodTesis"].Value.ToString();
                TxtCodTramite.Text = DgvTramitesDeInscripcion.CurrentRow.Cells["CodTramITTesis"].Value.ToString();
                //DgvDocentes.DataSource= oPlanDeTesis.ListarTesistasXTesis();
                DgvInteresados.DataSource = oPlanDeTesis.ListarInteresados(TxtCodTesis.Text);
            }
            catch
            {
                MessageBox.Show("NO HA SELECCIONADO", "ERROR");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
