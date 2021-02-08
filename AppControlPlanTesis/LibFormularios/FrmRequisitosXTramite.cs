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
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { CboCodTramite.Text,TxtNombreTramite.Text};
        }
        // 	
        //-- Mostrar los datos de un registro 
        public override void MostrarDatos()
        {	//-- muestra la informacion contenida en el dataset de CDocente
            //CboCodTramite.Text = aEntidad.ValorAtributo("CodTramite");
            //TxtCodRequisito.Text = aEntidad.ValorAtributo("CodRequisito");
            //TxtNombreTramite.Text = oRequisitoXTramite.ValorAtributoTipo("TipoRequisito");
        }
        // 	
        //-- Iniciar los atributos clave y no clave en blanco 
        public override void InicializarAtributoClave()
        {
            CboCodTramite.Enabled = true;


        }
        public override void InicializarAtributosNoClave()
        {
            TxtNombreTramite.Text = "";
        }
        // 	
        //-- Listar los registros y mostrarlos en el datagrid 
        public override void ListarRegistros()
        {	//-- Mostrar todos los libros de la tabla en el grid 
            try
            {
                DgvTramiteXRequisito.DataSource = (aEntidad as CRequisitoXTramite).ListaPorTramite(CboCodTramite.Text);
            }
            catch
            {

            }
        }

        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        // 	
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 

        public override void ProcesarClave()
        {
            //-- Recuperar atributos, el primer atributo es la clave 
            string[] Atributos = AsignarValoresAtributos();
            // ----- Verificar si existe clave primaria 
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {   //-- Registro existente, Recuperar Atributos y mostrarlos 
                MostrarDatos();
                aEntidad.Nuevo = false;
            }
            else
            {   //-- Registro nuevo, inicializar atributos no clave 
                InicializarAtributosNoClave();
            }
        }

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
                CboCodTramite.ValueMember = "CodTramite";
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
            LlenarCboTramites();
        }

        private void CboCodTramite_TextChanged(object sender, EventArgs e)
        {
            //LlenarListaRequisitos();
            //ListarRegistros();
        }

        private void CboCodTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LlenarListaRequisitos();
            ListarRegistros();
            MostrarDatos();
        }
    }
}
