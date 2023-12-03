
namespace Logistica.Application.UseCases.PurchaseNotification.GetPurchaseNotificationById
{
    public sealed class GetPurchaseNotificationByIdResponse
    {
        public Guid ShippingId { get; set; }
        public Domain.Entities.Receiver Receiver { get; set; }
        public Domain.Entities.Product Product { get; set; }
    }
}
