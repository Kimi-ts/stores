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

            bundles.Add(new StyleBundle("~/Content/libStyles").Include(
                      "~/Scripts/lib/tether/dist/css/tether.css",
                      "~/Scripts/lib/bootstrap/dist/css/bootstrap.css",
                      "~/Scripts/lib/font-awesome/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/styles").Include(
          "~/Content/points.css",
          "~/Content/site.css"));


            BundleTable.EnableOptimizations = true;
        }
    }
}