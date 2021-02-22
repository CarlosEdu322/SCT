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
    public partial class FrmBuscarExpediente : Form
    {
        public TextBox CajadeTexto;
        private CDictaminanteDeTesis oDictaminanteDeTesis = new CDictaminanteDeTesis();
        public FrmBuscarExpediente()
        {
            InitializeComponent();
            InicializarCamposCboNroEstudiantes();
        }
        public void InicializarCamposCboNroEstudiantes()
        {
            //CboCategoria.SelectedIndex = 0;
            DgvExpediente.DataSource = oDictaminanteDeTesis.ListarExpediente();
            //DgvExpediente.Columns["CodDocente"].Visible = false;
            //DgvExpediente.Columns["Correo"].Visible = false;
            //DgvExpediente.Columns["Telefono"].Visible = false;
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string Consulta = "select * from TExpediente;";
            DgvExpediente.DataSource = oDictaminanteDeTesis.Busqueda(Consulta);
            //DgvExpediente.Columns["CodDocente"].Visible = false;
            //DgvExpediente.Columns["Correo"].Visible = false;
            //DgvExpediente.Columns["Telefono"].Visible = false;
        }



        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
        {

            FrmIniciarTramiteEstudiante frm = Owner as FrmIniciarTramiteEstudiante;
            //frm.CodigoBusqueda.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            CajadeTexto.Text = DgvExpediente.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
