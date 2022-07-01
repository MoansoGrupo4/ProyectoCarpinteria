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
    public class DatUnidadMedida
    {
        #region sigleton
        private static readonly DatUnidadMedida _instancia = new DatUnidadMedida();
        public static DatUnidadMedida Instancia
        {
            get
            {
                return DatUnidadMedida._instancia;
            }
        }
        #endregion singleton
        //listar funcion
        public List<EntUnidadMedida> ListarUnidadMedida()
        {
            SqlCommand cmd = null;
            List<EntUnidadMedida> lista = new List<EntUnidadMedida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarUnidadesMedida", cn);//nombre del procedimiento

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntUnidadMedida uni = new EntUnidadMedida();     //objeto
                    uni.CodUnidadMedida = dr["CodUnidadMedida"].ToString();
                    uni.DesUnidadMedida = dr["DesUnidadMedida"].ToString();
                    lista.Add(uni);
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
