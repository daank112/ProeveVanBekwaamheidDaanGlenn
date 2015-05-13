using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProductieSysteem.Models;
using System.Web.Security;

namespace ProductieSysteem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        DefaultConnection db = new DefaultConnection();

        public ActionResult Index()
        {
            //var GebruikersList = from m in db.Gebruikers
            //                     where m.voornaam == "daan"
            //                     select m;
            //GebruikersList.ToList()
            return View();
        }
        
    }
}