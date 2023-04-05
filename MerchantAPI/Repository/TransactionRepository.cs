using AutoMapper;
using MerchantAPI.DTO;
using MerchantAPI.Model;
using MerchantAPI.Interfaces;
using System.Transactions;

namespace MerchantAPI.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MerchantDbContext _context;
        private readonly IMapper _mapper;
        public TransactionRepository(MerchantDbContext context, IMapper mapper) 
        { 
           _context= context;
            _mapper= mapper;
        }

        public async Task<int> CreateTransaction(TransactionDTO transaction)
        {
            var transactionEntity = _mapper.Map<Transaction>(transaction);
            _context.Terminals.Add(transactionEntity);
            await _context.SaveChangesAsync();
            return transactionEntity.TransactionId;
        }

        public async Task<TransactionDTO> GetTransaction(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            return _mapper.Map<TransactionDTO>(transaction);
        }

        public async Task<IEnumerable<TransactionDTO>> GetTransactions()
        {
            var transactions =  _context.Transactions.ToList();
            return _mapper.Map<IEnumerable<TransactionDTO>>(transactions);
        }
    }
}
