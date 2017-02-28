using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularJS").Include(
                        //"~/Scripts/app/angular.min.js",
                        "~/Scripts/app/angular.js",
                        "~/Scripts/app/angular-route.js",
                        "~/Scripts/app/angular-resource.js",
                        "~/Scripts/app/angular-animate.js",
                        "~/Scripts/app/angular-mocks.js",
                        "~/Scripts/app/app.module.js",
                        "~/Scripts/app/app.config.js",
                        "~/Scripts/app/app.animations.js",
                        "~/Scripts/app/phone-list/phone-list.module.js",
                        "~/Scripts/app/phone-list/phone-list.component.js",
                        "~/Scripts/app/phone-detail/phone-detail.module.js",
                        "~/Scripts/app/phone-detail/phone-detail.component.js",
                        "~/Scripts/app/core/core.module.js",
                        "~/Scripts/app/core/checkmark/checkmark.filter.js",
                        "~/Scripts/app/core/phone/phone.module.js",
                        "~/Scripts/app/core/phone/phone.service.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/app.css",
                      "~/Content/app.animations.css"));
        }
    }
}
