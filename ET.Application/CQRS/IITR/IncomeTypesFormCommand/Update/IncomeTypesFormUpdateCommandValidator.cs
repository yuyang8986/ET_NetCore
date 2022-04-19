using FluentValidation;

namespace ET.Application.CQRS.IITR.IncomeTypesFormCommand.Update
{
    public class IncomeTypesFormUpdateCommandValidator:AbstractValidator<IncomeTypesFormUpdateCommand>
    {
        public IncomeTypesFormUpdateCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
