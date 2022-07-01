using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LogFuncion
    {
        #region sigleton

        private static readonly LogFuncion _instancia = new LogFuncion();
        //privado para evitar la instanciación directa
        public static LogFuncion Instancia
        {
            get
            {
                return LogFuncion._instancia;
            }
        }
        #endregion singleton

        public List<EntFuncion> ListarFuncion()
        {
            return DatFuncion.Instancia.ListarFuncion();
        }
    }
}
