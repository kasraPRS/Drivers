using System.ComponentModel.DataAnnotations;

namespace Drivers.Models.DTO_s.Profiles
{
    public class UserUpdateDto
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public bool? IsActive { get; set; }
    }
}
