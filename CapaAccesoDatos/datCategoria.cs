using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datCategoria
    {
        #region sigleton

        //Patron Singleton
        private static readonly datCategoria _instancia = new datCategoria();

        public static datCategoria Instancia
        {
            get
            {
                return datCategoria._instancia;
            }
        }

        #endregion singleton

        #region metodos

        //////////////////// listado de Categorias
        public List<entCategoria> ListarCategoria()
        {
            SqlCommand cmd = null;
            List<entCategoria> lista = new List<entCategoria>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entCategoria Cat = new entCategoria();

                    Cat.idCategoria = Convert.ToInt32(dr["CategoriaID"]);
                    Cat.codigo = dr["Codigo"].ToString();
                    Cat.nombre = dr["Nombre"].ToString();
                    Cat.descripcion = dr["Descripcion"].ToString();
                    Cat.estCategoria = Convert.ToBoolean(dr["Estado"]);

                    lista.Add(Cat);
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

        ///////////////////////// InsertaCategoria
        public Boolean InsertarCategoria(entCategoria Cat)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Codigo", Cat.codigo);
                cmd.Parameters.AddWithValue("@Nombre", Cat.nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Cat.descripcion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", Cat.estCategoria);

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

        ////////////////////////////// EditaCategoria
        public Boolean EditarCategoria(entCategoria Cat)
        {
            SqlCommand cmd = null;
            Boolean edita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoriaID", Cat.idCategoria);
                cmd.Parameters.AddWithValue("@Codigo", Cat.codigo);
                cmd.Parameters.AddWithValue("@Nombre", Cat.nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Cat.descripcion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", Cat.estCategoria);

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

        ////////////////////////////// DesactivaCategoria
        public Boolean DesactivarCategoria(entCategoria Cat)
        {
            SqlCommand cmd = null;
            Boolean delete = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesactivaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoriaID", Cat.idCategoria);

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
