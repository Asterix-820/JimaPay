using MerchantAPI.Common.DTO;
using MerchantAPI.Domain.Entities;

namespace MerchantAPI.Repository.Interfaces
{
    public interface ITerminalRepository : IGenericRepository<Terminal>
    {
        Task<Terminal> GetTerminalById(string id);
        Task<IEnumerable<Terminal>> GetMerchantTerminal(string merchantId);
    }
}
