using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
namespace CapaAccesoDatos
{
    public class DatPedido:Conexion
    {
        private static readonly DatPedido _instancia = new DatPedido();
        public static new DatPedido Instancia
        {
            get
            {
                return DatPedido._instancia;
            }
        }
      
        
        public EntCliente BuscarIdPedido(string CodPedido)
        {
            SqlCommand cmd = null;
            EntPedido Pedido = new EntPedido();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodPedido", CodPedido);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Pedido.CodPedido = dr["CodPedido"].ToString();
                    Pedido.Descripcion = dr["descripcion"].ToString();
                    Pedido.Cantidad = Convert.ToInt32(dr["cantidad"]);
                    Pedido.Precio = Convert.ToDecimal(dr["precio"]);
                    Pedido.Codigo.Codigo = Convert.ToInt32(dr["CodCliente1"]);
                    Pedido.CodModelo.CodModelo = dr["CodModelo1"].ToString();
                    Pedido.Precio = Convert.ToDecimal(dr["precio"]);

                    Cli.Codigo = Convert.ToInt32(dr["CodCLiente"]);
                    Cli.Cliente = dr["NombreCliente"].ToString();
                    Cli.Razon_Social = dr["RazonSocialCliente"].ToString();
                    Cli.Direccion = dr["dirCliente"].ToString();
                    Cli.Registro = Convert.ToDateTime(dr["FechaRegCliente"]);
                    Cli.Telefono = Convert.ToInt32(dr["telefono"]);
                    Cli.Estado = Convert.ToBoolean(dr["EstadoCliente"]);

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Cli;
        }
}
