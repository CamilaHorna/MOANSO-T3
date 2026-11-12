using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class Conexion
    {

        // Patron Singleton
        private static readonly Conexion _instancia = new Conexion();

        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();

<<<<<<< HEAD
            cn.ConnectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=Gimnasio; Integrated Security=True";
=======
            cn.ConnectionString = "Data Source=localhost ; Initial Catalog=Gimnasio; Integrated Security=True";
>>>>>>> origin/main

            return cn;
        }
    }
}
