using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    public class CTesis:CEntidad
    {
        //=============== ATRIBUTOS =======================
        //--	Todos heredados de CEntidad	----

        //================ METODOS ========================
        //	Constructores	 
        public CTesis() : base("TTesis")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodTesis",
                "Tema",
                "CodDocente",
                "Titulo",
                "Estado",
                "Observaciones"
            };
        }

        public void AgregarTesisAutovalores(List<string> cadenaTesis)
        {
            //insert into TTesis values ('tema','coddocente','titulo','','')
            string Consulta = "insert into TTesis values ('"+cadenaTesis[0]+"','"+cadenaTesis[1]+"','"+cadenaTesis[2]+"','TESIS PREINSCRITA','NINGUNA') ";
            aConexion.EjecutarComando(Consulta);
        }
        public string ObtenerDatos(List<string> cadenaTesis,string pNombreCampo)
        {
            string consulta = "select CodTesis from TTesis " +
                "where Tema = '"+cadenaTesis[0]+"'and CodDocente = '" + cadenaTesis[1] + "' and " +
                "Titulo = '" + cadenaTesis[2] + "' and Estado = 'TESIS PREINSCRITA' and " +
                "Observaciones = 'NINGUNA'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
        }
        public void AgregarTramiteDeInscripcionDePlanDeTesis(List<string> cadenaInscripciondePlanDeTesis)
        {
            //insert into TIniciarTramiteInscripcionPlanDeTesis values ('TR0001','124813','124219','150409','100005','NINGUNA')
            string consulta = "insert into TIniciarTramiteInscripcionPlanDeTesis values ('" + cadenaInscripciondePlanDeTesis[0] + "','" + cadenaInscripciondePlanDeTesis[1] + "','" + cadenaInscripciondePlanDeTesis[2] + "','" + cadenaInscripciondePlanDeTesis[3] + "'," + cadenaInscripciondePlanDeTesis[4] + ",'" + cadenaInscripciondePlanDeTesis[5] + "')";
            aConexion.EjecutarComando(consulta);


        }

    }
}
