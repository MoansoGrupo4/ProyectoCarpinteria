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

namespace FormularioCarpinteria
{
    public partial class FormDatosCliente : Form
    {
        public FormDatosCliente()
        {
            InitializeComponent();
            listarClientes();
        }
        public void listarClientes()
        {
            dgvDatosCliente.DataSource = LogCliente.Instancia.ListarCliente();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            EntCliente BusCli = new EntCliente();
            BusCli.Cliente = txtBuscar.Text;
            DataTable dt = new DataTable();
            dt = LogCliente.Instancia.BuscarCliente(BusCli.Cliente);

            if (txtBuscar.Text != "" && (BusCli.Estado = true))
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
