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
namespace FormularioCarpinteria
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        LogEmpleado User = new LogEmpleado();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text != "")
            {
                if (txtContra.Text != "")
                {
                    var validarLogin = User.loginUser(txtUsuario.Text, txtContra.Text);
                    if (validarLogin == true)
                    {
                        FormMantenedorEmpleado MenuUsuario = new FormMantenedorEmpleado();
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
                else msgError("Por favor, Ingrese Contraseña");
            }
            else msgError("Por favor, Ingrese Nombre de Usuario");

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
            this.Close();
        }
    }
}
