using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    public class CEvaluacionTesis
    {
        public CConexion aConexion;
        public CEvaluacionTesis()
        {
            aConexion = new CConexion();
        }

        //select a.NroExpediente, a.CodEvaluacionPlanDeTesis, a.CodTesis, b.Titulo, b.Tema, b.Estado, b.Observaciones from TExpediente a inner join TTesis b on a.CodTesis= b.CodTesis where CodEvaluacionPlanDeTesis!='' and CodDictamenDeTesis = ''
        public DataTable TesisPendientesDeDictamen()
        {
            string consulta = "select a.NroExpediente, a.CodDictamenDeTesis, a.CodTesis, b.Titulo, b.Tema, b.Estado, b.Observaciones from TExpediente a inner join TTesis b on a.CodTesis= b.CodTesis where CodEvaluacionPlanDeTesis!='' and CodEvaluacionPlanDeTesis != '' and CodSustentacionOral=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
            /*
            string consulta = " select * from TExpediente where CodEvaluacionPlanDeTesis=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
            */
        }

        public DataTable ListarInteresados(string pCodTesis)
        {
            string consulta = "select Apellidos,Nombres from TTesista WHERE CodTesista IN" +
"(select CodTesista from TTesisXTesista where CodTesis = '" + pCodTesis + "')";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ListarDictaminantes(string pCodDictaminantes)
        {
            string consulta = "select A.CodDocente,B.Apellidos,B.Nombres from TDictaminantesDeTesis A inner join TDocente B on A.CodDocente=B.CodDocente where A.CodDictamenDeTesis='" + pCodDictaminantes + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public string GenerarCodigoNombrarComisionRevisora()
        {
            try
            {
                string codigo;
                string consulta = "select top 1 CodSustentacionOral from TExpediente order by CodSustentacionOral desc";
                aConexion.EjecutarSelect(consulta);
                codigo = aConexion.Datos.Tables[0].Rows[0]["CodSustentacionOral"].ToString();
                int valorcodigo = int.Parse(codigo) + 1;
                return valorcodigo.ToString();
            }
            catch
            {
                return "250000";
            }
        }

        public string GenerarCodigoResolucionJuradoEvaluacion()
        {   //-- retorna una tabla con la lista completa de libros 
            try
            {
                string codigo;
                string consulta = "select top 1 id from TResolucion ORDER BY id DESC";
                aConexion.EjecutarSelect(consulta);
                codigo = aConexion.Datos.Tables[0].Rows[0]["id"].ToString();
                int valorcodigo = int.Parse(codigo) + 1;
                return valorcodigo.ToString();
            }
            catch
            {
                return "1000";
            }
        }

        public void UpdateExpediente(string pCodExpediente, string pCodDictamen)
        {
            string consulta;
            consulta = "UPDATE TExpediente set CodDictamenDeTesis='" + pCodDictamen + "' WHERE NroExpediente='" + pCodExpediente + "'";
            aConexion.EjecutarComando(consulta);
        }
        public void AgregarDocentesDictaminantes(List<string> NombrarCR, string pCodEvaluacionDictamen)
        {
            string consulta;

            for (int i = 0; i < NombrarCR.Count; i++)
            {
                consulta = " insert into TDictaminantesDeTesis values ('" + pCodEvaluacionDictamen + "','" + NombrarCR[i] + "')";
                aConexion.EjecutarComando(consulta);
            }
        }
        public DataTable ListarDatosTesis(string pCodTesis)
        {
            string consulta = "select* from TTesis where CodTesis = '" + pCodTesis + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public bool VerificarSiEmitioEvaluacionDictamen(string pCodDictamenTesis, string pCodDocente)
        {
            //bool encontrado = false;
            string Consulta = "SELECT * FROM TActaDictamenDeTesis WHERE CodDictamenDeTesis='" + pCodDictamenTesis + "' AND CodDocente='" + pCodDocente + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0].Rows.Count > 0;
        }
        public DataTable ListarCodGrupoDictaminantes()
        {
            string consulta = "select * from TExpediente where CodEvaluacionPlanDeTesis!='' and CodDictamenDeTesis!=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public string MostrarCodTesis(string pCodDictamen)
        {
            string consulta = "select  * from TExpediente a , TDictaminantesDeTesis b where a.CodDictamenDeTesis = b.CodDictamenDeTesis and b.CodDictamenDeTesis = '" + pCodDictamen + "'";
            aConexion.EjecutarSelect(consulta);

            return aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
        }
        public DataTable ListarDocentesDictaminantes(string pCodComisionRevisora)
        {
            string consulta = "select * from TDictaminantesDeTesis where CodDictamenDeTesis = '" + pCodComisionRevisora + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ListarExpediente()
        {
            string consulta = "select * from TExpediente";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable Busqueda(string Consulta)
        {   //-- retorna una tabla con la lista completa de libros 
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        public string BuscarTesisXExpediente(string pNroExpediente)
        {
            string consulta = "select * from TExpediente where NroExpediente='" + pNroExpediente + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
        }
        public string BuscarDocenteAsesorPorTesis(string pCodTesis)
        {
            string consulta = "select * from TTesis where CodTesis='" + pCodTesis + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0].Rows[0]["CodDocente"].ToString();
        }

        public void AgregarDictamenPlanDeTesis(List<string> Cadena)
        {
            //insert into TActaDictamenDeTesis values('350000','D00001',0,'puede mejorar')
            string consulta = "insert into TActaDictamenDeTesis values('" + Cadena[0] + "','" + Cadena[1] + "','" + Cadena[2] + "','" + Cadena[3] + "')";
            aConexion.EjecutarComando(consulta);
        }
        public List<string> ObtenerResultadoDictamen(string pCodDictamenDeTesis)
        {
            string Consulta = "select * from TActaDictamenDeTesis where CodDictamenDeTesis='" + pCodDictamenDeTesis + "'";
            aConexion.EjecutarSelect(Consulta);
            DataTable tablaresultado = aConexion.Datos.Tables[0];
            int NroAprobados = 0;
            int NroDesaprobados = 0;
            string dictamen;
            List<string> Resultados = new List<string>();
            for (int k = 0; k < tablaresultado.Rows.Count; k++)
            {
                DataRow drv = tablaresultado.Rows[k];
                dictamen = drv["SuficienciaJuicio"].ToString();
                if (dictamen.CompareTo("APROBADO") == 0)
                {
                    NroAprobados++;

                }
                else if (dictamen.CompareTo("DESAPROBADO") == 0)
                {
                    NroDesaprobados++;
                }
            }
            if (NroAprobados == tablaresultado.Rows.Count)
                Resultados.Add("APROBADO");
            else
                Resultados.Add("NECESITA LEVANTAR OBSERVACIONES");

            Resultados.Add((NroAprobados + NroDesaprobados).ToString());
            return Resultados;
        }
        public DataTable ListarRevisores(string pExpediente)
        {
            string Consulta = "select* from tdocente where coddocente in(select CodDocente from TExpediente a, TComisionRevisora b where a.CodEvaluacionPlanDeTesis = b.CodEvaluacionPlanDeTesis and a.NroExpediente = '" + pExpediente + "')";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];

        }
    }
}
