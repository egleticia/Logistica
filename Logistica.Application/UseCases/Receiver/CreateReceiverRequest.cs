using MediatR;

namespace Logistica.Application.UseCases.Receiver
{
    public sealed record CreateReceiverRequest(Domain.Entities.Address Adress, string Name) : IRequest<CreateReceiverResponse>;
}
