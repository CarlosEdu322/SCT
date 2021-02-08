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
        public FrmGenerarExpediente()
        {
            InitializeComponent();
            oTramite = new CTramite();
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
    }
}
