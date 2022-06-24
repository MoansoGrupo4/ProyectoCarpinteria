using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntEmpleado
    {
        public string IdEmpleado { get; set; }
        public string NomEmpleado { get; set; }
        public string FuncionEmpleado { get; set; }
        public string DirEmpleado { get; set; }
        public int DNIEmpleado { get; set; }
        public int EdadEmpleado { get; set; }
        public DateTime FechaEmpleado { get; set; }
        public int numero { get; set; }
        public Boolean estEmpleado { get; set; }

        //public string contra { get; set; }
    }
}
