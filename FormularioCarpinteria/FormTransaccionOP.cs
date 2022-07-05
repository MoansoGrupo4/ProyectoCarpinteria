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
        private List<EntOP> LisOP = new List<EntOP>();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntOP OP = new EntOP();
                OP.CodOP = txtCodProduccion.Text.Trim();
                OP.CodPedido.CodPedido = TxtCodPedido.Text.Trim();
                OP.Codigo.Codigo = Convert.ToInt32(txtCodCliente.Text.Trim());
                OP.CodModelo.CodModelo = txtCodModelo.Text.Trim();
                OP.InicioOP = DateTime.Parse(dtpFechaInicioOP.Text.Trim());
                LogOP.Instancia.InsertarOP(OP);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariable();

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
            }
            else
                MessageBox.Show("El cliente no existe or esta inhabilitado, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnBuscarIdPedido_Click(object sender, EventArgs e)
        {
            TxtCodPedido.Focus();
           int CodPedido = Convert.ToInt32(TxtCodPedido.Text);
            EntPedido BusPedido = new EntPedido();
            BusPedido = LogPedido.Instancia.BuscarIdPedido(CodPedido);
            if (BusPedido != null && TxtCodPedido.Text != "")
            {
                txtCodModelo.Text = Convert.ToString(BusPedido.CodModelo.CodModelo);
               txtCodCliente.Text = Convert.ToString(BusPedido.Codigo.Codigo);
            }
            else
                MessageBox.Show("El cliente no existe or esta inhabilitado, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void LimpiarVariable()
        {


            txtCodProduccion.Text = "";
            TxtCodPedido.Text = "";
            txtCodCliente.Text = "";
            txtCodModelo.Text = "";
            dtpFechaInicioOP.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
