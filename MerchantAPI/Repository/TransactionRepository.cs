using AutoMapper;
using MerchantAPI.DTO;
using MerchantAPI.Model;
using MerchantAPI.Interfaces;
using System.Transactions;
using Microsoft.EntityFrameworkCore;

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

        public async Task<string> CreateTransaction(TransactionDTO transaction, string merchantId)
        {
            var merchantTransaction = await _context.Terminals.FirstOrDefaultAsync(t => t.merchant.MerchantId== merchantId);
            if (merchantTransaction == null)
            {
                return "Invalid Transaction Credentials";
            }

            var transactionEntity = _mapper.Map<Transactions>(transaction);
            transactionEntity.terminal = merchantTransaction;
            _context.Transactions.Add(transactionEntity);
            await _context.SaveChangesAsync();
            return transactionEntity.TransactionId;
        }

        public async Task<TransactionDTO> GetTransactionById(string id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            return _mapper.Map<TransactionDTO>(transaction);
        }

        public async Task<IEnumerable<TransactionDTO>> GetAllTransactions()
        {
            var transactions = await  _context.Transactions.ToListAsync();
            return _mapper.Map<IEnumerable<TransactionDTO>>(transactions);
        }

        public async Task<IEnumerable<TransactionDTO>> GetTerminalTransactions(string merchantId, string terminalId)
        {
            var terminalTransaction = await _context.Terminals.Where(t => t.merchant.MerchantId== merchantId && t.TerminalId == terminalId).ToListAsync();
            return _mapper.Map<IEnumerable<TransactionDTO>>(terminalTransaction);
        }
    }
}
