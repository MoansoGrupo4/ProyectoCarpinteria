using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntModelo
    {
        public string CodModelo { get; set; }
        public string DesModelo { get; set; }
        public string CodTipoMadera { get; set; }
        public string ColorModelo { get; set; }
        public float PrecioVentaPU { get; set; }
        public float PrecioVentaPM { get; set; }
        public string CodTipoMueble { get; set; }
        public Boolean EstadoModelo { get; set; }
    }
}
