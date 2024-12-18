using Demo.DAL.Models;
using System.Net;
using System.Net.Mail;

namespace Demo.Presentation.Helper
{
    public class EmailSettings
    {
        public static void SendEmail(Email email)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("alimohamedelnaggar400@gmail.com", "uvprgvtlvqzskamk");
            client.Send("alimohamedelnaggar400@gmail.com", email.To, email.Subject, email.Body);
        }
    }
}
