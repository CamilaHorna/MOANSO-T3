using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDescuento
    {
            public int DescuentoID { get; set; }
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public decimal Porcentaje { get; set; }
            public bool Estado { get; set; }
        }
 }



