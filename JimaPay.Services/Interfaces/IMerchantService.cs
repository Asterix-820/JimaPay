using JimaPay.Common.DTO;

namespace JimaPay.Services.Interfaces
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
