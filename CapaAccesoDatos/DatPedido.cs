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
    public class DatPedido : Conexion
    {
        private static readonly DatPedido _instancia = new DatPedido();
        public static new DatPedido Instancia
        {
            get
            {
                return DatPedido._instancia;
            }
        }

        //Listar Pedido
        public List<EntPedido> ListarPedido()
        {
            SqlCommand cmd = null;
            List<EntPedido> lista = new List<EntPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPedido Ped = new EntPedido();
                    EntCliente Cli = new EntCliente();
                    Ped.CodPedido = dr["CodPedido"].ToString();
                    Ped.Fecha = Convert.ToDateTime(dr["fecha"]);
                    //Ped.CodCliente = Convert.ToInt32(dr["CodCliente"]);
                    Cli.Codigo = Convert.ToInt32(dr["CodCliente1"]);
                    Cli.Razon_Social = dr["RazonSocialCliente"].ToString();
                    Ped.Codigo = Cli;
                    Ped.Total = Convert.ToDecimal(dr["total"]);
                    lista.Add(Ped);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        //Insertar Pedido
        public String InsertarPedido(EntPedido Ped)
        {
            SqlCommand cmd = null;
            String idPed = "";
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodPedido", Ped.CodPedido);
                cmd.Parameters.AddWithValue("@fecha", Ped.Fecha);
                cmd.Parameters.AddWithValue("@codCliente1", Ped.Codigo.Codigo);
                cmd.Parameters.AddWithValue("@total", Ped.Total);

                SqlParameter m = new SqlParameter("@retorno", DbType.StringFixedLength);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);
                cn.Open();
                cmd.ExecuteNonQuery();
                idPed = cmd.Parameters["@retorno"].Value.ToString();
                return idPed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        //Insertar Detalle del Pedido
        public Boolean InsertarDetPedido(EntDetPedido DetPed)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Icodnuevo", DetPed.CodigoDetPed);
                cmd.Parameters.AddWithValue("@CodPedido", DetPed.CodPedido);
                cmd.Parameters.AddWithValue("@cantidad", DetPed.Cantidad);
                cmd.Parameters.AddWithValue("@precio", DetPed.Precio);
                cmd.Parameters.AddWithValue("@CodModelo", DetPed.CodModelo.CodModelo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return (inserta);
        }
        //Buscar Pedido
        public EntPedido BuscarIdPedido(int CodPedido)
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
                    Pedido.Codigo.Codigo = Convert.ToInt32(dr["CodCliente1"]);
                    Pedido.Total = Convert.ToDecimal(dr["total"]);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Pedido;
        }
    }
}
