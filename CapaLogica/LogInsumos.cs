using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;
using System.Data;
using System.Data.SqlClient;
namespace CapaLogica
{
    public class LogInsumos
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogInsumos _instancia = new LogInsumos();
        //privado para evitar la instanciación directa
        public static LogInsumos Instancia
        {
            get
            {
                return LogInsumos._instancia;
            }
        }
        #endregion singleton
        public DataTable BuscarInsumos(string Producto)
        {
            return DatInsumos.Instancia.BuscarInsumos(Producto);
        }
        public List<EntInsumos> ListarInsumo()
        {
            return DatInsumos.Instancia.ListarInsumo();
        }
        public Boolean InsertarInsumo(EntInsumos Ins)
        {
            return DatInsumos.Instancia.InsertarInsumo(Ins);
        }
        public Boolean EditarInsumo(EntInsumos Ins)
        {
            return DatInsumos.Instancia.EditarInsumo(Ins);
        }
        public Boolean DeshabilitarInsumo(EntInsumos Ins)
        {
            return DatInsumos.Instancia.DeshabilitarInsumo(Ins);

        }
    }
}
