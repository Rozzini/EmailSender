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
            AppContext.SaveChanges();
        }
    }
}
