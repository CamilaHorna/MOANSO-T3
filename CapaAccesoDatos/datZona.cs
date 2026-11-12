using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datZona
    {
        #region sigleton

        //Patron Singleton
        private static readonly datZona _instancia = new datZona();

        public static datZona Instancia
        {
            get
            {
                return datZona._instancia;
            }
        }

        #endregion singleton

        #region metodos

        //////////////////// listado de Zonas
        public List<entZona> ListarZona()
        {
            SqlCommand cmd = null;
            List<entZona> lista = new List<entZona>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaZona", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entZona Zon = new entZona();

                    Zon.idZona = Convert.ToInt32(dr["ZonaID"]);
                    Zon.codigo = dr["Codigo"].ToString();
                    Zon.nombre = dr["Nombre"].ToString();
                    Zon.descripcion = dr["Descripcion"].ToString();
                    Zon.estZona = Convert.ToBoolean(dr["Estado"]);

                    lista.Add(Zon);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return lista;
        }

        ///////////////////////// InsertaZona
        public Boolean InsertarZona(entZona Zon)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaZona", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Codigo", Zon.codigo);
                cmd.Parameters.AddWithValue("@Nombre", Zon.nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Zon.descripcion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", Zon.estZona);

                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return inserta;
        }

        ////////////////////////////// EditaZona
        public Boolean EditarZona(entZona Zon)
        {
            SqlCommand cmd = null;
            Boolean edita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaZona", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ZonaID", Zon.idZona);
                cmd.Parameters.AddWithValue("@Codigo", Zon.codigo);
                cmd.Parameters.AddWithValue("@Nombre", Zon.nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Zon.descripcion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", Zon.estZona);

                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return edita;
        }

        ////////////////////////////// DesactivaZona
        public Boolean DesactivarZona(entZona Zon)
        {
            SqlCommand cmd = null;
            Boolean delete = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesactivaZona", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ZonaID", Zon.idZona);

                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return delete;
        }

        #endregion metodos
    }
}
