using Drivers.Models.DTO_s.Bank_Cards;

namespace Drivers.Data.BankCardRepository
{
    public class BankCardRepository : IBankCardRepository
    {
        private readonly ApiDbContext _context;
        public BankCardRepository(ApiDbContext context)
        {
            _context = context;
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
