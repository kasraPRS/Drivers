using System.ComponentModel.DataAnnotations;

namespace Drivers.Models.DTO_s.Bank_Cards
{
    public class BankCardCreateDto
    {
        [Required, MaxLength(12)]
        public int BankCardNumber { get; set; }
        [Required,MaxLength(16)]
        public string AccountNumber { get; set; }
        [Required]
        public DateTime ExpairedDate { get; set; }

        [Required]
        public int CVV2 { get; set; }
    }
}
