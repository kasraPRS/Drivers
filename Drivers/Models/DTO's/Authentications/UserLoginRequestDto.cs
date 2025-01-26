using System.ComponentModel.DataAnnotations;

namespace Drivers.Models.DTO_s
{
    public class UserLoginRequestDto
    {
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
    }
}
