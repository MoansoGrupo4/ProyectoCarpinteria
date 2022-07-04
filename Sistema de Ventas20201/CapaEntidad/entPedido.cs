using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPedido
    {

        public int idPedido { get; set; }
        public DateTime fechPedido { get; set; }
            
        public entCliente idCliente { get; set; }

        public Double TotPedido { get; set; }
        //public 
        public Boolean estPedido { get; set; }
        public List<entDetPedido> DetPedidos { get; set; }
        
    }
}
