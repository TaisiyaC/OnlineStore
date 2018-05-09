using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DAL.Identity
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // настройка логина, пароля отправителя
            var from = "taya0805@gmail.com";
            var pass = "432432nf.irf";

            Task t = Task.Run(async () =>
            {
                // You should use using block so .NET can clean up resources
                using (var client = new SmtpClient("smtp.gmail.com", 587))
                {
                    MailMessage msg = new MailMessage();

                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential(from, pass);
                    client.EnableSsl = true;

                    // создаем письмо: message.Destination - адрес получателя
                    var mail = new MailMessage(from, message.Destination);
                    mail.Subject = message.Subject;
                    mail.Body = message.Body;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.High;

                    await client.SendMailAsync(mail);
                }
            });

            return t;
        }
    }
}
