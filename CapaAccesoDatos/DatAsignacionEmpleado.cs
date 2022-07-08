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
    public class DatAsignacionEmpleado
    {
        #region sigleton
        private static readonly DatAsignacionEmpleado _instancia = new DatAsignacionEmpleado();
        public static DatAsignacionEmpleado Instancia
        {
            get
            {
                return DatAsignacionEmpleado._instancia;
            }
        }
        #endregion singleton

        public List<EntAsignacionEmpleado> ListarEmpleadosAsignados()
        {
            SqlCommand cmd = null;
            List<EntAsignacionEmpleado> lista = new List<EntAsignacionEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarAsignacionEmpleado", cn);//nombre del procedimiento

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntAsignacionEmpleado asi = new EntAsignacionEmpleado();     //objeto
                    asi.IdGrupo = dr["IdGrupo"].ToString();
                    asi.Nombre = dr["Nombre"].ToString();
                    asi.Cargo = dr["Cargo"].ToString();
                    asi.IdEmpleado = dr["IdEmpleado"].ToString();
                    asi.IdOp = dr["IdOp"].ToString();
                    asi.HorasTrabajo = Convert.ToInt32(dr["HorasTrabajo"].ToString());
                    asi.PagoHora = Convert.ToSingle(dr["PagoHora"].ToString());
                    asi.PagoTotal = Convert.ToSingle(dr["PagoTotal"].ToString());
                    lista.Add(asi);
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
        //agregar :v
        public Boolean InsertarAsignacion(EntAsignacionEmpleado asi)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarAsignacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdGrupo", asi.IdGrupo);
                cmd.Parameters.AddWithValue("@Nombre", asi.Nombre);
                cmd.Parameters.AddWithValue("@Cargo", asi.Cargo);
                cmd.Parameters.AddWithValue("@IdEmpleado", asi.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdOp", asi.IdOp);
                cmd.Parameters.AddWithValue("@HorasTrabajo", asi.HorasTrabajo);
                cmd.Parameters.AddWithValue("@PagoHora", asi.PagoHora);
                cmd.Parameters.AddWithValue("@PagoTotal", asi.PagoTotal);
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
            finally { cmd.Connection.Close(); }
            return inserta;
        }

    }
}
