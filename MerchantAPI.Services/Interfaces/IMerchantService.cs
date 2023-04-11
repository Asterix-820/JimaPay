using MerchantAPI.Common.DTO;

namespace MerchantAPI.Services.Interfaces
{
    public interface IMerchantService
    {
        Task<IEnumerable<MerchantDTO>> GetAllMerchants();
        Task<MerchantDTO> GetMerchantById(string id);
        void CreateMerchant(MerchantDTO merchant);
        void UpdateMerchant(MerchantDTO merchant);
        Task DeleteMerchant(string id);
    }
}
