using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntOrdenEntrada
    {
        public string idOrdenEntrada { get; set; }
        public EntPedido CodPedido { get; set; }
        public EntMPrima CodMPrima { get; set; }
        public EntInsumos CodInsumo { get; set; }
    }
}
