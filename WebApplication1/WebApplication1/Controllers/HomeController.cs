﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public ActionResult ChingJen()
    {
        return View();
    }

    public class HomeController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teresa()
        {
            return View();
        }

        public ActionResult ohohoh()
        {
            return View();
        }
    }
}
    }