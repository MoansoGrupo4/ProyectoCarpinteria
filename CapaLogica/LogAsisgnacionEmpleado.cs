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
    public class LogAsisgnacionEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogAsisgnacionEmpleado _instancia = new LogAsisgnacionEmpleado();
        //privado para evitar la instanciación directa
        public static LogAsisgnacionEmpleado Instancia
        {
            get
            {
                return LogAsisgnacionEmpleado._instancia;
            }
        }
        #endregion singleton
        public List<EntAsignacionEmpleado> ListarAsignacion()
        {
            return DatAsignacionEmpleado.Instancia.ListarEmpleadosAsignados();
        }
        public Boolean InsertarCliente(EntAsignacionEmpleado asi)
        {
            return DatAsignacionEmpleado.Instancia.InsertarAsignacion(asi);
        }
    }
}
