using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ProductieSysteem.Models;
using System.Globalization;

namespace ProductieSysteem.Controllers
{
    
    public class DashboardController : Controller
    {
        EFDbContext db = new EFDbContext();
     
        // GET: Dashboard
       // [Authorize]
        public ActionResult Index()
        {
            if (Request.IsAuthenticated == false)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                //User user = db.User.Find();
                List<SelectListItem> items = new List<SelectListItem>();

                items.Add(new SelectListItem { Text = "Niet beschikbaar", Value = "0" });
                items.Add(new SelectListItem { Text = "Ochtend", Value = "1" });
                items.Add(new SelectListItem { Text = "Middag", Value = "0" });
                items.Add(new SelectListItem { Text = "Avond", Value = "0" });

                CalendarWeekRule weekRule = CalendarWeekRule.FirstFourDayWeek;
                DayOfWeek firstWeekDay = DayOfWeek.Monday;
                Calendar calendar = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar;

                int currentWeek = calendar.GetWeekOfYear(DateTime.Now, weekRule, firstWeekDay);


                ViewBag.Dagdelen = items;
                return View(new Dashboard
                {
                    
                    WeekNummer = currentWeek.ToString()
                }
                    );
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult Week(Dashboard model )
        {
            

            return View();
        }
        public ActionResult DagVerwachting()
        {

            CategorieDbContect model = new CategorieDbContect();

           
            return View(model);
        }
    }
}