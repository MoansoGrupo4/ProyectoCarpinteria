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
    public class DatCliente:Conexion
    {
        private static readonly DatCliente _instancia = new DatCliente();
        public static new DatCliente Instancia
        {
            get
            {
                return DatCliente._instancia;
            }
        }
        public EntCliente BuscarClienteNom(string CLiente)
        {
            SqlCommand cmd = null;
            EntCliente Cli = new EntCliente();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCliente", CLiente);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cli.Codigo = Convert.ToInt32(dr["CodCLiente"]);
                    Cli.Cliente = dr["NombreCliente"].ToString();
                    Cli.Razon_Social = dr["RazonSocialCliente"].ToString();
                    Cli.Direccion = dr["dirCliente"].ToString();
                    Cli.Registro = Convert.ToDateTime(dr["FechaRegCliente"]);
                    Cli.Telefono = Convert.ToInt32(dr["telefono"]);
                    Cli.Estado = Convert.ToBoolean(dr["EstadoCliente"]);

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Cli;
        }
        //LISRAR EMPLEADO
        public List<EntCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<EntCliente> lista = new List<EntCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCLiente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntCliente Cli = new EntCliente();
                    Cli.Codigo = Convert.ToInt32(dr["CodCLiente"]);
                    Cli.Cliente = dr["NombreCliente"].ToString();
                    Cli.Razon_Social = dr["RazonSocialCliente"].ToString();
                    Cli.Direccion = dr["dirCliente"].ToString();
                    Cli.Registro = Convert.ToDateTime(dr["FechaRegCliente"]);
                    Cli.Telefono = Convert.ToInt32(dr["telefono"]);
                    Cli.Estado = Convert.ToBoolean(dr["EstadoCliente"]);
                    //   Emp.contra = dr["Password"].ToString();
                    lista.Add(Cli);
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
        //Inserta Cliente
        public Boolean InsertarCliente(EntCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCLiente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
               // cmd.Parameters.AddWithValue("@CodCLiente", Cli.Codigo);
                cmd.Parameters.AddWithValue("@NombreCliente", Cli.Cliente);
                cmd.Parameters.AddWithValue("@RazonSocialCliente", Cli.Razon_Social);
                cmd.Parameters.AddWithValue("@dirCliente", Cli.Direccion);
                cmd.Parameters.AddWithValue("@FechaRegCliente", Cli.Registro);
                cmd.Parameters.AddWithValue("@telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@EstadoCliente", Cli.Estado);

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
        //EditaCliente
        public Boolean EditarCliente(EntCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodCLiente", Cli.Codigo);
                cmd.Parameters.AddWithValue("@NombreCliente", Cli.Cliente);
                cmd.Parameters.AddWithValue("@RazonSocialCliente", Cli.Razon_Social);
                cmd.Parameters.AddWithValue("@dirCliente", Cli.Direccion);
                cmd.Parameters.AddWithValue("@FechaRegCliente", Cli.Registro);
                cmd.Parameters.AddWithValue("@telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@EstadoCliente", Cli.Estado);
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
        public Boolean DeshabilitarCliente(EntCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodCLiente", Cli.Codigo);
                cmd.Parameters.AddWithValue("@EstadoCliente", Cli.Estado);
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
        
        //buscar CLiente
        public DataTable BuscarCliente(string Cliente)
        {
            EntCliente Emp = new EntCliente();
            DataTable dt;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCliente", Cliente);
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
    }
}
