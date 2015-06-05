using System.Web;
using System.Web.Optimization;

namespace DrivoJoyWebApp
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
                      "~/Scripts/ripples.js",
                     "~/Scripts/material.js",
                     "~/Scripts/jquery.dropdown.js"));


            // Include roboto.css to use the Roboto web font, material.css to include the theme and ripples.css to style the ripple effect 
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-social.css",
                      "~/Content/font-awesome.css",
                      "~/Content/site.css",
                      "~/Content/material.css",
                      "~/Content/ripples.css",
                      "~/Content/roboto.css",
                      "~/Content/jquery.dropdown.css"));

            bundles.Add(new ScriptBundle("~/bundles/RTOForms")
    .IncludeDirectory("~/Scripts/Controllers", "*.js")
    .IncludeDirectory("~/Scripts/Services", "*.js")

    .Include("~/Scripts/RTOForms.js"));

        }
    }
}