using FluentValidation;

namespace ET.Application.CQRS.IITR.DeductionTypeDetailsFormCommand.Add
{
    public class DeductionTypeDetailsFormAddCommandValidator : AbstractValidator<DeductionTypeDetailsFormAddCommand>
    {
        public DeductionTypeDetailsFormAddCommandValidator()
        {
            RuleFor(x => x.MainFormId).NotEmpty();
        }
    }

}
