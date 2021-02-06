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
            /*
             select c.CodTramite,c.Tipo,a.CodRequisito,TipoRequisito 
from TRequisitoXTramite a,TRequisito b,TTramite c 
where a.CodRequisito=b.CodRequisito and c.CodTramite=a.CodTramite and c.CodTramite='TR0002' 
 
             
             */

            string Consulta = "select c.CodTramite,c.Tipo,a.CodRequisito,TipoRequisito from " +
                aNombreTabla + "  a,TRequisito b,TTramite c " +
"where a.CodRequisito = b.CodRequisito and c.CodTramite = a.CodTramite and c.CodTramite = '" + pCodTramite + "' ";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }


        public DataTable ListarRequisitoXTramite(string pCodTramite)
        {   //-- retorna una tabla con la lista completa de libros 
            string Consulta = "select distinct * from " + aNombreTabla+ " where CodTramite= '"+pCodTramite+"' ";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

    }
}
