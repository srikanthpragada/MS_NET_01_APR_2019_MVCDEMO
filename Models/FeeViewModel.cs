using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Models
{
    public class FeeViewModel
    {
        public string Fee { get; set; }
        public string Timings { get; set; }
        public bool Material { get; set; }

        public List<SelectListItem> Courses =
            new List<SelectListItem>
            {
                new SelectListItem { Text = "Java", Value = "4000"},
                new SelectListItem { Text = "Python", Value = "4500"},
                new SelectListItem { Text = "MS.NET", Value = "6000"}
            };


    }
}