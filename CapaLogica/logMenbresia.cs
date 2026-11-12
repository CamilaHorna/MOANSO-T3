using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMembresia
    {
        #region Singleton
        private static readonly logMembresia _instancia = new logMembresia();
        public static logMembresia Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos

        public List<entMembresia> ListarMembresia()
        {
            return datMembresia.Instancia.ListarMembresia();
        }

        public void InsertaMembresia(entMembresia m)
        {
            datMembresia.Instancia.InsertarMembresia(m);
        }

        public void EditaMembresia(entMembresia m)
        {
            datMembresia.Instancia.EditarMembresia(m);
        }

        public void DesactivaMembresia(entMembresia m)
        {
            datMembresia.Instancia.DesactivarMembresia(m);
        }

        #endregion
    }
}