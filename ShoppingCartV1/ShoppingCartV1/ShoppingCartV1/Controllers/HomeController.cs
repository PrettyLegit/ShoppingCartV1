using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartV1.Controllers
{
    public partial class HomeController : Controller
    {// Text for Site Heading
        string siteHeading = "The Fun Cake Store";

        // Text for Order View Heading
        string orderHeading = "Cake Orders";

        // Text for View Heading for each Tab
        string[] tabHeadings = { "Home", "Single Layer Cake",
                                                 "About" };

        // View method name for each Tab
        string[] tabViews = { "Index", "Tab1Orders",
                                                 "About" };

        // View label displayed on each Tab
        string[] tabLabels = { "Home", "1-Layer",
                                                 "About" };

        // Action Method for Home page View
        public ActionResult Index()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "Welcome To " + siteHeading;
            ViewBag.Message2 = "Modify this text to jump-start your Shopping Cart application.";
            return View();
        }

        // Action Method for About page View
        public ActionResult About()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "About " + siteHeading;
            ViewBag.Message2 = "Modify this to identify yourself as the Webmaster.";
            return View();
        }

        // Action Method for First Product View
        public ActionResult Tab1Orders()
        {
            return GetTabView(1);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab1Orders(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }
    }
}