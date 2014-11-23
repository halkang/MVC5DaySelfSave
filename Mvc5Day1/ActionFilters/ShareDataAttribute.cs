using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5Day1.ActionFilters
{
    public class ShareDataAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);

            filterContext.Controller.ViewBag.P1 = "Will";
            filterContext.Controller.ViewBag.P2 = "John";

            //filterContext.Result = new RedirectResult("/");
        }
    }
}