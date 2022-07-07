using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioCarpinteria
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            AbrirFrmInPanel(new FormHora());
            btnRegresar.Visible = false;
            customizeDesign();
        }
        
        //Mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Funcion para acceder a cada panel de los formularios
        public void AbrirFrmInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        //Metodo para ocultar los submenu
        private void customizeDesign()
        {
            panelPersonalSubMenu.Visible = false;
            panelActividadSubMenu.Visible = false;
        }

        //Metodo para ocultar submenu mostrado anteriormente
        private void hideSubMenu()
        {
            if (panelPersonalSubMenu.Visible == true)
                panelPersonalSubMenu.Visible = false;
            if (panelActividadSubMenu.Visible == true)
                panelActividadSubMenu.Visible = false;
        }

        //Metodo para mostrar el submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMax.Visible = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AbrirFrmInPanel(new FormHora());
            btnRegresar.Visible = false;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPersonalSubMenu);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //escribe aqui tu codigo
            AbrirFrmInPanel(new FormMantenedorEmpleado());
            btnRegresar.Visible = true;
            hideSubMenu();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            //escribe aqui tu codigo
            //AbrirFrmInPanel(new nombredelformulario);
            btnRegresar.Visible = true;
            hideSubMenu();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //escribe aqui tu codigo
            AbrirFrmInPanel(new FormMantenedorCliente());
            btnRegresar.Visible = true;
            hideSubMenu();
        }

        private void btnInsumo_Click(object sender, EventArgs e)
        {
            //escribe aqui tu codigo
            AbrirFrmInPanel(new FormMantenedorInsumos());
            btnRegresar.Visible = true;
            hideSubMenu();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            //escribe aqui tu codigo
            AbrirFrmInPanel(new FormTransaccionPedido());
            btnRegresar.Visible = true;
            hideSubMenu();
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            showSubMenu(panelActividadSubMenu);
        }

        private void btnOrdenProduccion_Click(object sender, EventArgs e)
        {
            //escribe aqui tu codigo
            AbrirFrmInPanel(new FormTransaccionOP());
            btnRegresar.Visible = true;
            hideSubMenu();
        }

        private void btnPEntrada_Click(object sender, EventArgs e)
        {
            //escribe aqui tu codigo
            AbrirFrmInPanel(new FormOrdenEntrada());
            btnRegresar.Visible = true;
            hideSubMenu();
        }

        private void btnPSalida_Click(object sender, EventArgs e)
        {
            //escribe aqui tu codigo
            //AbrirFrmInPanel(new nombredelformulario);
            btnRegresar.Visible = true;
            hideSubMenu();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            //escribe aqui tu codigo
            AbrirFrmInPanel(new MantenedorMadera());
            btnRegresar.Visible = true;
            hideSubMenu();
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            //escribe aqui tu codigo
            AbrirFrmInPanel(new MantenedorModelo());
            btnRegresar.Visible = true;
            hideSubMenu();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
