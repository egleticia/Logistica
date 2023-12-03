using MediatR;

namespace Logistica.Application.UseCases.PurchaseNotification.DeletePurchaseNotification
{
    public sealed record DeletePurchaseNotificationRequest(Guid Id) : IRequest<DeletePurchaseNotificationResponse>;
}
