using FluentScheduler;
using MailSender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMailSender
{
    public class MyJob : IJob
    {
        public void Execute()
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail();
        }
    }
}
