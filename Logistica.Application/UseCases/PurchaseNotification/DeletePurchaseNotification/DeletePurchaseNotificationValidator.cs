using FluentValidation;

namespace Logistica.Application.UseCases.PurchaseNotification.DeletePurchaseNotification
{
    public sealed class DeletePurchaseNotificationValidator : AbstractValidator<DeletePurchaseNotificationRequest>
    {
        public DeletePurchaseNotificationValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
