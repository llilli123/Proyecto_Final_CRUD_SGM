using CAPA_DATOS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    //TODO Esta clase contiene la lógica de negocio para manejar los reportes médicos.
    public class LogicaDelReporte
    {
        //TODO Propiedades para almacenar los IDs de paciente y doctor
        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; }
        public int TurnoId { get; set; }
        public LogicaDelReporte(int turnoId)
        {
            TurnoId = turnoId;
        }
        //TODO Método para obtener el ID del paciente a partir del ID del turno
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

                    // Ejecutar la consulta y obtener los datos del doctor
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // El executereader hace una consulta a la base de datos y devuelve un SqlDataReader
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

        // TODO Método para obtener el ID del paciente a partir del ID del turno
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
                                //TODO Asignar los valores de las columnas a las propiedades del objeto Paciente
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

        //TODO Método para insertar un nuevo reporte médico en la base de datos
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
    //TODO Clase para representar un paciente
    public class Paciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }// TODO Clase para representar un doctor
    public class Doctor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
    }


}