using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;
namespace CapaLogica
{
    public class LogPedido
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogPedido _instancia = new LogPedido();
        //privado para evitar la instanciación directa
        public static LogPedido Instancia
        {
            get
            {
                return LogPedido._instancia;
            }
        }
        #endregion singleton
        public List<EntPedido> ListarPedido()
        {
            return DatPedido.Instancia.ListarPedido();
        }
        public String InsertarPedido(EntPedido Ped)
        {
            return DatPedido.Instancia.InsertarPedido(Ped);
        }
        public void InsertarDetPedido(EntDetPedido DetPed)
        {
            DatPedido.Instancia.InsertarDetPedido(DetPed);
        }
        public EntPedido BuscarIdPedido(int CodPedido)
        {
            return DatPedido.Instancia.BuscarIdPedido(CodPedido);
        }
    }
}
