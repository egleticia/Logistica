
using Logistica.Domain.Enums;

namespace Logistica.Domain.Entities
{
    public class ShippingPrice
    {
        public Region Region { get; set; }
        public bool ApplyShippingPrice { get; set; }
        public double Price { get; set; }
    }
}
