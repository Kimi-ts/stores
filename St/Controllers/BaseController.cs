using St.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace St.Controllers
{
    public class BaseController : Controller
    {
        protected string BuildMetaTag(string tagTitle, string tagValue)
        {
            System.Text.StringBuilder strDynamicMetaTag = new System.Text.StringBuilder();
            strDynamicMetaTag.AppendFormat(@"<meta name='{0}' content='{1}'/>", tagTitle, tagValue);
            return strDynamicMetaTag.ToString();
        }
    }
}