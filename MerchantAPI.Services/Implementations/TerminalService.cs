using MerchantAPI.Common.DTO;
using MerchantAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Services.Implementations
{
    public class TerminalService : ITerminalService
    {
        public Task<int> CreateTerminal(TerminalDTO terminal)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TerminalDTO>> GeTerminals()
        {
            throw new NotImplementedException();
        }

        public Task<TerminalDTO> GetTerminal(int id)
        {
            throw new NotImplementedException();
        }
    }
}
