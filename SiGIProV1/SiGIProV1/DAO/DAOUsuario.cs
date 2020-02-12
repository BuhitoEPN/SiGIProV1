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
        public string Login(string user, string pass)
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@usario", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandText = "SELECT * FROM EMPLEADO WHERE CEDULA_EMPLEADO = @usario AND CONTRASENA = @pass";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    string cargo = string.Empty;
                    //Cuadno queremos tomar un dato de una columna especifica
                    if (reader.Read())
                    {
                        cargo = reader.GetString(reader.GetOrdinal("CARGO_EMPLEADO"));
                        return cargo;
                    }
                    else { return cargo; }
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
