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
    public class datCliente

    {
        private static readonly datCliente _instancia = new datCliente();

        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }

        // LISTAR CLIENTES
        public List<entCliente> ListarCliente()
        {
            List<entCliente> lista = new List<entCliente>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListaCliente", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entCliente cli = new entCliente();

                        cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                        cli.Nombre_completo = dr["Nombre_completo"].ToString();
                        cli.Numero_documento = dr["Numero_documento"].ToString();
                        cli.Telefono = dr["Telefono"] == DBNull.Value ? null : dr["Telefono"].ToString();
                        cli.TipoDocumentoID = Convert.ToInt32(dr["TipoDocumentoID"]);
                        cli.TipoDocumento = dr["TipoDocumento"].ToString();

                        lista.Add(cli);
                    }
                }
            }

            return lista;
        }

        // INSERTAR CLIENTE
        public bool InsertarCliente(entCliente cli)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spInsertaCliente", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Nombre_completo", SqlDbType.VarChar, 100).Value = cli.Nombre_completo;
                cmd.Parameters.Add("@Numero_documento", SqlDbType.VarChar, 20).Value = cli.Numero_documento;
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 15).Value =
                    (object)cli.Telefono ?? DBNull.Value;
                cmd.Parameters.Add("@TipoDocumentoID", SqlDbType.Int).Value = cli.TipoDocumentoID;

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // EDITAR CLIENTE
        public bool EditarCliente(entCliente cli)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spEditaCliente", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ClienteID", SqlDbType.Int).Value = cli.ClienteID;
                cmd.Parameters.Add("@Nombre_completo", SqlDbType.VarChar, 100).Value = cli.Nombre_completo;
                cmd.Parameters.Add("@Numero_documento", SqlDbType.VarChar, 20).Value = cli.Numero_documento;
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 15).Value =
                    (object)cli.Telefono ?? DBNull.Value;
                cmd.Parameters.Add("@TipoDocumentoID", SqlDbType.Int).Value = cli.TipoDocumentoID;

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }

        }


        // LISTAR TIPO DE DOCUMENTO
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
    }
}
<<<<<<< HEAD


=======
>>>>>>> origin/main
