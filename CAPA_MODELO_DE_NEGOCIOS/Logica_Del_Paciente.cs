using CAPA_DATOS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    //TODO Esta clase contiene el negocio para gestionar los pacientes en el sistema.
    public class Logica_Del_Paciente
    {
        private CONEXIONDATOS conexion = new CONEXIONDATOS();

        /// Método para eleminar un paciente de la base de datos.
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
                //retona false si ocurre un error o no se encuentra el paciente
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        /// Método para modificar un paciente en la base de datos.
        public bool ModificarPaciente(int id, string nombre, string apellido, string documento, string genero, string correo, string telefono, DateTime fechaNacimiento, string nacionalidad)
        {
            try
            {
                // Abre la conexión a la base de datos
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    // Prepara la consulta SQL para actualizar el paciente
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
                //retorna false si ocurre un error
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        /// Método para guardar un nuevo paciente en la base de datos.
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
                    
                    // Verifica si el resultado no es null y si se puede convertir a int
                    if (result != null && int.TryParse(result.ToString(), out int nuevoID))
                    {
                        // Si la conversión es exitosa, retorna el nuevo ID
                        return nuevoID;
                    }
                    else
                    {
                        // Si no se puede convertir a int, retorna 0
                        return 0; 
                    }
                    
                }
            }
            catch
            /// Si ocurre un error retorna 0 tambien
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
