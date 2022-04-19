using FluentValidation;

namespace ET.Application.CQRS.IITR.DeductionTypesFormCommand.Update
{
    public class DeductionTypesFormUpdateCommandValidator:AbstractValidator<DeductionTypesFormUpdateCommand>
    {
        public DeductionTypesFormUpdateCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
