using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UIProject.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Smartwatches()
        {
            return View();
        }
        public ActionResult SmartwatchesPage2()
        {
            return View();
        }
    }
}