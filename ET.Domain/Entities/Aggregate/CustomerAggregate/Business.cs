using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ET.Domain.Entities.Auth;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Aggregate.CustomerAggregate
{
    public class Business
    {

        public Business()
        {
            Individuals = new HashSet<Individual>();
        }
       
        public int BusinessId { get; set; }

        //business has one main account, can has multiple accounts, retrieve them when do account managements
        [NotMapped]
        [JsonIgnore]
        public List<User> SubAccountUsers { get; set; }


        //Navigation Properties
        [JsonIgnore]
        public User User { get; set; } // must has a user account
        [JsonIgnore]
        public int UserId { get; set; }  //FK when first create account, auto set first created account to Main account

        public string Address { get; set; }
        public string AddressCity { get; set; }
        public string AddressPostCode { get; set; }
        public string AddressState { get; set; }
        public string AddressCountry { get; set; }
        public string Phone { get; set; }


        //private set to avoid alter ICollections
        public ICollection<Individual> Individuals { get; private set; } //non cascading delete
    }
}
