﻿using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public string Now()
        {
            return DateTime.Now.ToString();
        }

        public ActionResult Table()
        {
            return View();
        }

        public ActionResult GenerateTable(TableViewModel model)
        {
           
            return PartialView(model);
        }
    }
}