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
            txtCodigo.Enabled = false;
            gbMadera.Enabled = false;
        }

        private void LLenarDatosComboBoxTipoMadera()
        {
            cmbTipoMadera.DataSource = LogTipoMadera.Instancia.ListarTipoMadera();
            cmbTipoMadera.DisplayMember = "DesTipoMadera";
            cmbTipoMadera.ValueMember = "CodTipoMadera";
        }
        private void LLenarDatosComboBoxTipoMueble()
        {
            cmbTipoMueble.DataSource = LogTipoMueble.Instancia.ListarTipoMueble();
            cmbTipoMueble.DisplayMember = "DesTipoMueble";
            cmbTipoMueble.ValueMember = "CodTipoMueble";
        }

        public void ListarModelo()
        {
            dgvDatosModelo.DataSource = LogModelo.Instancia.ListarModelo();
        }

        public void LimpiarVariables()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtColor.Text = "";
            txtPrecioVentaPU.Text = "";
            txtPrecioVentaPM.Text = "";
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
                ckbEstado.Checked = false;
                mod.EstadoModelo = ckbEstado.Checked;
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
            try
            {
                EntModelo mod = new EntModelo();

                mod.CodModelo = txtCodigo.Text.Trim();
                mod.DesModelo = txtDescripcion.Text.Trim();
                mod.CodTipoMadera = Convert.ToString(cmbTipoMadera.SelectedValue);
                mod.ColorModelo = txtColor.Text.Trim();
                mod.PrecioVentaPU = Convert.ToSingle(txtPrecioVentaPU.Text.Trim());
                mod.PrecioVentaPM = Convert.ToSingle(txtPrecioVentaPM.Text.Trim());
                mod.CodTipoMueble = Convert.ToString(cmbTipoMueble.SelectedValue);
                mod.EstadoModelo = ckbEstado.Checked;
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
                mod.DesModelo = txtDescripcion.Text.Trim();
                mod.CodTipoMadera = Convert.ToString(cmbTipoMadera.SelectedValue);
                mod.ColorModelo = txtColor.Text.Trim();
                mod.PrecioVentaPU = Convert.ToSingle(txtPrecioVentaPU.Text.Trim());
                mod.PrecioVentaPM = Convert.ToSingle(txtPrecioVentaPM.Text.Trim());
                mod.CodTipoMueble = Convert.ToString(cmbTipoMueble.SelectedValue);
                mod.EstadoModelo = ckbEstado.Checked;
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

        private void dgvDatosModelo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaActual = dgvDatosModelo.Rows[e.RowIndex];
            txtCodigo.Text = filaActual.Cells[0].Value.ToString();
            txtPrecioVentaPU.Text = filaActual.Cells[4].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[1].Value.ToString();
            txtPrecioVentaPM.Text = filaActual.Cells[5].Value.ToString();
            txtColor.Text = filaActual.Cells[3].Value.ToString();
            ckbEstado.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);
        }

        private void ckbEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
                txtBuscar.Focus();
                EntModelo BusModelo = new EntModelo();
                string DesModelo = txtBuscar.Text;
                DataTable dt = new DataTable();
                dt = LogModelo.Instancia.BuscarModelo(DesModelo);
                if (txtBuscar.Text != "")
                {
                    dgvDatosModelo.DataSource = dt;
                }
                else
                {
                    ListarModelo();
                }
            }
        
    }
}
