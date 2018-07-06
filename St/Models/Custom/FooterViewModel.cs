using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace St.Models.Custom
{
    public class FooterViewModel
    {
        public SiteConfig SiteConfig { get; set; }
        public IList<SocialNetworkItem> SocialNetwors { get; set; }
    }
}