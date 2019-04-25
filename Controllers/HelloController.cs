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
    }
}