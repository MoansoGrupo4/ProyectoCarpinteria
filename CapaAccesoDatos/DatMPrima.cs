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
    public class DatMPrima : Conexion
    {

        private static readonly DatMPrima _instancia = new DatMPrima();
        public static new DatMPrima Instancia
        {
            get
            {
                return DatMPrima._instancia;
            }
        }
        public DataTable BuscarMateriaP(string Nombre)
        {
            DataTable dt;
            SqlCommand cmd = null;
            
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarMPrima", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreMPrima", Nombre);
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
            finally { cmd.Connection.Close(); }
            return dt;
        }
        public EntMPrima BuscarMaterial(string Codigo)
        {
            SqlCommand cmd = null;
            EntMPrima Material = new EntMPrima();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarMPrima", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreMPrima", Codigo);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   Material.CodigoMP = Convert.ToString(dr["CodMPrima"]);
                    Material.Nombre = Convert.ToString(dr["NombreMPrima"]);
                    Material.Cantidad = Convert.ToInt32(dr["cantMPrima"]);
                    Material.CostUnitario = Convert.ToDecimal(dr["CUMPrima"]);
                    Material.TipoMPrima = dr["TipogMPrima"].ToString();
                    Material.Tam = dr["tamMPrima"].ToString();
                    Material.DimensionA = Convert.ToSingle(dr["DimAMPrima"]);
                    Material.DimensionB = Convert.ToSingle(dr["DimBMPrima"]);
                    Material.DimensionC = Convert.ToSingle(dr["DimCMPrima"]);
                    Material.UnidadMedida = dr["MedidaMPrima"].ToString();
                    Material.Ingreso = Convert.ToDateTime(dr["fechaIngresMPrima"]);
                    Material.CostTotal = Convert.ToDecimal(dr["CTMPrima"]);
                    Material.Estado = Convert.ToBoolean(dr["EstMPrima"]);

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Material;
        }
        public List<EntMPrima> ListarMaterial()
        {
            SqlCommand cmd = null;
            List<EntMPrima> lista = new List<EntMPrima>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarMPrima", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntMPrima Material = new EntMPrima();
                    Material.CodigoMP = Convert.ToString(dr["CodMPrima"]);
                    Material.Nombre = Convert.ToString(dr["NombreMPrima"]);
                    Material.Cantidad = Convert.ToInt32(dr["cantMPrima"]);
                    Material.CostUnitario = Convert.ToDecimal(dr["CUMPrima"]);
                    Material.TipoMPrima = dr["TipogMPrima"].ToString();
                    Material.Tam = dr["tamMPrima"].ToString();
                    Material.DimensionA = Convert.ToSingle(dr["DimAMPrima"]);
                    Material.DimensionB = Convert.ToSingle(dr["DimBMPrima"]);
                    Material.DimensionC = Convert.ToSingle(dr["DimCMPrima"]);
                    Material.UnidadMedida = dr["MedidaMPrima"].ToString();
                    Material.Ingreso = Convert.ToDateTime(dr["fechaIngresMPrima"]);
                    Material.CostTotal = Convert.ToDecimal(dr["CTMPrima"]);
                    Material.Estado = Convert.ToBoolean(dr["EstMPrima"]);
                    lista.Add(Material);
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
        public Boolean InsertarMaterial(EntMPrima Material)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMPrima", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodMPrima", Material.CodigoMP);
                cmd.Parameters.AddWithValue("@NombreMPrima", Material.Nombre);
                cmd.Parameters.AddWithValue("@cantMPrima", Material.Cantidad);
                cmd.Parameters.AddWithValue("@CUMPrima", Material.CostUnitario);
                cmd.Parameters.AddWithValue("@TipogMPrima", Material.TipoMPrima);
                cmd.Parameters.AddWithValue("@tamMPrima", Material.Tam);
                cmd.Parameters.AddWithValue("@DimAMPrima", Material.DimensionA);
                cmd.Parameters.AddWithValue("@DimBMPrima", Material.DimensionB);
                cmd.Parameters.AddWithValue("@DimCMPrima", Material.DimensionC);
                cmd.Parameters.AddWithValue("@MedidaMPrima", Material.UnidadMedida);
                cmd.Parameters.AddWithValue("@fechaIngresMPrima", Material.Ingreso);
                cmd.Parameters.AddWithValue("@CTMPrima", Material.CostTotal);
                cmd.Parameters.AddWithValue("@EstMPrima", Material.Estado);
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

        //Edita MATERIAL
        public Boolean EditarMaterial(EntMPrima Material)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMPrima", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodMPrima", Material.CodigoMP);
                cmd.Parameters.AddWithValue("@NombreMPrima", Material.Nombre);
                cmd.Parameters.AddWithValue("@cantMPrima", Material.Cantidad);
                cmd.Parameters.AddWithValue("@CUMPrima", Material.CostUnitario);
                cmd.Parameters.AddWithValue("@TipogMPrima", Material.TipoMPrima);
                cmd.Parameters.AddWithValue("@tamMPrima", Material.Tam);
                cmd.Parameters.AddWithValue("@DimAMPrima", Material.DimensionA);
                cmd.Parameters.AddWithValue("@DimBMPrima", Material.DimensionB);
                cmd.Parameters.AddWithValue("@DimCMPrima", Material.DimensionC);
                cmd.Parameters.AddWithValue("@MedidaMPrima", Material.UnidadMedida);
                cmd.Parameters.AddWithValue("@fechaIngresMPrima", Material.Ingreso);
                cmd.Parameters.AddWithValue("@CTMPrima", Material.CostTotal);
                cmd.Parameters.AddWithValue("@EstMPrima", Material.Estado);
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

        //DESHABILITAR MATERIAL

        public Boolean DeshabilitarMaterial(EntMPrima material)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMPrima", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodMPrima", material.CodigoMP);
                cmd.Parameters.AddWithValue("@EstMPrima", material.Estado);
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
