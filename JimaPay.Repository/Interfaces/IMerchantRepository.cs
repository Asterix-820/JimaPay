using JimaPay.Common.DTO;
using JimaPay.Domain.Entities;

namespace JimaPay.Repository.Interfaces
{
    public interface IMerchantRepository : IGenericRepository<Merchant>
    {
        Task<Merchant> GetMerchantById(string id);
    }
}
