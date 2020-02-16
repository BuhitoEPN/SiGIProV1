using SiGIProV1.Conexion;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SiGIProV1.DAO
{
    class DAOUsuario : ConnectionToSql
    {
        public string LoginCargoDAO(string user, string pass)
        {
            using (var connection = GetConexion())
            {
                string cargo = string.Empty;
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ValidarLoginCargo";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    SqlDataReader reader = command.ExecuteReader();

                    //Cuadno queremos tomar un dato de una columna especifica
                    if (reader.Read())
                    {
                        cargo = reader.GetString(reader.GetOrdinal("CARGO_EMPLEADO"));
                    }

                    return cargo;
                }
            }

        }

        public string devolverNombre(string cedula)
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@usario", cedula);
                    command.CommandText = "SELECT * FROM EMPLEADO WHERE CEDULA_EMPLEADO = @usario";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    string nomnbre = string.Empty;
                    //Cuadno queremos tomar un dato de una columna especifica
                    if (reader.Read())
                    {
                        nomnbre = reader.GetString(reader.GetOrdinal("NOMBRE_EMPLEADO"));
                        return nomnbre;
                    }
                    else { return nomnbre; }
                }
            }
        }
    }
}
