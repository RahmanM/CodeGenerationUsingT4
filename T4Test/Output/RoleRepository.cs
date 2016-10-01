using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(DbContext context) : base(context) {}
    }
}

