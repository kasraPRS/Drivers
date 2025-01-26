using Drivers.Models.DTO_s.Bank_Cards;
using Drivers.Models.DTO_s.Result_s;

namespace Drivers.Models.DTO_s.Users
{
    public class UserProfileRequestResponce:SuccessResponce
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
        public string PublicId { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public ICollection<BankCardServiceModel> BankCards { get; set; } = new List<BankCardServiceModel>();

        public DateTime DateOfBirth { get; set; }

        public bool IsActive { get; set; }
    }
}
