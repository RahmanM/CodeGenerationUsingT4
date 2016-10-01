using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class CaseRepository : GenericRepository<Case>, ICaseRepository
    {
        public CaseRepository(DbContext context) : base(context) {}
    }
}

