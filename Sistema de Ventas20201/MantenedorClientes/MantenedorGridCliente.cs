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
    public partial class MantenedorGridCliente : Form
    {
        
        public MantenedorGridCliente()
        {
            InitializeComponent();
            ListarCliente();
        }
        public void ListarCliente()
        {
            List<entCliente> listaCliente = logCliente.Instancia.ListarCliente();
            if (listaCliente.Count > 0) // para verificar si existen filas
            {
                
                tablaClientes.Columns.Clear(); // se eliminan todas las columnas existentes del DataGridView antes de mostrar el resultado de la consulta
                BindingSource datosEnlazados = new BindingSource(); // objeto para vincular el resultado de la consulta al DataGridView
                datosEnlazados.DataSource = listaCliente;
                tablaClientes.DataSource = datosEnlazados; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                //configurarColumnasDataGridView();
                tablaClientes.Rows[0].Selected = false; // permite que la primera fila del DataGridView no esté seleccionada
            }
           
        }
        private void configurarColumnasDataGridView()       //No se esta utilizando
        {
            DataGridViewColumn columna0, columna1, columna2, columna3, columna4; // objetos columna
            // modificar los encabezados de columnas de la tabla
            columna0 = tablaClientes.Columns[0]; // se recupera la columna Id
            columna0.Visible = false; // se oculta la columna
            columna1 = tablaClientes.Columns[1]; // se recupera la columna nombre
            columna1.HeaderText = "idCliente"; // se asigna el encabezado de columna
            columna1.Width = 200; // se asigna el ancho de la columna
            columna2 = tablaClientes.Columns[2];
            columna2.HeaderText = "RazonSocial";
            columna2.Width = 80;
            columna3 = tablaClientes.Columns[3];
            columna3.HeaderText = "Dirección";
            columna3.Width = 200;
            columna4 = tablaClientes.Columns[4];
            columna4.HeaderText = "Ciudad";
            columna4.Width = 200;
        }
        private void Insertar_Click(object sender, EventArgs e)
        {
            FormDatosCliente formCliente = new FormDatosCliente();
            formCliente.ShowDialog();
           
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //public void Buscar_Click(object sender, EventArgs e)
        //{
        //    entCliente Cli = new entCliente();
        //    Cli.RazonSocial = txtRazonSocial.Text.Trim();
        //    Cli = logCliente.Instancia.BuscarCliente(Cli.RazonSocial);

        //}

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entCliente Cli = new entCliente();
            //this.ActiveControl = txtRazonSocial;
            //txtRazonSocial.Focus();
            ////--
            int idCliente;
            DataGridViewRow fila = tablaClientes.CurrentRow; // se obtine la fila que contiene la celda actual
            
            if (fila != null) // verifica que exista una fila seleccionada {                
            {
                idCliente = int.Parse(fila.Cells[0].Value.ToString()); // se obtiene el valor de una celda 
                entCliente C = logCliente.Instancia.BuscarClienteId(idCliente);
                if (C!= null)
                {
                    FormDatosCliente formDatosCliente = new FormDatosCliente(C);                 
                    formDatosCliente.cbkEstado.Enabled = false;  //Es necesario propiedad modifiers es public
                    //txtidCliente.Enabled = false;
                    formDatosCliente.ShowDialog();
                }
                else
                    MessageBox.Show("El cliente no existe, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Seleccione cliente.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void Inhabilitar_Click(object sender, EventArgs e)
        {

            entCliente Cli = new entCliente();
            int idCliente;
            DataGridViewRow fila = tablaClientes.CurrentRow; // se obtine la fila que contiene la celda actual
            //MessageBox.Show("fila "+fila)
            if (fila != null) // verifica que exista una fila seleccionada {                
            {
                idCliente = int.Parse(fila.Cells[0].Value.ToString()); // se obtiene el valor de una celda 
                entCliente C = logCliente.Instancia.BuscarClienteId(idCliente);
                if (C != null)
                {
                    FormDatosCliente formDatosCliente = new FormDatosCliente(C);
                    formDatosCliente.txtRazonSocial.Enabled = false;  //Es necesario propiedad modifiers es public
                    formDatosCliente.txtDireccion.Enabled = false;  //Es necesario propiedad modifiers es public
                    formDatosCliente.txtCiudad.Enabled = false;  //Es necesario propiedad modifiers es public
                    formDatosCliente.txtTipoCliente.Enabled = false;  //Es necesario propiedad modifiers es public
                    formDatosCliente.ShowDialog();

                }
                else
                    MessageBox.Show("El cliente no existe, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Seleccione cliente.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MantenedorGridCliente_Load(object sender, EventArgs e)
        {

        }

        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
