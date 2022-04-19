using ET.Application.CQRS.IITR.IncomeTypesFormCommand.Add;
using FluentValidation;

namespace ET.Application.CQRS.IITR.DeductionTypesFormCommand.Add
{
    public class DeductionTypesFormAddCommandValidator:AbstractValidator<IncomeTypesFormAddCommand>
    {
        public DeductionTypesFormAddCommandValidator()
        {
            RuleFor(x => x.MainFormId).NotEmpty();
        }
    }
}
