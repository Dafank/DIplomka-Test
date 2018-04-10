using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diplomka.Models.User.Login;
using Diplomka.Models.User.Registration;

namespace Diplomka.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginData login)
        {
            DateTime x = new DateTime();
            if (ModelState.IsValid)
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            else
            {
                return View();
            }
        }
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrationData registration)
        {
            if (ModelState.IsValid)
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            else
            {
                return View();
            }
        }
    }
}