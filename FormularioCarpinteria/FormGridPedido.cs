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
    public partial class FormGridPedido : Form
    {
        public FormGridPedido()
        {
            InitializeComponent();
        }

        public static int confilas = 0;
        public static decimal Total = 0;
        public void ListarPedido()
        {
            List<EntPedido> dataPedido = LogPedido.Instancia.ListarPedido();
            if (dataPedido.Count >= 0)
            {
                dgvPedidos.Columns.Clear();
                BindingSource datos = new BindingSource();
                datos.DataSource = dataPedido;
                dgvPedidos.DataSource = datos;
                dgvPedidos.Rows[0].Selected = false;
            }

        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Form Pedido = new FormTransaccionPedido();
            Pedido.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (confilas > 0)
            {
                dgvPedidos.Rows.RemoveAt(dgvPedidos.CurrentRow.Index);
                confilas--;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
