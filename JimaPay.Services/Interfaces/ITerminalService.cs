using JimaPay.Common.DTO;

namespace JimaPay.Services.Interfaces
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
