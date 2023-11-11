
using Logistica.Domain.Enums;

namespace Logistica.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string? AddressLine2 { get; set; }
        public string? UnitNumber { get; set; }
        public string? Landmark { get; set; }
        public Region Region { get; set; }
    }
}
