
namespace Logistica.Application.UseCases.Receiver.GetAllReceiver
{
    public sealed record GetAllReceiverResponse
    {
        public Domain.Entities.Address Address { get; set; }
        public string Name { get; set; }
    }
}
