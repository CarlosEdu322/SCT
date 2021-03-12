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
            string consulta = "select Estado, COUNT(Estado) as Numero from TTesis group by Estado";
            aConexion.EjecutarSelect(consulta);
            foreach (DataRow dtRow in aConexion.Datos.Tables[0].Rows)
            {
                a.Add(dtRow["Estado"]);
                b.Add(dtRow["Numero"]);
            }
        }
        public void NumeroDeTesisPorEspecialidad(ArrayList a, ArrayList b)
        {
            string consulta = "select Tema, COUNT(Tema) as Numero from TTesis group by Tema";
            aConexion.EjecutarSelect(consulta);
            foreach (DataRow dtRow in aConexion.Datos.Tables[0].Rows)
            {
                a.Add(dtRow["Tema"]);
                b.Add(dtRow["Numero"]);
            }
        }
        public string EstadoProcesoTesis(string pcodTesis)
        {
            string estado = "";
            string consulta = "select b.NroExpediente, b.Estado from TTesis a inner join TExpediente b on a.CodTesis=b.CodTesis where a.CodTesis='" + pcodTesis + "'";
            aConexion.EjecutarSelect(consulta);
            foreach (DataRow dtRow in aConexion.Datos.Tables[0].Rows)
            {
                estado = (dtRow["Estado"]).ToString();
            }
            return estado;
        }
        public DataTable TesisNoConcluidas()
        {
            string consulta = "select a.CodTesis,Titulo,Tema,a.Estado from TExpediente a inner join TTesis b on a.CodTesis=b.CodTesis where a.Estado!='TESIS CONCLUIDA' order by Tema";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable TesisConcluidas()
        {
            string consulta = "select a.CodTesis,Titulo,Tema,a.Estado from TExpediente a inner join TTesis b on a.CodTesis=b.CodTesis where a.Estado='TESIS CONCLUIDA' order by Tema";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }


        public DataTable EstadoTesisInscrita(string pcodtesis)
        {
            string consulta = "exec ConsultarDatosTesis "+pcodtesis;
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ConsultarAsesor(string pcodtesis)
        {
            string consulta = "exec ConsultarDatosDocenteAsesor " + pcodtesis;
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ConsultarDatosTesistas(string pcodtesis)
        {
            string consulta = "exec ConsultarDatosTesistas " + pcodtesis;
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ConsultarEstadoTesis(string pcodtesis)
        {
            string consulta = "exec ConsultarEstadoDeTesis " + pcodtesis;
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
