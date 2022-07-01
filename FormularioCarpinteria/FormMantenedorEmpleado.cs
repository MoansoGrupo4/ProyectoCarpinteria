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
    public partial class FormMantenedorEmpleado : Form
    {
        public FormMantenedorEmpleado()
        {
            InitializeComponent();

            listarEmpleado();
            LlenarComboBoxFuncion();
            gbDatosUsuario.Enabled = false;
            txtUsuario.Enabled = false;
            
        }
        void LlenarComboBoxFuncion() {
            comboBoxFuncion.DataSource = LogFuncion.Instancia.ListarFuncion();
            comboBoxFuncion.DisplayMember = "DesFuncion";
            comboBoxFuncion.ValueMember = "CodFuncion";
        }

        private void FormMantenedorUsuario_Load(object sender, EventArgs e)
        {
           
        }
          
        private void LimpiarVariables()
        {
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtNumero.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e){
            gbDatosUsuario.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatosUsuario.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntEmpleado empleado = new EntEmpleado();

                empleado.IdEmpleado = txtUsuario.Text.Trim();
                cbkEstadoEmpleado.Checked = false;
                empleado.estEmpleado = cbkEstadoEmpleado.Checked;
                LogEmpleado.Instancia.DeshabilitarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosUsuario.Enabled = false;
            listarEmpleado();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntEmpleado empleado = new EntEmpleado();
                empleado.IdEmpleado = txtUsuario.Text.Trim();
                empleado.NomEmpleado = txtNombre.Text.Trim();
                empleado.FuncionEmpleado = Convert.ToString(comboBoxFuncion.SelectedValue);
                empleado.DNIEmpleado = int.Parse(txtDNI.Text.Trim());
                empleado.EdadEmpleado = int.Parse(txtEdad.Text.Trim());
              //empleado.FechaEmpleado = DateTime.Parse(dtpFechaIngreso.Text.Trim());
                empleado.FechaEmpleado = dtpFechaIngreso.Value;
                empleado.DirEmpleado = txtDireccion.Text.Trim();
                empleado.numero = int.Parse(txtNumero.Text.Trim());
                empleado.estEmpleado = cbkEstadoEmpleado.Checked;
                LogEmpleado.Instancia.InsertarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosUsuario.Enabled = false;
            listarEmpleado();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntEmpleado empleado = new EntEmpleado();
                empleado.IdEmpleado = txtUsuario.Text.Trim();
                empleado.NomEmpleado = txtNombre.Text.Trim();
                empleado.FuncionEmpleado = Convert.ToString(comboBoxFuncion.SelectedValue);
                empleado.DNIEmpleado = int.Parse(txtDNI.Text.Trim());
                empleado.EdadEmpleado = int.Parse(txtEdad.Text.Trim());
                empleado.FechaEmpleado = dtpFechaIngreso.Value;
                empleado.DirEmpleado = txtDireccion.Text.Trim();
                empleado.numero = int.Parse(txtNumero.Text.Trim());
                empleado.estEmpleado = cbkEstadoEmpleado.Checked;
                   
                LogEmpleado.Instancia.EditarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosUsuario.Enabled = false;
            listarEmpleado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosUsuario.Enabled = false;
        }

        public void listarEmpleado()
        {
            dgvDatosEmpleado.DataSource = LogEmpleado.Instancia.ListarEmpleado();
        }
        private void dgvDatosEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDatosEmpleado.Rows[e.RowIndex];
             
            txtUsuario.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            comboBoxFuncion.Text = filaActual.Cells[2].Value.ToString();
            txtDireccion.Text = filaActual.Cells[3].Value.ToString(); ;//si algo sale mal es aqui
            txtEdad.Text = filaActual.Cells[5].Value.ToString();
            txtDNI.Text = filaActual.Cells[4].Value.ToString();
           
             //dtpFechaIngreso.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
            dtpFechaIngreso.Text = filaActual.Cells[6].Value.ToString();
            // dtpFechaIngreso.Checked = Convert.ToBoolean(filaActual.Cells[5].Value.ToString());
            txtNumero.Text = filaActual.Cells[7].Value.ToString();
            cbkEstadoEmpleado.Checked = Convert.ToBoolean(filaActual.Cells[8].Value);
        }
        private void dgvDatosEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

           
            txtBuscar.Focus();

            EntEmpleado BusEmp = new EntEmpleado();
            //(BusEmp != null && (BusEmp.estEmpleado == true)
            BusEmp.NomEmpleado = txtBuscar.Text;
            DataTable dt = new DataTable();
            dt = LogEmpleado.Instancia.BuscarEmpleados(BusEmp.NomEmpleado);
            if (txtBuscar.Text != "")
            {

               // MessageBox.Show("hola");


                dgvDatosEmpleado.DataSource = dt;
            }
            else 
            {
               // MessageBox.Show("EL cliente no existe o está inhabilitado, verifique", "cliente");
                dgvDatosEmpleado.DataSource = LogEmpleado.Instancia.ListarEmpleado();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void gbDatosUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}
