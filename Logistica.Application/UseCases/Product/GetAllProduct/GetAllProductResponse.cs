
namespace Logistica.Application.UseCases.Product.GetAllProduct
{
    public sealed record GetAllProductResponse
    {
        public Guid Id { get; set; }
        public Domain.Entities.Receiver Receiver { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}
