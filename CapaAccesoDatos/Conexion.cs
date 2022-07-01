﻿using System;
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
            cn.ConnectionString = "Data Source=LAPTOP-BNHKM586; Initial Catalog = CARPINTERIA;" +//"User ID=sa;Password = 123";
                                "Integrated Security=true";
            return cn;
        }

    }
}
//esto es una prueba del git hub 