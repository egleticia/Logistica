namespace Logistica.Application.UseCases.Receiver.CreateReceiver
{
    public sealed record CreateReceiverResponse
    {
        public Domain.Entities.Address Address { get; set; }
        public string Name { get; set; }
    }
}
