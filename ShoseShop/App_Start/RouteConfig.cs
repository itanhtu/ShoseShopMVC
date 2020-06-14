using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShoseShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "New",
                url: "tin-tuc",
                defaults: new { controller = "Website", action = "New", id = UrlParameter.Optional }
            );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Introduce",
                url: "gioi-thieu",
                defaults: new { controller = "Website", action = "Introduce", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Website", action = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
