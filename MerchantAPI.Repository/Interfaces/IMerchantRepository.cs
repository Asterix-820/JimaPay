using MerchantAPI.Common.DTO;
using MerchantAPI.Domain.Entities;

namespace MerchantAPI.Repository.Interfaces
{
    public interface IMerchantRepository : IGenericRepository<Merchant>
    {
        Task<Merchant> GetMerchantById(string id);
    }
}
