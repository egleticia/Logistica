using MediatR;

namespace Logistica.Application.UseCases.Receiver.GetAllReceiver
{
    public sealed record GetAllReceiverRequest : IRequest<List<GetAllReceiverResponse>>;
}
