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
    public class Logica_Envio_Correos_Base
    {
        protected string remitente = "medico.centro.uce@gmail.com"; // correo del hospital
        protected string contraseña = "fpde sdmb snmh htbn"; // contraseña del correo (usa clave de aplicación si es Gmail)

        public virtual void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(remitente);
                mail.To.Add(destinatario);
                mail.Subject = asunto;
                mail.Body = cuerpo;
                mail.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(remitente, contraseña);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
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
    public class CorreoCitaCreada : Logica_Envio_Correos_Base
    {
        public override void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            // Personalizar si deseas
            base.EnviarCorreo(destinatario, asunto, cuerpo);
        }
       
    }
    public class CorreoCitaCancelada : Logica_Envio_Correos_Base
    {
        public override void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            // Puedes modificar el asunto o cuerpo aquí antes de enviar si lo deseas
            base.EnviarCorreo(destinatario, asunto, cuerpo);
        }
    }
}

