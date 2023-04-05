using MerchantAPI.DTO;

namespace MerchantAPI.Interfaces
{
    public interface ITerminalRepository
    {
        Task<IEnumerable<TerminalDTO>> GetTerminals();
        Task<TerminalDTO> GetTerminal(int id);
        Task<int> CreateTerminal(TerminalDTO terminal);
    }
}
