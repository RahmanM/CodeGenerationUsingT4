using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class OppertunityRepository : GenericRepository<Oppertunity>, IOppertunityRepository
    {
        public OppertunityRepository(DbContext context) : base(context) {}
    }
}

