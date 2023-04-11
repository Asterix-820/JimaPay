using JimaPay.Common.DTO;
using JimaPay.Domain.Entities;

namespace JimaPay.Repository.Interfaces
{
    public interface ITerminalRepository : IGenericRepository<Terminal>
    {
        Task<Terminal> GetTerminalById(string id);
        Task<IEnumerable<Terminal>> GetMerchantTerminal(string merchantId);
    }
}
