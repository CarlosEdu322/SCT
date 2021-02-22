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
    public partial class FrmMostrarResolucion : Form
    {
        CPlanDeTesis oPlantesis = new CPlanDeTesis();
        public FrmMostrarResolucion()
        {
            InitializeComponent();
            CargarGridResolucion();
        }
        private void CargarGridResolucion()
        {
            dgvResoluciones.DataSource = oPlantesis.MostrarResolucion();
            dgvResoluciones.Columns["id"].Visible = false;
            //dgvResoluciones.Columns["Resolucion"].Width = 170;
            //dgvResoluciones.Columns["Considerando"].Width = 280;
            //dgvResoluciones.Columns["FechaEmision"].Width = 130;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGridResolucion();
        }
    }
}
