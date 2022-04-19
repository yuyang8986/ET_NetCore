using FluentValidation;
using FluentValidation.Validators;

namespace ET.Application.CQRS.Individual.IndividualCommand
{
    public class IndividualUpdateCommandValidator:AbstractValidator<IndividualUpdateCommand>
    {
        public IndividualUpdateCommandValidator()
        {
            RuleFor(x => x.IndividualId).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.Gender).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.DateOfBirth).NotEmpty();
            RuleFor(x => x.HomeAddressStreet).MaximumLength(60).NotEmpty();
            RuleFor(x => x.HomeAddressCity).NotEmpty();
            RuleFor(x => x.HomeAddressCountry).NotEmpty();
            RuleFor(x => x.Mobile).MaximumLength(10).NotEmpty();
            RuleFor(x => x.HomeAddressPostCode).MaximumLength(10).NotEmpty();
            RuleFor(x => x.HomeAddressState).NotEmpty();
            RuleFor(x => x.TFN).NotEmpty().MinimumLength(8).MaximumLength(9);
            RuleFor(x => x.PostalAddressStreet).NotEmpty();
            RuleFor(x => x.PostalAddressCity).NotEmpty();
            RuleFor(x => x.PostalAddressCountry).NotEmpty();
            RuleFor(x => x.PostalAddressPostCode).MaximumLength(10).NotEmpty();
            RuleFor(x => x.PostalAddressState).NotEmpty();

            RuleFor(c => c.HomeAddressPostCode).Matches(@"^\d{4}$")
                .When(c => c.HomeAddressCountry == "Australia")
                .WithMessage("Australian Postcodes have 4 digits");

            RuleFor(c => c.Mobile).NotEmpty()
                .Must(HaveAustraliaMobileNumber).Length(10)
                .When(c => c.HomeAddressCountry == "Australia" )
                .WithMessage("Mobile number is not a valid Australian number");
        }

        private static bool HaveAustraliaMobileNumber(IndividualUpdateCommand model, string phoneValue, PropertyValidatorContext ctx)
        {
            return model.Mobile.StartsWith("04");
        }
    }
}
