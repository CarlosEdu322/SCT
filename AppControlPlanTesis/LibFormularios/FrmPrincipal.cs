using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LibFormularios
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();
            esconderSubMenu();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        #region FuncionesSubMenus
        private void esconderSubMenu()
        {
            panelSubMenuMantenimiento.Visible = false;
            panelSubMenuOperaciones.Visible = false;
            panelSubMenuConsultas.Visible = false;
            panelSubMenuSustentacionOral.Visible = false;
            panelSubMenuReportes.Visible = false;
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
        public void abrirFormHijoEnPanel(Form formHijo)
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

        private void BtnTesisXTesista_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmTesisXTesista());
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuConsultas);
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuSustentacionOral);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {

            //normalises window
            if (this.WindowState == FormWindowState.Maximized)
            {
                //this.Bounds = default;
                //this.WindowState = FormWindowState.Maximized;
                //this.Bounds = 

                //Rectangle a = new Rectangle(1, 1, 300, 400);
                //this.Bounds = a;
                //this.Size = Screen.GetWorkingArea(this);
                this.MaximumSize = this.Size;
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();

            }
            //maximises window 
            else
            {
                this.WindowState = FormWindowState.Maximized;

                //this.Bounds = Screen.GetWorkingArea(this);
                //this.Bounds = Screen.GetWorkingArea(this);
                //this.Bounds = default;
                //this.WindowState = FormWindowState.Maximized;
                //Size= new Size(400,600);
                this.CenterToScreen();
            }
        }

        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            //Cuando el mouse esta encima del boton maximizar
            btnMaximize.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            //Cuando el mouse ya no esta encima del boton maximizar
            btnMaximize.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            //Cuando el mouse esta encima del boton minimizar
            btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            //Cuando el mouse ya no esta encima del boton minimizar
            btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblContextoForm_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void lblContextoForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnInformeComisionRevisora_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmResultadoEvaluacionPlanTesis());
        }

        private void BtnTesisXTesista_Click_1(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmTesisXTesista());
        }

        private void BtnManTramite_Click_1(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmTramite());
        }

        private void btnNombrarCRevisora_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmNombrarComisionRevisoracs());
        }

        private void btnActaComisionRevisora_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmResultadoEvaluacionPlanTesis());
        }

        private void BtnResultadoComisionRevisora_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmInformeComisionRevisora());
        }

        private void BtnNombrarDictaminantes_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmNombrarDictaminantescs());
        }

        private void BtnAceptarCargoDictaminantes_Click(object sender, EventArgs e)
        {
            //abrirFormHijoEnPanel(new)
        }

        private void BtnEvaluacionDictaminantes_Click(object sender, EventArgs e)
        {
            
            abrirFormHijoEnPanel(new FrmResultadoEvaluacionDictamen());
        }

        private void BtnActaDictamen_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmInformeDictaminantesDeTesis());
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuReportes);
        }

        private void btnNombrarJuradoSustentacionOral_Click(object sender, EventArgs e)
        {
            abrirFormHijoEnPanel(new FrmNombrarJuradoSustentacionOral());
        }
    }
}
