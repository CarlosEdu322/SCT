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
        private CEvaluacionTesis oEvaluacionTesis;
        public FrmNombrarJuradoSustentacionOral()
        {
            InitializeComponent();
            CboNroReplicantes.SelectedIndex = 0;
            oEvaluacionTesis = new CEvaluacionTesis();
            LlenarTesisPendientes();
        }

        public void LlenarTesisPendientes()
        {
            DgvTesisPendientesDeSustentacion.DataSource = oEvaluacionTesis.TesisPendientesDeDictamen();
            DgvTesisPendientesDeSustentacion.Columns["CodTesis"].Visible = false;
            DgvTesisPendientesDeSustentacion.Columns["CodDictamenDeTesis"].Visible = false;
            //checks
            //DataGridViewCheckBoxColumn CBColumn = new DataGridViewCheckBoxColumn();
            //CBColumn.HeaderText = "";
            //CBColumn.FalseValue = "0";
            //CBColumn.TrueValue = "1";
            //DgvTesisPendientesDeSustentacion.Columns.Insert(0, CBColumn);


            string codigo = oEvaluacionTesis.GenerarCodigoNombrarComisionRevisora();
            TxtCodJuradoEvaluador.Text = codigo;
            /*
            DgvTesisPendientesDeCR.Columns["CodDictamenDeTesis"].Visible = false;
            DgvTesisPendientesDeCR.Columns["CodSustentacionOral"].Visible = false;
            */
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
            ConsultarDocente(TxtNombresDictaminante1, TxtApellidosDictaminante1, TxtDNIDictaminante1, txtCodDictaminante1.Text);
        }

        private void txtCodDictaminante2_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDictaminante2, TxtApellidosDictaminante2, TxtDNIDictaminante2, txtCodDictaminante2.Text);
        }

        private void txtCodDictaminante3_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDictaminante3, TxtApellidosDictaminante3, TxtDNIDictaminante3, txtCodDictaminante3.Text);
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

        private void CboNroReplicantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboNroReplicantes.SelectedIndex==0)
            {
                //replicante2
                //replicante3
                txtCodReplicante3.Enabled = false;
                txtNombresReplicante3.Enabled = false;
                txtApellidosReplicante3.Enabled = false;
                txtDNIReplicante3.Enabled = false;
                BtnBuscarReplicante3.Enabled = false;
                txtCodReplicante3.Text = "";
            }
            if (CboNroReplicantes.SelectedIndex == 1)
            {
                txtCodReplicante3.Enabled = true;
                txtNombresReplicante3.Enabled = true;
                txtApellidosReplicante3.Enabled = true;
                txtDNIReplicante3.Enabled = true;
                BtnBuscarReplicante3.Enabled = true;
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                //int filat= DgvTramitesDeInscripcion.CurrentRow.Index;
                TxtCodTesis.Text = DgvTesisPendientesDeSustentacion.CurrentRow.Cells["CodTesis"].Value.ToString();
                TxtExpediente.Text = DgvTesisPendientesDeSustentacion.CurrentRow.Cells["NroExpediente"].Value.ToString();
                //DgvDocentes.DataSource= oPlanDeTesis.ListarTesistasXTesis();
                DgvInteresados.DataSource = oEvaluacionTesis.ListarInteresados(TxtCodTesis.Text);
                dgvDictaminantes.DataSource = oEvaluacionTesis.ListarDictaminantes(DgvTesisPendientesDeSustentacion.CurrentRow.Cells["CodDictamenDeTesis"].Value.ToString());
            }
            catch
            {
                MessageBox.Show("NO HA SELECCIONADO", "ERROR");
            }

            //
            //TxtCodTesis.Text = oPlanDeTesis.GenerarCodigoNombrarComisionRevisora();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerarNroResolucion_Click(object sender, EventArgs e)
        {
            String NResolucion = "D-" + oEvaluacionTesis.GenerarCodigoResolucionJuradoEvaluacion() + "-2021-FIEEIM-UNSAAC";
            TxtResolucion.Text = NResolucion;
        }

        private void btnMostrarResoluciones_Click(object sender, EventArgs e)
        {
            FrmMostrarResolucion A = new FrmMostrarResolucion();
            A.Show();
        }

        private void dgvDictaminantes_DoubleClick(object sender, EventArgs e)
        {
            if (txtCodDictaminante1.Text == "")
            {
                txtCodDictaminante1.Text = dgvDictaminantes.CurrentRow.Cells["CodDocente"].Value.ToString();
            }
            else
            {
                if (txtCodDictaminante2.Text == "")
                {
                    txtCodDictaminante2.Text = dgvDictaminantes.CurrentRow.Cells["CodDocente"].Value.ToString();
                }
                else
                {
                    if (txtCodDictaminante3.Text == "")
                    {
                        txtCodDictaminante3.Text = dgvDictaminantes.CurrentRow.Cells["CodDocente"].Value.ToString();
                    }
                }
            }
        }
    }
}
