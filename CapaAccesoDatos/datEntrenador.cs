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
    public class datEntrenador
    {
        private static readonly datEntrenador _instancia = new datEntrenador();

        public static datEntrenador Instancia
        {
            get { return datEntrenador._instancia; }
        }

        // LISTAR ENTRENADORES
        public List<entEntrenador> ListarEntrenadores()
        {
            List<entEntrenador> lista = new List<entEntrenador>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_ListarEntrenadores", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entEntrenador ent = new entEntrenador();

                        ent.EntrenadorID = Convert.ToInt32(dr["EntrenadorID"]);
                        ent.Estado = Convert.ToBoolean(dr["Estado"]);
                        ent.Nombre_completo = dr["Nombre_completo"].ToString();
                        ent.Numero_documento = dr["Numero_documento"].ToString();
                        ent.TipoDocumentoID = Convert.ToInt32(dr["TipoDocumentoID"]);
                        ent.TipoDocumento = dr["TipoDocumento"].ToString();
                        ent.EspecialidadID = Convert.ToInt32(dr["EspecialidadID"]);
                        ent.Especialidad = dr["Especialidad"].ToString();

                        lista.Add(ent);
                    }
                }
            }

            return lista;
        }

        // REGISTRAR ENTRENADOR
        public bool RegistrarEntrenador(entEntrenador ent)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarEntrenador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Nombre_completo", SqlDbType.VarChar, 100).Value = ent.Nombre_completo;
                cmd.Parameters.Add("@Numero_documento", SqlDbType.VarChar, 20).Value = ent.Numero_documento;
                cmd.Parameters.Add("@TipoDocumentoID", SqlDbType.Int).Value = ent.TipoDocumentoID;
                cmd.Parameters.Add("@EspecialidadID", SqlDbType.Int).Value = ent.EspecialidadID;

                cn.Open();

                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // EDITAR ENTRENADOR
        public bool EditarEntrenador(entEntrenador ent)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_EditarEntrenador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@EntrenadorID", SqlDbType.Int).Value = ent.EntrenadorID;
                cmd.Parameters.Add("@Nombre_completo", SqlDbType.VarChar, 100).Value = ent.Nombre_completo;
                cmd.Parameters.Add("@Numero_documento", SqlDbType.VarChar, 20).Value = ent.Numero_documento;
                cmd.Parameters.Add("@TipoDocumentoID", SqlDbType.Int).Value = ent.TipoDocumentoID;
                cmd.Parameters.Add("@EspecialidadID", SqlDbType.Int).Value = ent.EspecialidadID;

                cn.Open();


                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // DESACTIVAR ENTRENADOR
        public bool DesactivarEntrenador(int entrenadorID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_DesactivarEntrenador", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@EntrenadorID", SqlDbType.Int).Value = entrenadorID;

                cn.Open();


                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // LISTAR TIPOS DE DOCUMENTO
        public DataTable ListarTipoDocumento()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListaTipoDocumento", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }

            return tabla;
        }

        // LISTAR ESPECIALIDADES
        public DataTable ListarEspecialidad()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("sp_ListarEspecialidades", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }

            return tabla;
        }
    }
}
