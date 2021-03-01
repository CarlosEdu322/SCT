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
    public partial class FrmTramite : FrmPadre
    {
        public FrmTramite()
        {
            InitializeComponent();
            IniciarEntidad(new CTramite());
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================

        //-- Establecer los valores que iran a la tabla 
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodTramite.Text,
                TxtTipo.Text};
        }
        // 	
        //-- Mostrar los datos de un registro 
        public override void MostrarDatos()
        {	//-- muestra la informacion contenida en el dataset de CDocente
            TxtCodTramite.Text = aEntidad.ValorAtributo("CodTramite");
            TxtTipo.Text = aEntidad.ValorAtributo("Tipo");
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
            TxtTipo.Text = "";
        }
        // 	
        //-- Listar los registros y mostrarlos en el datagrid 
        public override void ListarRegistros()
        {	//-- Mostrar todos los libros de la tabla en el grid 
            DgvTramite.DataSource = aEntidad.ListaGeneral();

        }
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        // 	
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        public override bool EsRegistroValido()
        {
            if ((TxtCodTramite.Text.Trim() != "") &&
                (TxtTipo.Text.Trim() != ""))
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
        private void FrmTramite_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void BtnManTramite_Click(object sender, EventArgs e)
        {
            FrmEditarRegistrosXTramite f = new FrmEditarRegistrosXTramite();
            f.ShowDialog();
        }
    }
}
