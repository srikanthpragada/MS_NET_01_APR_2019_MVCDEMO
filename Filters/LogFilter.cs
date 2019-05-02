using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Filters
{
    public class LogFilterAttribute : ActionFilterAttribute 
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Response.Write("LogFilter.OnActionExecuting<p/>");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Response.Write("<p/>LogFilter.OnActionExecuted<p/>");
        }

       
    }
}