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
    public partial class FormTransaccionOP : Form
    {
        EntOP OP = new EntOP();
        private List<EntOP> listarOP = new List<EntOP>();
        public FormTransaccionOP()
        {
            InitializeComponent();
        
        }
        private void lblCliente_Click(object sender, EventArgs e)
        {
            
        }
        private void Quitar_Click(object sender, EventArgs e)
        {

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //oli
        }
        private void FormTransaccionOP_Load(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
