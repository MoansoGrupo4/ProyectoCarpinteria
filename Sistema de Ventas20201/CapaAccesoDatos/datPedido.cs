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
    public class datPedido
    {
        #region singleton
        private static readonly datPedido _instancia = new datPedido();
        public static datPedido Instancia
        {
            get { return datPedido._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entPedido> ListarPedido()
        {
            SqlCommand cmd = null;
            List<entPedido> lista = new List<entPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entPedido Ped = new entPedido();
                    //----Ped.idCliente = new entCliente();
                    entCliente Cli = new entCliente();

                    Ped.idPedido = Convert.ToInt32(dr["idPedido"]);
                    Ped.estPedido = Convert.ToBoolean(dr["estPedido"]);
                    Ped.fechPedido = Convert.ToDateTime(dr["fechPedido"]);

                    //----Ped.idCliente.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]); 
                    Cli.RazonSocial = dr["RazonSocial"].ToString();
                    
                    
                    Ped.idCliente = Cli;
                    //Ped.idCliente.idCliente =Cli.idCliente;
                    //Ped.idCliente = (entCliente) Cli.idCliente;
                    //Ped.idCliente.idCliente = (int) Cli.idCliente;
                    //Console.WriteLine("idCliente "+Ped.idCliente.idCliente);

                    
                   
                    //////////pd.idDetPedido= Convert.ToInt16(dr["idDetPedido"]);
                    //////////Ped.idPedido= pd.idPedido;
                    //////////pd.cantProducto = Convert.ToInt16(dr["canProducto"]);
                    //////////pd.precProducto = Convert.ToDecimal(dr["precProducto"]);
                    //pd.Importe = Convert.ToDecimal(dr["Importe"]);
                    //pd.Importe = (Decimal)(dr["Importe"]);
                     Ped.TotPedido= Convert.ToDouble(dr["TotPedido"]);
                    lista.Add(Ped);
                    
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public int InsertarPedido(entPedido Ped)
        {

            SqlCommand cmd = null;
            int idPed = 0;
            //Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                //////cmd.Parameters.AddWithValue("@prmintidPedido", c.IdPedido);

                               
                cmd.Parameters.AddWithValue("@idCliente", Ped.idCliente.idCliente);
                cmd.Parameters.AddWithValue("@fechPedido", Ped.fechPedido);
                cmd.Parameters.AddWithValue("@TotPedido", Ped.TotPedido);
                cmd.Parameters.AddWithValue("@estPedido", Ped.estPedido);

                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);
                cn.Open();
                cmd.ExecuteNonQuery();
                idPed = Convert.ToInt16(cmd.Parameters["@retorno"].Value);
                return idPed;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            
        }
        public Boolean InsertarDetPedido(entDetPedido dPed)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarDetPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@idPedido", dPed.idPedido);
                cmd.Parameters.AddWithValue("@idProducto", dPed.idProducto.idProducto );
                cmd.Parameters.AddWithValue("@cantProducto", dPed.cantProducto );
                cmd.Parameters.AddWithValue("@precProducto" , dPed.precProducto );
                //cmd.Parameters.AddWithValue("@igv", dPed. );
                
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { inserta = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        #endregion metodos
    }
}
