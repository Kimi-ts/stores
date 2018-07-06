using St.Models.Custom;
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
        private readonly IParnterManager _partnerManager;

        public HomeController(ISiteConfigManager siteConfigManger, IParnterManager partnerManager)
        {
            _siteConfigManager = siteConfigManger;
            _partnerManager = partnerManager;
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

        public ActionResult Partners()
        {
            IList<Partner> model = new List<Partner>();

            model = _partnerManager.GetFilteredPartners(true);

            return PartialView("~/Views/Home/Partners.cshtml", model);
        }

        public ActionResult Footer()
        {
            FooterViewModel model = new FooterViewModel();
            model.SiteConfig = _siteConfigManager.GetSiteConfig();
            model.SocialNetwors = _siteConfigManager.GetSocialNetworkByType("share");

            return PartialView("~/Views/Shared/_Footer.cshtml", model);
        }
    }
}