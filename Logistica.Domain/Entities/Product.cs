
namespace Logistica.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid ReceiverId { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}
