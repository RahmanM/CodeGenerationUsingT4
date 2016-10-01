using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class WebPresenseRepository : GenericRepository<WebPresense>, IWebPresenseRepository
    {
        public WebPresenseRepository(DbContext context) : base(context) {}
    }
}

