using MediatR;

namespace Logistica.Application.UseCases.Receiver.GetReceiverById
{
    public sealed record GetReceiverByIdRequest(Guid Id) :
                   IRequest<GetReceiverByIdResponse>;
}
