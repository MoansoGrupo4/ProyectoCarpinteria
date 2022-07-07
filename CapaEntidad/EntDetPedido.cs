using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntDetPedido
    {
        public string CodigoDetPed { get; set; }
        public string CodPedido { get; set; }
        public int Cantidad { get; set; }
        public Decimal Precio { get; set; }
        public EntModelo CodModelo { get; set; }
    }
}
