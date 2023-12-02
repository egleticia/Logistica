using MediatR;

namespace Logistica.Application.UseCases.PurchaseNotification.CreatePurchaseNotification
{
    public sealed record CreatePurchaseNotificationRequest(Domain.Entities.Receiver Receiver, Domain.Entities.Product Product) : IRequest<CreatePurchaseNotificationResponse>;

}
