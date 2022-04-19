using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace ET.Domain.Entities.Auth
{
    public class Role: IdentityRole<int>
    {

        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }
        //identity core
        [JsonIgnore]
        public ICollection<UserRole> UserRoles { get; private set; }
    }
}
