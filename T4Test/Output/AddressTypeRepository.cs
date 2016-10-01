using System.Data.Entity;
using Core.GenericRepository;
using CRM.Entities;

namespace CRM.Repositories
{
    public class AddressTypeRepository : GenericRepository<AddressType>, IAddressTypeRepository
    {
        public AddressTypeRepository(DbContext context) : base(context) {}
    }
}

