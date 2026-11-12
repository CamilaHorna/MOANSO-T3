using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class entMaquina
    {
        public int idMaquina { get; set; }
        public int idCategoria { get; set; }
        public int idZona { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public DateTime? fecAdquisicion { get; set; }
        public Boolean estMaquina { get; set; }
    }
}
