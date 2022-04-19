using System;
using MediatR;

namespace ET.Application.CQRS.Individual.IndividualCommand
{
    public class IndividualUpdateCommand:IRequest<IndividualUpdatedModel>
    {
        public int IndividualId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string TFN { get; set; }
        public string Email { get; set; }
        public string HomeAddressStreet { get; set; }
        public string HomeAddressCity { get; set; }
        public string HomeAddressPostCode { get; set; }
        public string HomeAddressState { get; set; }
        public string HomeAddressCountry { get; set; }
        public string PostalAddressStreet { get; set; }
        public string PostalAddressCity { get; set; }
        public string PostalAddressPostCode { get; set; }
        public string PostalAddressState { get; set; }
        public string PostalAddressCountry { get; set; }
        public string Mobile { get; set; }
        public string HomePhone { get; set; }
        public string Occupation { get; set; }
    }
}
