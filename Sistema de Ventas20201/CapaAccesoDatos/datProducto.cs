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
    public class datProducto
    {
        #region singleton
        private static readonly datProducto _instancia = new datProducto();
        public static datProducto Instancia
        {
            get { return datProducto._instancia; }
        }
        #endregion singleton
        #region metodos
        public entProducto BuscarProductoId(int idProducto)
        {
            SqlCommand cmd = null;
            entProducto Prod = new entProducto();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spBuscaridProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmintidProducto", idProducto);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Prod.idProducto = Convert.ToInt16(dr["idProducto"]);
                    Prod.descProducto = Convert.ToString(dr["descProducto"]);
                    //Prod.idMarca = Convert.ToInt16(dr["idMarca"]);
                    Prod.precioVenta = Convert.ToDecimal(dr["precioVenta"]);
                    Prod.StkProducto = Convert.ToInt16(dr["Stock"]);
                    Prod.estProducto = Convert.ToBoolean(dr["estProducto"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Prod;

        }
        #endregion endMetodos
    }
}
