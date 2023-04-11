using MerchantAPI.Common.DTO;

namespace MerchantAPI.Services.Interfaces
{
    public interface ITerminalService
    {
        Task<IEnumerable<TerminalDTO>> GeTerminals();
        Task<TerminalDTO> GetTerminal(int id);
        Task<int> CreateTerminal(TerminalDTO terminal);
    }
}
