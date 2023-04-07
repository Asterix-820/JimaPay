using MerchantAPI.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
