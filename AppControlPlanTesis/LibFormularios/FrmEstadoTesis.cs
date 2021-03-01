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
        FrmBuscarTesis A;
        TextBox txtETesis;
        public FrmEstadoTesis()
        {
            InitializeComponent();

        }
        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
            Application.DoEvents();
        }
        private void FrmEstadoTesis_Load(object sender, EventArgs e)
        {
            ArrayList ListaEstado = new ArrayList();
            ArrayList ListaNumero = new ArrayList();
            ArrayList ListaEspecialidades = new ArrayList();
            ArrayList ListaCantidadDeEspecialidad = new ArrayList();
            oReportes.NumeroDeTesis(ListaEstado,ListaNumero);
            oReportes.NumeroDeTesisPorEspecialidad(ListaEspecialidades, ListaCantidadDeEspecialidad);
            chartTesis.Series[0].Points.DataBindXY(ListaEstado, ListaNumero);
            chartTesisXEspecialidad.Series[0].Points.DataBindXY(ListaEspecialidades, ListaCantidadDeEspecialidad);
        }

        private void BtnBuscarTesis_Click(object sender, EventArgs e)
        {
            A= new FrmBuscarTesis();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodTesis;
        }
        public void ConsultarTesis(TextBox tbox1, TextBox tbox2,TextBox txtEstado, string codigotesis)
        {
            CTesis tesis = new CTesis();
            if (tesis.ExisteClavePrimaria(codigotesis))
            {
                //MessageBox.Show("Codigo encontrado", "Se actualizaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-- Recuperar atributos, el primer atributo es la clave 
                tbox1.Text = tesis.ValorAtributo("Titulo");
                tbox2.Text = tesis.ValorAtributo("Tema");
                txtEstado.Text = tesis.ValorAtributo("Estado");
            }
            else
            {
                //MessageBox.Show("No se pudo encontrar el codigo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbox1.Clear(); tbox2.Clear();
            }
        }
        private void txtCodTesis_TextChanged(object sender, EventArgs e)
        {
            txtETesis = new TextBox();
            ConsultarTesis(txtNombreTesis, txtEspecialidadTesis, txtETesis, txtCodTesis.Text);
            txtEstadoTesis.Text = oReportes.EstadoProcesoTesis(txtCodTesis.Text);
        }
        private void InicializarState()
        {
            pb1.Value = 0;
            picture1OK.Visible = false;
            pb2.Value = 0;
            picture2OK.Visible = false;
            pb3.Value = 0;
            picture3OK.Visible = false;
            pb4.Value = 0;
            picture4OK.Visible = false;
            txtEstadoTesis.Visible = false;
        }
        private void txtEstadoTesis_TextChanged(object sender, EventArgs e)
        {
            A.Close();
            InicializarState();
            if (txtETesis.Text == "TESIS PREINSCRITA")
            {
                txtEstadoTesis.Visible = false;
                imgCargando.Visible = true;
                lblCargando.Visible = true;
                if (pb1.Value == 0)
                {
                    pb1.Value = 100;
                    Wait(500);
                    picture1OK.Visible = true;
                    pb2.Value = 50;
                }
                imgCargando.Visible = false;
                lblCargando.Visible = false;
                txtEstadoTesis.Visible = true;
            }
            if (txtETesis.Text == "TESIS APROBADA POR COMISION REVISORA")
            {
                txtEstadoTesis.Visible = false;
                imgCargando.Visible = true;
                lblCargando.Visible = true;
                if (pb1.Value == 0)
                {
                    pb1.Value = 100;
                    Wait(500);
                    picture1OK.Visible = true;
                    pb2.Value = 50;
                }
                if (pb2.Value == 50)
                {
                    pb2.Value = 100;
                    Wait(500);
                    picture2OK.Visible = true;
                    pb3.Value = 50;
                    Wait(500);
                }
                imgCargando.Visible = false;
                lblCargando.Visible = false;
                txtEstadoTesis.Visible = true;
            }
            if (txtETesis.Text == "TESIS APROBADA POR DICTAMINANTES")
            {
                txtEstadoTesis.Visible = false;
                imgCargando.Visible = true;
                lblCargando.Visible = true;
                if (pb1.Value == 0)
                {
                    pb1.Value = 100;
                    Wait(500);
                    picture1OK.Visible = true;
                    pb2.Value = 50;
                }
                if (pb2.Value == 50)
                {
                    pb2.Value = 100;
                    Wait(500);
                    picture2OK.Visible = true;
                    pb3.Value = 50;
                }
                if (pb3.Value == 50)
                {
                    pb3.Value = 100;
                    Wait(500);
                    picture3OK.Visible = true;
                    pb4.Value = 50;
                    Wait(500);
                }
                imgCargando.Visible = false;
                lblCargando.Visible = false;
                txtEstadoTesis.Visible = true;
            }
            if (txtETesis.Text == "TESIS CONCLUIDA")
            {
                txtEstadoTesis.Visible = false;
                imgCargando.Visible = true;
                lblCargando.Visible = true;
                if (pb1.Value == 0)
                {
                    pb1.Value = 100;
                    Wait(500);
                    picture1OK.Visible = true;
                    pb2.Value = 50;
                }
                if (pb2.Value == 50)
                {
                    pb2.Value = 100;
                    Wait(500);
                    picture2OK.Visible = true;
                    pb3.Value = 50;
                }
                if (pb3.Value == 50)
                {
                    pb3.Value = 100;
                    Wait(500);
                    picture3OK.Visible = true;
                    pb4.Value = 50;
                }
                if (pb4.Value == 50)
                {
                    pb4.Value = 100;
                    Wait(500);
                    picture4OK.Visible = true;
                }
                imgCargando.Visible = false;
                lblCargando.Visible = false;
                txtEstadoTesis.Visible = true;
            }     
        }
    }
}
