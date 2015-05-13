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
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login(string returnUrl)
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
                    FormsAuthentication.SetAuthCookie(user.gebruikersnaam, user.RememberMe);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Foutieve gebruikersnaam en of wachtwoord!");
                }
            }
            return View(user);
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
        
    }
}