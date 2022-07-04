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
using CapaLogicaNegocio;

namespace MantenedorClientes
{
    public partial class TransaccionGridPedido : Form
    {
        public TransaccionGridPedido()
        {
            InitializeComponent();
            ListarPedidos();
        }
        public void ListarPedidos()
        {
            List<entPedido> listaPedido = logPedido.Instancia.ListarPedido();
            
            if (listaPedido.Count >= 0)
            {
                tablaPedidos.Columns.Clear(); // se eliminan todas las columnas existentes del DataGridView antes de mostrar el resultado de la consulta
                //BindingSource datosEnlazados = new BindingSource(); // objeto para vincular el resultado de la consulta al DataGridView
                //datosEnlazados.DataSource = listaPedido;
                ///tablaPedidos.DataSource = datosEnlazados; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                tablaPedidos.DataSource = listaPedido; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                //tablaPedidos.Rows[listaPedido.Count - 1].Cells[2].Value = listaPedido[listaPedido.Count - 1].idCliente.idCliente;
                
               
                //configurarColumnasDataGridView();
                //tablaPedidos.Rows[0].Selected = false; // permite que la primera fila del DataGridView no esté seleccionada

               

            }
           
            
            

        }
        private void configurarColumnasDataGridView()       //No se esta utilizando
        {
            DataGridViewColumn columna0, columna1, columna2, columna3; // objetos columna
             // modificar los encabezados de columnas de la tabla
            columna0 = tablaPedidos.Columns[0]; // se recupera la columna Id
            columna0.Visible = true; // no se oculta la columna
            columna1 = tablaPedidos.Columns[1]; // se recupera la columna nombre
            columna1.HeaderText = "xxx"; // se asigna el encabezado de columna
            columna1.Width = 200; // se asigna el ancho de la columna
            columna2 = tablaPedidos.Columns[2];
            columna2.HeaderText = "xxxxxxrazon";
            //columna2.ValueType.Attributes.ToString();
            columna2.Width = 80;
            columna3 = tablaPedidos.Columns[3];
            columna3.HeaderText = "Dirección";
            columna3.Width = 200;
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
                FormDatosPedido formPedido = new FormDatosPedido();
                formPedido.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
