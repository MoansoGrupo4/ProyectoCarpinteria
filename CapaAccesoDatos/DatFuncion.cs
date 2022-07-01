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
    public class DatFuncion
    {
        #region sigleton
        private static readonly DatFuncion _instancia = new DatFuncion();
        public static DatFuncion Instancia
        {
            get
            {
                return DatFuncion._instancia;
            }
        }
        #endregion singleton
        //listar funcion
        public List<EntFuncion> ListarFuncion()
        {
            SqlCommand cmd = null;
            List<EntFuncion> lista = new List<EntFuncion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarFuncion", cn);//nombre del procedimiento

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntFuncion func = new EntFuncion();     //objeto
                    func.CodFuncion = dr["CodFuncion"].ToString();
                    func.DesFuncion = dr["DesFuncion"].ToString();
                    lista.Add(func);
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
