using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;
namespace CapaLogica
{
    public class LogOP
    {

        #region sigleton
        private static readonly LogOP _instancia = new LogOP();
        public static LogOP Instancia
        {
            get
            {
                return LogOP._instancia;
            }
        }
        #endregion singleton
        public List<EntOP> ListarOP()
        {
            return DatOP.Instancia.ListarOP();
        }
        public string InsertarOP(EntOP OP)
        {
            return DatOP.Instancia.InsertarOP(OP);
        }
    }
}
