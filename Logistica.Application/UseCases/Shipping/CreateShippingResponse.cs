using Logistica.Domain.Entities;
using Logistica.Domain.Enums;

namespace Logistica.Application.UseCases.Shipping
{
    public sealed record CreateShippingResponse
    {
        public Guid Id { get; set; }
        public Domain.Entities.Address Address { get; set; }
        public Domain.Entities.Receiver Receiver { get; set; }
        public bool ApplyShippingPrice { get; set; }
        public double Price { get; set; }
        public Status Status { get; set; }
    }
}
