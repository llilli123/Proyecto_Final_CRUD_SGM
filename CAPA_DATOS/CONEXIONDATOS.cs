using Microsoft.Data.SqlClient;
namespace CAPA_DATOS
{
    // Esta clase gestiona la conexión a la base de datos SQL Server para el proyecto.
    // Proporciona métodos para abrir y cerrar la conexión.
    public class CONEXIONDATOS

    {
        // TODO: Declaracion de la conexion al SQL 
        private SqlConnection Conexion;

        // Constructor de la clase CONEXIONDATOS
        // Inicia la conexión con la cadena de conexión al servidor y BD
        public CONEXIONDATOS()
        {
            // TODO: Instancia de la cadena de conexión
            Conexion = new SqlConnection("Server=.; Database=Proyecto_Final_SGM; Integrated Security=true; TrustServerCertificate=True");
        }
        // Método para abrir la conexion a la bd
        public SqlConnection AbrirConexion()
        {
            // TODO: Verifica si la conexion esta cerrada antes de intentar abrirla
            if (Conexion.State == System.Data.ConnectionState.Closed)
            {
                // TODO: Abre la conexion si esta cerrada
                Conexion.Open();
            }
            return Conexion;
        }
        // Método para cerrar la conexion a la bd
        public void CerrarConexion()
        {
            // TODO: Verifica si la conexion esta abierta antes de cerrarla
            if (Conexion.State == System.Data.ConnectionState.Open)
            {
                // TODO: Cierra la conexion si esta abierta
                Conexion.Close();
            }
        }
    }
}