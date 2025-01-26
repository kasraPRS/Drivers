using System.ComponentModel.DataAnnotations;
using UserApi.Models.DTOs;

namespace Drivers.Models
{
    public class RegistrationRequestResponse:AuthResult
    {
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public new string Email { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
    }
}
