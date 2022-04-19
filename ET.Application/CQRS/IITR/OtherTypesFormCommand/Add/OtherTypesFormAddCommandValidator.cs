using FluentValidation;

namespace ET.Application.CQRS.IITR.OtherTypesFormCommand.Add
{
    public class OtherTypesFormAddCommandValidator:AbstractValidator<OtherTypesFormAddCommand>
    {
        public OtherTypesFormAddCommandValidator()
        {
            RuleFor(x => x.MainFormId).NotEmpty();
        }
    }
}
