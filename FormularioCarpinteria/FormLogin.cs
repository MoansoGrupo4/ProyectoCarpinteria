using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;
using System.Runtime.InteropServices;

namespace FormularioCarpinteria
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        LogEmpleado User = new LogEmpleado();


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text != "")
            {
                if (txtContra.Text != "")
                {
                    var validarLogin = User.loginUser(Int32.Parse(txtUsuario.Text), txtContra.Text);
                    if (validarLogin == true)
                    {
                        FormMenu MenuUsuario = new FormMenu();
                        MenuUsuario.Show();
                        MenuUsuario.FormClosed += CerrarSesion;
                        this.Hide();//ocultar formulario login
                       
                        MenuUsuario.Show();
                    }
                    else
                    {
                        msgError("Nombre de usuario o contraseña ingresados\nincorrectamente. Vuelva a intentarlo.");
                        txtUsuario.Clear();
                        txtContra.Clear();
                    }
                }
                else msgError("Por favor, ingrese contraseña");
            }
            else msgError("Por favor, ingrese nombre de usuario");

        }
        private void msgError(string msg)
        {
            lblMensaje.Text = "    " + msg;
            lblMensaje.Visible = true;
        }
        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtContra.Clear();
            lblMensaje.Visible = true;
            this.Show();//mostrar formulario loginn
            txtUsuario.Focus();
            //this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
