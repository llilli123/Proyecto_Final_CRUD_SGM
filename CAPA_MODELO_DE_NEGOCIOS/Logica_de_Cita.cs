using System;
using System.Collections.Generic;
using System.Text;
using CAPA_MODELO_DE_NEGOCIOS;
using CAPA_DATOS;
using Microsoft.Data.SqlClient;

namespace CAPA_LOGICA_DE_NEGOCIOS
{
    public class Logica_de_Cita
    {
        private CONEXIONDATOS conexion = new CONEXIONDATOS();

        public bool RegistrarCita(Cita cita)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    // Buscar el ID del doctor según el nombre que seleccionaste
                    string queryBuscarDoctor = "SELECT ID_DOCTOR FROM DOCTORES WHERE NOMBRE = @nombreDoctor";
                    SqlCommand cmdDoctor = new SqlCommand(queryBuscarDoctor, conn);
                    cmdDoctor.Parameters.AddWithValue("@nombreDoctor", cita.Doctor);

                    object result = cmdDoctor.ExecuteScalar();

                    if (result == null)
                        throw new Exception("No se encontró el doctor en la base de datos.");

                    int idDoctor = Convert.ToInt32(result);

                    // Insertar la cita en la base de datos
                    string queryInsertarCita = @"
                        INSERT INTO CITAS (NOMBRE, APELLIDO, CORREO, TELEFONO, FECHA, HORA, ID_DOCTOR)
                        VALUES (@nombre, @apellido, @correo, @telefono, @fecha, @hora, @idDoctor)";

                    SqlCommand cmdInsert = new SqlCommand(queryInsertarCita, conn);
                    cmdInsert.Parameters.AddWithValue("@nombre", cita.Nombre);
                    cmdInsert.Parameters.AddWithValue("@apellido", cita.Apellido);
                    cmdInsert.Parameters.AddWithValue("@correo", cita.Correo);
                    cmdInsert.Parameters.AddWithValue("@telefono", cita.Telefono);
                    cmdInsert.Parameters.AddWithValue("@fecha", cita.FechaCita.Date);

                    // Convertir HoraCita a formato TIME
                    TimeSpan hora = DateTime.Parse(cita.HoraCita).TimeOfDay;
                    cmdInsert.Parameters.AddWithValue("@hora", hora);

                    cmdInsert.Parameters.AddWithValue("@idDoctor", idDoctor);

                    int filasAfectadas = cmdInsert.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la cita: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(); // Cierra la conexión al final
            }
        }
    }
}
