using MerchantAPI.DTO;

namespace MerchantAPI.Abstract.Interface
{
    public interface ITransactionService
    {
        Task<IEnumerable<TransactionDTO>> GetMerchants();
        Task<TransactionDTO> GetMerchant(int id);
        Task<int> CreateMerchant(TransactionDTO transaction);
    }
}
