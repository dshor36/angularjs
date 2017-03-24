using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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

        public ActionResult AngualrJSTestPage()
        {
            ViewBag.Message = "Angualr JS Test Page Using Code School Course Level 1.";

            string name = "PhoneListTemplate";
            string[] uriSegments = Request.Url.Segments;
            string [] test = Request.QueryString.AllKeys;
            if (uriSegments[uriSegments.Length - 1] != "/phones/*") 
            {
                name = "PhoneDetailTemplate";
            }

            if (name == null || !Regex.IsMatch(name, @"^[-\w]+$"))
            throw new ArgumentException("Illegal template name", "name");

            string relativeViewPath = string.Format("~/Views/Templates/{0}.cshtml", name);

            return View(relativeViewPath);
        }
    }
}