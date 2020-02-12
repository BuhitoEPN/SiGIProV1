using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGIProV1.Conexion
{
    class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql() => connectionString = "Server=LAPTOPCITA;DataBase=RuescoSA; integrated security = true";
        //public ConnectionToSql() => connectionString = "Server=COMPUCITA\\SQLEXPRESS;DataBase=RuescoSA; integrated security = true";
        //public ConnectionToSql() => connectionString = "Server=ASUS\\SQLEXPRESS;DataBase=RuescoSA; integrated security = true";

        protected SqlConnection GetConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}
