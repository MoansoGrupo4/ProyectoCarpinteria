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
        EntPedido Pedido = new EntPedido();
        EntDetPedido DetPed = new EntDetPedido();

        private List<EntDetPedido> ListaDetPed = new List<EntDetPedido>();
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
            txtTotal.Text = Convert.ToString(Convert.ToInt32(txtPrecio.Text)* Convert.ToInt32(txtCantidad.Text));
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
            else {
                MessageBox.Show("El cliente no existe");
            }
        }
        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            txtModelo.Focus();
            string Codigo = txtModelo.Text;
            EntModelo busCodModelo = new EntModelo();
            busCodModelo = LogModelo.Instancia.BuscarCódigoModelo(Codigo);
            if (busCodModelo != null && (busCodModelo.EstadoModelo = true) && txtModelo.Text != "")
            {
                txtDescripcion.Text = Convert.ToString(busCodModelo.CodTipoMueble);
                txtPrecio.Text = Convert.ToString(busCodModelo.PrecioVentaPU);
                Convert.ToString(busCodModelo.CodModelo);
            }
           
            else
            {
                MessageBox.Show("No se encuentra el producto");
            }

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
            String idPed;
            try
            {
                EntPedido Ped = new EntPedido();
                EntCliente Cli = new EntCliente();
                EntModelo Mod = new EntModelo();
               
                Cli.Codigo =Convert.ToInt32( txtCodCliente.Text);
                Ped.Codigo = Cli;
                Ped.Codigo.Codigo = Cli.Codigo;
                Ped.CodPedido = Convert.ToString( txtIdPedido.Text);
                Ped.Fecha = Convert.ToDateTime(dtpFechaIngreso.Value);
                Ped.Total = Convert.ToDecimal(txtTotal.Text);
                idPed = LogPedido.Instancia.InsertarPedido(Ped);
                GuardarDetPed(idPed);
                Close();
                ActualizarDataGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GuardarDetPed(String cod)
        {
            foreach (DataGridViewRow fila in dgvDatosPedido.Rows)
            {
                EntModelo Mod = new EntModelo();
                DetPed.CodPedido = cod;
                DetPed.CodPedido = fila.Cells[0].Value.ToString();
                Mod.CodModelo = fila.Cells[1].Value.ToString();
                DetPed.CodModelo = Mod;
                DetPed.CodModelo.CodModelo = Mod.CodModelo;
                DetPed.Cantidad = Convert.ToInt32(fila.Cells[2].Value.ToString());
                DetPed.Precio = Convert.ToDecimal(fila.Cells[3].Value.ToString());
                Mod.DesModelo = fila.Cells[4].Value.ToString();
                LogPedido.Instancia.InsertarDetPedido(DetPed);
            }
        }
        private void ActualizarDataGrid()
        {
            FormGridPedido formGridPedido = Application.OpenForms.OfType<FormGridPedido>().FirstOrDefault();
            if (formGridPedido != null)
            {
                formGridPedido.ListarPedido();
                formGridPedido.Refresh();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            if ((this.txtCliente.Text.Trim() != "") && (txtModelo.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            {
                if ((Convert.ToInt32(txtCantidad.Text) > 0))
                {
                    if (confilas == 0)
                    {

                        dgvDatosPedido.Rows.Add(txtModelo.Text, txtDescripcion, txtCantidad.Text, txtPrecio.Text);
                        decimal subTotal = Convert.ToDecimal(dgvDatosPedido.Rows[confilas].Cells[2].Value) * Convert.ToDecimal(dgvDatosPedido.Rows[confilas].Cells[3].Value);
                        dgvDatosPedido.Rows[confilas].Cells[4].Value = subTotal;
                        confilas++;
                    }
                    else
                    {
                        dgvDatosPedido.Rows.Add(txtModelo.Text, txtDescripcion, txtCantidad.Text, txtPrecio.Text);
                        decimal subTotal = Convert.ToDecimal(dgvDatosPedido.Rows[confilas].Cells[2].Value) * Convert.ToDecimal(dgvDatosPedido.Rows[confilas].Cells[3].Value);
                        dgvDatosPedido.Rows[confilas].Cells[4].Value = subTotal;
                        confilas++;
                    }

                    //Limpiar();
                }
                Total = 0;
                foreach (DataGridViewRow Fila in dgvDatosPedido.Rows)
                {

                    Total += Convert.ToDecimal(Fila.Cells[4].Value);
                }
                txtTotal.Text = Total.ToString();
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            txtRazonSocial.Text = "";
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            txtModelo.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtTotal.Text = "";
        }
    }
}
