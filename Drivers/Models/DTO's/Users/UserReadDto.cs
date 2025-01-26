using Drivers.Models.DTO_s.Bank_Cards;

namespace Drivers.Models.DTO_s.Profiles
{
    public class UserReadDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PublicId { get; set; }
        public ICollection<BankCardServiceModel> BankCards { get; set; } = new List<BankCardServiceModel>();

        public string Email { get; set; }
    }
}
