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
            mostrarSubMenu(panelSubMenuReportes);
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
            //Cuando se maximiza el formulario

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
            abrirFormHijoEnPanel(new FrmInformeComisionRevisora());
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
    }
}
