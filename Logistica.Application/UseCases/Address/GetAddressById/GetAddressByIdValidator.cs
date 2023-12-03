using FluentValidation;

namespace Logistica.Application.UseCases.Address.GetAddressById
{
    public class GetAddressByIdValidator : AbstractValidator<GetAddressByIdRequest>
    {
        public GetAddressByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
