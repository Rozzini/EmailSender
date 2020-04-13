using MailSender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebMailSender
{
    public class ModelRepository : IModel
    {
        private readonly AppContext AppContext;

        public ModelRepository(AppContext  appContext)
        {
            this.AppContext = appContext;
        }

        public void CreateInvitation(Model Models)
        {
            AppContext.Models.Add(Models);
            DateTime localDate = DateTime.Now;
            string date = localDate.ToString("MM-dd-yyyy-HH-mm");
            Logger.Default.Write(date + "\nData add to data base: " + Models.Email + " " + Models.PersonName + ";");
            AppContext.SaveChanges();
        }
    }
}
