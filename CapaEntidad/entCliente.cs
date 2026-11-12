using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{  
      public class entCliente
        {
            public int ClienteID { get; set; }
            public string Nombre_completo { get; set; }
            public string Numero_documento { get; set; }
            public string Telefono { get; set; }
            public int TipoDocumentoID { get; set; }
            public string TipoDocumento { get; set; }
        }
    
}
