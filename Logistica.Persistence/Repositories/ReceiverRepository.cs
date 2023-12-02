
using Logistica.Domain.Interfaces;

namespace Logistica.Persistence.Repositories
{
    public class ReceiverRepository : BaseRepository<Domain.Entities.Receiver>, IReceiverRepository
    {
        public ReceiverRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
