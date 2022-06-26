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
                EntCliente Cli = new EntCliente();
                Cli.Codigo = int.Parse(txtIdCliente.Text.Trim());
                cbkEstadoCliente.Checked = false;
                Cli.Estado = cbkEstadoCliente.Checked;
                LogCliente.Instancia.DeshabilitarCliente(Cli);
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
                EntCliente cli = new EntCliente();

                //cli.Codigo = Convert.ToInt32(txtIdCliente.Text.Trim());
                cli.Cliente = txtNombreCliente.Text.Trim();
                cli.Razon_Social = txtRazonSocial.Text.Trim();
                cli.Telefono = int.Parse(txtTelefono.Text.Trim());
                cli.Direccion = txtDireccion.Text.Trim();
                cli.Estado = cbkEstadoCliente.Checked;
                cli.Registro = dtpFechaIngreso.Value;               
                LogCliente.Instancia.InsertarCliente(cli);
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
         
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntCliente cli = new EntCliente();
                cli.Codigo = int.Parse(txtIdCliente.Text.Trim());
                cli.Cliente = txtNombreCliente.Text.Trim();
                cli.Razon_Social = txtRazonSocial.Text.Trim();
                cli.Telefono = int.Parse(txtTelefono.Text.Trim());
                cli.Direccion = txtDireccion.Text.Trim();
                cli.Estado = cbkEstadoCliente.Checked;
                cli.Registro = dtpFechaIngreso.Value;
                LogCliente.Instancia.EditarCliente(cli);
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
            DataGridViewRow filaActual = dgvDatosCliente.Rows[e.RowIndex];

            txtIdCliente.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCliente.Text = filaActual.Cells[1].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[2].Value.ToString();
            txtDireccion.Text = filaActual.Cells[3].Value.ToString();
            dtpFechaIngreso.Text = filaActual.Cells[4].Value.ToString();
            txtTelefono.Text = filaActual.Cells[5].Value.ToString();         
            cbkEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }
        private void FormMantenedorCliente_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarVariables()
        {
            txtIdCliente.Text = "";
            txtNombreCliente.Text = "";
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
            txtBuscar.Focus();
            EntCliente BusCli = new EntCliente();
            //(BusEmp != null && (BusEmp.estEmpleado == true)
            BusCli.Cliente = txtBuscar.Text;
            DataTable dt = new DataTable();
            dt = LogCliente.Instancia.BuscarCliente(BusCli.Cliente);
            if (txtBuscar.Text != "")
            {
                dgvDatosCliente.DataSource = dt;
            }
            else
            {
                dgvDatosCliente.DataSource = LogCliente.Instancia.ListarCliente();
            }
        }
    }
}
