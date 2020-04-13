using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Net;
namespace MailSender 
{
    public class EmailSender
    {
        public Lazy<SmtpClient> smtpClient = new Lazy<SmtpClient>(() =>
       {
           SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
           smtp.UseDefaultCredentials = false;
           smtp.Credentials = new NetworkCredential("pykelvl7mastery@gmail.com", "mak3387101");
           smtp.EnableSsl = true;
           return smtp;
       }, true);
       
        public void SendEmail()
        {
            int i = 0;
            using (var db = new EmailDbContext())
            {
                foreach (var item in db.Models)
                {
                    string threadName = "Thread number: " + i;
                    MailAddress from = new MailAddress("pykelvl7mastery@gmail.com", "max");
                    MailAddress to = new MailAddress(item.Email.ToString());
                    var message = MessageFabric.CreateMail(from, to, item);
                    SendMessageInThread(message, threadName);
                    Logger.Default.Write("Did send message;");
                    i++;
                }
            }
        }


        public void SendMessage(object message)
        {
            Thread.Sleep(400);
            MailMessage mailMessage = (MailMessage)message;
            smtpClient.Value.Send(mailMessage);
            Logger.Default.Write("Email sending to: " + mailMessage.To.ToString() + ";");
        }
        public void SendMessageInThread(MailMessage message, string threadNum)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(SendMessage));
            thread.Name = threadNum;
            thread.IsBackground = true;
            Logger.Default.Write("\nStarting thread;");
            Logger.Default.Write("Thread name: " + thread.Name.ToString());
            thread.Start(message);
            thread.Join();
        }

        public class MessageFabric
        {
            public static MailMessage CreateMail(MailAddress from, MailAddress to, Models item)
            {
                MailMessage message = new MailMessage(from, to);
                message.Subject = "Party  invitation";
                message.Body = "Hi, " + item.PersonName + " you’re invited to WPE (Worst Party Ever), 08 / 05 from 20:00 to 10:00 at https://goo.gl/maps/zVnXSnKkMCq2KNfHA Please let me know if you’re able to come";
                message.IsBodyHtml = true;
                return message;
            }
        }

    }
}
