using FluentValidation;

namespace ET.Application.CQRS.IITR.OtherTypesFormCommand.Update
{
    public class OtherTypesFormUpdateCommandValidator:AbstractValidator<OtherTypesFormUpdateCommand>
    {
        public OtherTypesFormUpdateCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
