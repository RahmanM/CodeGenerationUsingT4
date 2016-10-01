using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class BallRepository : GenericRepository<Ball>, IBallRepository
    {
        public BallRepository(DbContext context) : base(context) {}
    }
}

