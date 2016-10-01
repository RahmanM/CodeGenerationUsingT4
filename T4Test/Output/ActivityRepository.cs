using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class ActivityRepository : GenericRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(DbContext context) : base(context) {}
    }
}

