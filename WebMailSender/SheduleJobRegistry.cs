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
    public class SheduleJobRegistry : Registry
    {
        public SheduleJobRegistry()
        {
            Schedule<MyJob>()
                   .NonReentrant()
                   .ToRunOnceAt(15, 55);
            DateTime localDate = DateTime.Now;
            string date = localDate.ToString("MM-dd-yyyy-HH-mm");
            string sendingDate = localDate.ToString("MM-dd-yyyy");
            Logger.Default.Write(date + "\nMessages sending time: " + sendingDate + "-18-50");
        }
    }
}

