using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int idCliente { get; set; }
        public String RazonSocial { get; set; }
        public String Direccion { get; set; }
        public String Ciudad { get; set; }
        public int idTipoCliente { get; set; }
        public Boolean estCliente { get; set; }
        public override string ToString()
        {
            return RazonSocial;
        }


    }
}
