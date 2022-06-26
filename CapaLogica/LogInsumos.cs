using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
namespace CapaLogica
{
    public class LogInsumos
    {
        public DataTable BuscarInsumo(string Producto)
        {
            return DatInsumos.Instancia.BuscarInsumo(Producto);
        }
        public List<EntInsumos> ListarInsumo()
        {
            return DatInsumos.Instancia.ListarInsumo();
        }
    }
}
