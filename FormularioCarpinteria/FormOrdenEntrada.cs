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
        }

        public void listarPedido()
        {
            dgvDatosEmpleado.DataSource = LogEmpleado.Instancia.ListarEmpleado();
        }
        public void listarMPrima()
        {
            dgvTablaMadera.DataSource = LogMPrima.Instancia.ListarMaterial();
        }
        public void listarInsumos() 
        {
            dgvDatosInsumos.DataSource = LogInsumos.Instancia.ListarInsumo();
        }

        private void dgvDatosEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatosEmpleado.Rows[e.RowIndex];

            txtCodigoPedido.Text = filaActual.Cells[0].Value.ToString();
            txtClientePedido.Text = filaActual.Cells[1].Value.ToString();
        }

        private void dgvTablaMadera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTablaMadera.Rows[e.RowIndex];

            txtCodigoMPrima.Text = filaActual.Cells[0].Value.ToString();
            txtNombreMPrima.Text = filaActual.Cells[1].Value.ToString();
        }

        private void dgvDatosInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatosInsumos.Rows[e.RowIndex];

            txtCodigoInsumo.Text = filaActual.Cells[0].Value.ToString();
            txtNombreInsumo.Text = filaActual.Cells[2].Value.ToString();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FormDatosOrdenEntrada f = new FormDatosOrdenEntrada();
            f.ShowDialog();
        }
    }
}
