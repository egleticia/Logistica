namespace Logistica.Domain.Entities
{
    public class PurchaseNotification : BaseEntity
    {
        public Guid ShippingId { get; set; }
        public Receiver Receiver { get; set; }
        public Product Product { get; set; }
    }
}
