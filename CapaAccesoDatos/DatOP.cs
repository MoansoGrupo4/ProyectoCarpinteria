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
    public class DatOP:Conexion
    {   
        private static readonly DatOP _instancia = new DatOP();
        public static new DatOP Instancia
        {
            get
            {
                return DatOP._instancia;
            }
        }
        public List<EntOP> ListarOP()
        {
            SqlCommand cmd = null;
            List<EntOP> lista = new List<EntOP>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOP", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EntOP OP = new EntOP();
                    EntCliente Cli = new EntCliente();
                    OP.Codigo = Cli;
                    EntPedido Pedido = new EntPedido();
                    OP.CodPedido = Pedido;
                    EntModelo modelo = new EntModelo();
                    OP.CodOP = dr["CodOP"].ToString();
                    Cli.Codigo = Convert.ToInt32(dr["idCliente"]);
                    // OP.Codigo = Convert.ToInt32(dr["CodCLiente"]);
                    Pedido.CodPedido = dr["CodPedido"].ToString();
                    modelo.CodModelo = dr["CodModelo"].ToString();
                    OP.EstOP = Convert.ToBoolean(dr["EstOP"]);
                    OP.InicioOP = Convert.ToDateTime(dr["InicioOP"]);
                    lista.Add(OP);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public String InsertarOP(EntOP OP)
        {
            SqlCommand cmd = null;
            String inserta = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodCLiente", OP.Codigo.Codigo);
                cmd.Parameters.AddWithValue("@CodModelo", OP.CodModelo.CodModelo);
                cmd.Parameters.AddWithValue("@CodOP", OP.CodOP);
                cmd.Parameters.AddWithValue("@CodPedido", OP.CodPedido.CodPedido);
                cmd.Parameters.AddWithValue("@InicioOP", OP.InicioOP);
                cmd.Parameters.AddWithValue("@EstOP", OP.EstOP);
              
                SqlParameter m = new SqlParameter("@retorno", DbType.String);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);
                cn.Open();
                cmd.ExecuteNonQuery();
                inserta = Convert.ToString(cmd.Parameters["@retorno"].Value);
                return inserta;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }  
        }
    }
}
