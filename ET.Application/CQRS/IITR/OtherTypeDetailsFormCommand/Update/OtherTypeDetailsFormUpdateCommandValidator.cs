using FluentValidation;

namespace ET.Application.CQRS.IITR.OtherTypeDetailsFormCommand.Update
{
    public class OtherTypeDetailsFormUpdateCommandValidator : AbstractValidator<OtherTypeDetailsFormUpdateCommand>
    {
        public OtherTypeDetailsFormUpdateCommandValidator()
        {
            RuleFor(x => x.OtherDetailsFormId).NotEmpty();
        }
    }

}
