using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoseShop.Controllers
{
    public class WebsiteController : Controller
    {
        // GET: Website
        public ActionResult Home()
        {
            return View();
        }
    }
}