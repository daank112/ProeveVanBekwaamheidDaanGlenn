using ProductieSysteem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProductieSysteem.Controllers
{
    public class AccountController : Controller
    {
        DefaultConnection db = new DefaultConnection();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Login user)
        {
            if (ModelState.IsValid)
            {
                if (user.IsValid(user.gebruikersnaam, user.wachtwoord))
                {
                    FormsAuthentication.SetAuthCookie(user.gebruikersnaam, user.OnthoudMij);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Gebruikersnaam en of wachtwoord zijn incorect!!");
                }
            }
            return View(user);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult NieuweGebruiker()
        {
            ViewBag.gebruikersId = new SelectList(db.tbl_login, "gebruikersId", "Voornaam");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NieuweGebruiker([Bind(Include = "gebruikersId,gebruikersnaam,wachtwoord")] Login login)
        {
            if (ModelState.IsValid)
            {               
                db.tbl_login.Add(login);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.gebruikersId = new SelectList(db.tbl_login, "gebruikersId", "voornaam",  login);
            return View(login);
        }
    }
}