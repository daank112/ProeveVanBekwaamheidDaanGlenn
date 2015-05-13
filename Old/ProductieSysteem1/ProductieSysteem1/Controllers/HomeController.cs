using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductieSysteem1.Models;

namespace ProductieSysteem1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CatDBContext cat = new CatDBContext();

            return View(cat.Categorien.ToList());
        }
    }
}