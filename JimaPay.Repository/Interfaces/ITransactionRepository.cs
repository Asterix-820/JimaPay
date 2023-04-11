using JimaPay.Common.DTO;
using JimaPay.Domain.Entities;

namespace JimaPay.Repository.Interfaces
{
    public interface ITransactionRepository : IGenericRepository<Transactions>
    {
        Task<Transactions> GetTransactionById(string id);
        Task<IEnumerable<Transactions>> GetTerminalTransactions(string merchantId, string terminalId);
    }
}
