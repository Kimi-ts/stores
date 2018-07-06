using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using St.Models.Custom;
using St.Models;
using System.Data.Entity;

namespace St.Providers
{
    public class SiteConfigManager : ISiteConfigManager
    {
        private ApplicationDbContext _context;

        public SiteConfigManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddSocialNetwork(SocialNetworkItem item)
        {
             _context.SocialNetworkItems.Add(item);
            _context.SaveChanges();
        }

        public IList<PageData> GetAllPageDataItems()
        {
            return _context.PageDataItems.ToList();
        }

        public PageData GetPageDataByName(string name)
        {
            return _context.PageDataItems.Where(c => c.PageName == name).FirstOrDefault();
        }

        public SiteConfig GetSiteConfig()
        {
            return _context.SiteConfig.FirstOrDefault();
        }

        public async Task<SocialNetworkItem> GetSocialNetworkByIdAsync(string id)
        {
            return await _context.SocialNetworkItems.Where(c => c.SocialNetworkItemId == id).FirstAsync();
        }

        public IList<SocialNetworkItem> GetSocialNetworkByType(string type)
        {
            return _context.SocialNetworkItems.Where(c => c.Type == type).ToList();
        }

        public async Task RemoveSocialNetworkAsync(SocialNetworkItem item)
        {
            _context.SocialNetworkItems.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePageDataAsync(PageData item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSiteConfig(SiteConfig config)
        {
            _context.Entry(config).State = System.Data.Entity.EntityState.Modified;
        
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSocialNetworkAsync(SocialNetworkItem item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}