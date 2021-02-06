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
    public partial class FrmRequisitosXTramite : FrmPadre
    {
        private CRequisitoXTramite oRequisitoXTramite;
        private CTramite oTramite;
        public FrmRequisitosXTramite()
        {
            InitializeComponent();
            IniciarEntidad(new CRequisitoXTramite());
            oRequisitoXTramite = new CRequisitoXTramite();
            oTramite = new CTramite();
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================

        //-- Establecer los valores que iran a la tabla 

        // 	
        //-- Mostrar los datos de un registro 
        // 	
        //-- Iniciar los atributos clave y no clave en blanco 

        //-- Listar los registros y mostrarlos en el datagrid 
        public override void ListarRegistros()
        {	//-- Mostrar todos los libros de la tabla en el grid 
            DgvTramiteXRequisito.DataSource = (aEntidad as CRequisitoXTramite).ListaPorTramite(CboCodTramite.Text);

        }

        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        // 	
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ProcesarClave();
            ListarRegistros();
        }
        
        public void LlenarCboTramites()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodTramite.DataSource = oTramite.ListaGeneral();
                //CboCodDocente.DisplayMember = "Correo";
                CboCodTramite.ValueMember = "NroTramite";
                //-- dejar el combo sin libro seleccionado
                CboCodTramite.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        private void FrmRequisitosXTramite_Load(object sender, EventArgs e)
        {
            //ListarRequisitosXTramite();
            ListarRegistros();
            MessageBox.Show("hola1");
            LlenarCboTramites();
            MessageBox.Show("hola2");
        }

        private void CboCodTramite_TextChanged(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        private void CboCodTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarRegistroXTramite f = new FrmEditarRegistroXTramite();
            f.ShowDialog();
        }
    }
}
