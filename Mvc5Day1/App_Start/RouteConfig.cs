﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc5Day1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", message = UrlParameter.Optional },
                constraints: new
                {
                    id = @"\d+"
                }
            );

            routes.MapRoute(
                name: "Default2",
                url: "{controller}/{action}/{message}",
                defaults: new { controller = "Home", action = "Index", message = UrlParameter.Optional },
                constraints: new
                {
                    message = @"(Hello)|(Hi)|(Check)"
                }
            );
        }
    }
}
