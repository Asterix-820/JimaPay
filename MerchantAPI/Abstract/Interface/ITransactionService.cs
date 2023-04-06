using MerchantAPI.DTO;

namespace MerchantAPI.Abstract.Interface
{
    public interface ITransactionService
    {
        Task<IEnumerable<TransactionDTO>> GetTransactions();
        Task<TransactionDTO> GetTransaction(int id);
        Task<int> CreateTransaction(TransactionDTO transaction);
    }
}
