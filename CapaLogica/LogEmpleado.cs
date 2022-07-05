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
    public class LogEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogEmpleado _instancia = new LogEmpleado();
        //privado para evitar la instanciación directa
        public static LogEmpleado Instancia
        {
            get
            {
                return LogEmpleado._instancia;
            }
        }
        #endregion singleton

        DatEmpleado UserEmpleado = new DatEmpleado();
        EntEmpleado Var = new EntEmpleado();
        public bool loginUser(String usuario, string contra)
        {
            return UserEmpleado.Login(usuario, contra);
        }
        /*public bool editContra(String usuario, String contra)
        {
            if (usuario == Var.IdEmpleado)
            {
                return true;
            }
        }*/
        public DataTable BuscarEmpleados(string NomEmpleado)
        {
            return DatEmpleado.Instancia.BuscarEmpleados(NomEmpleado);
        }
        public EntEmpleado BuscarEmpleado(string NomEmpleado)
        {
            return DatEmpleado.Instancia.BuscarEmpleado(NomEmpleado);
        }

        public List<EntEmpleado> ListarEmpleado()
        {
            return DatEmpleado.Instancia.ListarEmpleado();
        }
        ///inserta
        public void InsertarEmpleado(EntEmpleado Emp)
        {
           DatEmpleado.Instancia.InsertarEmpleado(Emp);
        }
        //edita
        public void EditarEmpleado(EntEmpleado Emp)
        {
            DatEmpleado.Instancia.EditarEmpleado(Emp);
        }
        public void DeshabilitarEmpleado(EntEmpleado Emp)
        {
            DatEmpleado.Instancia.DeshabilitarEmpleado(Emp);
        }

    }
}
