using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocio;
using MantenedorClientes;
namespace MantenedorClientes
{
    public partial class FormDatosCliente : Form
    {
        entCliente Cliente;
        private const int NUEVO = 1;
        private const int EDITAR = 2;
        private const Boolean INHABILITAR = false;
        private int tipoAccion;

        public FormDatosCliente()
        {
            InitializeComponent();
            this.Cliente =new entCliente();
            tipoAccion = NUEVO;
            
        }
        public FormDatosCliente(entCliente Cliente)
        {
            InitializeComponent();
            txtidCliente.Text = Convert.ToString(Cliente.idCliente);
            txtidCliente.Enabled = false;
            txtRazonSocial.Text = Convert.ToString(Cliente.RazonSocial);
            //txtRuc=Cliente.
            txtDireccion.Text = Convert.ToString(Cliente.Direccion);
            txtCiudad.Text = Convert.ToString(Cliente.Ciudad);
            txtTipoCliente.Text=Convert.ToString(Cliente.idTipoCliente);
            cbkEstado.Checked = Convert.ToBoolean(Cliente.estCliente);

            //MessageBox.Show(" " + cbkEstado.Checked);
            tipoAccion = EDITAR;
        }

        public void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Boolean inserta;
                entCliente c = new entCliente();
                MantenedorGridCliente formGridCliente = new MantenedorGridCliente();
                //c.idCliente = int.Parse(txtidCliente.Text); Colocarle comentario

                c.RazonSocial=txtRazonSocial.Text.Trim();
                c.Direccion=txtDireccion.Text.Trim();
                c.Ciudad = txtCiudad.Text.Trim();
                c.idTipoCliente = int.Parse(txtTipoCliente.Text);
                c.estCliente = cbkEstado.Checked;     
               
                if (tipoAccion == NUEVO)
                {
                    // se compara la longitud
                    //if (c.RazonSocial.Length == 0 || c.Direccion.Length == 0)
                     logCliente.Instancia.InsertarCliente(c);
                }
                 else if(tipoAccion==EDITAR)
                 {
                      c.idCliente = int.Parse(txtidCliente.Text);
                     logCliente.Instancia.EditarCliente(c);

                  }
                 else 
                 {
                    ///MessageBox.Show(" inhabilitar");
                    c.idCliente = int.Parse(txtidCliente.Text);
                    logCliente.Instancia.InhabilitarCliente(c);
                 }
                Close();
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("err" + ex);
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void ActualizarGrid()
        {
            
            //MessageBox.Show("formulario de datos se cierra....de si encuentra instancia");
            MantenedorGridCliente formGridCliente = Application.OpenForms.OfType<MantenedorGridCliente>().FirstOrDefault();

            if (formGridCliente != null)  //Si encuentra una instancia abierta
            {
                //MessageBox.Show("Instancia abierta!!! instancia");
                formGridCliente.ListarCliente();
                formGridCliente.Refresh();
            }
        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
