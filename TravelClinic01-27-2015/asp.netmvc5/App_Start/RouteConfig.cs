using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace asp.netmvc5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null, "connector", new { controller = "File", action = "Index" });

            routes.MapRoute(
                "Index",
                "DocumentRepository/Index",
                new
                {
                    controller = "DocumentRepository",
                    action = "Index"
                }
            );

            routes.MapRoute(
                "Files",
                "DocumentRepository/Files/{subFolder}",
                new
                {
                    controller = "DocumentRepository",
                    action = "Files"
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Hello",
                url: "{controller}/{action}/{name}/{id}"
                );
        }
    }
}
