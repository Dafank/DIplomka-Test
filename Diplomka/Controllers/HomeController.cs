﻿using System;
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
            List<string> ua_words = Translaters.SetData(Word);
            ViewBag.word = Word;
            return View(ua_words);
        }

        public ActionResult Grammar()
        {
            return View();
        }
    }
}