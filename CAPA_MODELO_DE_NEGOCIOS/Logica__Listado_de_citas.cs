using System.Data;
using CAPA_DATOS;
using Microsoft.Data.SqlClient;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    //TODO Clase encargada de la lógica para gestionar las citas médicas en el listado
    public class LogicaCitas
    {
        private CONEXIONDATOS conexion = new CONEXIONDATOS();

        public DataTable ObtenerCitasPorFechaYDoctor(DateTime fecha, string nombreDoctor)
        {
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    // Obtiene todas las citas activas para un doctor específico en una fecha determinada.
                    string query = @"
            SELECT C.ID_CITA, C.NOMBRE AS PACIENTE_NOMBRE, C.APELLIDO, C.CORREO, C.TELEFONO, C.FECHA, C.HORA
            FROM CITAS C
            INNER JOIN DOCTORES D ON C.ID_DOCTOR = D.ID_DOCTOR
            WHERE C.FECHA = @fecha AND D.NOMBRE = @nombreDoctor AND C.ESTADOCITA = 'ACTIVA'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@nombreDoctor", nombreDoctor);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable tabla = new DataTable();
                        da.Fill(tabla);
                        return tabla;
                    }
                }
            }
        }
        
        public bool EliminarCita(int citaId)
        {//metodo para eliminar una cita
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "DELETE FROM CITAS WHERE ID_CITA = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", citaId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool ModificarCita(int id, string NOMBRE, string APELLIDO, string CORREO, int TELEFONO, DateTime FECHA, string HORA)
        { // metodo para modificar una cita
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = @"UPDATE CITAS SET 
                            NOMBRE = @nombre,
                            APELLIDO = @apellido,
                            CORREO = @correo,
                            TELEFONO = @telefono,
                            FECHA = @fecha,
                            HORA = @hora
                          WHERE ID_CITA = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", NOMBRE);
                cmd.Parameters.AddWithValue("@apellido", APELLIDO);
                cmd.Parameters.AddWithValue("@correo", CORREO);
                cmd.Parameters.AddWithValue("@telefono", TELEFONO);
                cmd.Parameters.AddWithValue("@fecha", FECHA);
                cmd.Parameters.AddWithValue("@hora", HORA);
                cmd.Parameters.AddWithValue("@id", id);
                
                return cmd.ExecuteNonQuery() > 0;
            }

        }
    }
    
    
}      


    








