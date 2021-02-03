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
    public partial class FrmTesista : FrmPadre
    {
        public FrmTesista()
        {
            InitializeComponent();
            IniciarEntidad(new CTesista());
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================

        //-- Establecer los valores que iran a la tabla 
        public override string[] AsignarValoresAtributos()
        {
            return new string[] {
                TxtCodTesista.Text,
                TxtApellidos.Text,
                TxtNombres.Text,
                TxtCorreo.Text,
                TxtTelefono.Text,
                TxtDNI.Text
                
            };
        }
        // 	
        //-- Mostrar los datos de un registro 
        public override void MostrarDatos()
        {	//-- muestra la informacion contenida en el dataset de CDocente
            TxtCodTesista.Text = aEntidad.ValorAtributo("CodTesista");
            TxtApellidos.Text = aEntidad.ValorAtributo("Apellidos");
            TxtNombres.Text = aEntidad.ValorAtributo("Nombres");
            TxtCorreo.Text = aEntidad.ValorAtributo("Correo");
            TxtTelefono.Text = aEntidad.ValorAtributo("Telefono");
            TxtDNI.Text = aEntidad.ValorAtributo("DNI");
            
        }
        // 	
        //-- Iniciar los atributos clave y no clave en blanco 
        public override void InicializarAtributoClave()
        {
            TxtCodTesista.Text = "";
            TxtCodTesista.Enabled = true;

        }
        public override void InicializarAtributosNoClave()
        {
            TxtCodTesista.Text = "";
            TxtApellidos.Text = "";
            TxtNombres.Text = "";
            TxtCorreo.Text = "";
            TxtTelefono.Text = "";
            TxtDNI.Text = "";
        }
        // 	
        //-- Listar los registros y mostrarlos en el datagrid 
        public override void ListarRegistros()
        {	//-- Mostrar todos los libros de la tabla en el grid 
            DgvTesista.DataSource = aEntidad.ListaGeneral();

        }
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        // 	
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        public override bool EsRegistroValido()
        {
            if ((TxtCodTesista.Text != "")&&
            (TxtApellidos.Text != "")&&
            (TxtNombres.Text != "")&&
             (TxtCorreo.Text != "") &&
            (TxtTelefono.Text != "")&&
             (TxtDNI.Text != "")
            )
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
                TxtCodTesista.Enabled = false;
            }
            else
            {   //-- Registro nuevo, inicializar atributos no clave 
                InicializarAtributosNoClave();
            }
        }

        private void TxtCodTesista_Leave(object sender, EventArgs e)
        {
            //ProcesarClave();
        }

        private void FrmTesista_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ProcesarClave();
        }
    }
}
