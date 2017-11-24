using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnockoutApi.Models;
using System.Web.Http;
using System.Net;
using System.Net.Http;

namespace KnockoutApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
            //return Json("Home");
        }
    }
}
