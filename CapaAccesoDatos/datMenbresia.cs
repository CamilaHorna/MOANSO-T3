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
    public class datMembresia
    {
        #region Singleton
        private static readonly datMembresia _instancia = new datMembresia();
        public static datMembresia Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos

        public List<entMembresia> ListarMembresia()
        {
            SqlCommand cmd = null;
            List<entMembresia> lista = new List<entMembresia>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaMembresia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMembresia m = new entMembresia();
                    m.MembresiaID = Convert.ToInt32(dr["MembresiaID"]);
                    m.Nombre = dr["Nombre"].ToString();
                    m.Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : "";
                    m.Precio = Convert.ToDecimal(dr["Precio"]);
                    m.DuracionDias = Convert.ToInt32(dr["DuracionDias"]);
                    m.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(m);
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

        public bool InsertarMembresia(entMembresia m)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaMembresia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", (object)m.Descripcion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Precio", m.Precio);
                cmd.Parameters.AddWithValue("@DuracionDias", m.DuracionDias);
                cmd.Parameters.AddWithValue("@Estado", m.Estado);
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

        public bool EditarMembresia(entMembresia m)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaMembresia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MembresiaID", m.MembresiaID);
                cmd.Parameters.AddWithValue("@Nombre", m.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", (object)m.Descripcion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Precio", m.Precio);
                cmd.Parameters.AddWithValue("@DuracionDias", m.DuracionDias);
                cmd.Parameters.AddWithValue("@Estado", m.Estado);
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

        public bool DesactivarMembresia(entMembresia m)
        {
            SqlCommand cmd = null;
            bool desactiva = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesactivaMembresia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MembresiaID", m.MembresiaID);
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

        #endregion
    }
}
