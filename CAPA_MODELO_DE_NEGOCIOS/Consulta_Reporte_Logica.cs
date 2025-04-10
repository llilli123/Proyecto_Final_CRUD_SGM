using CAPA_DATOS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    //TODO Clase que contiene la lógica relacionada con la gestión
    public class Consulta_Reporte_Logica
    // Actualiza el estado de un turno específico en la base de datos (por ejemplo, "Atendiendo", "Atendido", etc.).
    {
        //TODO Método para actualizar el estado a "Atendiendo" de un turno específico
        public bool Atendiendo(int turnoId, int doctorId, DateTime fecha, string nuevoEstado)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"UPDATE TURNOSCONSULTA
                         SET ESTADOTURNO = @estado
                         WHERE ID_TURNO = @turnoId
                         AND ID_DOCTOR = @doctorId
                         AND CONVERT(DATE, FECHATURNO) = @fecha";
                // Se crea un DataTable para almacenar los resultados de la consulta
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@turnoId", turnoId);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                // Se ejecuta la consulta y se obtiene el número de filas afectadas
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //TODO Método para actualizar el estado a "Atendido" de un turno específico
        public void Atendido(int turnoId)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = "UPDATE TURNOSCONSULTA SET ESTADOTURNO = 'Atendido' WHERE ID_TURNO = @turnoId";
                // Se crea un DataTable para almacenar los resultados de la consulta
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@turnoId", turnoId);
                cmd.ExecuteNonQuery();
            }
        }
        //TODO Método para verificar si un doctor está atendiendo a un paciente en una fecha específica
        public bool PacienteAtendiendo(int doctorId, DateTime fecha)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"SELECT COUNT(*) FROM TURNOSCONSULTA
                         WHERE ID_DOCTOR = @doctorId
                         AND CONVERT(DATE, FECHATURNO) = @fecha
                         AND ESTADOTURNO = 'Atendiendo'";
                // Se crea un DataTable para almacenar los resultados de la consulta
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                // Se ejecuta la consulta y se obtiene el conteo de turnos atendidos
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        
        //TODO Método para obtener los turnos atendidos de un doctor en una fecha específica
        public DataTable ObtenerCitasAtendidas(int doctorId, DateTime fecha)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"SELECT T.ID_TURNO,T.PACIENTE_ID,T.ID_DOCTOR, T.FECHATURNO, P.NOMBRE, P.APELLIDO, T.ESTADOTURNO
                         FROM TURNOSCONSULTA T
                         JOIN PACIENTES P ON T.PACIENTE_ID = P.PACIENTE_ID
                         WHERE T.ID_DOCTOR = @doctorId
                         AND CONVERT(DATE, T.FECHATURNO) = @fecha
                         AND T.ESTADOTURNO IN ('Sin atender', 'Atendiendo')";
                // Se crea un DataTable para almacenar los resultados de la consulta
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }
    }
}
