using Logistica.Domain.Interfaces;

namespace Logistica.Persistence.Repositories
{
    public class ShippingRepository : BaseRepository<Domain.Entities.Shipping>, IShippingRepository
    {
        public ShippingRepository(AppDbContext context) : base(context)
        { 
        }
    }
}
