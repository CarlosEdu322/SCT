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
    public partial class FrmBuscarTesista : Form
    {
        public TextBox CajadeTexto;
        private CTesista oTesista = new CTesista();
        public List<string> ListaEstudiantes;
        public FrmBuscarTesista()
        {
            InitializeComponent();
            InicializarCamposCboNroEstudiantes();
        }
        public void InicializarCamposCboNroEstudiantes()
        {
            CboCategoria.SelectedIndex = 0;
            dgvTesista.DataSource = oTesista.ListaGeneral();
            //dgvTesista.Columns["CodDocente"].Visible = false;
            dgvTesista.Columns["Correo"].Visible = false;
            dgvTesista.Columns["Telefono"].Visible = false;
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string Consulta = "select * from TTesista where " + CboCategoria.SelectedItem.ToString() + " like'" + TxtBuscar.Text + "%';";
            dgvTesista.DataSource = oTesista.Busqueda(Consulta);
            //dgvTesista.Columns["CodDocente"].Visible = false;
            //dgvTesista.Columns["Correo"].Visible = false;
            //dgvTesista.Columns["Telefono"].Visible = false;
        }
        public bool listaEstudiantes(string pCodDocente)
        {
            bool encontrado = false;
            for (int k = 0; k < ListaEstudiantes.Count; k++)
            {
                if (ListaEstudiantes[k].CompareTo(pCodDocente) == 0)
                    encontrado = true;
            }
            return encontrado;
        }
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmIniciarTramiteEstudiante frm = Owner as FrmIniciarTramiteEstudiante;
            //frm.CodigoBusquedaTesista1.Text = dgvTesista.CurrentRow.Cells[0].Value.ToString();
            string codigoTesista = dgvTesista.CurrentRow.Cells[0].Value.ToString();
            if (!listaEstudiantes(codigoTesista))
            {
                CajadeTexto.Text = codigoTesista;
                this.Close();
            }
            
            else
            {

                MessageBox.Show("EL TESISTA SELECCIONADO YA FUE SELECCIONADO", "ALERTA");
            }

        }

    }
}
