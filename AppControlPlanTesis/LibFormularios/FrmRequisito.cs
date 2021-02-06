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
    public partial class FrmRequisito : FrmPadre
    {
        public FrmRequisito()
        {
            InitializeComponent();
            IniciarEntidad(new CRequisito());
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================

        //-- Establecer los valores que iran a la tabla 
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodRequisito.Text,
                TxtTipoRequisito.Text};
        }
        // 	
        //-- Mostrar los datos de un registro 
        public override void MostrarDatos()
        {	//-- muestra la informacion contenida en el dataset de CDocente
            TxtCodRequisito.Text = aEntidad.ValorAtributo("NroRequisito");
            TxtTipoRequisito.Text = aEntidad.ValorAtributo("TipoRequisito");
        }
        // 	
        //-- Iniciar los atributos clave y no clave en blanco 
        public override void InicializarAtributoClave()
        {
            TxtCodRequisito.Enabled = true;
            TxtCodRequisito.Text = "";

        }
        public override void InicializarAtributosNoClave()
        {
            TxtTipoRequisito.Text = "";
        }
        // 	
        //-- Listar los registros y mostrarlos en el datagrid 
        public override void ListarRegistros()
        {	//-- Mostrar todos los libros de la tabla en el grid 
            DgvDocentes.DataSource = aEntidad.ListaGeneral();

        }
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        // 	
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        public override bool EsRegistroValido()
        {
            if ((TxtCodRequisito.Text.Trim() != "") && 
                (TxtTipoRequisito.Text.Trim() != "") )
                return true;
            else
                return false;
        }
        public override void ProcesarClave()
        {
            //-- Recuperar atributos, el primer atributo es la clave 
            string[] Atributos = AsignarValoresAtributos();
            // ----- Verificar si existe clave primaria 
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {   //-- Registro existente, Recuperar Atributos y mostrarlos 
                MostrarDatos();
                aEntidad.Nuevo = false;
                TxtCodRequisito.Enabled = false;
            }
            else
            {   //-- Registro nuevo, inicializar atributos no clave 
                InicializarAtributosNoClave();
            }
        }



        private void FrmRequisito_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        private void TxtCodRequisito_Leave(object sender, EventArgs e)
        {
            //ProcesarClave();
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            ProcesarClave();
        }
    }
}
