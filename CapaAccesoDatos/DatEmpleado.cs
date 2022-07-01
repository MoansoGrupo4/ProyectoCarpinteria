using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos{
    public class DatEmpleado : Conexion{
        private static readonly DatEmpleado _instancia = new DatEmpleado();
        public static new DatEmpleado Instancia
        {
            get
            {
                return DatEmpleado._instancia;
            }
        }
        public bool Login(int Usuario, string Contra)
        {
            SqlCommand cmd = null;
            EntEmpleado Var = new EntEmpleado(); 
            try
            {
                using (var connection = Conectar())
                {
                    connection.Open();
                    using (cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "select * from EMPLEADO where IdEmpleado = @Usuario and Password = @Contra ";
                        cmd.Parameters.AddWithValue("@Usuario", Usuario);
                        cmd.Parameters.AddWithValue("@Contra", Contra);
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            return true;
                        }
                        else
                            return false;
                    }
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

        }
        // BUSCAR EMPLEADO
       public DataTable BuscarEmpleados(string NomEmpleado)
        {
            EntEmpleado Emp = new EntEmpleado();
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                 cmd = new SqlCommand("spBucarEmpleado",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomEmpleado", NomEmpleado);
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
       public EntEmpleado BuscarEmpleado(string NomEmpleado)
        {
            SqlCommand cmd = null;
            EntEmpleado Emp = new EntEmpleado();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBucarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomEmpleado", NomEmpleado);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Emp.IdEmpleado = dr["IdEmpleado"].ToString();
                    Emp.NomEmpleado = dr["NomEmpleado"].ToString();
                    Emp.FuncionEmpleado = dr["FuncionEmpleado"].ToString();
                    Emp.DirEmpleado = dr["DirEmpleado"].ToString();
                    Emp.DNIEmpleado = Convert.ToInt32(dr["DNIEmpleado"]);
                    Emp.EdadEmpleado = Convert.ToInt32(dr["EdadEmpleado"]);
                    Emp.FechaEmpleado = Convert.ToDateTime(dr["FechaEmpleado"]);
                    Emp.numero = Convert.ToInt32(dr["numero"]);
                    Emp.estEmpleado = Convert.ToBoolean(dr["estEmpleado"]);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return Emp;
        
    }
    //LISRAR EMPLEADO
        public List<EntEmpleado> ListarEmpleado()
        {
            SqlCommand cmd = null;
            List<EntEmpleado> lista = new List<EntEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntEmpleado Emp = new EntEmpleado();
                    Emp.IdEmpleado = dr["IdEmpleado"].ToString();
                    Emp.NomEmpleado = dr["NomEmpleado"].ToString();
                    Emp.FuncionEmpleado = dr["FuncionEmpleado"].ToString();
                    Emp.DirEmpleado = dr["DirEmpleado"].ToString();
                    Emp.DNIEmpleado = Convert.ToInt32(dr["DNIEmpleado"]);
                    Emp.EdadEmpleado = Convert.ToInt32(dr["EdadEmpleado"]);
                    Emp.FechaEmpleado = Convert.ToDateTime(dr["FechaEmpleado"]);
                    Emp.numero = Convert.ToInt32(dr["numero"]);
                    Emp.estEmpleado = Convert.ToBoolean(dr["estEmpleado"]);
                 //   Emp.contra = dr["Password"].ToString();
                    lista.Add(Emp);
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
    //Inserta Empleado
        public Boolean InsertarEmpleado(EntEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", Emp.IdEmpleado);
                cmd.Parameters.AddWithValue("@NomEmpleado", Emp.NomEmpleado);
                cmd.Parameters.AddWithValue("@FuncionEmpleado", Emp.FuncionEmpleado);
                cmd.Parameters.AddWithValue("@DirEmpleado", Emp.DirEmpleado);
                cmd.Parameters.AddWithValue("@DNIEmpleado", Emp.DNIEmpleado);
                cmd.Parameters.AddWithValue("@EdadEmpleado", Emp.EdadEmpleado);
                cmd.Parameters.AddWithValue("@FechaEmpleado", Emp.FechaEmpleado);
                cmd.Parameters.AddWithValue("@numero", Emp.numero);
                cmd.Parameters.AddWithValue("@estEmpleado", Emp.estEmpleado);
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

       //Edita Empleado
        public Boolean EditarEmpleado(EntEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", Emp.IdEmpleado);
                cmd.Parameters.AddWithValue("@NomEmpleado", Emp.NomEmpleado);
                cmd.Parameters.AddWithValue("@FuncionEmpleado", Emp.FuncionEmpleado);
                cmd.Parameters.AddWithValue("@DirEmpleado", Emp.DirEmpleado);
                cmd.Parameters.AddWithValue("@DNIEmpleado", Emp.DNIEmpleado);
                cmd.Parameters.AddWithValue("@EdadEmpleado", Emp.EdadEmpleado);
                cmd.Parameters.AddWithValue("@FechaEmpleado", Emp.FechaEmpleado);
                cmd.Parameters.AddWithValue("@numero", Emp.numero);
                cmd.Parameters.AddWithValue("@estEmpleado", Emp.estEmpleado);
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

        //deshabilitaCliente

        public Boolean DeshabilitarEmpleado(EntEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", Emp.IdEmpleado);
                cmd.Parameters.AddWithValue("@estEmpleado", Emp.estEmpleado);
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