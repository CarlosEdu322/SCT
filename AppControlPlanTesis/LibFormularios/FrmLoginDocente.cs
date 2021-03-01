using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class FrmLoginDocente : Form
    {
        public Label CajadeTexto;
        public FrmLoginDocente(string pCodDocente)
        {
            InitializeComponent();
            TxtUsuario.Text = pCodDocente;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text.CompareTo(TxtContraseña.Text)==0)
            {
                CajadeTexto.Text = "LOGUEADO";
                MessageBox.Show("LOGIN EXITOSO", "NOTIFICACION");
                this.Close();
            }
            else
            {
                MessageBox.Show("LOGIN FALLIDO", "NOTIFICACION");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtContraseña.Text = "";
        }
    }
}
