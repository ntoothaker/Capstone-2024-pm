﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NightRiderMVC.Controllers
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
        public ActionResult Privacy()
        {
            ViewBag.Message = "NightRider Privacy Policy";
            return View();
        }
        public ActionResult Terms()
        {
            ViewBag.Message = "NightRider Terms of Use";
            return View();
        }
        public ActionResult Help()
        {
            ViewBag.Message = "Request Help";
            return View();
        }
    }
}