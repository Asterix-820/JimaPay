using MerchantAPI.Common.DTO;

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
