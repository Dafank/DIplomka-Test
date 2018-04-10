using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diplomka.Models;

namespace Diplomka.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Translate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Translate(string Word)
        {
            string s = Translaters.SetData(Word);
            Object s1 = s;
            return View(s1);
        }

        public ActionResult Grammar()
        {
            return View();
        }
    }
}