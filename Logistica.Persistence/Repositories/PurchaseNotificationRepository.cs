
using Logistica.Domain.Interfaces;

namespace Logistica.Persistence.Repositories
{
    public class PurchaseNotificationRepository : BaseRepository<Domain.Entities.PurchaseNotification>, IPurchaseNotificationRepository
    {
        public PurchaseNotificationRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
