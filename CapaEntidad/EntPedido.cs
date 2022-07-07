using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPedido
    { 
        public string  CodPedido { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public EntCliente Codigo { get; set; }
        public decimal Total { get; set; }
        public List<EntDetPedido> DetPedido { get; set; }
    }
}
