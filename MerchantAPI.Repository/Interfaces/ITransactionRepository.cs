using MerchantAPI.Common.DTO;

namespace MerchantAPI.Repository.Interfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<TransactionDTO>> GetAllTransactions();
        Task<TransactionDTO> GetTransactionById(string id);
        Task<string> CreateTransaction(TransactionDTO transaction, string merchantId);
        Task<IEnumerable<TransactionDTO>> GetTerminalTransactions(string merchantId, string terminalId);
    }
}
