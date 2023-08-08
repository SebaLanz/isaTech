using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace TPProgramacionA.ClasesModuloUsuarios
{
    internal class EnvioMail
    {
        public static void EnvioDeMail(string Subject, string Body, string CorreoReceptor)
        {

            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde";
            string from = "ProgramacionAvanzadaISA@hotmail.com";
            string displayName = "ISA PROGRAMACIÓN AVANZADA";

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(Subject);

                mail.Subject = Body;
                mail.Body = CorreoReceptor;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient();
                client.Host = "smtp.office365.com";
                client.Port = 587;               
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;

                // se envía el correo
                client.Credentials = new NetworkCredential(from, "ISA1234!", "smtp.office365.com");
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

           
                client.Send(mail);
                msge = "Correo enviado exitosamente";
            }
            catch (Exception ex)
            {
                msge = ex.Message;
            }           
        }
    }
}



