using MerchantAPI.Common.DTO;

namespace MerchantAPI.Services.Interfaces
{
    public interface ITerminalService
    {
        Task<IEnumerable<TerminalDTO>> GetAllTerminals();
        Task<TerminalDTO> GetTerminalById(string id);
        void CreateTerminal(TerminalDTO merchant);
        void UpdateTerminal(TerminalDTO merchant);
        Task DeleteTerminal(string id);
    }
}
