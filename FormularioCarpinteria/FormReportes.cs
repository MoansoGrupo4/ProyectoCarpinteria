using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioCarpinteria
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormDatosEmpleado f = new FormDatosEmpleado();
            f.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormDatosCliente f = new FormDatosCliente();
            f.ShowDialog();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            FormDatosInsumo f = new FormDatosInsumo();
            f.ShowDialog();
        }

        private void btnMPrima_Click(object sender, EventArgs e)
        {
            FormDatosMPrima f = new FormDatosMPrima();
            f.ShowDialog();
        }
    }
}
