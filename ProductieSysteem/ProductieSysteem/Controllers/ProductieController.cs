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
            return View();
        }
        public ActionResult ProductieBijstellen()
        {
            return View();
        }
    }
}