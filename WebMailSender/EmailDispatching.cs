using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using FluentScheduler;
using System.Threading.Tasks;
using MailSender;

namespace WebMailSender
{
    public class EmailDispatching : Registry
    {
        public async void SendEMails()
        {
            EmailSender emailSender = new EmailSender();
            await Task.Run(() => Schedule(() => emailSender.SendEmail()).ToRunEvery(1).Days().At(23, 36));
        }
    }
}

