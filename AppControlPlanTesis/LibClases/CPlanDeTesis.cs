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
            string consulta = " select * from TExpediente where CodEvaluacionPlanDeTesis=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
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
    }
}
