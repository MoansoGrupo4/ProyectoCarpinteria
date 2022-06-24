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
using CapaLogica; 
using System.Data.SqlClient;

namespace FormularioCarpinteria
{
    public partial class FormMantenedorCliente : Form
    {
        public FormMantenedorCliente()
        {
            InitializeComponent();
            ListarCliente();
            gbDatosCliente.Enabled = false;
            txtIdCliente.Enabled = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntCliente Cliente = new EntCliente();
                Cliente.Codigo = int.Parse(txtIdCliente.Text.Trim());
                cbkEstadoCliente.Checked = false;
                Cliente.Estado = cbkEstadoCliente.Checked;
                LogCliente.Instancia.DeshabilitarCliente(Cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosCliente.Enabled = false;
            ListarCliente();
        }
        private void bntSalir_Click(object sender, EventArgs e)
        {
            {
                Close();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntCliente cliente = new EntCliente();
                cliente.Codigo = int.Parse(txtIdCliente.Text.Trim());
                cliente.Cliente = txtNombre.Text.Trim();
                cliente.Razon_Social = txtRazonSocial.Text.Trim();
                cliente.Telefono = int.Parse(txtTelefono.Text.Trim());
                cliente.Direccion = txtDireccion.Text.Trim();
                cliente.Estado = cbkEstadoCliente.Checked;  
                cliente.Registro = dtpFechaIngreso.Value;               
                LogCliente.Instancia.InsertarCliente(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosCliente.Enabled = false;
            ListarCliente();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Enabled = false;
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            EntCliente BusCli = new EntCliente();
            //(BusEmp != null && (BusEmp.estEmpleado == true)
            BusCli.Cliente = txtBuscar.Text;
            DataTable dt = new DataTable();
            dt = LogEmpleado.Instancia.BuscarEmpleados(BusCli.Cliente);
            if (txtBuscar.Text != "" )
            {
                dgvDatosCliente.DataSource = dt;
            }
            else
            {
                dgvDatosCliente.DataSource = LogEmpleado.Instancia.ListarEmpleado();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntCliente cliente = new EntCliente();
                cliente.Codigo = int.Parse(txtIdCliente.Text.Trim());
                cliente.Cliente = txtNombre.Text.Trim();
                cliente.Razon_Social = txtRazonSocial.Text.Trim();
                cliente.Telefono = int.Parse(txtTelefono.Text.Trim());
                cliente.Direccion = txtDireccion.Text.Trim();
                cliente.Estado = cbkEstadoCliente.Checked;
                cliente.Registro = dtpFechaIngreso.Value;
            

                LogCliente.Instancia.EditarCliente(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosCliente.Enabled = false;
            ListarCliente();
        }

        private void dgvDatosCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void FormMantenedorCliente_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarVariables()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtRazonSocial.Text = "";
            dtpFechaIngreso.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
        public void ListarCliente()
        {
            dgvDatosCliente.DataSource = LogCliente.Instancia.ListarCliente();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
