using FluentValidation;

namespace ET.Application.CQRS.IITR.IncomeTypeDetailsFormCommand.UpdateCommand
{
    public class IncomeTypeDetailsFormUpdateCommandValidator : AbstractValidator<IncomeTypeDetailsFormUpdateCommand>
    {
        public IncomeTypeDetailsFormUpdateCommandValidator()
        {
            RuleFor(x => x.IncomeDetailsFormId).NotEmpty();
        }
    }

}
