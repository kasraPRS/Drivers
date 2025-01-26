using System.ComponentModel.DataAnnotations;

namespace Drivers.Models.DTO_s.Users
{
    public class UserProfileDto
    {
        public int Id { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsActive { get; set; }
    }
}
