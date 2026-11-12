
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datMaquina
    {
        #region sigleton

        //Patron Singleton
        private static readonly datMaquina _instancia = new datMaquina();

        public static datMaquina Instancia
        {
            get
            {
                return datMaquina._instancia;
            }
        }

        #endregion singleton

        #region metodos

        //////////////////// listado de Maquinas
        public List<entMaquina> ListarMaquina()
        {
            SqlCommand cmd = null;
            List<entMaquina> lista = new List<entMaquina>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaMaquina", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entMaquina Maq = new entMaquina();

                    Maq.idMaquina = Convert.ToInt32(dr["MaquinaID"]);
                    Maq.idCategoria = Convert.ToInt32(dr["CategoriaID"]);
                    Maq.idZona = Convert.ToInt32(dr["ZonaID"]);
                    Maq.codigo = dr["Codigo"].ToString();
                    Maq.nombre = dr["Nombre"].ToString();
                    Maq.marca = dr["Marca"].ToString();
                    Maq.modelo = dr["Modelo"].ToString();

                    Maq.fecAdquisicion = dr["FechaAdquisicion"] == DBNull.Value
                        ? (DateTime?)null
                        : Convert.ToDateTime(dr["FechaAdquisicion"]);

                    Maq.estMaquina = Convert.ToBoolean(dr["Estado"]);

                    lista.Add(Maq);
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

        ///////////////////////// InsertaMaquina
        public Boolean InsertarMaquina(entMaquina Maq)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaMaquina", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoriaID", Maq.idCategoria);
                cmd.Parameters.AddWithValue("@ZonaID", Maq.idZona);
                cmd.Parameters.AddWithValue("@Codigo", Maq.codigo);
                cmd.Parameters.AddWithValue("@Nombre", Maq.nombre);
                cmd.Parameters.AddWithValue("@Marca", Maq.marca ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Modelo", Maq.modelo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaAdquisicion",
                    Maq.fecAdquisicion.HasValue ? (object)Maq.fecAdquisicion.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", Maq.estMaquina);

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

        ////////////////////////////// EditaMaquina
        public Boolean EditarMaquina(entMaquina Maq)
        {
            SqlCommand cmd = null;
            Boolean edita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaMaquina", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaquinaID", Maq.idMaquina);
                cmd.Parameters.AddWithValue("@CategoriaID", Maq.idCategoria);
                cmd.Parameters.AddWithValue("@ZonaID", Maq.idZona);
                cmd.Parameters.AddWithValue("@Codigo", Maq.codigo);
                cmd.Parameters.AddWithValue("@Nombre", Maq.nombre);
                cmd.Parameters.AddWithValue("@Marca", Maq.marca ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Modelo", Maq.modelo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaAdquisicion",
                    Maq.fecAdquisicion.HasValue ? (object)Maq.fecAdquisicion.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", Maq.estMaquina);

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

        ////////////////////////////// DesactivaMaquina
        public Boolean DesactivarMaquina(entMaquina Maq)
        {
            SqlCommand cmd = null;
            Boolean delete = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesactivaMaquina", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaquinaID", Maq.idMaquina);

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
