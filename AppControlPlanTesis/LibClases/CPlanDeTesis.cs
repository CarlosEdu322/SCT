﻿using System;
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
    }
}
