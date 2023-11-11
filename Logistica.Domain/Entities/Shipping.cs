using Logistica.Domain.Enums;

namespace Logistica.Domain.Entities
{
    public class Shipping : BaseEntity
    {
        public Guid Id { get; set; }
        public Address Address { get; set; }
        public Receiver Receiver { get; set; }
        public bool ApplyShippingPrice { get; set; }
        public double Price { get; set; }
        public Status Status { get; set; }
    }
}
