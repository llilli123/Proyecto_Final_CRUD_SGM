using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    public class LogicaCitas
    {
        private CONEXIONDATOS conexion = new CONEXIONDATOS();

        public DataTable ObtenerCitas()
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "SELECT ID_CITA,NOMBRE,APELLIDO,CORREO,TELEFONO,FECHA, HORA,ESTADOCITA FROM CITAS";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }
        public bool EliminarCita(int citaId)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = "DELETE FROM CITAS WHERE ID_CITA = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", citaId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool ModificarCita(int id, string NOMBRE, string APELLIDO, string CORREO, int TELEFONO, DateTime FECHA, string HORA)
        {
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


    








