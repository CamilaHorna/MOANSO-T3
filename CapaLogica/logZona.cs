
using System;
using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logZona
    {
        // Patron Singleton
        private static readonly logZona _instancia = new logZona();

        public static logZona Instancia
        {
            get { return logZona._instancia; }
        }

        // Listado
        public List<entZona> ListarZona()
        {
            return datZona.Instancia.ListarZona();
        }

        // Inserta
        public void InsertaZona(entZona Zon)
        {
            datZona.Instancia.InsertarZona(Zon);
        }

        // Edita
        public void EditaZona(entZona Zon)
        {
            datZona.Instancia.EditarZona(Zon);
        }

        // Deshabilita
        public void DeshabilitarZona(entZona Zon)
        {
            datZona.Instancia.DesactivarZona(Zon);
        }
    }
}
