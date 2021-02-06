using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CRequisito:CEntidad
    {
        //=============== ATRIBUTOS =======================
        //--	Todos heredados de CEntidad	----

        //================ METODOS ========================
        //	Constructores	 
        public CRequisito() : base("TRequisito")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodRequisito", "TipoRequisito" };
        }
    }
}
