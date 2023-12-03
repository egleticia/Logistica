
using MediatR;

namespace Logistica.Application.UseCases.Receiver.UpdateReceiver
{
    public sealed record UpdateReceiverRequest(Guid Id, Domain.Entities.Address Adress, string Name) : IRequest<UpdateReceiverResponse>;
}
