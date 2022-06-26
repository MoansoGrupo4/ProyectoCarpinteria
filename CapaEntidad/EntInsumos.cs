using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntInsumos
    {
        public string Codigo { get; set; }
        public char Categoria{ get; set; }
        public char Producto { get; set; }
        public int cantidad { get; set; }
        public DateTime FechaEmision { get; set; }
        public Double CUnitario { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double CTotal { get; set; }
        public bool EstInsumo { get; set; }
      
        
    }
}
