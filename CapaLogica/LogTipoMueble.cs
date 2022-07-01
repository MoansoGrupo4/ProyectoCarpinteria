using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class LogTipoMueble
    {
        #region sigleton

        private static readonly LogTipoMueble _instancia = new LogTipoMueble();
        //privado para evitar la instanciación directa
        public static LogTipoMueble Instancia
        {
            get
            {
                return LogTipoMueble._instancia;
            }
        }
        #endregion singleton

        public List<EntTipoMueble> ListarTipoMueble()
        {
            return DatTipoMueble.Instancia.ListarTipoMueble();
        }
    }
}