/*   private void btnBuscar1_Click(object sender, EventArgs e)
      {

            //  EntEmpleado BusEmp = new EntEmpleado();
            txtBuscar.Focus();

            // Column1
            string NomEmpleado = txtBuscar.Text;
            EntEmpleado EMP = LogEmpleado.Instancia.BuscarEmpleado(NomEmpleado);
            // EMP != null && (EMP.estEmpleado == true)
            if (txtBuscar.Text != "")
            {
                dgvDatosEmpleado.DataSource = EMP;
            }
            else
            {
                dgvDatosEmpleado.DataSource = LogEmpleado.Instancia.ListarEmpleado();
                MessageBox.Show("EL cliente no existe o está inhabilitado, verifique", "cliente");
            }   
   txtBuscar.Focus();

      EntEmpleado BusEmp = new EntEmpleado();

      BusEmp.NomEmpleado = txtBuscar.Text;
      DataTable dt = new DataTable();
      dt = LogEmpleado.Instancia.BuscarEmpleados(BusEmp.NomEmpleado);
      if ((BusEmp.estEmpleado == true))
      {

          MessageBox.Show("hola");


          dgvDatosEmpleado.DataSource = dt;
      }
      else
      {
          MessageBox.Show("EL cliente no existe o está inhabilitado, verifique", "cliente");

      }
       EntEmpleado BusEmp = new EntEmpleado();

      BusEmp.NomEmpleado = txtBuscar.Text;
      DataTable dt = new DataTable();
      dt = LogEmpleado.Instancia.BuscarEmpleados(BusEmp.NomEmpleado);
      if ((BusEmp.estEmpleado == true))
      {

          MessageBox.Show("hola");


          dgvDatosEmpleado.DataSource = dt;
      }
      else
      {
          MessageBox.Show("EL cliente no existe o está inhabilitado, verifique", "cliente");


      }*/
/*  tdxtBuscar.Focus();
       BusEmp.NomEmpleado = txtNombre.Text.Trim();
       EntEmpleado EMP = LogEmpleado.Instancia.BuscarEmpleado(NomEmpleado); */


/*
                txtUsuario.Text = Convert.ToString(EMP.IdEmpleado);
                txtNombre.Text = Convert.ToString(EMP.NomEmpleado);
                txtFuncion.Text = Convert.ToString(EMP.FuncionEmpleado);
                txtDireccion.Text = Convert.ToString(EMP.DirEmpleado);
                //txtEdad.Text = int.Parse(EMP.EdadEmpleado);
                txtEdad.Text = Convert.ToString(EMP.EdadEmpleado);
                //dtpFechaIngreso.Text = Convert.ToDateTime(EMP.FechaEmpleado);
                dtpFechaIngreso.Text = Convert.ToString(EMP.FechaEmpleado);
                txtNumero.Text = Convert.ToString(EMP.numero);
                cbkEstadoEmpleado.Checked = Convert.ToBoolean(EMP.estEmpleado);
*/

/*BusEmp.NomEmpleado = txtBuscar.Text;
     BusEmp.IdEmpleado = txtUsuario.Text;
     BusEmp.NomEmpleado = txtNombre.Text;
     BusEmp.FuncionEmpleado = txtFuncion.Text;
     BusEmp.DNIEmpleado = int.Parse(txtDNI.Text);
     BusEmp.EdadEmpleado = int.Parse(txtEdad.Text);
     BusEmp.FechaEmpleado = dtpFechaIngreso.Value;
     BusEmp.DirEmpleado = txtDireccion.Text;
     BusEmp.numero = int.Parse(txtNumero.Text);
     BusEmp.estEmpleado = cbkEstadoEmpleado.Checked;*/