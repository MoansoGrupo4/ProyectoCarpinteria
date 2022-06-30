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
    public class LogMPrima
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogMPrima _instancia = new LogMPrima();
        //privado para evitar la instanciación directa
        public static LogMPrima Instancia
        {
            get
            {
                return LogMPrima._instancia;
            }
        }
        #endregion singleton
        public EntMPrima BuscarMaterial(string Codigo)
        {
            return DatMPrima.Instancia.BuscarMaterial(Codigo);
        }
        public List<EntMPrima> ListarMaterial()
        {
            return DatMPrima.Instancia.ListarMaterial();
        }
        public Boolean InsertarMaterial(EntMPrima Material)
        {
            return DatMPrima.Instancia.InsertarMaterial(Material);
        }
        public Boolean EditarMaterial(EntMPrima Material)
        {
            return DatMPrima.Instancia.EditarMaterial(Material);
        }
        public Boolean DeshabilitarMaterial(EntMPrima material)
        {
            return DatMPrima.Instancia.DeshabilitarMaterial(material);

        }
    }
}
