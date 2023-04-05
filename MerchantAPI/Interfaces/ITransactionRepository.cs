using MerchantAPI.DTO;

namespace MerchantAPI.Interfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<TransactionDTO>> GetTransactions();
        Task<TransactionDTO> GetTransaction(int id);
        Task<int> CreateTransaction(TransactionDTO transaction);
    }
}
