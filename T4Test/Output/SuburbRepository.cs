using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class SuburbRepository : GenericRepository<Suburb>, ISuburbRepository
    {
        public SuburbRepository(DbContext context) : base(context) {}
    }
}

