using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LibClases
{
    public class CPlanDeTesis
    {
        public CConexion aConexion;
        public CPlanDeTesis()
        {
            aConexion = new CConexion();
        }
        
        public string GenerarCodigoTesis()
        {   //-- retorna una tabla con la lista completa de libros 

            try
            {
                string codigo;
                string consulta = "select top 1 NroExpediente from TExpediente ORDER BY NroExpediente DESC";
                aConexion.EjecutarSelect(consulta);
                codigo = aConexion.Datos.Tables[0].Rows[0]["NroExpediente"].ToString();
                int valorcodigo = int.Parse(codigo) + 1;
                return valorcodigo.ToString();
            }
            catch
            {
                return "400000";
            }
        }
        public void GenerarExpediente(List<string> listaTesistas)
        {
            string Consulta = "insert into TExpediente values('"+ listaTesistas[0]+ "','"+ listaTesistas[1] + "','','','')";
            aConexion.EjecutarComando(Consulta);
            
        }
        public void ActualizarEstadoDelTramite(string pCodTramITTesis,string pCodTesis)
        {
            string update = "update TIniciarTramiteInscripcionPlanDeTesis set Estado='RESUELTO' where CodTramITTesis='" + pCodTramITTesis + "' and CodTesis='" + pCodTesis + "'";
            aConexion.EjecutarComando(update);
        }
        public DataTable ListarTesistasXTesis()
        {
            string consulta = "select CodTesis,a.CodTesista,Apellidos,Nombres,DNI from TTesisXTesista a inner join TTesista b on a.CodTesista=b.CodTesista where CodTesis='700014'";
            aConexion.EjecutarComando(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable TesisPendientesDeDCR()
        {
            string consulta = "select a.NroExpediente,a.CodEvaluacionPlanDeTesis,a.CodTesis,b.Titulo,b.Tema,b.Estado,b.Observaciones  from TExpediente a inner join TTesis b on a.CodTesis=b.CodTesis where CodEvaluacionPlanDeTesis=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
            /*
            string consulta = " select * from TExpediente where CodEvaluacionPlanDeTesis=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
            */
        }
        public string GenerarCodigoNombrarComisionRevisora()
        {
            try
            {


                string codigo;
                string consulta = " select top 1 CodEvaluacionPlanDeTesis from TExpediente order by CodEvaluacionPlanDeTesis desc";
                aConexion.EjecutarSelect(consulta);
                codigo = aConexion.Datos.Tables[0].Rows[0]["CodEvaluacionPlanDeTesis"].ToString();
                int valorcodigo = int.Parse(codigo) + 1;
                return valorcodigo.ToString();
            }
            catch
            {
                return "300000";
            }
        }
        public void AgregarDocentesCR(List<string>NombrarCR,string pCodEvaluacionPlanDeTesis)
        {
            string consulta;

            for (int i = 0; i < NombrarCR.Count; i++)
            {
                consulta = " insert into TComisionRevisora values ('"+ pCodEvaluacionPlanDeTesis + "','"+ NombrarCR [i]+ "')";
                aConexion.EjecutarComando(consulta);
            }
        }
        public void UpdateExpediente(string pCodExpediente,string pCodCR)
        {
            string consulta;
            consulta = "UPDATE TExpediente set CodEvaluacionPlanDeTesis='"+ pCodCR + "' WHERE NroExpediente='"+ pCodExpediente + "'";
            aConexion.EjecutarComando(consulta);
        }
        public DataTable ListarCodComisionRevisora()
        {
            string consulta = "select * from TExpediente where CodEvaluacionPlanDeTesis!=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ListarDocenteComisionRevisora(string pCodComisionRevisora)
        {
            string consulta = "select * from TComisionRevisora where CodEvaluacionPlanDeTesis='"+ pCodComisionRevisora + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public void AgregarEvaluacionPlanDeTesis(List<string> Cadena)
        {
            string consulta= "insert into TActaDePlanDeTesis values('"+ Cadena [0]+ "','" + Cadena[1] + "'," + Cadena[2] + "," + Cadena[3] + "," + Cadena[4] + "," + Cadena[5] + "," + Cadena[6] + "," + Cadena[7] + "," + Cadena[8] + "," + Cadena[9] + ")";
            aConexion.EjecutarComando(consulta);
        }
        public bool VerificarSiEmitioEvaluacion(string pCodPlanTesis,string pCodDocente)
        {
            //bool encontrado = false;
            string Consulta = "SELECT * FROM TActaDePlanDeTesis WHERE CodEvaluacionPlanDeTesis='" + pCodPlanTesis + "' AND CodDocente='" + pCodDocente + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0].Rows.Count>0;
        }
        public List<string> ObtenerResultadoCR(string pCodPlanDeTesis)
        {
            string Consulta = "select * from TActaDePlanDeTesis where CodEvaluacionPlanDeTesis='"+ pCodPlanDeTesis + "'";
            aConexion.EjecutarSelect(Consulta);
            DataTable tablaresultado = aConexion.Datos.Tables[0];
            double SNotaIdentificacionDelProblema = 0;
            double SNotaHipotesis = 0;
            double SNotaAlcanceResultados = 0;
            double SNotaMetodologia = 0;
            double SNotaRevisionBibliografica = 0;
            double SNotaRecursosPresupuesto = 0;
            double SNotaImpacto = 0;
            double SNotaOrganizacionDocTesis = 0;
            for (int k=0;k< tablaresultado.Rows.Count;k++)
            {
                DataRow drv = tablaresultado.Rows[k];
                SNotaIdentificacionDelProblema += double.Parse(drv["NotaIdentificacionProblema"].ToString());
                SNotaHipotesis += double.Parse(drv["NotaHipotesis"].ToString());
                SNotaAlcanceResultados += double.Parse(drv["NotaAlcanceResultados"].ToString());
                SNotaMetodologia += double.Parse(drv["NotaMetodologia"].ToString());
                SNotaRevisionBibliografica += double.Parse(drv["NotaRevisionBibliografica"].ToString());
                SNotaRecursosPresupuesto += double.Parse(drv["NotaRecursosPresupuesto"].ToString());
                SNotaImpacto += double.Parse(drv["NotaImpacto"].ToString());
                SNotaOrganizacionDocTesis += double.Parse(drv["NotaOrganizacionDocTesis"].ToString());
            }
            double NotaIdentificacionDelProblema = Math.Round(SNotaIdentificacionDelProblema / 3, 2);
            double NotaHipotesis = Math.Round(SNotaHipotesis / 3, 2);
            double NotaAlcanceResultados = Math.Round(SNotaAlcanceResultados / 3, 2);
            double NotaMetodologia = Math.Round(SNotaMetodologia / 3, 2);
            double NotaRevisionBibliografica = Math.Round(SNotaRevisionBibliografica / 3, 2);
            double NotaRecursosPresupuesto = Math.Round(SNotaRecursosPresupuesto / 3, 2);
            double NotaImpacto = Math.Round(SNotaImpacto / 3, 2);
            double NotaOrganizacionDocTesis = Math.Round(SNotaOrganizacionDocTesis / 3, 2);
            List<string> Promedios = new List<string>();
            Promedios.Add(NotaIdentificacionDelProblema.ToString());
            Promedios.Add(NotaHipotesis.ToString());
            Promedios.Add(NotaAlcanceResultados.ToString());
            Promedios.Add(NotaMetodologia.ToString());
            Promedios.Add(NotaRevisionBibliografica.ToString());
            Promedios.Add(NotaRecursosPresupuesto.ToString());
            Promedios.Add(NotaImpacto.ToString());
            Promedios.Add(NotaOrganizacionDocTesis.ToString());
            double NotaFinal = Math.Round((NotaIdentificacionDelProblema + NotaHipotesis + NotaAlcanceResultados + NotaMetodologia + NotaRevisionBibliografica +
                NotaRecursosPresupuesto + NotaImpacto + NotaOrganizacionDocTesis) / 8, 2);
            Promedios.Add(NotaFinal.ToString());
            return Promedios;
        }

        public DataTable ListarInteresados(string pCodTesis)
        {
            string consulta = "select CodTesista,Apellidos,Nombres,DNI from TTesista WHERE CodTesista IN" +
"(select CodTesista from TTesisXTesista where CodTesis = '"+pCodTesis+"')";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ListaTramitesDeInscripcionDeTesis()
        {
            string consulta = "select a.CodTramITTesis,a.CodTesis,b.Titulo,b.Tema,a.Estado,a.Observaciones from TIniciarTramiteInscripcionPlanDeTesis a inner join TTesis b on a.CodTesis=b.CodTesis where a.Estado='RECIBIDO'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ListarDatosTesis(string pCodTesis)
        {
            string consulta = "select* from TTesis where CodTesis = '"+pCodTesis+"'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public string MostrarCodTesis(string pCodEvaluacion)
        {
            string consulta = "select  * from TExpediente a , TComisionRevisora b where a.CodEvaluacionPlanDeTesis = b.CodEvaluacionPlanDeTesis and b.CodEvaluacionPlanDeTesis = '"+ pCodEvaluacion + "'";
            aConexion.EjecutarSelect(consulta);
            
            return aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
        }

    }
}
