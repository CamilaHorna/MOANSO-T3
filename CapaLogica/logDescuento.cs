using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDescuento
    {
        #region Singleton
        private static readonly logDescuento _instancia = new logDescuento();
        public static logDescuento Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        #region Métodos

        public List<entDescuento> ListarDescuento()
        {
            return datDescuento.Instancia.ListarDescuento();
        }

        public void InsertaDescuento(entDescuento d)
        {
            datDescuento.Instancia.InsertarDescuento(d);
        }

        public void EditaDescuento(entDescuento d)
        {
            datDescuento.Instancia.EditarDescuento(d);
        }

        public void DesactivaDescuento(entDescuento d)
        {
            datDescuento.Instancia.DesactivarDescuento(d);
        }

        #endregion Métodos
    }
}