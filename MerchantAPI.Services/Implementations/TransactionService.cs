using MerchantAPI.Common.DTO;
using MerchantAPI.Services.Interfaces;

namespace MerchantAPI.Services.Implementations
{
    public class TransactionService : ITransactionService
    {
        public Task<int> CreateTransaction(TransactionDTO transaction)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionDTO> GetTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransactionDTO>> GetTransactions()
        {
            throw new NotImplementedException();
        }
    }
}
