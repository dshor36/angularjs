using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AngularTemplatesController : Controller
    {
        [ChildActionOnly]
        public ActionResult Inline()
        {
            IEnumerable<string> templateNames = Directory
                                .GetFiles(HostingEnvironment.MapPath("~/Views/Templates/"))
                                .Select(Path.GetFileNameWithoutExtension);

            return View(templateNames);
        }

        public ActionResult Template(string name)
        {
            if (name == null || !Regex.IsMatch(name, @"^[-\w]+$"))
                throw new ArgumentException("Illegal template name", "name");

            string relativeViewPath = string.Format("~/Views/Templates/{0}.cshtml", name);

            return View(relativeViewPath);
        }
    }
}