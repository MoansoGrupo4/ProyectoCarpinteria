using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntNuevoPedido
    {
        public string CodPedido { get; set; }
        public string CodModelo { get; set; }
        public string DesModelo { get; set; }
        public int CodCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime fecha { get; set; }
        public float total { get; set; }
    }
}
