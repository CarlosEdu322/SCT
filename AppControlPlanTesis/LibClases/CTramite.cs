using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CTramite:CEntidad
    {
        //=============== ATRIBUTOS =======================
        //--	Todos heredados de CEntidad	----

        //================ METODOS ========================
        //	Constructores	 
        public CTramite() : base("TTramite")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodTramite", "Tipo" };
        }
    }
}
