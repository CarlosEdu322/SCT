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
            oEvaluacionTesis = new CEvaluacionTesis();
            LlenarTesisPendientes();
            String NResolucion = "D-" + oEvaluacionTesis.GenerarCodigoResolucionJuradoEvaluacion() + "-2021-FIEEIM-UNSAAC";
            TxtResolucion.Text = NResolucion;
        }

        public void LlenarTesisPendientes()
        {
            DgvTesisPendientesDeSustentacion.DataSource = oEvaluacionTesis.TesisPendientesDeDictamen();
            DgvTesisPendientesDeSustentacion.Columns["CodTesis"].Visible = false;
            //DgvTesisPendientesDeSustentacion.Columns["CodDictamenDeTesis"].Visible = false;
            DgvTesisPendientesDeSustentacion.Columns["Tema"].Visible = false;
            DgvTesisPendientesDeSustentacion.Columns["Observaciones"].Visible = false;
            //checks
            //DataGridViewCheckBoxColumn CBColumn = new DataGridViewCheckBoxColumn();
            //CBColumn.HeaderText = "";
            //CBColumn.FalseValue = "0";
            //CBColumn.TrueValue = "1";
            //DgvTesisPendientesDeSustentacion.Columns.Insert(0, CBColumn);


            string codigo = oEvaluacionTesis.GenerarCodigoNombrarComisionRevisora();
            TxtCodJuradoEvaluador.Text = codigo;
            if (DgvTesisPendientesDeSustentacion.Rows.Count == 0)
            {
                BtnCargar.Enabled = false;
                BtnNombrarJE.Enabled = false;
            }
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
            List<string> ListaDocentes = new List<string>();
            ListaDocentes.Add(TxtPresidente.Text);
            ListaDocentes.Add(txtCodDictaminante1.Text);
            ListaDocentes.Add(txtCodDictaminante2.Text);
            ListaDocentes.Add(txtCodDictaminante3.Text);
            ListaDocentes.Add(txtCodReplicante1.Text);
            ListaDocentes.Add(txtCodReplicante2.Text);
            ListaDocentes.Add(txtCodReplicante3.Text);
            A.ListaDocentes = ListaDocentes;
        }

        private void BtnBuscarDictaminante2_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDictaminante2;
            List<string> ListaDocentes = new List<string>();
            ListaDocentes.Add(TxtPresidente.Text);
            ListaDocentes.Add(txtCodDictaminante1.Text);
            ListaDocentes.Add(txtCodDictaminante2.Text);
            ListaDocentes.Add(txtCodDictaminante3.Text);
            ListaDocentes.Add(txtCodReplicante1.Text);
            ListaDocentes.Add(txtCodReplicante2.Text);
            ListaDocentes.Add(txtCodReplicante3.Text);
            A.ListaDocentes = ListaDocentes;
        }

        private void BtnBuscarDictaminante3_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDictaminante3;
            List<string> ListaDocentes = new List<string>();
            ListaDocentes.Add(TxtPresidente.Text);
            ListaDocentes.Add(txtCodDictaminante1.Text);
            ListaDocentes.Add(txtCodDictaminante2.Text);
            ListaDocentes.Add(txtCodDictaminante3.Text);
            ListaDocentes.Add(txtCodReplicante1.Text);
            ListaDocentes.Add(txtCodReplicante2.Text);
            ListaDocentes.Add(txtCodReplicante3.Text);
            A.ListaDocentes = ListaDocentes;
        }

        private void BtnBuscarReplicante1_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodReplicante1;
            List<string> ListaDocentes = new List<string>();
            ListaDocentes.Add(TxtPresidente.Text);
            ListaDocentes.Add(txtCodDictaminante1.Text);
            ListaDocentes.Add(txtCodDictaminante2.Text);
            ListaDocentes.Add(txtCodDictaminante3.Text);
            ListaDocentes.Add(txtCodReplicante1.Text);
            ListaDocentes.Add(txtCodReplicante2.Text);
            ListaDocentes.Add(txtCodReplicante3.Text);
            A.ListaDocentes = ListaDocentes;
        }

        private void BtnBuscarReplicante2_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodReplicante2;
            List<string> ListaDocentes = new List<string>();
            ListaDocentes.Add(TxtPresidente.Text);
            ListaDocentes.Add(txtCodDictaminante1.Text);
            ListaDocentes.Add(txtCodDictaminante2.Text);
            ListaDocentes.Add(txtCodDictaminante3.Text);
            ListaDocentes.Add(txtCodReplicante1.Text);
            ListaDocentes.Add(txtCodReplicante2.Text);
            ListaDocentes.Add(txtCodReplicante3.Text);
            A.ListaDocentes = ListaDocentes;
        }

        private void BtnBuscarReplicante3_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodReplicante3;
            List<string> ListaDocentes = new List<string>();
            ListaDocentes.Add(TxtPresidente.Text);
            ListaDocentes.Add(txtCodDictaminante1.Text);
            ListaDocentes.Add(txtCodDictaminante2.Text);
            ListaDocentes.Add(txtCodDictaminante3.Text);
            ListaDocentes.Add(txtCodReplicante1.Text);
            ListaDocentes.Add(txtCodReplicante2.Text);
            ListaDocentes.Add(txtCodReplicante3.Text);
            A.ListaDocentes = ListaDocentes;
        }
        public void ConsultarDocente(TextBox tbox1, TextBox tbox2, string codigotesista)
        {
            CDocente docente = new CDocente();
            if (codigotesista != "")
            {
                if (docente.ExisteClavePrimaria(codigotesista))
                {
                    //-- Recuperar atributos, el primer atributo es la clave 
                    tbox1.Text = docente.ValorAtributo("Nombres");
                    tbox2.Text = docente.ValorAtributo("Apellidos");
                }
                else
                {
                    tbox1.Clear(); tbox2.Clear();
                }
            }
        }

        private void TxtPresidente_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresPresidente, TxtApellidosPresidente, TxtPresidente.Text);
        }

        private void txtCodDictaminante1_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDictaminante1, TxtApellidosDictaminante1, txtCodDictaminante1.Text);
        }

        private void txtCodDictaminante2_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDictaminante2, TxtApellidosDictaminante2, txtCodDictaminante2.Text);
        }

        private void txtCodDictaminante3_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDictaminante3, TxtApellidosDictaminante3, txtCodDictaminante3.Text);
        }

        private void txtCodReplicante1_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(txtNombresReplicante1, txtApellidosReplicante1, txtCodReplicante1.Text);
        }

        private void txtCodReplicante2_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(txtNombresReplicante2, txtApellidosReplicante2, txtCodReplicante2.Text);
        }

        private void txtCodReplicante3_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(txtNombresReplicante3, txtApellidosReplicante3, txtCodReplicante3.Text);
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                //int filat= DgvTramitesDeInscripcion.CurrentRow.Index;
                TxtCodTesis.Text = DgvTesisPendientesDeSustentacion.CurrentRow.Cells["CodTesis"].Value.ToString();
                TxtExpediente.Text = DgvTesisPendientesDeSustentacion.CurrentRow.Cells["NroExpediente"].Value.ToString();
                TxtEspecialidad.Text = DgvTesisPendientesDeSustentacion.CurrentRow.Cells["Tema"].Value.ToString();
                //DgvDocentes.DataSource= oPlanDeTesis.ListarTesistasXTesis();
                DgvInteresados.DataSource = oEvaluacionTesis.ListarInteresados(TxtCodTesis.Text);
                //txtCodDictaminante1.Text = 
                string codDictaminantes = DgvTesisPendientesDeSustentacion.CurrentRow.Cells["CodDictamenDeTesis"].Value.ToString();
                dgvDictaminantes.DataSource = oEvaluacionTesis.ListarDictaminantes(codDictaminantes);
                txtCodDictaminante1.Text = dgvDictaminantes.Rows[0].Cells[0].Value.ToString();
                txtCodDictaminante2.Text = dgvDictaminantes.Rows[1].Cells[0].Value.ToString();
                txtCodDictaminante3.Text = dgvDictaminantes.Rows[2].Cells[0].Value.ToString();
                TxtNombreTesis.Text = DgvTesisPendientesDeSustentacion.CurrentRow.Cells["Titulo"].Value.ToString();
                TxtPresidente.Text = "D90021";
                TxtNombresPresidente.Text = "DAVID REYNALDO";
                TxtApellidosPresidente.Text = "BERRIOS BECERRA";
            }
            catch(Exception eee)
            {
                MessageBox.Show(eee.ToString());
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
        private bool EstanVaciosLosCampos()
        {
            bool a = true;
            if (TxtPresidente.Text == "" || txtCodDictaminante1.Text == "" || txtCodDictaminante2.Text == "" )
            {
                return a=false;
            }
            if (txtCodReplicante1.Text == "" || txtCodReplicante2.Text == "" || txtLugarSustentacion.Text == ""||TxtResolucion.Text=="")
            {
                return a=false;
            }
            return a;
        }
        public void RefrescarCampos()
        {
            TxtExpediente.Text = "";
            TxtCodTesis.Text = "";
            TxtNombreTesis.Text = "";
            TxtEspecialidad.Text = "";
            DgvInteresados.DataSource = null;
            TxtPresidente.Text = "";
            TxtNombresPresidente.Text = "";
            TxtApellidosPresidente.Text = "";

            txtCodDictaminante1.Text = "";
            TxtNombresDictaminante1.Text = "";
            TxtApellidosDictaminante1.Text = "";

            txtCodDictaminante2.Text = "";
            TxtNombresDictaminante2.Text = "";
            TxtApellidosDictaminante2.Text = "";

            txtCodDictaminante3.Text = "";
            TxtNombresDictaminante3.Text = "";
            TxtApellidosDictaminante3.Text = "";

            txtCodReplicante1.Text = "";
            txtNombresReplicante1.Text = "";
            txtApellidosReplicante1.Text = "";

            txtCodReplicante2.Text = "";
            txtNombresReplicante2.Text = "";
            txtApellidosReplicante2.Text = "";

            txtCodReplicante3.Text = "";
            txtNombresReplicante3.Text = "";
            txtApellidosReplicante3.Text = "";

            txtLugarSustentacion.Text = "";


        }
        private void BtnNombrarJE_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstanVaciosLosCampos())
                {
                    //AGREGAR CODIGO AL EXPEDIENTE
                    oEvaluacionTesis.UpdateExpediente(TxtExpediente.Text, TxtCodJuradoEvaluador.Text);
                    //AGREGAR DOCENTES A TJURADOEVALUADOR
                    List<string> JuradoEvaluador = new List<string>();
                    JuradoEvaluador.Add(TxtCodJuradoEvaluador.Text);
                    JuradoEvaluador.Add(TxtPresidente.Text);
                    JuradoEvaluador.Add(txtCodDictaminante1.Text);
                    JuradoEvaluador.Add(txtCodDictaminante2.Text);
                    JuradoEvaluador.Add(txtCodDictaminante3.Text);
                    JuradoEvaluador.Add(txtCodReplicante1.Text);
                    JuradoEvaluador.Add(txtCodReplicante2.Text);
                    JuradoEvaluador.Add(txtCodReplicante3.Text);
                    //ASESOR
                    JuradoEvaluador.Add("");
                    //SECRETARIO ACADEMICO
                    JuradoEvaluador.Add("");
                    JuradoEvaluador.Add(txtLugarSustentacion.Text);
                    //FECHA
                    var a = dateTimePicker1.Value;
                    var b = dateTimePicker2.Value;
                    JuradoEvaluador.Add(a.Month + "/" + a.Day + "/" +a.Year+" "+b.Hour+":"+b.Minute+":"+b.Second);           
                    oEvaluacionTesis.AgregarCodYJuradoEvaluador(JuradoEvaluador);
                    if (oEvaluacionTesis.VerificarSiEmitioResolucionFHJuradoEvaluador(TxtCodTesis.Text) == false)
                    {
                        oEvaluacionTesis.EmitirResolucionNombramientoJuradoEvaluador(TxtResolucion.Text, TxtCodTesis.Text);
                        CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
                        oPlanDeTesis.UpdateEstadoExpediente(TxtExpediente.Text, "TESIS CON EVALUACION DE JURADO EVALUADOR PENDIENTE");
                        MessageBox.Show("RESOLUCION: "+TxtResolucion.Text+" EMITIDA", "CONFIRMACION");
                    }
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");

                    LlenarTesisPendientes();
                    RefrescarCampos();
                }
                else
                {
                    MessageBox.Show("EXISTEN CAMPOS VACIOS", "ALERTA");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
    }
}
