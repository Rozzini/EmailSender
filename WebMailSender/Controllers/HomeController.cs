using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebMailSender.Controllers
{
    public class HomeController : Controller
    {

        IModel model;

        public HomeController(IModel _model)
        {
            model = _model;
        }

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Model User)
        {
            model.CreateInvitation(User);
            //model.SendEmails();
            Index();
            return View();
        }

        [HttpPost]
        public void SendEmails()
        {
            Index();
        }
    }
}