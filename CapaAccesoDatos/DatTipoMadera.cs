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
    public class DatTipoMadera
    {

        #region sigleton
        private static readonly DatTipoMadera _instancia = new DatTipoMadera();
        public static DatTipoMadera Instancia
        {
            get
            {
                return DatTipoMadera._instancia;
            }
        }
        #endregion singleton

        public List<EntTipoMadera> ListarTipoMadera()
        {
            SqlCommand cmd = null;
            List<EntTipoMadera> lista = new List<EntTipoMadera>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTipoMadera", cn);//nombre del procedimiento

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoMadera tipma = new EntTipoMadera();     //objeto
                    tipma.CodTipoMadera = dr["CodTipoMadera"].ToString();
                    tipma.DesTipoMadera = dr["DesTipoMadera"].ToString();
                    lista.Add(tipma);
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
