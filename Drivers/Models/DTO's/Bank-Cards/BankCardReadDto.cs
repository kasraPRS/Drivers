namespace Drivers.Models.DTO_s.Bank_Cards
{
    public class BankCardReadDto
    {
        public int Id { get; set; }
        public int BankCardNumber { get; set; }
        public string AccountNumber { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}
