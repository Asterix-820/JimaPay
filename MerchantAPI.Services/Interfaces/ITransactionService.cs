using MerchantAPI.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Services.Interfaces
{
    public interface ITransactionService
    {
        Task<IEnumerable<TransactionDTO>> GetTransactions();
        Task<TransactionDTO> GetTransaction(int id);
        Task<int> CreateTransaction(TransactionDTO transaction);
    }
}
