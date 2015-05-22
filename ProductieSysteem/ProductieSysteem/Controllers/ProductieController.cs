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
           // return View();
                List<SelectListItem> items = new List<SelectListItem>();

                items.Add(new SelectListItem { Text = "  ", Value = "0" });
                items.Add(new SelectListItem { Text = "Komkommer", Value = "1" });
                items.Add(new SelectListItem { Text = "Tomaat", Value = "0" });
                items.Add(new SelectListItem { Text = "Paprika", Value = "0" });



                ViewBag.Dagdelen = items;
                return View();
        }


        public ActionResult ProductieBijstellen()
        {
            ViewData["Message"] = "Productie bijstellen";
            return View();
        }
    }
}