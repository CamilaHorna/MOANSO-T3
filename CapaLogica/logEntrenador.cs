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
    public class logEntrenador
    {
        private static readonly logEntrenador _instancia = new logEntrenador();

        public static logEntrenador Instancia
        {
            get { return logEntrenador._instancia; }
        }

        // LISTAR ENTRENADORES
        public List<entEntrenador> ListarEntrenadores()
        {
            return datEntrenador.Instancia.ListarEntrenadores();
        }

        // REGISTRAR ENTRENADOR
        public bool RegistrarEntrenador(entEntrenador ent)
        {
            return datEntrenador.Instancia.RegistrarEntrenador(ent);
        }

        // EDITAR ENTRENADOR
        public bool EditarEntrenador(entEntrenador ent)
        {
            return datEntrenador.Instancia.EditarEntrenador(ent);
        }

        // DESACTIVAR ENTRENADOR
        public bool DesactivarEntrenador(int entrenadorID)
        {
            return datEntrenador.Instancia.DesactivarEntrenador(entrenadorID);
        }

        // LISTAR TIPOS DE DOCUMENTO
        public DataTable ListarTipoDocumento()
        {
            return datEntrenador.Instancia.ListarTipoDocumento();
        }

        // LISTAR ESPECIALIDADES
        public DataTable ListarEspecialidad()
        {
            return datEntrenador.Instancia.ListarEspecialidad();
        }
    }
}
