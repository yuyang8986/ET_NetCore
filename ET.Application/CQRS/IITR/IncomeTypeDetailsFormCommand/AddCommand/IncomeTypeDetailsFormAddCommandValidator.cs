using FluentValidation;

namespace ET.Application.CQRS.IITR.IncomeTypeDetailsFormCommand.AddCommand
{
    public class IncomeTypeDetailsFormAddCommandValidator : AbstractValidator<IncomeTypeDetailsFormAddCommand>
    {
        public IncomeTypeDetailsFormAddCommandValidator()
        {
            RuleFor(x => x.MainFormId).NotEmpty();
        }
    }

}
