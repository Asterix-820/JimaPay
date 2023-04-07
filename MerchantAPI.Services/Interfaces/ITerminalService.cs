using MerchantAPI.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Services.Interfaces
{
    public interface ITerminalService
    {
        Task<IEnumerable<TerminalDTO>> GeTerminals();
        Task<TerminalDTO> GetTerminal(int id);
        Task<int> CreateTerminal(TerminalDTO terminal);
    }
}
