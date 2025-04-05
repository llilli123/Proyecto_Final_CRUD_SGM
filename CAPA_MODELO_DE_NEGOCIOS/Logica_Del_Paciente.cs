using CAPA_DATOS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    public class Logica_Del_Paciente
    {
        private CONEXIONDATOS conexion = new CONEXIONDATOS();

        public bool EliminarPaciente(int id)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    string query = "DELETE FROM PACIENTES WHERE PACIENTE_ID = @Id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public bool ModificarPaciente(int id, string nombre, string apellido, string documento, string genero, string correo, string telefono, DateTime fechaNacimiento, string nacionalidad)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    string query = @"UPDATE PACIENTES SET 
                NOMBRE = @Nombre,
                APELLIDO = @Apellido,
                DOCUMENTO = @Documento,
                GENERO = @Genero,
                CORREO = @Correo,
                TELEFONO = @Telefono,
                FECHA_NACIMIENTO = @FechaNacimiento,
                NACIONALIDAD = @Nacionalidad
                WHERE PACIENTE_ID = @Id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                    cmd.Parameters.AddWithValue("@Id", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public int GuardarPaciente(string nombre, string apellido, string documento, string genero, string correo, string telefono, DateTime fechaNacimiento, string nacionalidad)
        {
            try
            {
                using (SqlConnection co = conexion.AbrirConexion())
                {
                    string query = @"INSERT INTO PACIENTES 
                    (NOMBRE, APELLIDO, DOCUMENTO, GENERO, CORREO, TELEFONO, FECHA_NACIMIENTO, NACIONALIDAD) OUTPUT INSERTED.PACIENTE_ID
                    VALUES (@Nombre, @Apellido, @Documento, @Genero, @Correo, @Telefono, @FechaNacimiento, @Nacionalidad)";

                    SqlCommand cmd = new SqlCommand(query, co);

                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Documento", documento);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@Nacionalidad", nacionalidad);

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int nuevoID))
                    {
                        return nuevoID;
                    }
                    else
                    {
                        return 0; 
                    }
                    
                }
            }
            catch
            {
                return 0;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
