using SiGIProV1.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGIProV1.DAO
{
    class DAOProveedor : ConnectionToSql
    {
        private SqlDataReader leerFilas;
        public void agregarProveedor(string ruc, string nombreProveedor, string direccionProveedor, string correoElectronico, string telefonoMovil)
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "AgregarProveedor";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ruc", ruc);
                    command.Parameters.AddWithValue("@nombre", nombreProveedor);
                    command.Parameters.AddWithValue("@direccion", direccionProveedor);
                    command.Parameters.AddWithValue("@correo", correoElectronico);
                    command.Parameters.AddWithValue("@telefono", telefonoMovil);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
          
                }
            }
        }

        public DataTable listarProveedor()
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "ListarProveedor";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    leerFilas = command.ExecuteReader();
                    tabla.Load(leerFilas);
                    leerFilas.Close();
                    return tabla;
                }
            }
        }

        public DataTable filtrarRUC(string ruc)
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "FiltrarRucProveedor";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ruc", ruc);
                    leerFilas = command.ExecuteReader();
                    command.Parameters.Clear();
                    tabla.Load(leerFilas);
                    leerFilas.Close();
                    return tabla;
                }
            }
        }

        public DataTable filtrarNombre(string nombre)
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "FiltrarNombreProveedor";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombre);
                    leerFilas = command.ExecuteReader();
                    command.Parameters.Clear();
                    tabla.Load(leerFilas);
                    leerFilas.Close();
                    return tabla;
                }
            }
        }
    }
}
