using MerchantAPI.DTO;

namespace MerchantAPI.Abstract.Interface
{
    public interface IMerchantService
    {
        Task<IEnumerable<MerchantDTO>> GetMerchants();
        Task<MerchantDTO> GetMerchant(int id);
        Task<int> CreateMerchant(MerchantDTO merchant);
    }
}
