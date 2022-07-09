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
            gbDatosCliente.Enabled = false;
            gbModelo.Enabled = false;
        }
        public void listarNPedidos()
        {
            dgvDatosPedido.DataSource = LogNuevoPedido.Instancia.ListarNPedido();
        }
        private void LimpiarVariables()
        {
            txtIdPedido.Text = "";
            txtCliente.Text = "";
            txtCodCliente.Text = "";
            txtRazonSocial.Text = "";
            txtCodigoModelo.Text = "";
            txtModelo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtTotal.Text = "";
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
                np.NombreCliente = txtCliente.Text.Trim();
                np.cantidad = int.Parse(txtCantidad.Text);
                np.fecha = dtpFechaIngreso.Value;
                np.total = Convert.ToDecimal(txtTotal.Text.Trim());

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
                txtCodigoModelo.Text = Convert.ToString(busCodModelo.CodModelo);
                Convert.ToString(busCodModelo.CodModelo);
            }
            else
            {
                MessageBox.Show("No se encuentra el producto");
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
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
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtModelo.Focus();
                string Codigo = txtModelo.Text;
                EntModelo busCodModelo = new EntModelo();
                busCodModelo = LogModelo.Instancia.BuscarCódigoModelo(Codigo);
                if (busCodModelo != null && (busCodModelo.EstadoModelo == true) && txtModelo.Text != "")
                {
                    txtDescripcion.Text = Convert.ToString(busCodModelo.CodTipoMueble);
                    txtPrecio.Text = Convert.ToString(busCodModelo.PrecioVentaPU);
                    txtCodigoModelo.Text = Convert.ToString(busCodModelo.CodModelo);
                    Convert.ToString(busCodModelo.CodModelo);
                }
                else
                {
                    MessageBox.Show("No se encuentra el producto");
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int primerValor = int.Parse(txtPrecio.Text);
            int segundoValor = int.Parse(txtCantidad.Text);

            txtTotal.Text = (primerValor * segundoValor).ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Enabled = true;
            gbModelo.Enabled = true;
            btnGuardar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariables();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntNuevoPedido pedido = new EntNuevoPedido();
                 
                pedido.CodPedido = txtIdPedido.Text.Trim();
                pedido.CodModelo = txtCodigoModelo.Text.Trim();
                pedido.DesModelo = txtDescripcion.Text.Trim();
                pedido.CodCliente = int.Parse(txtCodCliente.Text);
                pedido.NombreCliente = txtRazonSocial.Text.Trim();
                pedido.cantidad = int.Parse(txtCantidad.Text);
                pedido.fecha = dtpFechaIngreso.Value;
                pedido.total = Convert.ToDecimal(txtTotal.Text.Trim());

                LogNuevoPedido.Instancia.EditarPedido(pedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarNPedidos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EntNuevoPedido pedido = new EntNuevoPedido();

                pedido.CodPedido = txtIdPedido.Text.Trim();

                LogNuevoPedido.Instancia.DeshabilitarPedido(pedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarNPedidos();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            txtCodCliente.Text = "";
            txtRazonSocial.Text = "";
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            txtCodigoModelo.Text = "";
            txtModelo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtTotal.Text = "";
        }

        private void dgvDatosPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatosPedido.Rows[e.RowIndex];

            txtIdPedido.Text = filaActual.Cells[0].Value.ToString();
            txtCodigoModelo.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            txtCodCliente.Text = filaActual.Cells[3].Value.ToString(); 
            txtCliente.Text = filaActual.Cells[4].Value.ToString();
            txtCantidad.Text = filaActual.Cells[5].Value.ToString();
            dtpFechaIngreso.Text = filaActual.Cells[6].Value.ToString();
            txtTotal.Text = filaActual.Cells[7].Value.ToString();
        }
    }
}
