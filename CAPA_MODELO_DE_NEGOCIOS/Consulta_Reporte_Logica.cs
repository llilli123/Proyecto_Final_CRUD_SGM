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
    public class Consulta_Reporte_Logica
    {
        public bool Atendiendo(int turnoId, int doctorId, DateTime fecha, string nuevoEstado)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"UPDATE TURNOSCONSULTA
                         SET ESTADOTURNO = @estado
                         WHERE ID_TURNO = @turnoId
                         AND ID_DOCTOR = @doctorId
                         AND CONVERT(DATE, FECHATURNO) = @fecha";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@turnoId", turnoId);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public void Atendido(int turnoId)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = "UPDATE TURNOSCONSULTA SET ESTADOTURNO = 'Atendido' WHERE ID_TURNO = @turnoId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@turnoId", turnoId);
                cmd.ExecuteNonQuery();
            }
        }
        public bool PacienteAtendiendo(int doctorId, DateTime fecha)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"SELECT COUNT(*) FROM TURNOSCONSULTA
                         WHERE ID_DOCTOR = @doctorId
                         AND CONVERT(DATE, FECHATURNO) = @fecha
                         AND ESTADOTURNO = 'Atendiendo'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
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
