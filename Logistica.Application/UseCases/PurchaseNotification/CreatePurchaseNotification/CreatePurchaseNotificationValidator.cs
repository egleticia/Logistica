
using FluentValidation;

namespace Logistica.Application.UseCases.PurchaseNotification.CreatePurchaseNotification
{
    public sealed class CreatePurchaseNotificationValidator : AbstractValidator<CreatePurchaseNotificationRequest>
    {
        public CreatePurchaseNotificationValidator()
        {
            RuleFor(x => x.Receiver).NotEmpty();
            RuleFor(x => x.Product).NotEmpty();
        }

    }
}
