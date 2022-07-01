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


namespace FormularioCarpinteria
{
    public partial class MantenedorModelo : Form
    {
        public MantenedorModelo()
        {
            InitializeComponent();
        }

        private void LLenarDatosComboBoxTipoMadera()
        {
            comboBoxTipoMadera.DataSource = LogTipoMadera.Instancia.ListarTipoMadera();
            comboBoxTipoMadera.DisplayMember = "DesTipoMadera";
            comboBoxTipoMadera.ValueMember = "CodTipoMadera";
        }
        private void LLenarDatosComboBoxTipoMueble()
        {
            comboBoxTipoMueble.DataSource = LogTipoMueble.Instancia.ListarTipoMueble();
            comboBoxTipoMueble.DisplayMember = "DesTipoMueble";
            comboBoxTipoMueble.ValueMember = "CodTipoMueble";
        }

        public void ListarModelo()
        {
            dgvDatosModelo.DataSource = LogModelo.Instancia.ListarModelo();
        }

        public void LimpiarVariables()
        {
            txtCodigo.Text = "";
            textBox2.Text = "";
            txtColor.Text = "";
            txtPrcioVenta.Text = "";
            txtPrecioVenta.Text = "";
        }

        private void MantenedorModelo_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
