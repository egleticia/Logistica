using FluentValidation;

namespace Logistica.Application.UseCases.Message
{
    public class CreateMessageValidator : AbstractValidator<CreateMessageRequest>
    {
        public CreateMessageValidator()
        {
            RuleFor(x => x.topic).NotEmpty();
            RuleFor(x => x.content).NotEmpty();
        }
    }
}
