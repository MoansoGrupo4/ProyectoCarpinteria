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
    public class DatModelo
    {
        private static readonly DatModelo _instancia = new DatModelo();
        public static DatModelo Instancia
        {
            get
            {
                return DatModelo._instancia;
            }
        }

        //Listar Modelo
        public List<EntModelo> ListarModelo()
        {
            SqlCommand cmd = null;
            List<EntModelo> lista = new List<EntModelo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarModelo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntModelo mod = new EntModelo();
                    mod.CodModelo = dr["CodModelo"].ToString();
                    mod.DesModelo = dr["DesModelo"].ToString();
                    mod.CodTipoMadera = dr["CodTipoMadera"].ToString();
                    mod.ColorModelo = dr["ColorModelo"].ToString();
                    mod.PrecioVentaPU = Convert.ToSingle(dr["PrecioVentaPU"]);
                    mod.PrecioVentaPM = Convert.ToSingle(dr["PrecioVentaPM"]);
                    mod.CodTipoMueble = dr["CodTipoMueble"].ToString();
                    mod.EstadoModelo = Convert.ToBoolean(dr["EstadoModelo"]);
                    //   Emp.contra = dr["Password"].ToString();
                    lista.Add(mod);
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

        //Inserta Modelo
        public Boolean InsertarModelo(EntModelo mod)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarModelo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodModelo", mod.CodModelo);
                cmd.Parameters.AddWithValue("@DesModelo", mod.DesModelo);
                cmd.Parameters.AddWithValue("@CodTipoMadera", mod.CodTipoMadera);
                cmd.Parameters.AddWithValue("@ColorModelo", mod.ColorModelo);
                cmd.Parameters.AddWithValue("@PrecioVentaPU", mod.PrecioVentaPU);
                cmd.Parameters.AddWithValue("@PrecioVentaPM", mod.PrecioVentaPM);
                cmd.Parameters.AddWithValue("@CodTipoMueble", mod.CodTipoMueble);
                cmd.Parameters.AddWithValue("@EstadoModelo", mod.EstadoModelo);
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

        //EditaModelo
        public Boolean EditarModelo(EntModelo mod)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarModelo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodModelo", mod.CodModelo);
                cmd.Parameters.AddWithValue("@DesModelo", mod.DesModelo);
                cmd.Parameters.AddWithValue("@CodTipoMadera", mod.CodTipoMadera);
                cmd.Parameters.AddWithValue("@ColorModelo", mod.ColorModelo);
                cmd.Parameters.AddWithValue("@PrecioVentaPU", mod.PrecioVentaPU);
                cmd.Parameters.AddWithValue("@PrecioVentaPM", mod.PrecioVentaPM);
                cmd.Parameters.AddWithValue("@CodTipoMueble", mod.CodTipoMueble);
                cmd.Parameters.AddWithValue("@EstadoModelo", mod.EstadoModelo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaModelo
        public Boolean DeshabilitarModelo(EntModelo mod)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarModelo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodModelo", mod.CodModelo);
                cmd.Parameters.AddWithValue("@EstadoModelo", mod.EstadoModelo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        //buscar Modelo
        public DataTable BuscarModelo(string Modelo)
        {
            EntModelo mod = new EntModelo();
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarModelo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DesModelo", Modelo);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return dt;
        }
    }
}
