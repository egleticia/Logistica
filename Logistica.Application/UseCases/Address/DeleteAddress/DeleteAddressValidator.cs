using FluentValidation;

namespace Logistica.Application.UseCases.Address.DeleteAddress
{
    public class DeleteAddressValidator : AbstractValidator<DeleteAddressRequest>
    {
        public DeleteAddressValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
