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
    public partial class FrmBuscarDocente : Form
    {
        public TextBox CajadeTexto;
        public List<string> ListaDocentes=new List<string>();
        private CDocente oDocente = new CDocente();
        public FrmBuscarDocente()
        {
            InitializeComponent();
            InicializarCamposCboNroEstudiantes();                  
        }

        public void InicializarCamposCboNroEstudiantes()
        {
            CboCategoria.SelectedIndex = 0;
            dgvDocentes.DataSource = oDocente.ListarDocentesNombrados();
            dgvDocentes.Columns["CodDocente"].Visible = false;
            dgvDocentes.Columns["Correo"].Visible = false;
            dgvDocentes.Columns["Telefono"].Visible = false;
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string Consulta = "select * from TDocente where " + CboCategoria.SelectedItem.ToString() + " like'" + TxtBuscar.Text + "%' and Categoria like 'Nombrado';";
            dgvDocentes.DataSource = oDocente.Busqueda(Consulta);
            dgvDocentes.Columns["CodDocente"].Visible = false;
            dgvDocentes.Columns["Correo"].Visible = false;
            dgvDocentes.Columns["Telefono"].Visible = false;
        }
        public bool ExisteDocente(string pCodDocente)
        {
            bool encontrado = false;
            for (int k = 0; k < ListaDocentes.Count; k++)
            {
                if (ListaDocentes[k].CompareTo(pCodDocente) == 0)
                    encontrado = true;
            }
            return encontrado;
        }
        
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmIniciarTramiteEstudiante frm = Owner as FrmIniciarTramiteEstudiante;
            //frm.CodigoBusqueda.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            string codigoDocente= dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            if (!ExisteDocente(codigoDocente))
            {
                CajadeTexto.Text = codigoDocente;
                this.Close();
            }
            else
            {

                MessageBox.Show("EL DOCENTE SELECCIONADO YA FUE DESIGNADO", "ALERTA");
            }
            
        }
    }
}
