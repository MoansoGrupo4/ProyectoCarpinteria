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
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogOrdenEntrada _instancia = new LogOrdenEntrada();
        //privado para evitar la instanciación directa
        public static LogOrdenEntrada Instancia
        {
            get
            {
                return LogOrdenEntrada._instancia;
            }
        }
        #endregion singleton
        public List<EntOrdenEntrada> ListarOrdenEntrada()
        {
            return DatOrdenEntrada.Instancia.ListarOrdenEntrada();
        }

        public void InsertarOrdenEntrada(EntOrdenEntrada e)
        {
            try
            {
                DatOrdenEntrada.Instancia.InsertarOrdenEntrada(e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntOrdenEntrada BuscarOrdenEntrada(string idOrdenEntrada)
        {
            return DatOrdenEntrada.Instancia.BuscarOrdenEntrada(idOrdenEntrada);
        }
    }
}
