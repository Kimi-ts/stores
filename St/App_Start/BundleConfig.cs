using System.Web;
using System.Web.Optimization;

namespace St
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            var jqueryCDNPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.min.js";

            bundles.Add(new ScriptBundle("~/bundles/jquery", jqueryCDNPath).Include("~/Scripts/lib/jquery/dist/jquery-3.3.1.slim.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/proper", "https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/tether").Include("~/Scripts/lib/tether/dist/js/tether.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js").Include("~/Scripts/lib/bootstrap/dist/js/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/vue", "https://cdn.jsdelivr.net/npm/vue/dist/vue.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/lib/jquery-validation/dist/jquery.validate.js", "~/Scripts/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"));


            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}