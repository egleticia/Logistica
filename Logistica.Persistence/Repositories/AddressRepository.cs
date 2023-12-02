
using Logistica.Domain.Interfaces;

namespace Logistica.Persistence.Repositories
{
    public class AddressRepository : BaseRepository<Domain.Entities.Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
