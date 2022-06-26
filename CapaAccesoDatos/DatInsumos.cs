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
    public class DatInsumos:Conexion
    {
    
        private static readonly DatInsumos _instancia = new DatInsumos();
        public static new DatInsumos Instancia
        {
            get
            {
                return DatInsumos._instancia;
            }
        }
        //BUSCAR ISNUMOS
        public DataTable BuscarInsumos(string Producto)
        {
            EntInsumos Emp = new EntInsumos();
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBucarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NomInsumo", Producto);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
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
        //LISTAR INSUMOS
        public List<EntInsumos> ListarInsumo()
        {
            SqlCommand cmd = null;
            List<EntInsumos> lista = new List<EntInsumos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntInsumos Ins = new EntInsumos();
                    Ins.Codigo = dr["CodInsumo"].ToString();
                    Ins.Categoria = Convert.ToChar(dr["CategoriaInsumo"]);
                    Ins.Producto = Convert.ToChar(dr["NomInsumo"]);
                    Ins.cantidad = Convert.ToInt32(dr["CantProducto"]);
                    Ins.FechaEmision = Convert.ToDateTime(dr["EmisionInsumo"]);
                    Ins.CUnitario = Convert.ToDouble(dr["CUnitarioInsumo"]);
                    Ins.FechaVencimiento = Convert.ToDateTime(dr["FechaEmpleado"]);
                    Ins.CTotal = Convert.ToDouble(dr["CTInsumo"]);
                    Ins.EstInsumo = Convert.ToBoolean(dr["estEmpleado"]);
                    lista.Add(Ins);
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
        //INSERTAR INSUMOS
        public Boolean InsertarInsumo(EntInsumos Ins)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodInsumo", Ins.Codigo);
                cmd.Parameters.AddWithValue("@CategoriaInsumo", Ins.Categoria);
                cmd.Parameters.AddWithValue("@NomInsumo", Ins.Producto);
                cmd.Parameters.AddWithValue("@CantInsumo", Ins.cantidad);
                cmd.Parameters.AddWithValue("@EmisionInsumo", Ins.FechaEmision);
                cmd.Parameters.AddWithValue("@CUnitarioInsumo", Ins.CUnitario);
                cmd.Parameters.AddWithValue("@VencImiento", Ins.FechaVencimiento);
                cmd.Parameters.AddWithValue("@CTInsumo", Ins.CTotal);
                cmd.Parameters.AddWithValue("@EstInsumo", Ins.EstInsumo);
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
        //EDITAR INSUMOS
        public Boolean EditarInsumo(EntInsumos Ins)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodInsumo", Ins.Codigo);
                cmd.Parameters.AddWithValue("@CategoriaInsumo", Ins.Categoria);
                cmd.Parameters.AddWithValue("@NomInsumo", Ins.Producto);
                cmd.Parameters.AddWithValue("@CantInsumo", Ins.cantidad);
                cmd.Parameters.AddWithValue("@EmisionInsumo", Ins.FechaEmision);
                cmd.Parameters.AddWithValue("@CUnitarioInsumo", Ins.CUnitario);
                cmd.Parameters.AddWithValue("@VencImiento", Ins.FechaVencimiento);
                cmd.Parameters.AddWithValue("@CTInsumo", Ins.CTotal);
                cmd.Parameters.AddWithValue("@EstInsumo", Ins.EstInsumo);
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
        //InHabilita hinsumos
        public Boolean DeshabilitarInsumo(EntInsumos Ins)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodCLiente", Ins.Codigo);
                cmd.Parameters.AddWithValue("@estEmpleado", Ins.EstInsumo);
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
    }
}
