using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntMPrima
    {
        public string CodigoMP { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal CostUnitario { get; set; }
        public string TipoMPrima { get; set; }
        public string Tam { get; set; }
        public float DimensionA { get; set; }
        public float DimensionB { get; set; }
        public float DimensionC { get; set; }
        public string UnidadMedida { get; set; }
        public DateTime Ingreso { get; set; }        
        public decimal CostTotal { get; set; }
        public bool Estado { get; set; }

    }
}
