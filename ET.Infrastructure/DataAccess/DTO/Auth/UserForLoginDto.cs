using System.ComponentModel.DataAnnotations;

namespace ET.Infrastructure.DataAccess.DTO.Auth
{
    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
