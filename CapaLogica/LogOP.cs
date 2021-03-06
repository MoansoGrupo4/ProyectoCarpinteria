using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class LogOP
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogOP _instancia = new LogOP();
        //privado para evitar la instanciación directa
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
        public EntMPrima BuscarMaterial(string Codigo)
        {
            return DatMPrima.Instancia.BuscarMaterial(Codigo);
        }
        public String InsertarOP(EntOP OP)
        {
            return DatOP.Instancia.InsertarOP(OP);
        }
    }
}
