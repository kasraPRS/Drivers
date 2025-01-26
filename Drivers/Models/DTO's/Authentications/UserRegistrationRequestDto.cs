using System.ComponentModel.DataAnnotations;

namespace Drivers.Models.DTO_s
{
    public class UserRegistrationRequestDto
    {
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
    }
}
