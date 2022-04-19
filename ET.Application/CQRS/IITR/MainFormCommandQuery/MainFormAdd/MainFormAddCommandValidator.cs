using FluentValidation;

namespace ET.Application.CQRS.IITR.MainFormCommandQuery.MainFormAdd
{
    public class MainFormAddCommandValidator:AbstractValidator<MainFormAddCommand>
    {
        public MainFormAddCommandValidator()
        {
            RuleFor(x => x.FinancialYear).InclusiveBetween(2011, 2019).NotEmpty();
        }
    }
}
