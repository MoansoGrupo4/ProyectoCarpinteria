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
    internal class DatTipoMueble
    {

        #region sigleton
        private static readonly DatTipoMueble _instancia = new DatTipoMueble();
        public static DatTipoMueble Instancia
        {
            get
            {
                return DatTipoMueble._instancia;
            }
        }
        #endregion singleton

        public List<EntTipoMueble> ListarTipoMueble()
        {
            SqlCommand cmd = null;
            List<EntTipoMueble> lista = new List<EntTipoMueble>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTipoMueble", cn);//nombre del procedimiento

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoMueble tipmu = new EntTipoMueble();     //objeto
                    tipmu.CodTipoMueble = dr["CodTipoMueble"].ToString();
                    tipmu.DesTipoMueble = dr["DesTipoMueble"].ToString();
                    lista.Add(tipmu);
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
    }
}
