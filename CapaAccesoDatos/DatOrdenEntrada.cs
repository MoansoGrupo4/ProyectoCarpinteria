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
    public class DatOrdenEntrada
    {
        private static readonly DatOrdenEntrada _instancia = new DatOrdenEntrada();
        public static DatOrdenEntrada Instancia
        {
            get { return DatOrdenEntrada._instancia; }
        }

        //Listar Ordenes de Entradas
        public List<EntOrdenEntrada> ListarOrdenEntrada()
        {
            SqlCommand cmd = null;
            List<EntOrdenEntrada> lista = new List<EntOrdenEntrada>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOrdenEntrada", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EntOrdenEntrada oe = new EntOrdenEntrada();
                    oe.idOrdenEntrada = dr["idOrdenEntrada"].ToString();
                    oe.CodPedido = dr["CodPedido"].ToString();
                    oe.CodMPrima = dr["CodMPrima"].ToString();
                    oe.CodInsumo = dr["CodInsumo"].ToString();
                    lista.Add(oe);
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

        //Ingresar datos
        public Boolean InsertarOrdenEntrada(EntOrdenEntrada or)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarOrdenEntrada", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idOrdenEntrada", or.idOrdenEntrada);
                cmd.Parameters.AddWithValue("@codPedido", or.CodPedido);
                cmd.Parameters.AddWithValue("@CodMPrima", or.CodMPrima);
                cmd.Parameters.AddWithValue("@codInsumo", or.CodInsumo);
                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
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
            return inserta;
        }

        //Buscar orden de entrada
        public EntOrdenEntrada BuscarOrdenEntrada(string idOrdenEntrada)
        {
            SqlCommand cmd = null;
            EntOrdenEntrada ent = new EntOrdenEntrada();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarOrdenEntrada", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idOrdenEntrada", idOrdenEntrada);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ent.idOrdenEntrada = dr["idOrdenEntrada"].ToString();
                    ent.CodPedido = dr["CodPedido"].ToString();
                    ent.CodMPrima = dr["CodMPrima"].ToString();
                    ent.CodInsumo = dr["CodInsumo"].ToString();
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
            return ent;
        }
    }
}
