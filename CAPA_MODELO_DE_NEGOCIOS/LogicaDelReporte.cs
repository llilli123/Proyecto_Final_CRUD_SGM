using CAPA_DATOS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    public class LogicaDelReporte
    {

        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; }
        public int TurnoId { get; set; }
        public LogicaDelReporte(int turnoId)
        {
            TurnoId = turnoId;
        }
        public Doctor ObtenerDatosDoctor(int doctorId)
        {
            Doctor doctor = null;

            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"SELECT NOMBRE, APELLIDO, CORREO 
                         FROM DOCTORES 
                         WHERE ID_DOCTOR = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", doctorId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            doctor = new Doctor
                            {
                                Nombre = reader["NOMBRE"].ToString(),
                                Apellido = reader["APELLIDO"].ToString(),
                                Correo = reader["CORREO"].ToString()
                            };
                        }
                    }
                }
            }

            return doctor;
        }
        public Paciente ObtenerDatosPaciente(int pacienteId)
        {
            Paciente paciente = null;

            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"SELECT NOMBRE, APELLIDO, GENERO, DOCUMENTO, FECHA_NACIMIENTO 
                         FROM PACIENTES 
                         WHERE PACIENTE_ID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", pacienteId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            paciente = new Paciente
                            {
                                Nombre = reader["NOMBRE"].ToString(),
                                Apellido = reader["APELLIDO"].ToString(),
                                Genero = reader["GENERO"].ToString(),
                                Documento = reader["DOCUMENTO"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["FECHA_NACIMIENTO"])
                            };
                        }
                    }
                }
            }

            return paciente;
        }
        public bool InsertarReporteMedico(int pacienteId, int doctorId, string motivo, string diagnostico, string tratamiento, string observaciones)
        {
            using (SqlConnection conn = new CONEXIONDATOS().AbrirConexion())
            {
                string query = @"INSERT INTO REPORTESMEDICOS 
                        (PACIENTE_ID, ID_DOCTOR, MOTIVOCONSULTA, DIAGNOSTICO, TRATAMIENTO, OBSERVACIONES)
                         VALUES (@pacienteId, @doctorId, @motivo, @diagnostico, @tratamiento, @observaciones)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pacienteId", pacienteId);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.Parameters.AddWithValue("@diagnostico", diagnostico);
                cmd.Parameters.AddWithValue("@tratamiento", tratamiento);
                cmd.Parameters.AddWithValue("@observaciones", observaciones);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
    public class Paciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
}
    public class Doctor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
    }


}