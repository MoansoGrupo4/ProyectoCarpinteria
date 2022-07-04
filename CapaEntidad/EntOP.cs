using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{   
    public class EntOP
    {
        public EntModelo CodModelo { get; set; }
        public string CodOP { get; set; }
        public EntPedido CodPedido { get; set; }
        public DateTime InicioOP { get; set; }
        public bool EstOP { get; set; }
        public EntCliente Codigo { get; set; }
    }
}
