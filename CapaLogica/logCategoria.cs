
using System;
using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logCategoria
    {
        // Patron Singleton
        private static readonly logCategoria _instancia = new logCategoria();

        public static logCategoria Instancia
        {
            get { return logCategoria._instancia; }
        }

        // Listado
        public List<entCategoria> ListarCategoria()
        {
            return datCategoria.Instancia.ListarCategoria();
        }

        // Inserta
        public void InsertaCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.InsertarCategoria(Cat);
        }

        // Edita
        public void EditaCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.EditarCategoria(Cat);
        }

        // Deshabilita
        public void DeshabilitarCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.DesactivarCategoria(Cat);
        }
    }
}
