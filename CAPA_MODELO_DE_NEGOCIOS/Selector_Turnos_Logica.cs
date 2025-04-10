using CAPA_DATOS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    //TODO Esta clase contiene la lógica de negocio para gestionar los turnos de consulta médica.
    public class Selector_Turnos_Logica
    {
        // Método para insertar un nuevo turno en la base de datos.
        public bool InsertarTurno(int pacienteId, int doctorId, DateTime fecha, int turno)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                // Verificar si el ID_TURNO ya existe
                string checkQuery = "SELECT COUNT(*) FROM TURNOSCONSULTA WHERE ID_TURNO = @turno";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@turno", turno);

                int count = (int)checkCmd.ExecuteScalar();

                // Si el ID_TURNO ya existe, generar un nuevo ID_TURNO único
                while (count > 0)
                {
                    turno++;
                    checkCmd.Parameters["@turno"].Value = turno;
                    count = (int)checkCmd.ExecuteScalar();
                }

                // Insertar el nuevo turno
                string query = @"INSERT INTO TURNOSCONSULTA
                    (ID_TURNO, PACIENTE_ID, ID_DOCTOR, FECHATURNO, ESTADOTURNO)
                    VALUES (@turno, @pacienteId, @doctorId, @fecha, 'Sin atender')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pacienteId", pacienteId);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@turno", turno);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Método para obtener todos los turnos de un paciente específico
        public bool EliminarTurno(int turnoId)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = "DELETE FROM TURNOSCONSULTA WHERE ID_TURNO = @turnoId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@turnoId", turnoId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Método para actualizar el estado del turno a "Atendido" (opcional para usar luego)
        public bool MarcarComoAtendido(int turnoId)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = "UPDATE TURNOSCONSULTA SET ESTADOTURNO = 'Atendido' WHERE ID_TURNO = @turnoId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@turnoId", turnoId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Método para obtener todos los turnos pendientes de un doctor en una fecha 
        public DataTable ObtenerTurnosPendientes(int doctorId, DateTime fecha)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"SELECT T.ID_TURNO, P.NOMBRE, P.APELLIDO, T.ESTADOTURNO
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
        // Método para obtener todos los turnos que se usaran en la consulta
        public static DataTable TomaTurno()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID_TURNO", typeof(int));

            for (int i = 1; i <= 100; i++)
            {
                tabla.Rows.Add(i);
            }

            return tabla;
        }

        // Método para obtener todos los turnos atendidos de un doctor en una fecha
        public DataTable ObtenerTurnosAtendidos(int doctorId, DateTime fecha)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"SELECT T.ID_TURNO, P.NOMBRE, P.APELLIDO, T.ESTADOTURNO
                    FROM TURNOSCONSULTA T
                    JOIN PACIENTES P ON T.PACIENTE_ID = P.PACIENTE_ID
                    WHERE T.ID_DOCTOR = @doctorId
                    AND CONVERT(DATE, T.FECHATURNO) = @fecha
                    AND T.ESTADOTURNO = 'Atendido'";

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
