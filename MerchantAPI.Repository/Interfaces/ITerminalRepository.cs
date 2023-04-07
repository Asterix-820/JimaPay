using MerchantAPI.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Repository.Interfaces
{
    public interface ITerminalRepository
    {
        Task<IEnumerable<TerminalDTO>> GetAllTerminals();
        Task<TerminalDTO> GetTerminalById(string id);
        Task<string> CreateTerminal(TerminalDTO terminal, string merchantId);
        Task<IEnumerable<TerminalDTO>> GetMerchantTerminal(string merchantId);
    }
}
