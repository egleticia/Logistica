
using FluentValidation;

namespace Logistica.Application.UseCases.PurchaseNotification.GetPurchaseNotificationById
{
    public sealed class GetPurchaseNotificationByIdValidator : AbstractValidator<GetPurchaseNotificationByIdRequest>
    {
        public GetPurchaseNotificationByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
