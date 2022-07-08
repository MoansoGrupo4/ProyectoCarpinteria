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
    }
}
