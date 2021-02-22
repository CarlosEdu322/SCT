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
    public partial class FrmNombrarJuradoSustentacionOral : Form
    {
        public FrmNombrarJuradoSustentacionOral()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarPresidente_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtPresidente;
        }

        private void BtnBuscarDictaminante1_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDictaminante1;
        }

        private void BtnBuscarDictaminante2_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDictaminante2;
        }

        private void BtnBuscarDictaminante3_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDictaminante3;
        }

        private void BtnBuscarReplicante1_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodReplicante1;
        }

        private void BtnBuscarReplicante2_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodReplicante2;
        }

        private void BtnBuscarReplicante3_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodReplicante3;
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

        private void TxtPresidente_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresPresidente, TxtApellidosPresidente, TxtPresidenteDNI, TxtPresidente.Text);
        }

        private void txtCodDictaminante1_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(txtCodDictaminante1, TxtApellidosDictaminante1, TxtDNIDictaminante1, txtCodDictaminante1.Text);
        }

        private void txtCodDictaminante2_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(txtCodDictaminante2, TxtApellidosDictaminante2, TxtDNIDictaminante2, txtCodDictaminante2.Text);
        }

        private void txtCodDictaminante3_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(txtCodDictaminante3, TxtApellidosDictaminante3, TxtDNIDictaminante3, txtCodDictaminante3.Text);
        }

        private void txtCodReplicante1_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(txtNombresReplicante1, txtApellidosReplicante1, txtDNIReplicante1, txtCodReplicante1.Text);
        }

        private void txtCodReplicante2_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(txtNombresReplicante2, txtApellidosReplicante2, txtDNIReplicante2, txtCodReplicante2.Text);
        }

        private void txtCodReplicante3_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(txtNombresReplicante3, txtApellidosReplicante3, txtDNIReplicante3, txtCodReplicante3.Text);
        }
    }
}
