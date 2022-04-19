using FluentValidation;

namespace ET.Application.CQRS.IITR.OtherTypeDetailsFormCommand.Add
{
    public class OtherTypeDetailsFormAddCommandValidator : AbstractValidator<OtherItemTypeDetailsFormAddCommand>
    {
        public OtherTypeDetailsFormAddCommandValidator()
        {
            RuleFor(x => x.MainFormId).NotEmpty();
        }
    }

}
