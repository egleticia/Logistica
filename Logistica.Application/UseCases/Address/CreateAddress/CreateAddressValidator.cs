
using FluentValidation;

namespace Logistica.Application.UseCases.Address.CreateAddress
{
    public sealed class CreateAddressValidator : AbstractValidator<CreateAddressRequest>
    {
        public CreateAddressValidator()
        {
            RuleFor(x => x.Street).NotEmpty().MinimumLength(3).MaximumLength(55);
            RuleFor(x => x.Number).NotEmpty().MinimumLength(1).WithMessage("Deve conter no mínimo 1 caracter");
            RuleFor(x => x.PostalCode).NotEmpty().MinimumLength(8).WithMessage("O CEP deve conter no mínimo 8 caracteres");
            RuleFor(x => x.City).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.State).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Country).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.AddressLine2).MaximumLength(50);
            RuleFor(x => x.UnitNumber).MaximumLength(50).WithMessage("Deve conter no mínimo 1 caracter");
            RuleFor(x => x.Region).NotEmpty().IsInEnum();
        }


    }
}
