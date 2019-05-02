using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class CacheController : Controller
    {
     
        [OutputCache(Duration = 60, VaryByParam ="p1")]
        public ActionResult Index()
        {
            ViewBag.Info = DateTime.Now.ToString(); 
            return View();
        }
    }
}