
using Logistica.Domain.Interfaces;

namespace Logistica.Persistence.Repositories
{
    public class ProductRepository : BaseRepository<Domain.Entities.Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
