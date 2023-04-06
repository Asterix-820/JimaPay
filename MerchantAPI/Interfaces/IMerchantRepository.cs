using MerchantAPI.DTO;

namespace MerchantAPI.Interfaces
{
    public interface IMerchantRepository
    {
        Task<IEnumerable<MerchantDTO>> GetAllMerchants();
        Task<MerchantDTO> GetMerchantById(string id);
        Task<string> CreateNewMerchant(MerchantDTO merchant);
    }
}
