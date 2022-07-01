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
    public partial class MantenedorMadera : Form
    {
        public MantenedorMadera()
        {
            InitializeComponent();
            ListarMPrima();
            LlenarComboboxUnidadMedidad();
            gbDatosMadera.Enabled = false;
            txtCodigo.Enabled = false;
            txtCostoTotal.Enabled = false;
        }
        private void LimpiarVariables()
        {
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtCostoUni.Text = "";
            txtNombre.Text = "";
            txtTipo.Text = "";
            txtTamaño.Text = "";
            txtMed1.Text = "";
            txtMed2.Text = "";
            txtMed3.Text = "";
            dtpFechaIngreso.Text = "";
            txtCostoTotal.Text = "";
            ckbEstMPrima.Text = "";

        }

        private void LlenarComboboxUnidadMedidad() {
            comboBoxUnidadMedida.DataSource = LogUnidadMedida.Instancia.ListarUnidadMedida();
            comboBoxUnidadMedida.DisplayMember = "DesUnidadMedida";
            comboBoxUnidadMedida.ValueMember = "CodUnidadMedida";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosMadera.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatosMadera.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntMPrima Material = new EntMPrima();

                Material.Codigo = txtCodigo.Text.Trim();
                ckbEstMPrima.Checked = false;
                Material.Estado = ckbEstMPrima.Checked;
                LogMPrima.Instancia.DeshabilitarMaterial(Material);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosMadera.Enabled = false;
            ListarMPrima();
        }
        private void bntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntMPrima Material = new EntMPrima();
                Material.Codigo = txtCodigo.Text.Trim();
                Material.Nombre = Convert.ToString(txtNombre.Text.Trim());
                Material.Cantidad = int.Parse(txtCantidad.Text.Trim());
                Material.CostUnitario = Convert.ToSingle(txtCostoUni.Text.Trim());
                Material.TipoMPrima = txtTipo.Text.Trim();
                Material.Tam = txtTamaño.Text.Trim();
                Material.DimensionA = Convert.ToSingle(txtMed1.Text.Trim());
                Material.DimensionB = Convert.ToSingle(txtMed2.Text.Trim());
                Material.DimensionC = Convert.ToSingle(txtMed3.Text.Trim());
                Material.UnidadMedida = Convert.ToString(comboBoxUnidadMedida.SelectedValue);
                Material.Ingreso = DateTime.Parse(dtpFechaIngreso.Text.Trim());
                Material.CostTotal = Material.CostUnitario * Material.Cantidad;
               //Material.CostTotal = Convert.ToSingle(txtCostoTotal.Text.Trim());
                Material.Estado = ckbEstMPrima.Checked;
                LogMPrima.Instancia.InsertarMaterial(Material);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosMadera.Enabled = false;
            ListarMPrima();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntMPrima Material = new EntMPrima();
                Material.Codigo = txtCodigo.Text.Trim();
                Material.Nombre = Convert.ToString(txtNombre.Text.Trim());
                Material.Cantidad = int.Parse(txtCantidad.Text.Trim());
                Material.CostUnitario = Convert.ToSingle(txtCostoUni.Text.Trim());
                Material.TipoMPrima = txtTipo.Text.Trim();
                Material.Tam = txtTamaño.Text.Trim();
                Material.DimensionA = Convert.ToSingle(txtMed1.Text.Trim());
                Material.DimensionB = Convert.ToSingle(txtMed2.Text.Trim());
                Material.DimensionC = Convert.ToSingle(txtMed3.Text.Trim());
                Material.UnidadMedida = Convert.ToString(comboBoxUnidadMedida.SelectedValue);
                Material.Ingreso = DateTime.Parse(dtpFechaIngreso.Text.Trim());
                Material.CostTotal = Convert.ToSingle(txtCostoTotal.Text.Trim());
                Material.Estado = ckbEstMPrima.Checked;
                LogMPrima.Instancia.EditarMaterial(Material);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosMadera.Enabled = false;
            ListarMPrima();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosMadera.Enabled = false;
        }

        private void dgvTablaMadera_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

             DataGridViewRow filaActual = dgvTablaMadera.Rows[e.RowIndex];

            txtCodigo.Text = filaActual.Cells[0].Value.ToString();
            txtCantidad.Text = filaActual.Cells[1].Value.ToString();
            txtCostoUni.Text = filaActual.Cells[2].Value.ToString();
            txtNombre.Text = filaActual.Cells[3].Value.ToString(); ;
            txtTamaño.Text = filaActual.Cells[5].Value.ToString();
            txtMed1.Text = filaActual.Cells[6].Value.ToString();
            txtMed2.Text = filaActual.Cells[7].Value.ToString();
            txtMed3.Text = filaActual.Cells[8].Value.ToString();
            comboBoxUnidadMedida.Text = filaActual.Cells[9].Value.ToString();
            dtpFechaIngreso.Text = filaActual.Cells[10].Value.ToString();
            txtCostoTotal.Text = filaActual.Cells[11].Value.ToString();
            ckbEstMPrima.Checked = Convert.ToBoolean(filaActual.Cells[12].Value);
        }
        public void ListarMPrima()
        {
            List<EntMPrima> ListarMaterial = LogMPrima.Instancia.ListarMaterial();
            if (ListarMaterial.Count > 0)
            {
                dgvTablaMadera.Columns.Clear(); 
                BindingSource datosEnlazados = new BindingSource();
                datosEnlazados.DataSource = ListarMaterial;
                dgvTablaMadera.DataSource = datosEnlazados; 
                dgvTablaMadera.Rows[0].Selected = false; 
            }
            else
            {
                dgvTablaMadera.DataSource = ListarMaterial;
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
                EntMPrima Material = new EntMPrima();
            Material.Nombre = txtBuscar.Text.Trim();
            Material = LogMPrima.Instancia.BuscarMaterial(Material.Nombre);
            dgvTablaMadera.DataSource = Material;

        }

    }
}
