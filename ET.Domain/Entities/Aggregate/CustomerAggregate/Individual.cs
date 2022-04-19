using System;
using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.LodgementAggregate;
using ET.Domain.Entities.Auth;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.CustomerAggregate
{
    //real people
    public class Individual
    {
        public Individual()
        {
            Lodgements = new HashSet<IITRLodgement>();
        }
        public int IndividualId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public DateTime DateTimeCreated { get; set; } = DateTime.Now;
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

        //Navigation Properties
        public ICollection<IITRLodgement> Lodgements { get; private set; } //1 to 0...N, Cascading delete 

        [JsonIgnore] //hide it to public when return response to client
        public User AccountUser { get; set; } //must has a user account
        [JsonIgnore]
        public int AccountUserId { get; set; } //FK

        public int? OccupationId { get; set; }
        public Occupation Occupation { get; set; }
     
    }
}
