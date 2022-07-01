using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class LogTipoMadera
    {
        #region sigleton

        private static readonly LogTipoMadera _instancia = new LogTipoMadera();
        //privado para evitar la instanciación directa
        public static LogTipoMadera Instancia
        {
            get
            {
                return LogTipoMadera._instancia;
            }
        }
        #endregion singleton

        public List<EntTipoMadera> ListarTipoMadera()
        {
            return DatTipoMadera.Instancia.ListarTipoMadera();
        }
    }
}
