using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LogNuevoPedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogNuevoPedido _instancia = new LogNuevoPedido();
        //privado para evitar la instanciación directa
        public static LogNuevoPedido Instancia
        {
            get
            {
                return LogNuevoPedido._instancia;
            }
        }
        #endregion singleton

        public List<EntNuevoPedido> ListarNPedido()
        {
            return DatNuevoPedido.Instancia.ListaNPedido();
        }
        public void InsertarNPedido(EntNuevoPedido t)
        {
            try
            {
                DatNuevoPedido.Instancia.InsertarNPedido(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
