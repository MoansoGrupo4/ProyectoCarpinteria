using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class DatNuevoPedido : Conexion
    {
        private static readonly DatNuevoPedido _instancia = new DatNuevoPedido();
        public static new DatNuevoPedido Instancia
        {
            get
            {
                return DatNuevoPedido._instancia;
            }
        }
        public List<EntNuevoPedido> ListaNPedido()
        {
            SqlCommand cmd = null;
            List<EntNuevoPedido> lista = new List<EntNuevoPedido>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EntNuevoPedido pe = new EntNuevoPedido();

                    pe.CodPedido = dr["CodPedido"].ToString();
                    pe.CodModelo = dr["CodModelo"].ToString();
                    pe.DesModelo = dr["DesModelo"].ToString();
                    pe.CodCliente = Convert.ToInt32(dr["CodCliente"]);
                    pe.NombreCliente = dr["NombreCliente"].ToString();
                    pe.fecha = Convert.ToDateTime(dr["fecha"]);
                    pe.total = Convert.ToSingle(dr["total"]);
                    
                    lista.Add(pe);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public Boolean InsertarNPedido(EntNuevoPedido e)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodPedido", e.CodPedido);
                cmd.Parameters.AddWithValue("@CodModelo",e.CodModelo);
                cmd.Parameters.AddWithValue("@DesModelo",e.DesModelo);
                cmd.Parameters.AddWithValue("@CodCliente", e.CodCliente);
                cmd.Parameters.AddWithValue("@NombreCliente", e.NombreCliente);
                cmd.Parameters.AddWithValue("@fecha", e.fecha);
                cmd.Parameters.AddWithValue("@total", e.total);
                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { inserta = true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public EntNuevoPedido BuscarPedido(string CodPedido)
        {
            SqlCommand cmd = null;
            EntNuevoPedido pedido = new EntNuevoPedido();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodPedido", CodPedido);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pedido.CodPedido = dr["CodPedido"].ToString();
                    pedido.CodModelo = dr["CodModelo"].ToString();
                    pedido.DesModelo = dr["DesModelo"].ToString();
                    pedido.CodCliente = Convert.ToInt32(dr["CodCliente"]);
                    pedido.NombreCliente = dr["NombreCliente"].ToString();
                    pedido.fecha = Convert.ToDateTime(dr["fecha"]);
                    pedido.total = Convert.ToSingle(dr["total"]);

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return pedido;
        }
    }
}
