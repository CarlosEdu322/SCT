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
    public partial class FrmInformeComisionRevisora : Form
    {
        public FrmInformeComisionRevisora()
        {
            InitializeComponent();
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
        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente;
            ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtDNIDocente, txtCodDocente.Text);
        }
    }
}
