using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_MODELO_DE_NEGOCIOS
{
    //TODO Esta clase contiene la lógica de negocio para la autenticación de usuarios.
    public class Logica_Login
    {

        private CONEXIONDATOS conexion = new CONEXIONDATOS();

        // Método para autenticar un usuario en la base de datos
        public bool SesionConectar(string usuario, string contrasena, out int idRol)
        {
            //idRol es un entero que representa el rol del usuario en la base de datos en este caso es -1 porque no se ha encontrado el rol aun
            idRol = -1;

            try
            {
                using (SqlConnection con = new CONEXIONDATOS().AbrirConexion())
                {
                    //consultar el ID_ROL del usuario en la base de datos
                    string query = "SELECT ID_ROL FROM USUARIOS WHERE NOMBRE = @Nombre AND CONTRASENA_USUARIO = @Contrasena";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", usuario);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                        // crea un objeto resultado que almacena el resultado de la consulta
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        // convierte el resultado a un entero si no es nulo 
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

            }// error al conectar a la base de datos
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos", ex);

            }
        }
    }
}
