using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntCliente
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Razon_Social { get; set; }
        public override string ToString()
        {
            return Razon_Social;
        }
        public string Direccion{ get; set; } 
        public DateTime Registro { get; set; }
        public int Telefono { get; set; }
        public Boolean Estado { get; set; }

    }
}
