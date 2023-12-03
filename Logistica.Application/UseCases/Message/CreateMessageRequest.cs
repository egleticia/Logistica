using MediatR;

namespace Logistica.Application.UseCases.Message
{
    public sealed record CreateMessageRequest(
        string topic, string sender, string receiver, string content) : IRequest<CreateMessageResponse>;
}
