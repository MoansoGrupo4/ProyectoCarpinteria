using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntAsignacionEmpleado
    {
        public string IdGrupo { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string IdEmpleado { get; set; }
        public string IdOp { get; set; }
        public int HorasTrabajo { get; set; }
        public float PagoHora { get; set; }
        public float PagoTotal { get; set; }

    }
}
