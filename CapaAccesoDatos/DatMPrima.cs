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
    public class DatMPrima : Conexion
    {

        private static readonly DatMPrima _instancia = new DatMPrima();
        public static new DatMPrima Instancia
        {
            get
            {
                return DatMPrima._instancia;
            }
        }
        public EntMPrima BuscarClienteId(string Codigo)
        {
            SqlCommand cmd = null;
            EntMPrima Material = new EntMPrima();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarMPrima", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreMPrima", Codigo);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    /* 
                        public string Tam { get; set; }
                        public float DimensionA { get; set; }
                        public float DimensionB { get; set; }
                        public float DimensionC { get; set; }
                        public string UnidadMedida { get; set; }
                        public DateTime Ingreso { get; set; }
                        public float CostTotal { get; set; }
                        public bool Estado { get; set; }*/


                    Material.Codigo = Convert.ToString(dr["CodMPrima"]);
                    Material.Nombre = Convert.ToString(dr["NombreMPrima"]);
                    Material.Cantidad = Convert.ToInt32(dr["cantMPrima"]);
                    Material.CostUnitario = Convert.ToSingle(dr["CUMPrima"]);
                    Material.TipoMPrima = dr["Direccion"].ToString();
                    Material.Tam = dr["tamMPrima"].ToString();
                    Material.DimensionA = Convert.ToSingle(dr["DimAMPrima"]);
                    Material.DimensionB = Convert.ToSingle(dr["DimBMPrima"]);
                    Material.DimensionC = Convert.ToSingle(dr["DimCMPrima"]);

                    /*Material.Ciudad = dr["Ciudad"].ToString();
                    Material.idTipoCliente = Convert.ToInt16(dr["idTipoCliente"]);
                    Material.estCliente = Convert.ToBoolean(dr["estCliente"]);*/

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Material;
        }
    }
}
