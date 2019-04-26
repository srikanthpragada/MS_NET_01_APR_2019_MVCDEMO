using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class InterestController : Controller
    {
     
        [HttpGet]
        public ActionResult Index()
        {
            Interest model = new Interest();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Interest model)
        {
            model.Result = model.Amount * model.Rate / 100;
            return View(model);
        }
    }
}