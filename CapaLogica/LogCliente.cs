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
    public class LogCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogCliente _instancia = new LogCliente();
        //privado para evitar la instanciación directa
        public static LogCliente Instancia
        {
            get
            {
                return LogCliente._instancia;
            }
        }
        #endregion singleton
        public List<EntCliente> ListarCliente()
        {
            return DatCliente.Instancia.ListarCliente();
        }
        public Boolean InsertarCliente(EntCliente Cli)
        {
            return DatCliente.Instancia.InsertarCliente(Cli);
        }
        public Boolean EditarCliente(EntCliente Cli)
        {
            return DatCliente.Instancia.EditarCliente(Cli);
        }
        public Boolean DeshabilitarCliente(EntCliente Cli)
        {
            return DatCliente.Instancia.DeshabilitarCliente(Cli);
        }
        public DataTable BuscarCliente(string Cliente)
        {
            return DatCliente.Instancia.BuscarCliente(Cliente);
        }
    }
}
