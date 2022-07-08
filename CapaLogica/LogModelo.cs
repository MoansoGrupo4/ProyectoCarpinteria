using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class LogModelo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogModelo _instancia = new LogModelo();
        //privado para evitar la instanciación directa
        public static LogModelo Instancia
        {
            get
            {
                return LogModelo._instancia;
            }
        }
        #endregion singleton

        public List<EntModelo> ListarModelo()
        {
            return DatModelo.Instancia.ListarModelo();
        }
        public Boolean InsertarModelo(EntModelo mod)
        {
            return DatModelo.Instancia.InsertarModelo(mod);
        }
        public Boolean EditarModelo(EntModelo mod)
        {
            return DatModelo.Instancia.EditarModelo(mod);
        }
        public Boolean DeshabilitarModelo(EntModelo mod)
        {
            return DatModelo.Instancia.DeshabilitarModelo(mod);
        }
        public DataTable BuscarModelo(string Modelo)
        {
            return DatModelo.Instancia.BuscarModelo(Modelo);
        }
        public EntModelo BuscarCódigoModelo(string Codigo)
        {
            return DatModelo.Instancia.BuscarCódigoModelo(Codigo);
        }
    }
}
