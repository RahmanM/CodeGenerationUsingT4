using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class TaskRepository : GenericRepository<Task>, ITaskRepository
    {
        public TaskRepository(DbContext context) : base(context) {}
    }
}

