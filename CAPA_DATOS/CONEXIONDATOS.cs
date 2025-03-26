using Microsoft.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CONEXIONDATOS
    {
        private SqlConnection Conexion;

        public CONEXIONDATOS()
        {
            Conexion = new SqlConnection("Server=.; Database=Proyecto_Final_SGM; Integrated Security=true; TrustServerCertificate=True");
        }
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }
        public void CerrarConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
            }
        }
    }
}