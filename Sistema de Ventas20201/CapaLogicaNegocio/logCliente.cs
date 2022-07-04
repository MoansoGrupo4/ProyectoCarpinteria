using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logCliente
    {
        #region singleton
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia
        {
            get { return logCliente._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entCliente> ListarCliente()
        {
            try
            {
                return datCliente.Instancia.ListarCliente();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void  InsertarCliente(entCliente c)
        {
            try
            {
                datCliente.Instancia.InsertarCliente(c);
            }
            catch (Exception e)
            { throw e; }
        }

        //public entCliente BuscarCliente(String RazonSocialCliente)
        //{
        //    try
        //    {
        //        return datCliente.Instancia.BuscarCliente(RazonSocialCliente);
        //    }
        //    catch (Exception e) { throw e; }
        //}
        public Boolean EditarCliente(entCliente Cli)
        {
            try
            {
                return datCliente.Instancia.EditarCliente(Cli);
            }
            catch (Exception e) { throw e; }
        }
        public Boolean InhabilitarCliente(entCliente Cli)
        {
            try
            {
                return datCliente.Instancia.InhabilitarCliente(Cli);
            }
            catch (Exception e) { throw e; }
        }
        public entCliente BuscarClienteId(int idCliente)
        {
            try
            {
                return datCliente.Instancia.BuscarClienteId(idCliente);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos

    }
}
