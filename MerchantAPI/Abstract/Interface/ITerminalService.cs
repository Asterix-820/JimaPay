using MerchantAPI.DTO;

namespace MerchantAPI.Abstract.Interface
{
    public interface ITerminalService
    {
        Task<IEnumerable<TerminalDTO>> GeTerminals();
        Task<TerminalDTO> GetTerminal(int id);
        Task<int> CreateTerminal(TerminalDTO terminal);
    }
}
