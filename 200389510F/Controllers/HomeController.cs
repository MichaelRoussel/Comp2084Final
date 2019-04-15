using _200389510F.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _200389510F.Controllers
{
    public class HomeController : Controller
    {
        private ChatMessageContext db = new ChatMessageContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Chat()
        {

            return View(db.ChatMessages.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}