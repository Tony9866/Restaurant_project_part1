using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_project.Controllers
{
    public class HomeController : Controller
    {
        //GET: /home index
        public ActionResult Index()
        {
            return View();
        }

        //GET About
        public ActionResult About()
        {
            ViewBag.Message = "Our Restraunt has good Chinese Food. We are located in Tai Bay, so we call our restaurant Tai Bay Restaurant. We open this restaurant since 2016. Eric and I hopeful everyone can enjoy our food.";

            return View();
        }

        //GET contact
        public ActionResult Contact()
        {
            ViewBag.Message = "The Phone Number: 700 1234 25@";

            return View();
        }
    }
}