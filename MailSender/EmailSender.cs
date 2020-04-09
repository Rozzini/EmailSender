using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Net;

namespace MailSender
{
    public class EmailSender
    {

        public  void SendEmail()
        {
            using (var db = new EmailDbContext())
            {
                foreach(var item in db.Models)
                {
                    MailAddress from = new MailAddress("pykelvl7mastery@gmail.com", "max");
                    MailAddress to = new MailAddress(item.Email.ToString());
                    MailMessage message = new MailMessage(from, to);
                    message.Subject = "Party  invitation>";
                    message.Body = "Hi, " + item.PersonName + " you’re invited to WPE (Worst Party Ever), 08 / 05 from 20:00 to 10:00 at https://goo.gl/maps/zVnXSnKkMCq2KNfHA Please let me know if you’re able to come";
                    message.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("pykelvl7mastery@gmail.com", "mak3387101");
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                }
            }
        }
        
    }
}
