using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;
using System.Text;

namespace MailSender
{/// <summary>
/// Send an email from [DELETED]
/// </summary>
/// <param name="to">Message to address</param>
/// <param name="body">Text of message to send</param>
/// <param name="subject">Subject line of message</param>
/// <param name="fromAddress">Message from address</param>
/// <param name="fromDisplay">Display name for "message from address"</param>
/// <param name="credentialUser">User whose credentials are used for message send</param>
/// <param name="credentialPassword">User password used for message send</param>
/// <param name="attachments">Optional attachments for message</param>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sending");
            EmailSender a = new EmailSender();
            a.SendEmail();
           
        }
    }
}
