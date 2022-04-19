using FluentValidation;

namespace ET.Application.CQRS.IITR.DeductionTypeDetailsFormCommand.Update
{
    public class DeductionTypeDetailsFormUpdateCommandValidator : AbstractValidator<DeductionTypeDetailsFormUpdateCommand>
    {
        public DeductionTypeDetailsFormUpdateCommandValidator()
        {
            RuleFor(x => x.DeductionDetailsFormId).NotEmpty();
        }
    }

}
