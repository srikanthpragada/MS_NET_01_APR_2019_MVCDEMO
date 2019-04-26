using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View(); // returns  Index.cshtml 
        }

        // Hello/Welcome 
        public string Welcome()
        {
            return "Welcome To ASP.NET MVC";
        }


        public ActionResult Wish()
        {
            var hour = DateTime.Now.Hour;
            var msg = "Good Evening!";

            if (hour < 12)
                msg = "Good Morning!";
            else
                if (hour < 17)
                msg = "Good Afternoon!";

            ViewBag.Message = msg;

            return View();
        }

        public ActionResult Wish2(string name)
        {
            var hour = DateTime.Now.Hour;
            UserMessage msg = new UserMessage();
            msg.Message  = "Good Evening!";
            if (name == null)
                msg.Name = "Unknown";
            else
                msg.Name = name;

            if (hour < 12)
                msg.Message= "Good Morning!";
            else
                if (hour < 17)
                 msg.Message = "Good Afternoon!";

            return View(msg); // pass model to view 
        }
    }
}