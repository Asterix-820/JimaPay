using MerchantAPI.Common.DTO;
using MerchantAPI.Services.Interfaces;

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
