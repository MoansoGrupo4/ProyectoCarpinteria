using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CapaAccesoDatos
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            //yisus
           //cn.ConnectionString = "Data Source=LAPTOP-BNHKM586; Initial Catalog = CARPINTERIA; Integrated Security=true";
            
            //elvissad
            cn.ConnectionString = "Data Source=DESKTOP-I5OBAPS; Initial Catalog = CARPINTERIA;Integrated Security=true";
            
            //Gilmer
           // cn.ConnectionString = "Data Source=DESKTOP-3AUK8AV; Initial Catalog = BCARPINTERIA; Integrated Security=true";
            return cn;
        }

    }
}
