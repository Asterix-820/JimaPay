using MerchantAPI.DTO;

namespace MerchantAPI.Interfaces
{
    public interface IMerchantRepository
    {
        Task<IEnumerable<MerchantDTO>> GetMerchants();
        Task<MerchantDTO> GetMerchant(int id);
        Task<int> CreateMerchant(MerchantDTO merchant);
    }
}
