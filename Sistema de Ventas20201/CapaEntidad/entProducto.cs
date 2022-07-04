using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int idProducto { get; set; }
        public String descProducto { get; set; }
        public int StkProducto { get; set; }
        public Decimal precioVenta { get; set; }
        public entMarca idMarca { get; set; }
        public Boolean  estProducto { get; set; }
    }
}
