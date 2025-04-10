using CAPA_DATOS;
using Microsoft.Data.SqlClient;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    // Clase que contiene la lógica de negocio para registrar citas médicas
    public class Logica_de_Cita
    {
        // Instancia de la clase que maneja la conexión a la base de datos
        private CONEXIONDATOS conexion = new CONEXIONDATOS();

        public bool CitaYaExiste(DateTime fecha, TimeSpan hora, int doctorId)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"SELECT ID_CITA FROM CITAS
                         WHERE FECHA = @fecha AND HORA = @hora AND ID_DOCTOR = @doctorId AND ESTADOCITA = 'ACTIVA'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@hora", hora);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public int ObtenerIdDoctorPorNombre(string nombre)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = "SELECT ID_DOCTOR FROM DOCTORES WHERE NOMBRE = @nombre";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        public List<string> ObtenerNombresDoctores()
        {
            List<string> doctores = new List<string>();

            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = "SELECT NOMBRE FROM DOCTORES";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Asumiendo que la columna "NOMBRE" es la 0:
                            doctores.Add(reader.GetString(0));
                        }
                    }
                }
            } conexion.CerrarConexion(); // Cierra la conexión al final

            return doctores;
        }

        public bool RegistrarCita(Cita cita)
        {
            try
            {
                // Abrir la conexión 
                using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
                {
                    // Consulta para obtener el ID del doctor según su nombre
                    string queryBuscarDoctor = "SELECT ID_DOCTOR FROM DOCTORES WHERE NOMBRE = @nombreDoctor";
                    SqlCommand cmdDoctor = new SqlCommand(queryBuscarDoctor, conn);
                    cmdDoctor.Parameters.AddWithValue("@nombreDoctor", cita.Doctor);

                    // Ejecutar la consulta y obtener el resultado
                    object result = cmdDoctor.ExecuteScalar();

                    // Validar si el doctor existe en la base de datos
                    if (result == null)
                        throw new Exception("No se encontró el doctor en la base de datos.");

                    // Convertir el resultado al tipo entero para usarlo como ID
                    int idDoctor = Convert.ToInt32(result);

                    // Consulta para insertar la cita en la base de datos
                    string queryInsertarCita = @"
                        INSERT INTO CITAS (NOMBRE, APELLIDO, CORREO, TELEFONO, FECHA, HORA, ID_DOCTOR)
                        VALUES (@nombre, @apellido, @correo, @telefono, @fecha, @hora, @idDoctor)";

                    // Crear el comando SQL con los parámetros necesarios
                    SqlCommand cmdInsert = new SqlCommand(queryInsertarCita, conn);
                    cmdInsert.Parameters.AddWithValue("@nombre", cita.Nombre);
                    cmdInsert.Parameters.AddWithValue("@apellido", cita.Apellido);
                    cmdInsert.Parameters.AddWithValue("@correo", cita.Correo);
                    cmdInsert.Parameters.AddWithValue("@telefono", cita.Telefono);
                    cmdInsert.Parameters.AddWithValue("@fecha", cita.FechaCita.Date);

                    // Convertir HoraCita a formato TIME
                    
                    cmdInsert.Parameters.AddWithValue("@hora", cita.HoraCita);

                    // Agregar el ID del doctor
                    cmdInsert.Parameters.AddWithValue("@idDoctor", idDoctor);

                    // Ejecutar la consulta de inserción
                    int filasAfectadas = cmdInsert.ExecuteNonQuery();

                    // Retornar true si se insertó al menos una fila, false en caso contrario
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                // Lanzar una excepción personalizada en caso de error
                throw new Exception("Error al registrar la cita: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión aunque ocurra un error
                conexion.CerrarConexion(); // Cierra la conexión al final
            }
        }
    }

}
