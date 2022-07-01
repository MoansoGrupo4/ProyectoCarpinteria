using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{   
    public class EntOP
    {
        public string CodCliente { get; set; }
        public string CodModelo { get; set; }
        public string CodOP { get; set; }
        public string CodPedido { get; set; }
        public int Cantidad { get; set; }
        public DateTime InioOP { get; set; }
    }
}
