using MerchantAPI.Common.DTO;
using MerchantAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Services.Implementations
{
    public class TransactionService : ITransactionService
    {
        public Task<int> CreateTransaction(TransactionDTO transaction)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionDTO> GetTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransactionDTO>> GetTransactions()
        {
            throw new NotImplementedException();
        }
    }
}
