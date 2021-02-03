using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    public class CRequisitoXTramite:CEntidad
    {
        //=============== ATRIBUTOS =======================
        //--	Todos heredados de CEntidad	----

        //================ METODOS ========================
        //	Constructores	 
        public CRequisitoXTramite() : base("TRequisitoXTramite")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodTramite", "CodRequisito" };
        }
        public DataTable ListaPorTramite(string pCodTramite)
        {   //-- retorna una tabla con la lista completa de libros 
            string Consulta = "select CodTramite,a.CodRequisito,TipoRequisito from " + aNombreTabla+ "  a,TRequisito b where a.CodRequisito=b.CodRequisito and CodTramite='" + pCodTramite+"' ";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
