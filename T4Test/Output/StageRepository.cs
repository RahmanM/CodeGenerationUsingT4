using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class StageRepository : GenericRepository<Stage>, IStageRepository
    {
        public StageRepository(DbContext context) : base(context) {}
    }
}

