using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class EngagementRepository : GenericRepository<Engagement>, IEngagementRepository
    {
        public EngagementRepository(DbContext context) : base(context) {}
    }
}

