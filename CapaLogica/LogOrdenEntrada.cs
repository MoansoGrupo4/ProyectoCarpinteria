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
    public class LogOrdenEntrada
    {
        private static readonly LogOrdenEntrada _instancia = new LogOrdenEntrada();
        public static LogOrdenEntrada Instancia
        {
            get { return LogOrdenEntrada._instancia; }
        }
        public List<EntOrdenEntrada> ListarOrdenEntrada()
        {
            return DatOrdenEntrada.Instancia.ListarOrdenEntrada();
        }

        public void InsertarOrdenEntrada(EntOrdenEntrada e)
        {
            DatOrdenEntrada.Instancia.InsertarOrdenEntrada(e);
        }

        public EntOrdenEntrada BuscarOrdenEntrada(string idOrdenEntrada)
        {
            return DatOrdenEntrada.Instancia.BuscarOrdenEntrada(idOrdenEntrada);
        }
    }
}
