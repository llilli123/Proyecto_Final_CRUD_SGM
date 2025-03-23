using Microsoft.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CONEXIONDATOS
    {
        private SqlConnection Conexion = new SqlConnection("Server=.; Database = Proyecto_Final_SGM; Integrated Security =true");
    }
}
