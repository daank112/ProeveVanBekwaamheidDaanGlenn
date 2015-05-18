using ProductieSysteem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
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
        public ActionResult Login(Models.login user)
        {
            if (ModelState.IsValid)
            {
                if (user.IsValid(user.gebruikersnaam, user.wachtwoord))
                {
                    //FormsAuthentication.SetAuthCookie(user.gebruikersnaam );
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
            //ViewBag.gebruikersId = new SelectList(db.tbl_gebruikers, "gebruikersId", "Voornaam");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NieuweGebruiker([Bind(Include = "gebruikersId,voornaam,achternaam,bedrijfsnaam,adres,plaats,postcode,email,gebruikersType")] gebruikers gebruiker)
        {
            if (ModelState.IsValid)
            {
                db.gebruikers.Add(gebruiker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

           // ViewBag.gebruikersId = new SelectList(db.tbl_gebruikers, "gebruikersId", "voornaam",  gebruiker);
            return View(gebruiker);
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_gebruikers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "gebruikersnaam,wachtwoord")] login login, string wachtwoord)
        {
       
            try
            {
                if (ModelState.IsValid)
                {

                    string passwordIsHashed = login.PasswordHash(wachtwoord);
                    login.wachtwoord = passwordIsHashed;
                    db.login.Add(login);
                    db.SaveChanges();
                    db.GetValidationErrors();
                    
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
           

            return View(login);
        }

    }
}