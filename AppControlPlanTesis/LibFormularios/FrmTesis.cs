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
    public partial class FrmTesis : FrmPadre
    {
        private CDocente oDocente;
        private CTesista oTesista;
        public FrmTesis()
        {
            InitializeComponent();
            IniciarEntidad(new CTesis());
            oDocente = new CDocente();
            oTesista = new CTesista();
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================

        //-- Establecer los valores que iran a la tabla 
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodTesis.Text,
                CboCodTesista.Text,
                CboCodDocente.Text,
                TxtTitulo.Text,
                TxtEstado.Text,
                TxtObservaciones.Text};
        }
        // 	
        //-- Mostrar los datos de un registro 
        public override void MostrarDatos()
        {	//-- muestra la informacion contenida en el dataset de CDocente
            TxtCodTesis.Text = aEntidad.ValorAtributo("CodTesis");
            CboCodTesista.Text = aEntidad.ValorAtributo("CodTesista");
            CboCodDocente.Text = aEntidad.ValorAtributo("CodDocente");
            TxtTitulo.Text = aEntidad.ValorAtributo("Titulo");
            TxtEstado.Text = aEntidad.ValorAtributo("Estado");
            TxtObservaciones.Text = aEntidad.ValorAtributo("Observaciones");
        }
        // 	
        //-- Iniciar los atributos clave y no clave en blanco 
        public override void InicializarAtributoClave()
        {
            TxtCodTesis.Enabled = true;
            TxtCodTesis.Text = "";

        }
        public override void InicializarAtributosNoClave()
        {
            TxtCodTesis.Text = "";
            CboCodTesista.SelectedIndex = -1;
            CboCodDocente.SelectedIndex = -1;
            TxtTitulo.Text = "";
            TxtEstado.Text = "";
            TxtObservaciones.Text = "";
        }
        // 	
        //-- Listar los registros y mostrarlos en el datagrid 
        public override void ListarRegistros()
        {	//-- Mostrar todos los libros de la tabla en el grid 
            DgvTesis.DataSource = aEntidad.ListaGeneral();

        }
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        // 	
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos 
        public override bool EsRegistroValido()
        {
            if ((TxtCodTesis.Text.Trim() != "") &&
                (CboCodTesista.Text.Trim() != "") && 
                (CboCodDocente.Text.Trim() != "") &&
                (TxtTitulo.Text.Trim() != "") &&
                (TxtEstado.Text.Trim() != "") && 
                (TxtObservaciones.Text.Trim() != "") )
                return true;
            else
                return false;
        }
        private void TxtCodTesis_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
            TxtCodTesis.Enabled = false;
        }


        public void LlenarListaDocentes()
        { //-- muestra la lista de libros en el combo
            CboCodDocente.DataSource = oDocente.ListaGeneral();
            //CboCodDocente.DisplayMember = "Correo";
            CboCodDocente.ValueMember = "CodDocente";
            //-- dejar el combo sin libro seleccionado
            CboCodDocente.SelectedIndex = -1;
        }
        public void LlenarListaTesistas()
        { //-- muestra la lista de libros en el combo
            CboCodTesista.DataSource = oTesista.ListaGeneral();
            //CboCodTesista.DisplayMember = "Correo";
            CboCodTesista.ValueMember = "CodTesista";
            //-- dejar el combo sin libro seleccionado
            CboCodTesista.SelectedIndex = -1;
        }

        private void FrmTesis_Load_1(object sender, EventArgs e)
        {
            ListarRegistros();
            LlenarListaDocentes();
            LlenarListaTesistas();
        }
    }
}
