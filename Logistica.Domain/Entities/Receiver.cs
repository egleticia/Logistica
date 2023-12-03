
namespace Logistica.Domain.Entities
{
    public class Receiver : BaseEntity
    {
        public Guid Id { get; set; }
        public Address Address { get; set; }
        public string Name { get; set; }
    }
}
