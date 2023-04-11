using MerchantAPI.Common.DTO;

namespace MerchantAPI.Services.Interfaces
{
    public interface ITransactionService
    {
        Task<IEnumerable<TransactionDTO>> GetAllTransactions();
        Task<TransactionDTO> GetTransactionById(string id);
        void CreateTransaction(TransactionDTO transaction);
        void UpdateTransaction(TransactionDTO transaction);
        Task DeleteTransaction(string id);
    }
}
