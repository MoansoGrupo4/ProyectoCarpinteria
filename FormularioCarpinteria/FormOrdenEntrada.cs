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
            listarEmpleado();
            listarMadera();
            listarInsumo();
            /*llenarCboPedido();
            llenarCboMPrima();
            llenarCboInsumo();*/
        }
        public void listarEmpleado()
        {
            dgvDatosEmpleado.DataSource = LogEmpleado.Instancia.ListarEmpleado();
        }
        public void listarMadera()
        {
            dgvTablaMadera.DataSource = LogMPrima.Instancia.ListarMaterial();
        }
        public void listarInsumo()
        {
            dgvDatosInsumos.DataSource = LogInsumos.Instancia.ListarInsumo();
        }
        private void limpiarVariable()
        {

        }
        private void llenarCboMPrima()
        {
            cboMPrima.DataSource = LogMPrima.Instancia.ListarMaterial();
            cboMPrima.DisplayMember = "NombreMPrima";
            cboMPrima.ValueMember = "CodMPrima";
        }
        private void llenarCboInsumo()
        {
            cboCodigoInsumos.DataSource = LogInsumos.Instancia.ListarInsumo();
            cboCodigoInsumos.DisplayMember = "NomInsumo";
            cboCodigoInsumos.ValueMember = "CodInsumo";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*try
            {
                EntOrdenEntrada ordenEntrada = new EntOrdenEntrada();
                ordenEntrada.CodPedido = Convert.ToString(cboPedido.SelectedValue);
                ordenEntrada.CodMPrima = Convert.ToString(cboMPrima.SelectedValue);
                ordenEntrada.CodInsumo = Convert.ToString(cboCodigoInsumos.SelectedValue);
                LogOrdenEntrada.Instancia.InsertarOrdenEntrada(ordenEntrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }*/
        }

        private void dgvDatosEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatosEmpleado.Rows[e.RowIndex];

            txtCodigo.Text = filaActual.Cells[0].Value.ToString();
            txtCliente.Text = filaActual.Cells[1].Value.ToString();
        }

        private void dgvTablaMadera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTablaMadera.Rows[e.RowIndex];

            txtMPrima.Text = filaActual.Cells[1].Value.ToString();
        }

        private void dgvDatosInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatosInsumos.Rows[e.RowIndex];

            txtNombreInsumo.Text = filaActual.Cells[1].Value.ToString();
        }
    }
}
