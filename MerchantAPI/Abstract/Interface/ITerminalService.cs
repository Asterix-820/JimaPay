using MerchantAPI.DTO;

namespace MerchantAPI.Abstract.Interface
{
    public interface ITerminalService
    {
        Task<IEnumerable<TerminalDTO>> GetMerchants();
        Task<TerminalDTO> GetMerchant(int id);
        Task<int> CreateMerchant(TerminalDTO terminal);
    }
}
