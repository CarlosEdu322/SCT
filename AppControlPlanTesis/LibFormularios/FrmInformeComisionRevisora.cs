﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibClases;

namespace LibFormularios
{
    public partial class FrmInformeComisionRevisora : Form
    {
        private CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
        public FrmInformeComisionRevisora()
        {
            InitializeComponent();
            LlenarDatosCboCodRevisionDeTesis();

        }
        public void LlenarDatosCboCodRevisionDeTesis()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodComisionRevisora.DataSource = oPlanDeTesis.ListarCodComisionRevisora();
                CboCodComisionRevisora.DisplayMember = "CodEvaluacionPlanDeTesis";
                CboCodComisionRevisora.ValueMember = "CodEvaluacionPlanDeTesis";
                //-- dejar el combo sin libro seleccionado
                CboCodComisionRevisora.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        private void CboCodComisionRevisora_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                TxtCodTesis.Text = oPlanDeTesis.MostrarCodTesis(CboCodComisionRevisora.Text);

                List<string> Resultados = oPlanDeTesis.ObtenerResultadoCR(CboCodComisionRevisora.Text);
                TxtNotaIdentificacionProblema.Text = Resultados[0];
                TxtNotaHipotesis.Text = Resultados[1];
                TxtNotaAlcanceResultados.Text = Resultados[2];
                TxtNotaMetodologia.Text = Resultados[3];
                TxtNotaRevisionBibliografica.Text = Resultados[4];
                TxtNotaRecursosPresupuesto.Text = Resultados[5];
                TxtNotaImpacto.Text = Resultados[6];
                TxtNotaOrganizacionDocTesis.Text = Resultados[7];
                TxtNotaFinal.Text = Resultados[8];
                if (double.Parse(Resultados[8].ToString()) > 3.5)
                {
                    LblCondicion.Text = "Su tesis esta aprobada";
                }
                else
                {
                    LblCondicion.Text = "Su tesis no esta aprobada";
                }
            }
            catch
            {

            }
        }

        private void TxtCodTesis_TextChanged(object sender, EventArgs e)
        {
            DgvInteresados.DataSource = oPlanDeTesis.ListarInteresados(TxtCodTesis.Text);
            DgvTesis.DataSource = oPlanDeTesis.ListarDatosTesis(TxtCodTesis.Text);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
