using ShoseShopDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoseShop.Controllers
{
    public class WebsiteController : Controller
    {
        ShoseShopEntities db = new ShoseShopEntities();
        // GET: Website
        public ActionResult Home()
        {
            var listCate = db.tbProductCates.ToList();
            return View(listCate);
        }
        public PartialViewResult Category()
        {
            var listCategory = db.tbProductCates.ToList();
            return PartialView(listCategory);
        }
        public PartialViewResult Slide()
        {
            var listSlide = db.tbSlides.ToList();
            return PartialView(listSlide);
        }
        public ViewResult Introduce()
        {
            return View();
        }
        [HttpGet]
        public JsonResult IntroduceAjax()
        {
            var introduce = db.tbIntroduces.First();
            return Json(introduce,JsonRequestBehavior.AllowGet);
        }
        public ViewResult New()
        {
            var listNew = db.tbNews.ToList();
            return View(listNew);
        }
    }
}