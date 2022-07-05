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
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public EntCliente Codigo { get; set; }

        public EntModelo CodModelo { get; set; }

        public decimal total { get; set; }
        public List<EntDetPedido> DetPedidos { get; set; }
    }
}
