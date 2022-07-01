using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<EntPedido> ListarPedido()v que fue mano
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
                    Ped.TotPedido = Convert.ToDouble(dr["TotPedido"]);
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
    }
}
