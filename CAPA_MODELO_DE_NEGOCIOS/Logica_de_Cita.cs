using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;
using Microsoft.Data.SqlClient;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    // Clase que contiene la lógica de negocio para registrar citas médicas
    public class Logica_de_Cita
    {
        // Instancia de la clase que maneja la conexión a la base de datos
        private CONEXIONDATOS conexion = new CONEXIONDATOS();

        public bool RegistrarCita(Cita cita)
        {
            try
            {  
                // Abrir la conexión 
                using (SqlConnection conn = conexion.AbrirConexion())
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
                    TimeSpan hora = DateTime.Parse(cita.HoraCita).TimeOfDay;
                    cmdInsert.Parameters.AddWithValue("@hora", hora);

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
