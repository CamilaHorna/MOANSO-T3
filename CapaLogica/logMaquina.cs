
using System;
using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logMaquina
    {
        // Patron Singleton
        private static readonly logMaquina _instancia = new logMaquina();

        public static logMaquina Instancia
        {
            get { return logMaquina._instancia; }
        }

        // Listado
        public List<entMaquina> ListarMaquina()
        {
            return datMaquina.Instancia.ListarMaquina();
        }

        // Inserta
        public void InsertaMaquina(entMaquina Maq)
        {
            datMaquina.Instancia.InsertarMaquina(Maq);
        }

        // Edita
        public void EditaMaquina(entMaquina Maq)
        {
            datMaquina.Instancia.EditarMaquina(Maq);
        }

        // Deshabilita
        public void DeshabilitarMaquina(entMaquina Maq)
        {
            datMaquina.Instancia.DesactivarMaquina(Maq);
        }
    }
}
