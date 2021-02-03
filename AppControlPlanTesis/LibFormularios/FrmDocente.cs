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
    public partial class FrmDocente : FrmPadre
    {
        public FrmDocente()
        {
            InitializeComponent();
            IniciarEntidad(new CDocente());
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================

        //-- Establecer los valores que iran a la tabla 
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodDocente.Text, 
                TxtApellidos.Text, 
                TxtNombres.Text, 
                TxtCorreo.Text,
                TxtTelefono.Text,
                TxtDNI.Text,
                CboCategoria.Text,
                CboEspecialidad.Text,
                TxtImpedimento.Text };
        }
        // 	
        //-- Mostrar los datos de un registro 
        public override void MostrarDatos()
        {	//-- muestra la informacion contenida en el dataset de CDocente
            TxtCodDocente.Text = aEntidad.ValorAtributo("CodDocente");
            TxtApellidos.Text = aEntidad.ValorAtributo("Apellidos");
            TxtNombres.Text = aEntidad.ValorAtributo("Nombres");
            TxtCorreo.Text = aEntidad.ValorAtributo("Correo");
            TxtTelefono.Text = aEntidad.ValorAtributo("Telefono");
            TxtDNI.Text = aEntidad.ValorAtributo("DNI");
            CboCategoria.Text = aEntidad.ValorAtributo("Categoria");
            CboEspecialidad.Text = aEntidad.ValorAtributo("Especialidad");
            TxtImpedimento.Text = aEntidad.ValorAtributo("Impedimento");
        }
        // 	
        //-- Iniciar los atributos clave y no clave en blanco 
        public override void InicializarAtributoClave()
        {
            TxtCodDocente.Enabled = true;
            TxtCodDocente.Text = "";

        }
        public override void InicializarAtributosNoClave()
        {
            TxtApellidos.Text = ""; 
            TxtNombres.Text = ""; 
            TxtCorreo.Text = "";
            TxtTelefono.Text = ""; 
            TxtDNI.Text = ""; 
            CboCategoria.SelectedIndex = -1; ;
            CboEspecialidad.SelectedIndex = -1;
            TxtImpedimento.Text = "";
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
            if ((TxtCodDocente.Text.Trim() != "") && (TxtApellidos.Text.Trim() != "") && (TxtNombres.Text.Trim() != "") &&
                (TxtCorreo.Text.Trim() != "") &&
                (TxtTelefono.Text.Trim() != "") && (TxtDNI.Text.Trim() != "") &&
                (CboCategoria.Text.Trim() != "") &&
                (CboEspecialidad.Text.Trim() != "") &&
                (TxtImpedimento.Text.Trim() != ""))
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
                TxtCodDocente.Enabled = false;
            }
            else
            {   //-- Registro nuevo, inicializar atributos no clave 
                InicializarAtributosNoClave();
            }
        }
        private void TxtCodDocente_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void FrmDocente_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

    }
}
