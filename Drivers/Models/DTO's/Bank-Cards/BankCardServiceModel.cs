using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Drivers.Models.DTO_s.Bank_Cards
{
    [Index(nameof(BankCardNumber), IsUnique = true)]
    [Index(nameof(AccountNumber), IsUnique = true)]
    public class BankCardServiceModel
    {
        [Key]
        public Guid Id { get; set; }

       [Required, Unicode, MaxLength(12)]
       public int BankCardNumber { get; set; }
        [Required, Unicode, MaxLength(16)]
        public string AccountNumber { get; set; }
        [Required]
        public DateTime ExpairedDate { get; set; }
        
        [Required]
        public int CVV2 { get; set; }

        [Required, Unicode]
        [ForeignKey(nameof(BankCardNumber))]
        public Guid UserId { get; set; }

        // Navigation property for the related UserProfile
        public UserServiceModel User { get; set; }
    }
}
