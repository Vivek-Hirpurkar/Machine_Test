﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firstproject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to the Cricket World";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "All Contact Given .";

            return View();
        }
    }
}