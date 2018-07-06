using St.Models.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace St.Providers
{
    public interface IParnterManager
    {
        IList<Partner> GetAllPartners();
        IList<Partner> GetFilteredPartners(bool isShowActive);
        void AddPartner(Partner item);
        Task<Partner> GetPartnerByIdAsync(string id);
        Task UpdatePartnerAsync(Partner item);
        Task RemovePartnerAsync(Partner item);
    }
}