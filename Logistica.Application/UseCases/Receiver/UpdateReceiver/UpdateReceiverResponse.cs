

namespace Logistica.Application.UseCases.Receiver.UpdateReceiver
{
    public sealed record UpdateReceiverResponse
    {
        public Guid Id { get; set; }
        public Domain.Entities.Address Address { get; set; }
        public string Name { get; set; }
    }
}
