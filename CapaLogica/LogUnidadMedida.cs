using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    internal class LogUnidadMedida
    {
        #region sigleton

        private static readonly LogUnidadMedida _instancia = new LogUnidadMedida();
        //privado para evitar la instanciación directa
        public static LogUnidadMedida Instancia
        {
            get
            {
                return LogUnidadMedida._instancia;
            }
        }
        #endregion singleton

        public List<EntUnidadMedida> ListarUnidadMedida()
        {
            return DatUnidadMedida.Instancia.ListarUnidadMedida();
        }
    }
}
