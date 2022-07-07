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
    public partial class FormDatosEmpleado : Form
    {
        public FormDatosEmpleado()
        {
            InitializeComponent();
            listarEmpleado();
        }
        public void listarEmpleado()
        {
            dgvDatosEmpleado.DataSource = LogEmpleado.Instancia.ListarEmpleado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            EntEmpleado BusEmp = new EntEmpleado();
            BusEmp.NomEmpleado = txtBuscar.Text;
            DataTable dt = new DataTable();
            dt = LogEmpleado.Instancia.BuscarEmpleados(BusEmp.NomEmpleado);
            if (txtBuscar.Text != "" && (BusEmp.estEmpleado = true))
            {
                dgvDatosEmpleado.DataSource = dt;
            }
            else
            {
                // MessageBox.Show("EL cliente no existe o está inhabilitado, verifique", "cliente");
                dgvDatosEmpleado.DataSource = LogEmpleado.Instancia.ListarEmpleado();
            }
        }
    }
}
