
using Drivers.Models.DTO_s.Bank_Cards;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Drivers.Models.DTO_s.Users
{
    public class UserProfileDto
    {
        public int Id { get; set; }


        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        [Required, MaxLength(10), Unicode]
        public string PublicId { get; set; } = "";

        public string Email { get; set; } = string.Empty;
        public ICollection<BankCardServiceModel> BankCards { get; set; } = new List<BankCardServiceModel>();

        public DateTime DateOfBirth { get; set; }

        public bool IsActive { get; set; }
    }
}
