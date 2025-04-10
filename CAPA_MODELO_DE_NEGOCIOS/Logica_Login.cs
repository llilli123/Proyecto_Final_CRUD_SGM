using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    public class Logica_Login
    {

        private CONEXIONDATOS conexion = new CONEXIONDATOS();

        public bool SesionConectar(string usuario, string contrasena, out int idRol)
        {
            idRol = -1;

            try
            {
                using (SqlConnection con = new CONEXIONDATOS().AbrirConexion())
                {
                    string query = "SELECT ID_ROL FROM USUARIOS WHERE NOMBRE = @Nombre AND CONTRASENA_USUARIO = @Contrasena";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", usuario);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);


                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            idRol = Convert.ToInt32(resultado);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
               
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos", ex);

            }
        }
    }
}
