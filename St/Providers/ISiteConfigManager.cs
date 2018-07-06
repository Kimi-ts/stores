using St.Models.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace St.Providers
{
    public interface ISiteConfigManager
    {
        SiteConfig GetSiteConfig();
        Task UpdateSiteConfig(SiteConfig config);
        //Task AddSocialNetworkAsync(SocialNetworkItem item);
        //Task UpdateSocialNetworkAsync(SocialNetworkItem item);
        //Task RemoveSocialNetworkAsync(SocialNetworkItem item);
        //IList<SocialNetworkItem> GetSocialNetworkByType(string type);
        //Task<SocialNetworkItem> GetSocialNetworkByIdAsync(string id);
        Task UpdatePageDataAsync(PageData item);
        PageData GetPageDataByName(string id);
        IList<PageData> GetAllPageDataItems();
    }
}