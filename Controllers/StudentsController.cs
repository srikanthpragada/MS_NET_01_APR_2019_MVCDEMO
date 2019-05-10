using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class StudentsController : Controller
    {
        //CollegeContext ctx;

        //public StudentsController()
        //{
        //    ctx = new CollegeContext();
        //}

        // GET: Students
        public ActionResult Index()
        {
            var ctx = new CollegeContext();
            ViewBag.Count = ctx.Students.Count();
            ViewBag.TotalFee = ctx.Students.Sum(s => s.FeePaid);
            return View();
        }

        public ActionResult List()
        {
            var ctx = new CollegeContext();
            return View(ctx.Students.ToList());
        }

        [Authorize]
        public ActionResult Add()
        {
            TempData["Message"] = "";
            var model = new Student();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Add(Student model)
        {
            TempData["Message"] = "";

            if (ModelState.IsValid)
            {
                var ctx = new CollegeContext();
                try
                {
                    ctx.Students.Add(model);
                    ctx.SaveChanges();
                    TempData["Message"] = "Successfully added student!";
                    return RedirectToAction("Add"); // PRG - Post to Get

                }
                catch (Exception ex)
                {
                    TempData["Message"] = "Sorry! Could not add student!";
                    HttpContext.Trace.Write("Error in Add ->" + ex.Message);
                }
            }

            return View(model);
        }


        [Authorize]
        public ActionResult Edit()
        {
            return View();
        }


        [Authorize]
        public ActionResult Delete(int id)
        {
            var ctx = new CollegeContext();
            var student = ctx.Students.Find(id);
            if (student == null)
            {
                ViewBag.Message = "Sorry! Student Id not found!";
            }
            else
            {
                try
                {
                    ctx.Students.Remove(student);
                    ctx.SaveChanges();
                    ViewBag.Message = $"Student [{student.Name}] was deleted successfully";
                }
                catch (Exception ex)
                {
                    ViewBag.Message = $"Student [{student.Name}] was NOT deleted due to error!";
                    HttpContext.Trace.Write("Error in Delete  ->" + ex.Message);
                }

            }

            return View();
        }
    }
}