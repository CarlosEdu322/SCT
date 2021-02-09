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
    public partial class FrmTesisXTesista : Form
    {
        private CTesis oTesis;
        public FrmTesisXTesista()
        {
            InitializeComponent();
            oTesis = new CTesis();
            DgvTesisXTesista.DataSource = oTesis.ListarTesisXTesista();
        }

    }
}
