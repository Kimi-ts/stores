using St.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace St.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ISiteConfigManager _siteConfigManager;

        public HomeController(ISiteConfigManager siteConfigManger)
        {
            _siteConfigManager = siteConfigManger;
        }

        public ActionResult Index()
        {
            var pageData = _siteConfigManager.GetPageDataByName("Home");

            ViewData["Title"] = pageData.Title;
            ViewData["MetaDescription"] = BuildMetaTag("description", pageData.MetaDescription);
            ViewData["MetaTitle"] = BuildMetaTag("title", pageData.Title);

            return View();
        }

        public ActionResult About()
        {
            var pageData = _siteConfigManager.GetPageDataByName("About");

            ViewData["Title"] = pageData.Title;
            ViewData["MetaDescription"] = BuildMetaTag("description", pageData.MetaDescription);
            ViewData["MetaTitle"] = BuildMetaTag("title", pageData.Title);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Footer()
        {
            var siteConfigItem = _siteConfigManager.GetSiteConfig();
            return PartialView("~/Views/Shared/_Footer.cshtml", siteConfigItem);
        }
    }
}