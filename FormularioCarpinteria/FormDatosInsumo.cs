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
    public partial class FormDatosInsumo : Form
    {
        public FormDatosInsumo()
        {
            InitializeComponent();
            listarInsumo();
        }
        public void listarInsumo()
        {
            dgvDatosInsumos.DataSource = LogInsumos.Instancia.ListarInsumo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //corregir esta parte
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            EntInsumos buscar = new EntInsumos();
            buscar.Producto = txtBuscar.Text;
            DataTable dt = new DataTable();
            dt = LogInsumos.Instancia.BuscarInsumos(buscar.Producto);

            if (txtBuscar.Text != "" && (buscar.EstInsumo = true))
            {
                dgvDatosInsumos.DataSource = dt;
            }
            else
            {
                dgvDatosInsumos.DataSource = LogInsumos.Instancia.ListarInsumo();
            }
        }
    }
}
