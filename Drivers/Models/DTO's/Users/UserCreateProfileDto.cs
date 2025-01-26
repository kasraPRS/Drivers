using System.ComponentModel.DataAnnotations;
using Drivers.Models.DTO_s.Bank_Cards;
using Microsoft.EntityFrameworkCore;

namespace Drivers.Models.DTO_s.Profile
{

    public class UserCreateDto
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; } = "";

        [Required, MaxLength(100)]
        public string LastName { get; set; } = "";
        [Required, MaxLength(10), Unicode]
        public string PublicId { get; set; } = "";

        public ICollection<BankCardCreateDto> BankCards { get; set; } = new List<BankCardCreateDto>();



        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
