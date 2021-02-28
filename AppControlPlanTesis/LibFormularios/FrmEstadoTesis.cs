using System;
using System.Collections;
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
    public partial class FrmEstadoTesis : Form
    {
        public CReportes oReportes = new CReportes();
        public FrmEstadoTesis()
        {
            InitializeComponent();
        }

        private void FrmEstadoTesis_Load(object sender, EventArgs e)
        {
            ArrayList ListaEstado = new ArrayList();
            ArrayList ListaNumero = new ArrayList();
            oReportes.NumeroDeTesis(ListaEstado,ListaNumero);
            chartTesis.Series[0].Points.DataBindXY(ListaEstado, ListaNumero);
        }
    }
}
