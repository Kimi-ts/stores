using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using St.Models.Custom;
using St.Models;

namespace St.Providers
{
    public class SiteConfigManager : ISiteConfigManager
    {
        private ApplicationDbContext _context;

        public SiteConfigManager(ApplicationDbContext context)
        {
            _context = context;
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
    }
}