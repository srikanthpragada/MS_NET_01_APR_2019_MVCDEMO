using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcDemo.Controllers
{
    public class UserController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


        [HttpPost]
        public ActionResult Login(string pwd)
        {
            if (pwd == "123")
            {
                FormsAuthentication.SetAuthCookie("guest", false);
                string url = Request.QueryString["ReturnUrl"];
                if (url == null)
                    url = "/Students/Index";

                return Redirect(url);

            }
            else
            {
                ViewBag.Message = "Invalid Password. Try again.";
                return View();
            }

        }
    }
}