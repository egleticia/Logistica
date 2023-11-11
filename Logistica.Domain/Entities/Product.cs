
namespace Logistica.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Guid Id { get; set; }
        public Receiver Receiver { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}
