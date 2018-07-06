using St.Models;
using St.Models.Custom;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace St.Providers
{
    public class PartnerManager: IParnterManager
    {
        private ApplicationDbContext _context;

        public PartnerManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddPartner(Partner item)
        {
            _context.Partners.Add(item);
            _context.SaveChanges();
        }

        public IList<Partner> GetAllPartners()
        {
            return _context.Partners
                    .OrderBy(c => c.OrderNumber).ToList();
        }

        public IList<Partner> GetFilteredPartners(bool isShowActive)
        {
            return _context.Partners
                    .Where(c => isShowActive == true ? c.IsActive == true : true)
                    .OrderBy(c => c.OrderNumber).ToList();
        }

        public async Task<Partner> GetPartnerByIdAsync(string id)
        {
            return await _context.Partners.Where(c => c.PartnerId == id)
                        .FirstOrDefaultAsync();
        }

        public async Task RemovePartnerAsync(Partner item)
        {
            _context.Partners.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePartnerAsync(Partner item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}