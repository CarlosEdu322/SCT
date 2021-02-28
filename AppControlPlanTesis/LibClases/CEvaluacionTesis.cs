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
            string consulta = "select a.NroExpediente, a.CodDictamenDeTesis, a.CodTesis, b.Titulo, b.Tema, b.Estado, b.Observaciones from TExpediente a inner join TTesis b on a.CodTesis= b.CodTesis where CodEvaluacionPlanDeTesis!='' and CodDictamenDeTesis != '' and CodSustentacionOral='' and a.Estado='TESIS APROBADA POR DICTAMINANTES'";
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

        public void UpdateExpediente(string pCodExpediente, string pCodJuradoEvaluador)
        {
            string consulta;
            consulta = "UPDATE TExpediente set CodSustentacionOral='" + pCodJuradoEvaluador + "' WHERE NroExpediente='" + pCodExpediente + "'";
            aConexion.EjecutarComando(consulta);
        }

        public DataTable ListarCodJuradoEvaluador()
        {
            string consulta = "select * from TExpediente where CodSustentacionOral!=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }




        public void UpdateFinalEstadoTesis(string pCodTesis)
        {
            string consulta;
            consulta = "UPDATE TTesis set Estado='TESIS APROBADA Y CONCLUIDA' WHERE CodTesis='" + pCodTesis + "'";
            aConexion.EjecutarComando(consulta);
        }
        public void AgregarCodYJuradoEvaluador(List<string> NombrarJE)
        {
            string consulta;
            consulta = " insert into TJuradoEvaluador values ('" + NombrarJE[0] + "','" + NombrarJE[1] + "','" + NombrarJE[2] + "','" + NombrarJE[3] + "','" + NombrarJE[4] + "','" + NombrarJE[5] + "','" + NombrarJE[6] + "','" + NombrarJE[7] + "','" + NombrarJE[8] + "','" + NombrarJE[9] + "','" + NombrarJE[10] + "','" + NombrarJE[11] + "')";
            aConexion.EjecutarComando(consulta);
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
            string consulta = "select  * from TExpediente a , TJuradoEvaluador b where a.CodSustentacionOral = b.CodSustentacionOral and b.CodSustentacionOral = '" + pCodDictamen + "'";
            aConexion.EjecutarSelect(consulta);

            return aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
        }

        public List<string> ListarDocentesJuradoEvaluador(string pJuradoEvaluador)
        {
            string consulta = "select * from TJuradoEvaluador where CodSustentacionOral = '" + pJuradoEvaluador + "'";
            aConexion.EjecutarSelect(consulta);
            List<string> ListaCodigosDocentes = new List<string>();
            ListaCodigosDocentes.Add(aConexion.Datos.Tables[0].Rows[0]["PrimerDictaminante"].ToString());
            ListaCodigosDocentes.Add(aConexion.Datos.Tables[0].Rows[0]["SegundoDictaminante"].ToString());
            ListaCodigosDocentes.Add(aConexion.Datos.Tables[0].Rows[0]["TercerDictaminante"].ToString());

            return ListaCodigosDocentes;
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
        //PARTE FUNCIONAL
        public void EmitirResolucionNombramientoJuradoEvaluador(string codigo, string codTesis)
        {
            string consulta = " insert into TResolucion values ('" + codigo + "','DESIGNACION DE LA FECHA, HORA Y JURADO EVALUADOR PARA SUSTENTACION ORAL',GETDATE(),'" + codTesis + "')";
            aConexion.EjecutarComando(consulta);
        }
        public bool VerificarSiEmitioResolucionFHJuradoEvaluador(string codTesis)
        {
            //bool encontrado = false;
            string Consulta = "SELECT * FROM TResolucion WHERE CodTesis='" + codTesis + "' AND Considerando='DESIGNACION DE LA FECHA, HORA Y JURADO EVALUADOR PARA SUSTENTACION ORAL'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0].Rows.Count > 0;
        }
        public void GuardarDeliberacion(List<String> Parametros)
        {
            string consulta = "insert into TActaSustentacionOral values ('"+ Parametros [0]+ "','"+ Parametros[1] + "',"+Parametros [2]+",'"+ Parametros[3] + "',GETDATE())";
            aConexion.EjecutarComando(consulta);
        }

        //insert into TActaSustentacionOral values ('250000','APROBADO',20,'APROBADO POR UNANIMIDAD')
        public DataTable ListarCodJuradosEvaluadores()
        {
            string Consulta = "SELECT * FROM TActaSustentacionOral";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        public bool VerificarSiEmitioEvaluoJuradoEvaluador(string pJurado)
        {
            //bool encontrado = false;
            string Consulta = "SELECT * FROM TActaSustentacionOral where CodSustentacionOral='"+ pJurado + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0].Rows.Count > 0;
        }
        public List<string> LlenarCamposSustentacionOral(string pCodJurado)
        {

            string Consulta = "select * from TActaSustentacionOral where CodSustentacionOral='" + pCodJurado + "'";
            aConexion.EjecutarSelect(Consulta);
            DataTable tablaresultado = aConexion.Datos.Tables[0];
            List<string> Resultados = new List<string>();
            string Atributo;
            
            DataRow drv = tablaresultado.Rows[0];
            Resultados.Add(drv["Resultado"].ToString());
            Resultados.Add(drv["Nota"].ToString());
            Resultados.Add(drv["EstadoVotacion"].ToString());

            return Resultados;


        }
        public bool VerificarSiEmitioResolucionSuficienciaTesis(string codTesis)
        {
            //bool encontrado = false;
            string Consulta = "SELECT * FROM TResolucion WHERE CodTesis='" + codTesis + "' AND Considerando='TESIS DICTAMINADA Y APROBADA PARA SUSTENCIACION ORAL'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0].Rows.Count > 0;
        }
        public List<string> ConsultarNotas(string pcodexpediente)
        {
            string consulta = "select * from TActaSustentacionOral where CodSustentacionOral='"+ pcodexpediente + "'";
            aConexion.EjecutarSelect(consulta);
            List<string> NotasEmitidas = new List<string>();
            DataTable tablaresultado = aConexion.Datos.Tables[0];
            DataRow drv = tablaresultado.Rows[0];
            NotasEmitidas.Add(drv["EstadoVotacion"].ToString());
            NotasEmitidas.Add(drv["Nota"].ToString());
            NotasEmitidas.Add(drv["Resultado"].ToString());
            return NotasEmitidas;

        }
    }
}
