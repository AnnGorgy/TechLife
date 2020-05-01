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
               name: "ann1",
               url: "gp/ann",
               defaults: new { controller = "Hadil", action = "ann1" }
           );
            routes.MapRoute(
                name: "Smartwatches",
                url: "Products/SmartWatches",
                defaults: new { controller = "Products", action = "Smartwatches" }
            );
            routes.MapRoute(
    name: "Smartwatches2",
    url: "Products/SmartwatchesPage2",
    defaults: new { controller = "Products", action = "SmartwatchesPage2" }
);
            routes.MapRoute(
   name: "SmartTelevisions",
   url: "Products/SmartTelevisions",
   defaults: new { controller = "Products", action = "SmartTelevisions" }
);
            routes.MapRoute(
 name: "PS4",
 url: "Products/VideoGames/PS4",
 defaults: new { controller = "Products", action = "PS4" }
);
            routes.MapRoute(
name: "PS4Page2",
url: "Products/VideoGames/PS4Page2",
defaults: new { controller = "Products", action = "PS4Page2" }
);
            routes.MapRoute(
name: "XBOX",
url: "Products/VideoGames/XBOX",
defaults: new { controller = "Products", action = "XBOX" }
);
            routes.MapRoute(
name: "XBOXPage2",
url: "Products/VideoGames/XBOXPage2",
defaults: new { controller = "Products", action = "XBOXPage2" }
);
            routes.MapRoute(
name: "GamingLaptops",
url: "Products/Computers/GamingLaptops",
defaults: new { controller = "Products", action = "GamingLaptops" }
);
            routes.MapRoute(
name: "LaptopsPage2",
url: "Products/Computers/LaptopsPage2",
defaults: new { controller = "Products", action = "LaptopsPage2" }
);
            routes.MapRoute(
name: "Laptops",
url: "Products/Computers/Laptops",
defaults: new { controller = "Products", action = "Laptops" }
);
            routes.MapRoute(
    name: "AppleIphone",
    url: "Products/MobilePhones/AppleIphone",
    defaults: new { controller = "Products", action = "AppleIphone" }
    );
            routes.MapRoute(
   name: "AppleIphone2",
   url: "Products/MobilePhones/AppleIphone2",
   defaults: new { controller = "Products", action = "AppleIphone2" }
   );

            routes.MapRoute(
    name: "Samsung",
    url: "Products/MobilePhones/Samsung",
    defaults: new { controller = "Products", action = "Samsung" }
    );

            routes.MapRoute(
  name: "Samsung2",
  url: "Products/MobilePhones/Samsung2",
  defaults: new { controller = "Products", action = "Samsung2" }
  );

            routes.MapRoute(
               name: "About",
               url: "Home/About",
               defaults: new { controller = "Home", action = "About" }
           );


            routes.MapRoute(
               name: "login",
               url: "login",
               defaults: new { controller = "Identity", action = "login" }
           );
            routes.MapRoute(
              name: "Register",
              url: "Register",
              defaults: new { controller = "Identity", action = "Register" }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Homepage", id = UrlParameter.Optional }
            );
        }
    }
}
