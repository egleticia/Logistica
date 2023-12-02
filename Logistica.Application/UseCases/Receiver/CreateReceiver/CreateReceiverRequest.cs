using MediatR;

namespace Logistica.Application.UseCases.Receiver.CreateReceiver
{
    public sealed record CreateReceiverRequest(Domain.Entities.Address Adress, string Name) : IRequest<CreateReceiverResponse>;
}
