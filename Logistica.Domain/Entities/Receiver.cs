
namespace Logistica.Domain.Entities
{
    public class Receiver : BaseEntity
    {
        public Address Address { get; set; }
        public string Name { get; set; }
    }
}
