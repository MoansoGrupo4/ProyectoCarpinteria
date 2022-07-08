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
    public partial class FormTransaccionEmpleado : Form
    {
        public FormTransaccionEmpleado()
        {
            InitializeComponent();
            ListarAsignacion();
        }

        private void ListarAsignacion() {
            dataGridView1.DataSource = LogAsisgnacionEmpleado.Instancia.ListarAsignacion();
        }
        private void LimpiarVariables() {
            textcargo.Text = "";
            texthorasdetrabajo.Text = "";
            textnombre.Text = "";
            textidgrupo.Text = "";
            textIdOp.Text = "";
            textpagoporhora.Text = "";
            textidempleado.Text = "";
            textnomEmp.Text = "";
        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            textnomEmp.Focus();
            string empleado = textnomEmp.Text;
            EntEmpleado E = new EntEmpleado();
            E = LogEmpleado.Instancia.BuscarEmpleado(empleado);
            if (E != null && (E.estEmpleado = true) && textnomEmp.Text != "")
            {
                textnombre.Text = Convert.ToString(E.NomEmpleado);
                textidempleado.Text = Convert.ToString(E.IdEmpleado);
                textcargo.Text = Convert.ToString(E.FuncionEmpleado);
            }
            else
                MessageBox.Show("El empleado no existe o esta inhabilitado, verifique.", "Empleado: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                EntAsignacionEmpleado asi = new EntAsignacionEmpleado();

                asi.IdGrupo = textidgrupo.Text.Trim();
                asi.Nombre = textnombre.Text.Trim();
                asi.Cargo = textcargo.Text.Trim();
                asi.IdEmpleado = textidempleado.Text.Trim();
                asi.IdOp=textIdOp.Text.Trim();
                asi.HorasTrabajo=Convert.ToInt32(texthorasdetrabajo.Text.Trim());
                asi.PagoHora = Convert.ToSingle(textpagoporhora.Text.Trim());
                asi.PagoTotal = asi.HorasTrabajo * asi.PagoHora;
                LogAsisgnacionEmpleado.Instancia.InsertarAsignacion(asi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarAsignacion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }
    }
}
