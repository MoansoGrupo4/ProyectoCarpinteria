using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logProducto
    {
        #region singleton
        private static readonly logProducto _instancia = new logProducto();
        public static logProducto Instancia
        {
            get { return logProducto._instancia; }
        }
        #endregion singleton

        #region metodos
        //public List<entProducto> ListarProducto()
        //{
        //    try
        //    {
        //        return datProducto.Instancia.ListarProducto();
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public void InsertarCliente(entProducto prod)
        //{
        //    try
        //    {
        //        datProducto.Instancia.InsertarProducto(prod);
        //    }
        //    catch (Exception e)
        //    { throw e; }
        //}

        
        //public Boolean EditarProducto(entProducto Prod)
        //{
        //    try
        //    {
        //        return datProducto.Instancia.EditarProducto(Prod);
        //    }
        //    catch (Exception e) { throw e; }
        //}
        //public Boolean InhabilitarProducto(entProducto Prod)
        //{
        //    try
        //    {
        //        return datProducto.Instancia.InhabilitarProducto(Prod);
        //    }
        //    catch (Exception e) { throw e; }
        //}
        public entProducto BuscarProductoId(int idProducto)
        {
            try
            {
                return datProducto.Instancia.BuscarProductoId(idProducto);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos
    }
}

