using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class EnquiryRepository : GenericRepository<Enquiry>, IEnquiryRepository
    {
        public EnquiryRepository(DbContext context) : base(context) {}
    }
}

