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
    public partial class FormOrdenEntrada : Form
    {
        public FormOrdenEntrada()
        {
            InitializeComponent();
            listarPedido();
            listarMPrima();
            listarInsumos();
            gbPedido.Enabled = false;
            gbMadera.Enabled = false;
            gbInsumos.Enabled = false;
        }
        private void LimpiarVariables()
        {
            txtCodigoPedido.Text = "";
            txtClientePedido.Text = "";
            txtCodigoMPrima.Text = "";
            txtNombreMPrima.Text = "";
            txtCodigoInsumo.Text = "";
            txtNombreInsumo.Text = "";
        }
        public void listarPedido()
        {
            dgvDatosPedido.DataSource = LogNuevoPedido.Instancia.ListarNPedido();
        }
        public void listarMPrima()
        {
            dgvTablaMadera.DataSource = LogMPrima.Instancia.ListarMaterial();
        }
        public void listarInsumos() 
        {
            dgvDatosInsumos.DataSource = LogInsumos.Instancia.ListarInsumo();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FormDatosOrdenEntrada f = new FormDatosOrdenEntrada();
            f.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbPedido.Enabled = true;
            gbMadera.Enabled = true;
            gbInsumos.Enabled = true;
            btnAgregar.Visible = true;
            btnListar.Visible = true;
            LimpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntOrdenEntrada orden = new EntOrdenEntrada();

                orden.CodPedido = txtCodigoPedido.Text.Trim();
                orden.CodMPrima = txtCodigoMPrima.Text.Trim();
                orden.CodInsumo = txtCodigoInsumo.Text.Trim();

                LogOrdenEntrada.Instancia.InsertarOrdenEntrada(orden);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }
        private void dgvTablaMadera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTablaMadera.Rows[e.RowIndex];

            txtCodigoMPrima.Text = filaActual.Cells[0].Value.ToString();
            txtNombreMPrima.Text = filaActual.Cells[1].Value.ToString();
        }

        private void dgvDatosInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatosInsumos.Rows[e.RowIndex];

            txtCodigoInsumo.Text = filaActual.Cells[0].Value.ToString();
            txtNombreInsumo.Text = filaActual.Cells[2].Value.ToString();
        }

        private void dgvDatosPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatosPedido.Rows[e.RowIndex];

            txtCodigoPedido.Text = filaActual.Cells[0].Value.ToString();
            txtClientePedido.Text = filaActual.Cells[4].Value.ToString();
        }
    }
}
