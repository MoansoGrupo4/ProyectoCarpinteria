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
    public partial class FormDatosPedido : Form
    {
        entPedido Pedido = new entPedido();
        entDetPedido dPed = new entDetPedido();

        private List<entDetPedido> listaDetPedido = new List<entDetPedido>();

        public FormDatosPedido()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            txtCliente.Focus();
            int idCliente = Convert.ToInt32(txtCliente.Text); // se obtiene el valor de una celda 
            entCliente C = logCliente.Instancia.BuscarClienteId(idCliente);
            if (C!= null && (C.estCliente = true))
            {
                txtRazonSocial.Text = Convert.ToString(C.RazonSocial);
            }
            else
                MessageBox.Show("El cliente no existe or esta inhabilitado, verifique.", "Cliente: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            txtProductoid.Focus();
            int idProducto = Convert.ToInt32(txtProductoid.Text); // se obtiene el valor de una celda 
            entProducto Prod = logProducto.Instancia.BuscarProductoId(idProducto);
            if (Prod!= null && (Prod.estProducto = true))
            {
                
                txtDescProducto.Text = Convert.ToString(Prod.descProducto);
                txtPrecio.Text = Convert.ToString(Prod.precioVenta);
                txtStock.Text = Convert.ToString(Prod.StkProducto);
            }
            else
                MessageBox.Show("El Producto no existe or esta inhabilitado, verifique.", "Producto: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static int confilas = 0;
        public static decimal Total = 0;


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entDetPedido dPe = new entDetPedido();
            entProducto Prod = new entProducto();
          
            if ((this.txtCliente.Text.Trim() != "") && (txtProductoid.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            {
                        if (( Convert.ToInt32(txtCantidad.Text) >0) && (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock.Text)))
                        {   
                                    if (confilas == 0)
                                    {
                                        
                                        TablaDetallePedido.Rows.Add(txtProductoid.Text, txtDescProducto, txtCantidad.Text, txtPrecio.Text);
                                        decimal subTotal = Convert.ToDecimal(TablaDetallePedido.Rows[confilas].Cells[2].Value) * Convert.ToDecimal(TablaDetallePedido.Rows[confilas].Cells[3].Value);
                                        TablaDetallePedido.Rows[confilas].Cells[4].Value = subTotal;
                                        confilas++;
                                    }
                                    else
                                          {
                                          TablaDetallePedido.Rows.Add(txtProductoid.Text, txtDescProducto, txtCantidad.Text, txtPrecio.Text);
                                          decimal subTotal = Convert.ToDecimal(TablaDetallePedido.Rows[confilas].Cells[2].Value) * Convert.ToDecimal(TablaDetallePedido.Rows[confilas].Cells[3].Value);
                                          TablaDetallePedido.Rows[confilas].Cells[4].Value = subTotal;
                                            confilas++;
                                           }
                                    
                                    //Limpiar();
                        }
                           Total = 0;
                          foreach(DataGridViewRow Fila in TablaDetallePedido.Rows)
                              {
                                                      
                                      Total += Convert.ToDecimal(Fila.Cells[4].Value);
                                       }
                                     txtTotal.Text = Total.ToString();
                              }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            if (confilas > 0)
            {
                Total = Total - Convert.ToDecimal(TablaDetallePedido.Rows[TablaDetallePedido.CurrentRow.Index].Cells[4].Value);
                //txtTotal.Text = "S/." + Total.ToString();
                txtTotal.Text = Total.ToString();
                TablaDetallePedido.Rows.RemoveAt(TablaDetallePedido.CurrentRow.Index);
                confilas--;
            }
        }


        

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int idPed;
            try
            {
                entPedido Ped = new entPedido();
                //entDetPedido dPed = new entDetPedido();
                entCliente c = new entCliente();
                entProducto prod = new entProducto();

                Ped.fechPedido = Convert.ToDateTime(dateTimePicker1.Value);
                Ped.TotPedido = Convert.ToDouble(txtTotal.Text);
               
                c.idCliente = int.Parse(txtCliente.Text);
               
                Ped.idCliente = c;
                Ped.idCliente.idCliente = c.idCliente;

                //Ped.DetPedidos = (List<entDetPedido>)(listaDetPedido);

               
                //Ped.estPedido = cbkEstado.Checked;
                Ped.estPedido = true;
                idPed =logPedido.Instancia.InsertarPedido(Ped);

                //MessageBox.Show(""+idPed);

                GrabarDetalle(idPed);

                Close();
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                throw ex;
            }
        }
            
        private void GrabarDetalle(int cod)
        {
            foreach (DataGridViewRow Fila in TablaDetallePedido.Rows)
            {
                dPed.idPedido = cod;
                entProducto prod = new entProducto();

                
                prod.idProducto = Convert.ToInt32(Fila.Cells[0].Value.ToString());
                dPed.idProducto = prod;
                dPed.idProducto.idProducto = prod.idProducto;

                dPed.cantProducto = Convert.ToInt32(Fila.Cells[2].Value.ToString());
                dPed.precProducto = Convert.ToDecimal(Fila.Cells[3].Value.ToString());

              
                logPedido.Instancia.InsertarDetPedido(dPed);
            }

        }
            
            
            
               
        private void configurarColumnasDataGridView()       
        {
            DataGridViewColumn columna0, columna1, columna2, columna3, columna4; // objetos columna
          

            // modificar los encabezados de columnas de la tabla
            columna0 = TablaDetallePedido.Columns[0]; // se recupera la columna Id
            columna0.Visible = false; // seoculta la columna
            columna1 = TablaDetallePedido.Columns[1]; // se recupera la columna nombre
            columna1.HeaderText = "idProducto"; // se asigna el encabezado de columna
            columna1.Width = 200; // se asigna el ancho de la columna
            columna2 = TablaDetallePedido.Columns[2];
            columna2.HeaderText = "Descripcion";
            columna2.Width = 80;
            columna3 = TablaDetallePedido.Columns[3];
            columna3.HeaderText = "Cantidad";
            columna3.Width = 200;
            columna4 = TablaDetallePedido.Columns[4];
            columna4.HeaderText = "Precio";
            columna4.Width = 200;
        }
        private void ActualizarGrid()
        {

            //MessageBox.Show("formulario de datos se cierra....de si encuentra instancia");
            TransaccionGridPedido formGridPedido = Application.OpenForms.OfType<TransaccionGridPedido>().FirstOrDefault();

            if (formGridPedido != null)  //Si encuentra una instancia abierta
            {
                //MessageBox.Show("Instancia abierta!!! instancia");
                formGridPedido.ListarPedidos();
                formGridPedido.Refresh();
            }
        }
    }
}
