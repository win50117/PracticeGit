﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ChingJen()
        {
            return View();
        }

        public ActionResult Contact()
        {//註解2
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ohohoh()
        {
            return View();
        }

        public ActionResult Teresa()
        {
            return View();
        }
    }
}