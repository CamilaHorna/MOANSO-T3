using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCliente
    {
        private static readonly logCliente _instancia = new logCliente();

        public static logCliente Instancia
        {
            get { return logCliente._instancia; }
        }

        // LISTAR CLIENTES
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        // INSERTAR CLIENTE
        public bool InsertarCliente(entCliente cli)
        {
            return datCliente.Instancia.InsertarCliente(cli);
        }

        // EDITAR CLIENTE
        public bool EditarCliente(entCliente cli)
        {
            return datCliente.Instancia.EditarCliente(cli);
        }

        //  TIPOS DE DCUMENTOS

        public DataTable ListarTipoDocumento()
        {
            return datCliente.Instancia.ListarTipoDocumento();
        }
    }
}
