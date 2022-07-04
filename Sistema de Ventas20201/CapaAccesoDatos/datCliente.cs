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
    public class datCliente
    {
        #region singleton
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia{
            get { return datCliente._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entCliente> ListarCliente(){
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try{
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.idCliente = Convert.ToInt16(dr["idCliente"]);
                    Cli.RazonSocial = dr["RazonSocial"].ToString();
                    Cli.Direccion = dr["Direccion"].ToString();
                    Cli.Ciudad = dr["Ciudad"].ToString();
                    Cli.idTipoCliente = Convert.ToInt16(dr["idTipoCliente"]);
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    lista.Add(Cli);
                }
            }catch (Exception e){
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean InsertarCliente(entCliente c)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@prmintidCliente", c.IdCliente);
                cmd.Parameters.AddWithValue("@prmstrRazonSocial", c.RazonSocial);
                cmd.Parameters.AddWithValue("@prmstrDireccionCliente", c.Direccion);
                cmd.Parameters.AddWithValue("@prmstrCiudad", c.Ciudad);
                cmd.Parameters.AddWithValue("@prmintidTipoCliente", c.idTipoCliente);
                cmd.Parameters.AddWithValue("@prmintidestCliente", c.estCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { inserta = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        //public entCliente BuscarCliente(string RazonSocialCliente)
        //{
        //    SqlCommand cmd = null;
        //    entCliente Cli = new entCliente();
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.conectar();
        //        cmd = new SqlCommand("spBuscarRazonSocialCliente", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@prmstrRazonSocialCliente", RazonSocialCliente);
        //        cn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            Cli.idCliente = Convert.ToInt16(dr["idCliente"]);
        //            Cli.RazonSocial = Convert.ToString(dr["RazonSocial"]);
        //            Cli.Direccion = dr["Direccion"].ToString();
        //            Cli.Ciudad = dr["Ciudad"].ToString();
        //            Cli.Ciudad = dr["estCiudad"].ToString();
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //    finally { cmd.Connection.Close(); }
        //    return Cli;
        //}
        public entCliente BuscarClienteId(int idCliente)
        {
            SqlCommand cmd = null;
            entCliente Cli = new entCliente();
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spBuscaridCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmintidCliente", idCliente);                
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cli.idCliente = Convert.ToInt16(dr["idCliente"]);
                    Cli.RazonSocial = Convert.ToString(dr["RazonSocial"]);
                    Cli.Direccion = dr["Direccion"].ToString();
                    Cli.Ciudad = dr["Ciudad"].ToString();
                    Cli.idTipoCliente = Convert.ToInt16(dr["idTipoCliente"]);
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                   
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Cli;
        }
        public Boolean EditarCliente(entCliente Cli)
        {
            
            SqlCommand cmd = null;
            Boolean Edito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spEditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;             
                cmd.Parameters.AddWithValue("@prmintidCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@prmstrRazonSocial", Cli.RazonSocial);
                cmd.Parameters.AddWithValue("@prmstrDireccionCliente", Cli.Direccion);
                cmd.Parameters.AddWithValue("@prmstrCiudad", Cli.Ciudad);
                cmd.Parameters.AddWithValue("@prmintidTipoCliente", Cli.idTipoCliente);
                
                cmd.Parameters.AddWithValue("@prmbolidestCliente", Cli.estCliente ? true : false);

                
                //cmd.Parameters.AddWithValue("@prmintidestCliente", Cli.estCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                //Console.Write(".............valor i= " + i);
                if (i>0) 
                { Edito = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Edito;
        }       
        //
        public Boolean InhabilitarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean Inhabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.conectar();
                cmd = new SqlCommand("spInhabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmintidCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@prmbolidestCliente", Cli.estCliente ? 1 : 0);
                //cmd.Parameters.AddWithValue("@sexo", checkboxSexoMasculino.checked ? "M" : "F");
                //cmd.Parameters.AddWithValue("@prmintidestCliente", Cli.estCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { Inhabilitar = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Inhabilitar;
        }       

        #endregion metodos
    }
    
}
