﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibClases
{
    public class CDocente:CEntidad
    {
        //=============== ATRIBUTOS =======================
        //--	Todos heredados de CEntidad	----

        //================ METODOS ========================
        //	Constructores	 
        public CDocente() : base("TDocente")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodDocente", "Apellidos", "Nombres", "Correo",
                "Telefono","DNI","Categoria","Especialidad","Impedimento" };
        }
        public DataTable Busqueda(string Consulta)
        {   //-- retorna una tabla con la lista completa de libros 
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

    }
}
