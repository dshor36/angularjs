using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TemplatesController : Controller
    {
        //This is done so we could use a partial view for the template url
        public ActionResult PhoneListTemplate()
        {
            return View();
        }
    }
}