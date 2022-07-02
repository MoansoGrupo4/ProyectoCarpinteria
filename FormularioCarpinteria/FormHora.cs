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
    public partial class FormHora : Form
    {
        public FormHora()
        {
            InitializeComponent();
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FormMantenedorEmpleado v1 = new FormMantenedorEmpleado();
            v1.Show();
        }
    }
}
