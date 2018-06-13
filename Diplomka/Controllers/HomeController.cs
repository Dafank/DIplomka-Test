using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Diplomka.Models;
using Diplomka.HtmlGenerator;

namespace Diplomka.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Translate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Translate(string Word)// передається англійське слово
        {
            List<string> ua_words = Translaters.SetData(Word);//повертає українське слово
            ViewBag.word = Word;// повертає українське слово
            return View(ua_words);// повертає наше слово на українській
        }

        public ActionResult Grammar()
        {
            return View();
        }
    }
}