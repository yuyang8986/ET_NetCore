using System.ComponentModel.DataAnnotations;

namespace ET.Infrastructure.DataAccess.DTO.Auth
{
    public class UserForRegisterDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength = 4,ErrorMessage = "You must specify password between 4 and 8 length")]
        public string Password { get; set; }

        //individual account or business account
        [Required]
        public string Role { get; set; }
    }
}
