﻿using Mybrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mybrary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Advanced()
        {
            ViewBag.Message = "Your contact page.";
            var person = new Person()
            {
            FirstName = "Shawn",
            LastName = "Murtagh"
            };
            return View(person);


        }
    }
}