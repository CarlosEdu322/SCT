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
    public partial class FrmBuscarTesis : Form
    {
        public TextBox CajadeTexto;
        private CTesis oTesis = new CTesis();
        public FrmBuscarTesis()
        {
            InitializeComponent();
            InicializarCamposCboNroEstudiantes();
            CboCategoria.SelectedIndex = 0;
        }
        public void InicializarCamposCboNroEstudiantes()
        {
            //CboCategoria.SelectedIndex = 0;
            DgvTesis.DataSource = oTesis.ListaGeneral();
            DgvTesis.Columns["CodTesis"].Visible = false;
            DgvTesis.Columns["CodDocente"].Visible = false;
            DgvTesis.Columns["Estado"].Visible = false;
            //DgvExpediente.Columns["CodDocente"].Visible = false;
            //DgvExpediente.Columns["Correo"].Visible = false;
            //DgvExpediente.Columns["Telefono"].Visible = false;
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string Consulta = "select * from TTesis where " + CboCategoria.SelectedItem.ToString() + " like'" + TxtBuscar.Text + "%';";
            DgvTesis.DataSource = oTesis.Busqueda(Consulta);
            DgvTesis.Columns["CodTesis"].Visible = false;
            DgvTesis.Columns["CodDocente"].Visible = false;
            DgvTesis.Columns["Estado"].Visible = false;
        }
        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
        {
            FrmIniciarTramiteEstudiante frm = Owner as FrmIniciarTramiteEstudiante;
            //frm.CodigoBusqueda.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            if (DgvTesis.CurrentRow.Cells[0].Value==null)
            {
                CajadeTexto.Text = "";
            }
            else
            {
                CajadeTexto.Text = DgvTesis.CurrentRow.Cells[0].Value.ToString();
            }
            this.Close();
        }
    }
}
