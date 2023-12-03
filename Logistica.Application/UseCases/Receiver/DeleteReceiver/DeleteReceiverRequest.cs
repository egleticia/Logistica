using MediatR;

namespace Logistica.Application.UseCases.Receiver.DeleteReceiver
{
    public sealed record DeleteReceiverRequest(Guid Id) : IRequest<DeleteReceiverResponse>;
}
