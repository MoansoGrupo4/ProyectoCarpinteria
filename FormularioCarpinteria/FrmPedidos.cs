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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
            listarNPedidos();
        }
        public void listarNPedidos()
        {
            dgvDatosPedido.DataSource = LogNuevoPedido.Instancia.ListarNPedido();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                EntNuevoPedido np = new EntNuevoPedido();
                EntModelo mo = new EntModelo();

                np.CodPedido = txtIdPedido.Text.Trim();
                np.CodModelo = txtCodigoModelo.Text.Trim();
                np.DesModelo = txtDescripcion.Text.Trim();
                np.CodCliente = int.Parse(txtCodCliente.Text);
                np.NombreCliente = txtRazonSocial.Text.Trim();
                np.fecha = dtpFechaIngreso.Value;
                np.total = Convert.ToSingle(txtTotal.Text.Trim());

                LogNuevoPedido.Instancia.InsertarNPedido(np);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarNPedidos();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            txtCliente.Focus();
            string Cliente = txtCliente.Text;

            EntCliente C = new EntCliente();
            C = LogCliente.Instancia.BuscarClienteNom(Cliente);
            if (C != null && (C.Estado = true) && txtCliente.Text != "")
            {
                txtRazonSocial.Text = Convert.ToString(C.Razon_Social);
                txtCodCliente.Text = Convert.ToString(C.Codigo);
            }
            else
            {
                MessageBox.Show("El cliente no existe");
            }
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            txtModelo.Focus();
            string Codigo = txtModelo.Text;
            EntModelo busCodModelo = new EntModelo();
            busCodModelo = LogModelo.Instancia.BuscarCódigoModelo(Codigo);
            if (busCodModelo != null && (busCodModelo.EstadoModelo == true) && txtModelo.Text != "")
            {
                txtDescripcion.Text = Convert.ToString(busCodModelo.CodTipoMueble);
                txtPrecio.Text = Convert.ToString(busCodModelo.PrecioVentaPU);
                txtTotal.Text = Convert.ToString(busCodModelo.PrecioVentaPU);
                txtCodigoModelo.Text = Convert.ToString(busCodModelo.CodModelo);
                Convert.ToString(busCodModelo.CodModelo);
            }
            else
            {
                MessageBox.Show("No se encuentra el producto");
            }
        }
    }
}
