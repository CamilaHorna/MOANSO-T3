using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEntrenador
    {
     
            public int EntrenadorID { get; set; }
            public bool Estado { get; set; }
            public string Nombre_completo { get; set; }
            public string Numero_documento { get; set; }
            public int TipoDocumentoID { get; set; }
            public string TipoDocumento { get; set; }
            public int EspecialidadID { get; set; }
            public string Especialidad { get; set; }
        public string EstadoTexto
        {
            get { return Estado ? "Activo" : "Inactivo"; }
        }
    }

}
