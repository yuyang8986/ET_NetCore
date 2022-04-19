using FluentValidation;

namespace ET.Application.CQRS.IITR.IncomeTypesFormCommand.Add
{
    public class IncomeTypesFormAddCommandValidator:AbstractValidator<IncomeTypesFormAddCommand>
    {
        public IncomeTypesFormAddCommandValidator()
        {
            RuleFor(x => x.MainFormId).NotEmpty();
        }
    }
}
