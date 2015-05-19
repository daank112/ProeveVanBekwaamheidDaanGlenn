using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductieSysteem.Models;


namespace ProductieSysteem.Controllers
{
    public class ProductieController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductieOpgeven()
        {
            ViewData["Message"] = "Productie opgeven";
            return View();
        }
        public ActionResult ProductieBijstellen()
        {
            ViewData["Message"] = "Productie bijstellen";
            return View();
        }
    }
}