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
        public FrmRequisitosXTramite()
        {
            InitializeComponent();
            IniciarEntidad(new CRequisitoXTramite());
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================

        //-- Establecer los valores que iran a la tabla 
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodTramite.Text,TxtCodRequisito.Text};
        }
        // 	
        //-- Mostrar los datos de un registro 
        public override void MostrarDatos()
        {	//-- muestra la informacion contenida en el dataset de CDocente
            TxtCodTramite.Text = aEntidad.ValorAtributo("CodTramite");
            TxtCodRequisito.Text = aEntidad.ValorAtributo("CodRequisito");
        }
        // 	
        //-- Iniciar los atributos clave y no clave en blanco 
        public override void InicializarAtributoClave()
        {
            TxtCodTramite.Enabled = true;
            TxtCodTramite.Text = "";

        }
        public override void InicializarAtributosNoClave()
        {
            TxtCodRequisito.Text = "";
        }
        // 	
        //-- Listar los registros y mostrarlos en el datagrid 
        public override void ListarRegistros()
        {	//-- Mostrar todos los libros de la tabla en el grid 
            DgvTramiteXRequisito.DataSource = (aEntidad as CRequisitoXTramite).ListaPorTramite(TxtCodTramite.Text);

        }

        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        // 	
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        public override bool EsRegistroValido()
        {
            if ((TxtCodTramite.Text.Trim() != "") )
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
                TxtCodTramite.Enabled = false;
            }
            else
            {   //-- Registro nuevo, inicializar atributos no clave 
                InicializarAtributosNoClave();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //ProcesarClave();
            ListarRegistros();
        }

        private void FrmRequisitosXTramite_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }
    }
}
