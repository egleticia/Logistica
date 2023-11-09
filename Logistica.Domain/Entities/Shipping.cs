using Logistica.Domain.Enums;

namespace Logistica.Domain.Entities
{
    public class Shipping : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public Guid ReceiverId { get; set; }
        public ShippingPrice ShippingPrice { get; set; }
        public Status Status { get; set; }
    }
}
