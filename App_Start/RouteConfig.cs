using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UIProject
{
    public class RouteConfig    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Smartwatches",
                url: "Products/SmartWatches",
                defaults: new { controller = "Products", action = "Smartwatches" }
            );
            routes.MapRoute(
    name: "Smartwatches2",
    url: "Products/SmartWatchesPage2",
    defaults: new { controller = "Products", action = "SmartwatchesPage2" }
);



            routes.MapRoute(
               name: "login",
               url: "Login",
               defaults: new { controller = "Identity", action = "login" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Homepage", id = UrlParameter.Optional }
            );
        }
    }
}
