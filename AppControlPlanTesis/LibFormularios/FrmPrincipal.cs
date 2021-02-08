using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            esconderSubMenu();
        }

        #region FuncionesSubMenus
        private void esconderSubMenu()
        {
            panelSubMenuMantenimiento.Visible = false;
            panelSubMenuOperaciones.Visible = false;
            //PARA MAS SUBMENUS ...
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region AbrirFormHijo
        private Form activeForm = null;
        private void abrirFormHijoEnPanel(Form formHijo)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            Panel_Contenedor.Controls.Add(formHijo);
            Panel_Contenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        #endregion

        private void btnManTesista_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmTesista());
        }

        private void btnManDocente_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmDocente());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuMantenimiento);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuOperaciones);
        }

        private void btnManTesis_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmTesis());
        }

        private void BtnManRequisitos_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmRequisito());
        }

        private void BtnManTramite_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmTramite());
        }

        private void BtnManRequisitosXTramite_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmRequisitosXTramite());
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmEditarRegistrosXTramite());
        }

        private void BtnIniciarTramite_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmIniciarTramiteEstudiante());
        }

        private void BtnGenerarExpediente_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmGenerarExpediente());
        }
    }
}
