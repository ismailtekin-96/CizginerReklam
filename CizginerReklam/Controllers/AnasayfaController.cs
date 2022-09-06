using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CizginerReklam.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        public ActionResult anasayfa()
        {
            return View();
        }
        public PartialViewResult PartialSlider1()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider2()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider3()
        {
            return PartialView();
        }
    }
}