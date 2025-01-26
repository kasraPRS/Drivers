using System.ComponentModel.DataAnnotations;

namespace Drivers.Models.DTO_s.Profile
{
    public class UserCreateProfileRequest
    {

        public class UserCreateDto
        {
            [Required, MaxLength(100)]
            public string FirstName { get; set; }

            [Required, MaxLength(100)]
            public string LastName { get; set; }

            [Required, EmailAddress]
            public string Email { get; set; }

            [Required]
            public DateTime DateOfBirth { get; set; }
        }
    }

}
