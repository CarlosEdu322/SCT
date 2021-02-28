using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    public class CReportes
    {
        public CConexion aConexion;
        public CReportes()
        {
            aConexion = new CConexion();
        }
        public void NumeroDeTesis(ArrayList a, ArrayList b)
        {
            string consulta = "select Estado, COUNT(Estado) as Numero from TExpediente group by Estado";
            aConexion.EjecutarSelect(consulta);
            foreach (DataRow dtRow in aConexion.Datos.Tables[0].Rows)
            {
                    a.Add(dtRow["Estado"]);
                    b.Add(dtRow["Numero"]);
            }
        }
    }
}
