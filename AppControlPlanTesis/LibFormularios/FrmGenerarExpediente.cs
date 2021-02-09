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
            InicializarGrid();
        }

        public void InicializarGrid()
        {
            dataGridView1.DataSource = oDocente.ListaGeneral();
            dataGridView1.Columns["CodDocente"].Visible = false;
            dataGridView1.Columns["Correo"].Visible = false;
            dataGridView1.Columns["Telefono"].Visible = false;
            dataGridView1.Columns["Dni"].Visible = false;
        }


        private void FrmGenerarExpediente_Load(object sender, EventArgs e)
        {
            DgvTramitesDeInscripcion.DataSource= oTramite.ListaTramitesDeInscripcionDeTesis();
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
            List<string> listaExpediente = new List<string>();
            listaExpediente.Add(TxtNroExpediente.Text);
            listaExpediente.Add(TxtCodTesis.Text);
            oPlanDeTesis.GenerarExpediente(listaExpediente);
        }
    }
}
