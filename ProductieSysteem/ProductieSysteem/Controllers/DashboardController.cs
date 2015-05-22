using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductieSysteem.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Index()
        //{
            
        //        //User user = db.User.Find();
        //    List<SelectListItem> items = new List<SelectListItem>();

        //    items.Add(new SelectListItem { Text = "Vlees met bami!", Value = "0" });
        //        items.Add(new SelectListItem { Text = "Ochtend", Value = "1" });
        //        items.Add(new SelectListItem { Text = "Middag", Value = "0" });
        //        items.Add(new SelectListItem { Text = "Avond", Value = "0" });



        //        ViewBag.Dagdelen = items;
        //        return View ();
               

            
        //}

    }
}