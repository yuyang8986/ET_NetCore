using FluentValidation;

namespace ET.Application.CQRS.IITR.BasicDetailsFormCommand.Add
{
    public class BasicDetailsFormAddCommandValidator:AbstractValidator<BasicDetailsFormAddCommand>
    {
        public BasicDetailsFormAddCommandValidator()
        {
            RuleFor(x => x.MainFormId).NotEmpty();
            RuleFor(x => x.IsLiveFullYearInAu).NotNull();
            RuleFor(x => x.IsLastITRInAu).NotNull();
            RuleFor(x => x.IsAustralianCitizenship).NotNull();
            RuleFor(x => x.HasSFSS).NotNull();
            RuleFor(x => x.HasOtherTaxDebt).NotNull();
            RuleFor(x => x.HasHELPOrTSL).NotNull();
            RuleFor(x => x.AccountName).NotEmpty();
            RuleFor(x => x.AccountNo).NotEmpty();
            RuleFor(x => x.BSB).NotEmpty();

        }
    }
}
