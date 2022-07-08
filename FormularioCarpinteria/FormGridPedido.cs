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
            listarPedidos();
        }

        public void listarPedidos()
        {
            dgvDatosPedido.DataSource = LogNuevoPedido.Instancia.ListarNPedido();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
