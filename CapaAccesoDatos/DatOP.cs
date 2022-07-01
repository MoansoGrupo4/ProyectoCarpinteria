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
                    //----Ped.idCliente = new entCliente();
                    EntCliente Cli = new EntCliente();
                    OP.CodOP = dr["CodOP"].ToString();
                    OP.CodCliente = Convert.ToInt32(dr["CodCLiente"]);
                    OP.CodPedido = dr["CodPedido"].ToString();
                    OP.CodModelo = dr["CodModelo"].ToString();
                    OP.EstOP = Convert.ToBoolean(dr["EstOP"]);
                    OP.InicioOP = Convert.ToDateTime(dr["InicioOP"]);

                    //----Ped.idCliente.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.Codigo = Convert.ToInt32(dr["idCliente"]);
                    Cli.Razon_Social = dr["RazonSocial"].ToString();


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
