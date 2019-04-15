using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _200389510F.Models;

namespace _200389510F.Controllers
{
    public class ChatMessagesController : Controller
    {
        private ChatMessageContext db = new ChatMessageContext();

        // GET: ChatMessages
        [Route("Chat")]
        public ActionResult Index()
        {
            ChatMessageViewModel vm = new ChatMessageViewModel()
            {
                Messages = db.ChatMessages.ToList()
            };
            return View(vm);
        }


        // GET: ChatMessages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChatMessages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("Chat")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Message,Name,Date")] ChatMessage newMessage)
        {
            ChatMessageViewModel vm;
            if (ModelState.IsValid)
            {
                newMessage.Date = DateTime.Now;
                db.ChatMessages.Add(newMessage);
                db.SaveChanges();
                ModelState.Clear();
                vm = new ChatMessageViewModel()
                {
                    Messages = db.ChatMessages.ToList(),
                };
                return PartialView("Index", vm);
            }

            vm = new ChatMessageViewModel()
            {
                Messages = db.ChatMessages.ToList(),
                newMessage = newMessage
            };
            return PartialView("Index", vm);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
