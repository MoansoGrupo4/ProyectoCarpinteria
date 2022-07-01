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
using System.Data.SqlClient;

namespace FormularioCarpinteria
{
    public partial class FormTransaccionPedido : Form
    {
        public FormTransaccionPedido()
        {
            InitializeComponent();
        }

        public static int confilas = 0;
        public static decimal Total = 0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            //asd
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //Buscar cliente
            txtCliente.Focus();
            EntCliente BusCli = new EntCliente();
            //(BusEmp != null && (BusEmp.estEmpleado == true)
            DataTable c = new DataTable();
            c = LogCliente.Instancia.BuscarCliente(BusCli.Cliente);
            String Cliente = txtCliente.Text;
            if (c != null && (BusCli.Estado = true))
            {
                txtRazonSocial.Text = Convert.ToString(BusCli.Razon_Social);
            }
            else {
                MessageBox.Show("El cliente no existe");
            }
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            txtProducto.Focus();
            int idProducto = Convert.ToInt32(txtProducto.Text);
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Borrar pedido
            if (confilas > 0) {
                Total = Total - Convert.ToDecimal(dgvDatosPedido.Rows[dgvDatosPedido.CurrentRow.Index].Cells[4].Value);
                txtTotal.Text = Total.ToString();
                dgvDatosPedido.Rows.RemoveAt(dgvDatosPedido.CurrentRow.Index);
                confilas--;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
