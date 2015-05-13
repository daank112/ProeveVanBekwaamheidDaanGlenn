using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProductieSysteem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
       
        public ActionResult Index()
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
        public ActionResult Index(Models.User user)
        {
           
                if (ModelState.IsValid)
                {
                    if (user.IsValid(user.UserName, user.Password))
                    {

                        FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);

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
