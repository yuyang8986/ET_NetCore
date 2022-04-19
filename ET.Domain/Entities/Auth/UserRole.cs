using Microsoft.AspNetCore.Identity;

namespace ET.Domain.Entities.Auth
{
    public class UserRole:IdentityUserRole<int>
    {
        //identity core
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
