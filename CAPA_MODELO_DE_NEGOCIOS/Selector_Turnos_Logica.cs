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
    public class Selector_Turnos_Logica
    {
        public bool InsertarTurno(int pacienteId, int doctorId, DateTime fecha, int turno)
        {
            try
            {
                using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
                {
                    // Verifica si ya existe el turno para ese doctor en esa fecha
                    string validar = @"SELECT COUNT(*) FROM TURNOSCONSULTA 
                               WHERE ID_TURNO = @turno AND ID_DOCTOR = @doctorId AND FECHATURNO = @fecha";

                    SqlCommand checkCmd = new SqlCommand(validar, conn);
                    checkCmd.Parameters.AddWithValue("@turno", turno);
                    checkCmd.Parameters.AddWithValue("@doctorId", doctorId);
                    checkCmd.Parameters.AddWithValue("@fecha", fecha.Date);

                    int existe = (int)checkCmd.ExecuteScalar();

                    if (existe > 0)
                    {
                        return false; // Ya existe el turno
                    }

                    // Insertar nuevo turno
                    string query = @"INSERT INTO TURNOSCONSULTA
                            (ID_TURNO, PACIENTE_ID, ID_DOCTOR, FECHATURNO, ESTADOTURNO)
                            VALUES (@turno, @pacienteId, @doctorId, @fecha, 'Sin atender')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@turno", turno);
                    cmd.Parameters.AddWithValue("@pacienteId", pacienteId);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@fecha", fecha.Date);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }
        public DataTable ObtenerTurnosPendientes(int doctorId, DateTime fecha)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"
    SELECT T.ID_TURNO,T.PACIENTE_ID,
           P.NOMBRE,
           P.APELLIDO,
           T.ESTADOTURNO
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
    }
}
