using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.UseCases.Product.UpdateProduct
{
    public sealed record UpdateProductResponse
    {
        public Guid Id { get; set; }
        public Domain.Entities.Receiver Receiver { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}
