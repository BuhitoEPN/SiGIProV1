using SiGIProV1.Conexion;
using SiGIProV1.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV1.DAO
{
    class DAOProveedor : ConnectionToSql
    {
        public void agregarProveedor(Proveedor proveedor)
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "AgregarProveedor";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ruc", proveedor.Ruc);
                    command.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                    command.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                    command.Parameters.AddWithValue("@correo", proveedor.Correo);
                    command.Parameters.AddWithValue("@telefono", proveedor.Telefono);
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
                    SqlDataReader leerFilas = command.ExecuteReader();
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
                    SqlDataReader leerFilas = command.ExecuteReader();
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
                    SqlDataReader leerFilas = command.ExecuteReader();
                    command.Parameters.Clear();
                    tabla.Load(leerFilas);
                    leerFilas.Close();
                    return tabla;
                }
            }
        }

        public Boolean comprobarRUC(string ruc)
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    DataTable tabla = new DataTable();

                    command.Connection = connection;
                    command.CommandText = "BuscarRucProveedor";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ruc", ruc);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }
                    else { return false; }                        
                }
            }
        }

        public void comprobarRUCError(string ruc, Label error)
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    DataTable tabla = new DataTable();

                    command.Connection = connection;
                    command.CommandText = "BuscarRucProveedor";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ruc", ruc);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        error.Visible = true;
                        MessageBox.Show("Ya existe un proveedor con el RUC: " + ruc + ".");
                    }
                    else
                    {
                        error.Visible = false;
                    }
                }
            }
        }

        public Proveedor llenarDatosProveedor(string ruc)
        {
            using (var connection = GetConexion())
            {
                Proveedor proveedor = new Proveedor();
                connection.Open();

                using (var command = new SqlCommand())
                {
                    DataTable tabla = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "BuscarRucProveedor";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ruc", ruc);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                            proveedor = new Proveedor(ruc, reader.GetString(reader.GetOrdinal("NOMBRE_PROVEEDOR")),
                            reader.GetString(reader.GetOrdinal("DIRECCION_PROVEEDOR")),
                            reader.GetString(reader.GetOrdinal("TELEFONO_PROVEEDOR")),
                            reader.GetString(reader.GetOrdinal("ESTADO_PROVEEDOR")),
                            reader.GetString(reader.GetOrdinal("CORREO_PROVEEDOR")));
                    }
                    return proveedor;
                }
            }
        }

        public void actualizarProveedor(Proveedor proveedor)
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;    
                    command.CommandText = "ActualizarDatosProveedor";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ruc", proveedor.Ruc);
                    command.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                    command.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                    command.Parameters.AddWithValue("@correo", proveedor.Correo);
                    command.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                    command.Parameters.AddWithValue("@estado", proveedor.Estado);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                }
            }
        }
    }
}
