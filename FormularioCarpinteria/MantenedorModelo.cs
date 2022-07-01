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
            LLenarDatosComboBoxTipoMadera();
            LLenarDatosComboBoxTipoMueble();
            ListarModelo();
            gbMadera.Enabled = false;
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
            gbMadera.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbMadera.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntModelo mod = new EntModelo();
                mod.CodModelo = txtCodigo.Text.Trim();
                cbxEstadoModelo.Checked = false;
                mod.EstadoModelo = cbxEstadoModelo.Checked;
                LogModelo.Instancia.DeshabilitarModelo(mod);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMadera.Enabled = false;
            ListarModelo();
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntModelo mod = new EntModelo();

                mod.CodModelo = txtCodigo.Text.Trim();
                mod.DesModelo = textBox2.Text.Trim();
                mod.CodTipoMadera = Convert.ToString(comboBoxTipoMadera.SelectedValue);
                mod.ColorModelo = txtColor.Text.Trim();
                mod.PrecioVentaPU = Convert.ToSingle(txtPrcioVenta.Text.Trim());
                mod.PrecioVentaPM = Convert.ToSingle(txtPrecioVenta.Text.Trim());
                mod.CodTipoMueble = Convert.ToString(comboBoxTipoMueble.SelectedValue);
                mod.EstadoModelo = cbxEstadoModelo.Checked;
                LogModelo.Instancia.InsertarModelo(mod);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMadera.Enabled = false;
            ListarModelo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntModelo mod = new EntModelo();

                mod.CodModelo = txtCodigo.Text.Trim();
                mod.DesModelo = textBox2.Text.Trim();
                mod.CodTipoMadera = Convert.ToString(comboBoxTipoMadera.SelectedValue);
                mod.ColorModelo = txtColor.Text.Trim();
                mod.PrecioVentaPU = Convert.ToSingle(txtPrcioVenta.Text.Trim());
                mod.PrecioVentaPM = Convert.ToSingle(txtPrecioVenta.Text.Trim());
                mod.CodTipoMueble = Convert.ToString(comboBoxTipoMueble.SelectedValue);
                mod.EstadoModelo = cbxEstadoModelo.Checked;
                LogModelo.Instancia.EditarModelo(mod);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMadera.Enabled = false;
            ListarModelo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbMadera.Enabled = false;
        }
    }
}
