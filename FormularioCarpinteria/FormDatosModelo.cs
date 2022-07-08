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
    public partial class FormDatosModelo : Form
    {
        public FormDatosModelo()
        {
            InitializeComponent();
            listarModelo();
        }

        public void listarModelo()
        {
            dgvDatosModelo.DataSource = LogModelo.Instancia.ListarModelo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
