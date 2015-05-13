using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ProductieSysteem.Models;

namespace ProductieSysteem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
      
        public ActionResult Index()
        {
            if (Request.IsAuthenticated == false)               
            {
                //RedirectToAction("Index", "Login");
                Response.Redirect("~/");
            }
        
            return View();
        }

       
    }
}