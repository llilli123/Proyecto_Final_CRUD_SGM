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
    //TODO Esta clase contiene la logica de consultagestion
    public class LogicaConsultaGestion
    {
        private CONEXIONDATOS conexion = new CONEXIONDATOS();

        /// Método para obtener los datos de los doctores
        public DataTable ObtenerDoctores()
        {
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                string query = "SELECT ID_DOCTOR, NOMBRE + ' ' + APELLIDO AS NombreCompleto FROM DOCTORES";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

       
            
}
}
