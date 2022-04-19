using System.Collections.Generic;
using ET.Domain.Entities.Aggregate.CustomerAggregate;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Auth
{
    //Account User
    public class User:IdentityUser<int>
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
            Individuals = new HashSet<Individual>();
            Businesses = new HashSet<Business>();
        }


        //identity core
        [JsonIgnore]
        public ICollection<UserRole> UserRoles { get; private set; }

       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Properties

        [JsonIgnore]
        public ICollection<Individual> Individuals { get; private set; }//1 to 0..N, Cascading Delete (Role = Individual Account : 1 to 1, Role = Business Account 1 to 1...N)

        [JsonIgnore]
        public ICollection<Business> Businesses { get; private set; }  //1 to 0..1, Cascading Delete (Role = Individual Account : 1 to 0, Role = Business Account 1 to 1)
    }
}
