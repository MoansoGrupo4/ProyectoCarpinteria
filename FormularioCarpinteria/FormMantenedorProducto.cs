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
    public partial class FormMantenedorProducto : Form
    {
        public FormMantenedorProducto()
        {
            InitializeComponent();

            ListarInsumos();
            gbDatosInsumos.Enabled = false;
            txtCodigo.Enabled = false;
            txtCTotal.Enabled = false;
        }
        private void LimpiarVariables()
        {
            txtCodigo.Text = "";
            txtCategoria.Text = "";
            txtProducto.Text = "";
            txtStock.Text = "";
            dtpFechaIngreso.Text = "";
            txtCUnitario.Text = "";
            dtpFVencimiento.Text = "";
            txtCTotal.Text = "";
        }
        private void FormMantenedorProducto_Load(object sender, EventArgs e)
        {

        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

    
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosInsumos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatosInsumos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntInsumos Insumos = new EntInsumos();

                Insumos.Codigo = txtCodigo.Text.Trim();
                ckbEstInsumo.Checked = false;
                Insumos.EstInsumo = ckbEstInsumo.Checked;
                LogInsumos.Instancia.DeshabilitarInsumo(Insumos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosInsumos.Enabled = false;
            ListarInsumos();
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
                EntInsumos Ins = new EntInsumos();
                Ins.Codigo = txtCodigo.Text.Trim();
                Ins.Categoria = txtCategoria.Text.Trim();
                Ins.Producto = Convert.ToString( txtProducto.Text.Trim());
                Ins.cantidad = int.Parse(txtStock.Text.Trim());
                Ins.FechaEmision = DateTime.Parse(dtpFechaIngreso.Text.Trim());
                Ins.
                    CUnitario = double.Parse(txtCUnitario.Text.Trim());
                Ins.FechaVencimiento = DateTime.Parse(dtpFVencimiento.Text.Trim());
               
                Ins.CTotal = Ins.CUnitario * Ins.cantidad;
                txtCTotal.Text = Convert.ToString( Ins.CTotal);
                Ins.EstInsumo = ckbEstInsumo.Checked;
                LogInsumos.Instancia.InsertarInsumo(Ins);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosInsumos.Enabled = false;
            ListarInsumos();
        }
        private void dgvDatosInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntInsumos Ins = new EntInsumos();
                Ins.Codigo = txtCodigo.Text.Trim();
                Ins.Categoria = txtCategoria.Text.Trim();
                Ins.Producto = txtProducto.Text.Trim();
                Ins.cantidad = int.Parse(txtStock.Text.Trim());
                Ins.FechaEmision = DateTime.Parse(dtpFechaIngreso.Text.Trim());
                Ins.CUnitario = double.Parse(txtCUnitario.Text.Trim());
                Ins.FechaVencimiento = DateTime.Parse(dtpFVencimiento.Text.Trim());
                Ins.CTotal = double.Parse(txtCTotal.Text.Trim());
                Ins.EstInsumo = ckbEstInsumo.Checked;
                LogInsumos.Instancia.EditarInsumo(Ins);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosInsumos.Enabled = false;
            ListarInsumos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosInsumos.Enabled = false;
        }
        public void ListarInsumos()
        {
            dgvDatosInsumos.DataSource = LogInsumos.Instancia.ListarInsumo(); 
        }
        private void dgvDatosInsumos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow filaActual = dgvDatosInsumos.Rows[e.RowIndex];
            txtCodigo.Text = filaActual.Cells[0].Value.ToString();
            txtCategoria.Text = filaActual.Cells[1].Value.ToString();
            txtProducto.Text = filaActual.Cells[2].Value.ToString();
            txtStock.Text = filaActual.Cells[3].Value.ToString(); ;
             txtCUnitario.Text = filaActual.Cells[5].Value.ToString();
            dtpFechaIngreso.Text = filaActual.Cells[4].Value.ToString();
            dtpFVencimiento.Text = filaActual.Cells[6].Value.ToString();
            txtCTotal.Text = filaActual.Cells[7].Value.ToString();
            ckbEstInsumo.Checked = Convert.ToBoolean(filaActual.Cells[8].Value);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            txtBuscar.Focus();

            EntInsumos BusIns = new EntInsumos();
            BusIns.Producto = txtBuscar.Text;
            DataTable dt = new DataTable();
            dt = LogInsumos.Instancia.BuscarInsumos(BusIns.Producto);
            if (txtBuscar.Text != "" && BusIns.EstInsumo == true)
            {
                dgvDatosInsumos.DataSource = dt;
            }
            else
            {
                ListarInsumos();
            }
        }
    }
}
