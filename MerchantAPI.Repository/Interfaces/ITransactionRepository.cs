using MerchantAPI.Common.DTO;
using MerchantAPI.Domain.Entities;

namespace MerchantAPI.Repository.Interfaces
{
    public interface ITransactionRepository : IGenericRepository<Transactions>
    {
        Task<Transactions> GetTransactionById(string id);
        Task<IEnumerable<Transactions>> GetTerminalTransactions(string merchantId, string terminalId);
    }
}
