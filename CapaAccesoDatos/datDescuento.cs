using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datDescuento
    {
        #region Singleton
        private static readonly datDescuento _instancia = new datDescuento();
        public static datDescuento Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton
        #region Métodos
        public List<entDescuento> ListarDescuento()
        {
            SqlCommand cmd = null;
            List<entDescuento> lista = new List<entDescuento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaDescuento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDescuento d = new entDescuento();
                    d.DescuentoID = Convert.ToInt32(dr["DescuentoID"]);
                    d.Codigo = dr["Codigo"].ToString();
                    d.Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : "";
                    d.Porcentaje = Convert.ToDecimal(dr["Porcentaje"]);
                    d.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(d);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return lista;
        }

        public bool InsertarDescuento(entDescuento d)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaDescuento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", d.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", (object)d.Descripcion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Porcentaje", d.Porcentaje);
                cmd.Parameters.AddWithValue("@Estado", d.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return inserta;
        }

        public bool EditarDescuento(entDescuento d)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaDescuento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DescuentoID", d.DescuentoID);
                cmd.Parameters.AddWithValue("@Codigo", d.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", (object)d.Descripcion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Porcentaje", d.Porcentaje);
                cmd.Parameters.AddWithValue("@Estado", d.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return edita;
        }
        public bool DesactivarDescuento(entDescuento d)
        {
            SqlCommand cmd = null;
            bool desactiva = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesactivaDescuento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DescuentoID", d.DescuentoID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) desactiva = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return desactiva;
        }
        #endregion Métodos
    }
}
