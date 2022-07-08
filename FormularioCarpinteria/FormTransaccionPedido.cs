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
            //asd
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //Buscar cliente
            txtCliente.Focus();
            EntCliente BusCli = new EntCliente();
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
            EntModelo BuscMod = new EntModelo();
            DataTable p = new DataTable();
            p = LogModelo.Instancia.BuscarModelo(BuscMod.CodModelo);
            String Producto = txtProducto.Text;
            if (p != null && (BuscMod.EstadoModelo = true))
            {
                txtDescripcion.Text = Convert.ToString(BuscMod.CodTipoMueble);
                txtPrecio.Text = Convert.ToString(BuscMod.PrecioVentaPU);

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
                Cli.Codigo = Convert.ToInt32(txtCliente.Text.Trim());
                Ped.Codigo = Cli;
                Ped.Codigo.Codigo = Convert.ToInt32(txtCliente.Text.Trim());
                Ped.Fecha = Convert.ToDateTime(dtpFechaIngreso);
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
                Mod.CodModelo = fila.Cells[0].Value.ToString();
                DetPed.CodModelo = Mod;
                DetPed.CodModelo.CodModelo = Mod.CodModelo;
                DetPed.Cantidad = Convert.ToInt32(fila.Cells[1].Value.ToString());
                DetPed.Precio = Convert.ToDecimal(fila.Cells[2].Value.ToString());
                Mod.DesModelo = fila.Cells[3].Value.ToString();
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

        }
    }
}
