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
            var GebruikersList = from m in db.Gebruikers
                                 where m.voornaam == "daan"
                                 select m;
            return View(GebruikersList.ToList());
        }
        public ActionResult Login()
        {

            if (Request.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Login(Models.Login user)
        {

            if (ModelState.IsValid)
            {
                if (user.IsValid(user.gebruikersnaam, user.wachtwoord))
                {

                    FormsAuthentication.SetAuthCookie(user.gebruikersnaam, user.RememberMe);

                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Fout!");
                }
            }
            return View(user);
        }
    }
}