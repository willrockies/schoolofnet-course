using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.SRP.Solucao
{
    public static class EmailServices
    {
        public static bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public static void Enviar(string de, string para, string assunto, string messagem)
        {

            var mail = new MailMessage(de, para);

            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com",
            };

            mail.Subject = assunto;
            mail.Body = messagem;
            client.Send(mail);

        }
    }
}
