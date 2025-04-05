using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    
    public class LogicaBusquedaPAx
    {
        private CONEXIONDATOS conexion = new CONEXIONDATOS();
        public DataTable BuscarPacientes(string texto)

            
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                string query = @"SELECT PACIENTE_ID, NOMBRE, APELLIDO, DOCUMENTO, CORREO, TELEFONO, FECHA_NACIMIENTO, GENERO, NACIONALIDAD 
                         FROM PACIENTES
                         WHERE NOMBRE + ' ' + APELLIDO LIKE @texto 
                            OR DOCUMENTO LIKE @texto 
                            OR CORREO LIKE @texto";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                da.Fill(tabla);

                return tabla;
            }
        }
    }
}
