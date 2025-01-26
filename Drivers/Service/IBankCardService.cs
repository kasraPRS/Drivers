using Drivers.Data.BankCardRepository;
using Drivers.Models.DTO_s.Bank_Cards;

namespace Drivers.Service
{
    public interface IBankCardService
    {
        Task<List<BankCardServiceModel>> GetAllBankCards();
        Task<BankCardServiceModel> GetBankCardById(int id);

        Task CreateBankCard(BankCardServiceModel bankCard);
        Task UpdateBankCard(BankCardServiceModel bankCard);
        Task DeleteBankCard(int id);
    }
    public class BankCardService : IBankCardService
    {
        private readonly IBankCardRepository _bankCardRepository;
        public BankCardService(IBankCardRepository bankCardRepository)
        {
            {
                _bankCardRepository = bankCardRepository;
            }
        }

        public Task CreateBankCard(BankCardServiceModel bankCard)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBankCard(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BankCardServiceModel>> GetAllBankCards()
        {
            throw new NotImplementedException();
        }

        public Task<BankCardServiceModel> GetBankCardById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBankCard(BankCardServiceModel bankCard)
        {
            throw new NotImplementedException();
        }
    }
}
