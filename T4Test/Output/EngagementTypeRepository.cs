using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class EngagementTypeRepository : GenericRepository<EngagementType>, IEngagementTypeRepository
    {
        public EngagementTypeRepository(DbContext context) : base(context) {}
    }
}

