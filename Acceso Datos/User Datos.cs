using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace Acceso_Datos
{
    public class User_Datos : Conexion
    {
        public bool Login(string user, string pass)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Pr_Login";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheInicioSesion.user = reader.GetInt32(0);
                            CacheInicioSesion.pass = reader.GetString(1);
                            CacheInicioSesion.empleadoid = reader.GetString(2);
                            CacheInicioSesion.nombre = reader.GetString(3);
                            CacheInicioSesion.apellido = reader.GetString(4);
                            CacheInicioSesion.privilegio = reader.GetInt32(5);
                        }
                        return true;
                    }
                    return false;
                }
            }
        }
        public DataTable Tb_ListadoEmpleados(string direccion)
        {
            using (var conexion = GetConnection())
            {
                DataTable tabla = new DataTable();
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Tb_ListadoEmpleados";
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader leer = command.ExecuteReader();
                    tabla.Load(leer);
                    command.CommandType = CommandType.StoredProcedure;
                    return tabla;
                }
            }
        }

        public DataTable Tb_Departamentos()
        {
            using (var conexion = GetConnection())
            {
                DataTable tabla = new DataTable();
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Tb_Departamentos";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader leer = command.ExecuteReader();
                    tabla.Load(leer);
                    command.CommandType = CommandType.StoredProcedure;
                    return tabla;
                }
            }
        }

        public void Pr_NuevoEmpleado(string empleadoid, string tarjeta, string nombre,
            string cedula, string puesto, string direccion, string departamento)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Pr_NuevoEmpleado";
                    command.Parameters.AddWithValue("@empleadoid", empleadoid);
                    command.Parameters.AddWithValue("@tarjeta", tarjeta);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@puesto", puesto);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@departamento", departamento);
                    command.Parameters.AddWithValue("@userid", CacheInicioSesion.user);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Pr_ActualizarEmpleado(string empleadoid, string tarjeta, string nombre, string cedula,
             string puesto, string direccion, string departamento )
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "Pr_ActualizarEmpleado";
                    command.Parameters.AddWithValue("@empleadoid", empleadoid);
                    command.Parameters.AddWithValue("@tarjeta", tarjeta);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@puesto", puesto);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@departamento", departamento);
                    command.Parameters.AddWithValue("@userid", CacheInicioSesion.user);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarCarnet(string cedula)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "ActualizarCarnet";
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable EmpleadosConLlave(string direccion)
        {
            using (var conexion = GetConnection())
            {
                DataTable tabla = new DataTable();
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "EmpleadosConLlave";
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader leer = command.ExecuteReader();
                    tabla.Load(leer);
                    command.CommandType = CommandType.StoredProcedure;
                    return tabla;
                }
            }
        }
        public void AsignarCodigoLlave(string codigollave, string cedula)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "AsignarCodigoLlave";
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@codigollave", codigollave);
                  //  command.Parameters.AddWithValue("@userid", CacheInicioSesion.user);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
