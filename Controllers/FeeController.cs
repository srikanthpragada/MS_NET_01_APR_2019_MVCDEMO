using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class FeeController : Controller
    {
        // GET: Fee
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int fee, string timings, string material)
        {
            HttpContext.Response.Write(fee + "," + timings + "," + material);

            if (timings == "a")
                fee = fee * 80/100;
            else
                if ( timings == "m")
                fee = fee * 90 / 100;

            if (material == "m")
                fee += 500;

            ViewBag.Fee = fee;

            return View();
        }

        [HttpGet]
        public ActionResult Calculate()
        {
            FeeViewModel model = new FeeViewModel();
            model.Timings = "e";
            return View(model);
        }
        [HttpPost]
        public ActionResult Calculate(FeeViewModel model)
        {
            int fee = Int32.Parse(model.Fee);

            if (model.Timings == "a")
                    fee = fee * 80 / 100;
                else
                 if (model.Timings == "m")
                    fee = fee * 90 / 100;

            if (model.Material)
                fee += 500;

            ViewBag.Fee = fee;
            return View(model);
        }

    }
}