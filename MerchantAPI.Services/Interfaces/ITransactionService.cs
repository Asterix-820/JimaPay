using MerchantAPI.Common.DTO;

namespace MerchantAPI.Services.Interfaces
{
    public interface ITransactionService
    {
        Task<IEnumerable<TransactionDTO>> GetTransactions();
        Task<TransactionDTO> GetTransaction(int id);
        Task<int> CreateTransaction(TransactionDTO transaction);
    }
}
