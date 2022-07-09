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
    public partial class FormTransaccionOP : Form
    {
        public FormTransaccionOP()
        {
            InitializeComponent();
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
         
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //oli
        }
        private void ListarOP()
        {
            dgvTablaOP.DataSource = LogOP.Instancia.ListarOP();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntOP OP = new EntOP();
                OP.CodModelo.CodModelo = txtCodModelo.Text.Trim();
                OP.CodOP = txtCodProduccion.Text.Trim();
                OP.CodPedido.CodPedido = TxtCodPedido.Text.Trim();
                OP.InicioOP = dtpFechaInicioOP.Value;
                OP.EstOP = ckbEstadoOP.Checked;
                OP.Codigo.Codigo = Convert.ToInt32( txtCodCliente.Text.Trim());
                OP.total.total = Convert.ToDecimal(txtTotalPedido.Text.Trim());
                LogOP.Instancia.InsertarOP(OP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarOP(); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCliente.Focus();
            string Cliente = txtCliente.Text;
            EntCliente C = new EntCliente();
             C = LogCliente.Instancia.BuscarClienteNom(Cliente);
            if (C != null && (C.Estado= true) && txtCliente.Text != "")
            {
                TxtRSocial.Text = Convert.ToString(C.Razon_Social);
                txtCodCliente.Text = Convert.ToString(C.Codigo);
            }
            else
                MessageBox.Show("El cliente no existe or esta inhabilitado, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnBuscarIdPedido_Click(object sender, EventArgs e)
        {
            TxtCodPedido.Focus();
            string CodPedido = Convert.ToString(TxtCodPedido.Text);
            EntNuevoPedido BusPedido = new EntNuevoPedido();
            BusPedido = LogNuevoPedido.Instancia.BuscarPedido(CodPedido);
            if (BusPedido != null && TxtCodPedido.Text != "")
            {
               txtCodModelo.Text = Convert.ToString(BusPedido.CodModelo);
               txtTotalPedido.Text = Convert.ToString(BusPedido.total);
            }
            else
                MessageBox.Show("El cliente no existe o esta inhabilitado, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }



        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
