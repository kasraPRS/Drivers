using Drivers.Models.DTO_s.Bank_Cards;

namespace Drivers.Data.BankCardRepository
{
    public interface IBankCardRepository
    {
        Task<List<BankCardServiceModel>> GetAllBankCards();
        Task<BankCardServiceModel> GetBankCardById(int id);

        Task CreateBankCard(BankCardServiceModel bankCard);
        Task UpdateBankCard(BankCardServiceModel bankCard);
        Task DeleteBankCard(int id);
    }
}
