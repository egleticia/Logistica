using MediatR;

namespace Logistica.Application.UseCases.PurchaseNotification
{
    public sealed record CreatePurchaseNotificationRequest(Domain.Entities.Receiver Receiver, Domain.Entities.Product Product) : IRequest<CreatePurchaseNotificationResponse>;

}
