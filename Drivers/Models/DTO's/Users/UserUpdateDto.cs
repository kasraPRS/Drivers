using System.ComponentModel.DataAnnotations;
using Drivers.Models.DTO_s.Bank_Cards;
using Microsoft.EntityFrameworkCore;

namespace Drivers.Models.DTO_s.Profiles
{
    public class UserUpdateDto
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }
        [Required, MaxLength(10), Unicode]
        public string PublicId { get; set; } = "";

        public ICollection<BankCardServiceModel> BankCards { get; set; } = new List<BankCardServiceModel>();

        [Required, EmailAddress]
        public string Email { get; set; }

        public bool? IsActive { get; set; }
    }
}
