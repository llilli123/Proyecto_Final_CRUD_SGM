using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Microsoft.Data.SqlClient;
using CAPA_DATOS;


namespace CAPA_MODELO_DE_NEGOCIOS
{
    //TODO Esta clase es responsable de enviar correos relacionados con citas médicas.
    public class Logica_Envio_Correos_Base
    {
        protected string remitente = "medico.centro.uce@gmail.com"; // correo del hospital
        protected string contraseña = "fpde sdmb snmh htbn"; // contraseña del correo (clave de stmp)


        // Método para enviar un correo electrónico.
        public virtual void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            using (MailMessage mail = new MailMessage())
            {// Mailmessage es la clase que representa el correo electrónico
                // Configuración del correo en donde se define el remitente, destinatario, asunto y cuerpo del mensaje
                mail.From = new MailAddress(remitente);
                mail.To.Add(destinatario);
                mail.Subject = asunto;
                mail.Body = cuerpo;
                mail.IsBodyHtml = false;
                //stmp es el protocolo de transferencia de correo simple
                //aca se define el servidor smtp y el puerto, es puerto 587 porque es el puerto de gmail
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(remitente, contraseña);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
        // Método para obtener el correo del doctor a partir de su nombre.
        public string ObtenerCorreoDoctor(string nombreDoctor)
        {
            using (SqlConnection con = new CONEXIONDATOS().AbrirConexion())
            {
                string query = "SELECT CORREO FROM DOCTORES WHERE NOMBRE = @nombre";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", nombreDoctor);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }
    }

    //Herencia de la clase base para enviar correos específicos caundo se crea una cita
    public class CorreoCitaCreada : Logica_Envio_Correos_Base
    {
        public override void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
           
            base.EnviarCorreo(destinatario, asunto, cuerpo);
        }
       
    }
    //Herencia de la clase base para enviar correos específicos cuando se cancela una cita
    public class CorreoCitaCancelada : Logica_Envio_Correos_Base
    {
        public override void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            
            base.EnviarCorreo(destinatario, asunto, cuerpo);
        }
    }
}

