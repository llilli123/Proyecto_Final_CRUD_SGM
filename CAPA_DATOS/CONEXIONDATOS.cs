﻿using Microsoft.Data.SqlClient;

namespace CAPA_DATOS
{// conexion a la base de datos
    public class CONEXIONDATOS
    {
        private SqlConnection Conexion = new SqlConnection("Server=.; Database = Proyecto_Final_SGM; Integrated Security =true");
    }
}
