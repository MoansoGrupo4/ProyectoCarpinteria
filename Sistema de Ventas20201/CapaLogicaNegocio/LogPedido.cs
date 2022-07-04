using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logPedido
    {
      
            #region singleton
            private static readonly logPedido _instancia = new logPedido();
            public static logPedido Instancia
            {
                get { return logPedido._instancia; }
            }
            #endregion singleton

            #region metodos
            public List<entPedido> ListarPedido()
            {
                try
                {
                    return datPedido.Instancia.ListarPedido();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        public int InsertarPedido(entPedido Ped)
        {
            int a;
            try
            {
                 a=datPedido.Instancia.InsertarPedido(Ped);
            }
            catch (Exception e)
            { throw e; }

            return a;
        }
        public void InsertarDetPedido(entDetPedido dPed)
        {
            try
            {
                datPedido.Instancia.InsertarDetPedido(dPed);
            }
            catch (Exception e)
            { throw e; }
        }


        #endregion metodos
    }
}
