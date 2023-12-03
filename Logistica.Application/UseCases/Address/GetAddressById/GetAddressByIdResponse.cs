using Logistica.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.UseCases.Address.GetAddressById
{
    public class GetAddressByIdResponse
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
