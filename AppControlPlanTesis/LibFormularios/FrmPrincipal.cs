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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTesista oFrmTesista = new FrmTesista();
            oFrmTesista.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDocente oFrmTesista = new FrmDocente();
            oFrmTesista.ShowDialog();
        }

        private void btnManTesista_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmTesista());
        }

        private void btnManDocente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmDocente());
        }
        private void AbrirFormInPanel(object formhijo)
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
                this.Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
