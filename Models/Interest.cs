using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class Interest
    {
        [Range(10000, double.MaxValue, ErrorMessage ="Invalid value for amount")]
        public double Amount { get; set; }

        [Range(5,50,ErrorMessage ="Invalid interest rate")]
        public double Rate { get; set; }

        public double Result { get; set; }
    }
}